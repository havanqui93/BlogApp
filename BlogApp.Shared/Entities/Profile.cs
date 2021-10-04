using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Shared.Entities
{
    public class Profile
    {
        public string Name { get; set; }
        public string Avatar { get; set; }
        public string Gender { get; set; }

        public Profile() { }

        public Profile(string name, string avatar, string gender)
        {
            this.Name = name;
            this.Avatar = avatar;
            this.Gender = gender;
        }
    }
}
