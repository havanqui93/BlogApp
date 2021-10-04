using IdentityModel;
using IdentityServer4;
using IdentityServer4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApp.Identity.Configruations
{
    public class Configs
    {
        public static IEnumerable<IdentityResource> GetIdentityResources() =>
            new List<IdentityResource>
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile(),
                new IdentityResources.Email()
            };

        public static IEnumerable<ApiResource> GetApiResources() =>
            new List<ApiResource> {
                new ApiResource("BlogApp.API", "Main API Resource")
            };


        public static IEnumerable<ApiScope> GetApiScopes() =>
           new List<ApiScope>
           {
                new ApiScope("api", "Main API Scope"),
           };

        public static IEnumerable<Client> GetClients() =>
            new List<Client> {
                new Client {
                    ClientId = "client.net.site",
                    ClientSecrets = { new Secret("BlogAppSerect".ToSha256()) },
                    AllowedGrantTypes = GrantTypes.ResourceOwnerPasswordAndClientCredentials,
                    AccessTokenLifetime = 3600, // 30s
                    AllowedScopes = {
                        "api", "openid", "email", "profile"
                    }
                }
            };

    }
}
