using BlogApp.API.Models;
using BlogApp.Shared.CommonReponse;
using System.Collections.Generic;

namespace BlogApp.API.Authorized
{
    public interface ITokenManagement
    {
        void StoreToken(string token, Profile profile);

        Dictionary<string, UserPrincipal> TokenUsers { get; }

        void SetCurrenUser(string token);

        string currentID();
    }
}