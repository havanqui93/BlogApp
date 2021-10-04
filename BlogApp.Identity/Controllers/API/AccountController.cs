using AutoWrapper.Wrappers;
using BlogApp.Identity.Models;
using BlogApp.Identity.ViewModels;
using BlogApp.Shared.Repositories;
using BlogApp.Shared.Utils;
using IdentityModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Identity.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;
        private UserRepository _userRepository { get; }

        public AccountController(
            UserManager<User> userManager,
            SignInManager<User> signInManager,
            UserRepository userRepository)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _userRepository = userRepository;
        }

        [HttpPost("Register")]
        public async Task<ApiResponse> Register([FromBody] RegisterViewModel model)
        {
            var user = new User()
            {
                Email = model.Email,
                UserName = model.Email
            };

            user.Claims.Add(new IdentityUserClaim<string>()
            {
                ClaimType = JwtClaimTypes.GivenName,
                ClaimValue = model.Firstname
            });

            user.Claims.Add(new IdentityUserClaim<string>()
            {
                ClaimType = JwtClaimTypes.FamilyName,
                ClaimValue = model.Lastname
            });

            user.Claims.Add(new IdentityUserClaim<string>()
            {
                ClaimType = JwtClaimTypes.Gender,
                ClaimValue = model.Gender
            });

            user.Claims.Add(new IdentityUserClaim<string>()
            {
                ClaimType = JwtClaimTypes.BirthDate,
                ClaimValue = model.BirthDate.ToString("yyyy-MM-dd")
            });

            var result = await _userManager.CreateAsync(user, model.Password);

            if (result.Succeeded)
            {
                //var userService = (UserRepository)HttpContext.RequestServices.GetService(typeof(UserRepository));
                await _userRepository.CreateAsync(user.Id, model.Firstname + " " + model.Lastname, model.Gender, model.Image);

                return new ApiResponse("New record has been created in the database.", user.Id, (int)StatusCodeEnum.Ok);
            }
            else
            {
                if (result.Errors.Any(x => x.Code == "DuplicateUserName"))
                {
                    throw new ApiException(message: "Duplicate User Name.");
                }

                throw new ApiException(message: result.Errors.FirstOrDefault().Description);
            }
        }


    }
}
