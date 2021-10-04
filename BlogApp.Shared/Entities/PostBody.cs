using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Shared.Entities
{
    public class PostBody
    {
        public string Content { get; set; }
        public string Photo { get; set; }

        public PostBody() { }
        public PostBody(string content, string photo)
        {
            this.Content = content;
            this.Photo = photo;
        }
    }
}
