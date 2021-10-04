using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Shared.Entities
{
    public class User : Base.Entity<string>
    {
        public Profile Profile { get; set; }

        public Dictionary<string, Profile> Followers = new Dictionary<string, Profile>();
    }
}
