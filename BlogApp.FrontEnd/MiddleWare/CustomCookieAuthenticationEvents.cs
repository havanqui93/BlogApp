using Microsoft.AspNetCore.Authentication.Cookies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApp.FrontEnd.MiddleWare
{
    public class CustomCookieAuthenticationEvents : CookieAuthenticationEvents
    {
        public CustomCookieAuthenticationEvents()
        {

        }
    }
}
