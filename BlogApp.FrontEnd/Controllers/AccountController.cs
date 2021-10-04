using AutoWrapper.Wrappers;
using BlogApp.FrontEnd.AppSettings;
using BlogApp.FrontEnd.Constants;
using BlogApp.Shared.CommonReponse;
using BlogApp.Shared.Models;
using BlogApp.Shared.Services;
using BlogApp.Shared.Utils;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BlogApp.FrontEnd.Controllers
{
    public class AccountController : Controller
    {
        private readonly HttpService _httpService;
        private readonly ApiAppSetting _apiAppSetting;
        public AccountController(HttpService httpService, IOptions<ApiAppSetting> apiAppSetting)
        {
            _httpService = httpService;
            _apiAppSetting = apiAppSetting.Value;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginUserModel model)
        {
            var endpoint = _apiAppSetting.URL_ROOT + ConstantsEndpoint.ENDPOINT_USER + "/Login";
            var response = await _httpService.CallApiAsync<ApiResponse>(endpoint, model, HttpType.Post);

            if (response.Result != null && response.StatusCode != 400)
            {
                var tokenObject = JsonConvert.DeserializeObject<Token>(response.Result.ToString());
                Response.Cookies.Append("X-Access-Token", tokenObject.access_token);

                var claims = new List<Claim>
                {
                    new Claim("email", model.Email),
                    new Claim("role", "Member")
                };

                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(claimsIdentity),
                    new AuthenticationProperties
                    {
                        IsPersistent = true,
                        ExpiresUtc = DateTime.UtcNow.AddDays(1)
                    });

                return RedirectToAction("Index", "Home");
            }


            return Json(new { Success = false, response.Message });
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Register(RegisterUserModel model)
        {
            var endpoint = _apiAppSetting.URL_ROOT + ConstantsEndpoint.ENDPOINT_USER + "/Register";
            var response = await _httpService.CallApiAsync<ApiResponse>(endpoint, model, HttpType.Post);

            if (response.Result != null && response.StatusCode != 400)
            {
                return Json(new { Success = true });
            }
            return Json(new { Success = false, response.Message });
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Logout()
        {
            if (HttpContext.User.Identity.IsAuthenticated)
            {
                await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
                return Json(new { Success = true });
            }

            return Json(new { Success = false });
        }


    }
}
