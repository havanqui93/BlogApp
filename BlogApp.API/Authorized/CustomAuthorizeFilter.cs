using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApp.API.Authorized
{
    public class CustomAuthorizeFilter : Attribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var result = true;
            var request = context.HttpContext.Request;
            var customAuthenHandler = (ITokenManagement)context.HttpContext.RequestServices.GetService(typeof(ITokenManagement));

            if (!request.Headers.ContainsKey("Authorization"))
                result = false;

            string token = string.Empty;
            if (result)
            {
                token = request.Headers["Authorization"].ToString();
                var auth = request.Headers["Authorization"].ToString().Split(" ");
                if (auth.Length != 2 || auth[0].ToLower() != "bearer")
                {
                    result = false;
                }

                // Validate token & refresh token
                if (!customAuthenHandler.TokenUsers.ContainsKey(auth[1]))
                    result = false;

                if(result)
                    customAuthenHandler.SetCurrenUser(auth[1]);
            }

            if (!result)
            {
                context.ModelState.AddModelError("Unauthorized", "You are not authorize");
                context.Result = new UnauthorizedObjectResult(context.ModelState);
            }
        }

    }
}
