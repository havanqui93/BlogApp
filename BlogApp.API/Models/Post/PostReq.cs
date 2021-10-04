using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApp.API.Models.Post
{
    public class PostReq
    {
        public string Content { get; set; }
        public string Photo { get; set; }
        public string Permission { get; set; }
    }
}
