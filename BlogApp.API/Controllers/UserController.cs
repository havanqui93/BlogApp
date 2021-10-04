using AutoWrapper.Wrappers;
using BlogApp.API.Authorized;
using BlogApp.Shared.CommonReponse;
using BlogApp.Shared.Models;
using BlogApp.Shared.Services;
using BlogApp.Shared.Utils;
using IdentityModel.Client;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlogApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly AppSettings _appSetting;
        HttpService _httpService { get; }

        ITokenManagement _customAuthenticationManager;

        public UserController(IOptions<AppSettings> appSettings, HttpService httpService, ITokenManagement customAuthenticationManager)
        {
            _appSetting = appSettings.Value;
            _httpService = httpService;
            _customAuthenticationManager = customAuthenticationManager;
        }

        [HttpPost]
        [Route("Register")]
        public async Task<ApiResponse> Register([FromBody] RegisterUserModel model)
        {

            var endPoint = $"{_appSetting.Authority}/api/Account/Register";
            var registerReponse = await _httpService.CallApiAsync<ApiResponse>(endPoint, model, HttpType.Post);

            if (registerReponse.IsError.HasValue && registerReponse.IsError.Value)
                throw new ApiException(registerReponse.ResponseException.ToString());

            return new ApiResponse("Success", (int)StatusCodeEnum.Ok);
        }

        [HttpPost]
        [Route("Login")]
        public async Task<ApiResponse> Login([FromBody] LoginUserModel model)
        {
            var endPoint = $"{_appSetting.Authority}/connect/token";
            var client = new HttpClient();
            var tokenResponse = await client.RequestPasswordTokenAsync(new PasswordTokenRequest
            {
                Address = endPoint,
                ClientId = _appSetting.client_id,
                ClientSecret = _appSetting.client_secret,
                Scope = _appSetting.scope,
                UserName = model.Email,
                Password = model.Password
            });

            if (tokenResponse.IsError)
            {
                string msgError = tokenResponse.ErrorDescription ?? tokenResponse.Error;
                if (msgError == "invalid_username_or_password")
                    msgError = "Wrong email or password";

                throw new ApiException(msgError, (int)StatusCodeEnum.BadRequest);
            }

            var token = new Token(tokenResponse.AccessToken, tokenResponse.ExpiresIn, tokenResponse.TokenType);
            var profile = await _httpService.CallApiAsync<Profile>($"{_appSetting.Authority}/connect/userinfo",
                headers: new Dictionary<string, string>() { { "Authorization", "Bearer " + tokenResponse.AccessToken } });
            _customAuthenticationManager.StoreToken(tokenResponse.AccessToken, profile);

            return new ApiResponse(token, (int)StatusCodeEnum.Ok);
        }

        [HttpGet]
        [Route("Profile")]
        [CustomAuthorizeFilter]
        public async Task<ApiResponse> Profile()
        {
            var endPoint = $"{_appSetting.Authority}/connect/userinfo";
            //var headers = AuthorizedHandle.GetBearerToken(Request);
            var headers = new Dictionary<string, string>();
            var profileReponse = await _httpService.CallApiAsync<Profile>(endPoint, headers: headers);

            if (profileReponse == null)
                return new ApiResponse("Can not get infomation!", (int)StatusCodeEnum.BadRequest);

            return new ApiResponse(profileReponse, (int)StatusCodeEnum.Ok);
        }

        [HttpGet]
        [Route("PublicMethod")]
        public async Task<ApiResponse> PublicMethod()
        {
            return new ApiResponse("Ok", (int)StatusCodeEnum.Ok);
        }

        [HttpGet]
        [CustomAuthorizeFilter]
        [Route("PrivateMethod")]
        public async Task<ApiResponse> PrivateMethod()
        {
            return new ApiResponse("Ok", (int)StatusCodeEnum.Ok);
        }


    }
}
