using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Shared.CommonReponse
{
    public class Token
    {
        public Token(string access_token, int expires_in, string token_type)
        {
            this.access_token = access_token;
            this.expires_in = expires_in;
            this.token_type = token_type;
        }

        public string access_token { get; set; }
        public int expires_in { get; set; }
        public string token_type { get; set; }
    }
}
