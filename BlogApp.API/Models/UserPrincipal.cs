using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;

namespace BlogApp.API.Models
{
    public class UserPrincipal : IPrincipal
    {
        private string _userId { get; set; }
        public string UserID
        {
            get
            {
                return _userId;
            }
        }

        private string _username { get; set; }
        public string Username
        {
            get
            {
                return _username.Replace("\"", "");
            }
        }

        private IIdentity _identity { get; set; }
        public IIdentity Identity => _identity;

        public bool IsInRole(string role)
        {
            throw new NotImplementedException();
        }


        public UserPrincipal(string uid, string userName)
        {
            this._userId = uid;
            this._username = userName;
        }

    }
}
