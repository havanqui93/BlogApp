using BlogApp.API.Models;
using BlogApp.Shared.CommonReponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApp.API.Authorized
{
    public class TokenManagement : ITokenManagement
    {
        private static Dictionary<string, UserPrincipal> tokenUsers = new Dictionary<string, UserPrincipal>();

        private static string _currentID { get; set; }
        public string currentID() => _currentID;

        public Dictionary<string, UserPrincipal> TokenUsers => tokenUsers;

        public void StoreToken(string token, Profile profile)
        {
            tokenUsers.Add(token, new UserPrincipal(profile.sub, profile.name));
        }

        public void SetCurrenUser(string token)
        {
            _currentID = tokenUsers.ContainsKey(token) ? tokenUsers[token].UserID ?? null : null;
        }

    }
}
