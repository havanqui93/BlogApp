using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Shared.Entities
{
    public class Owner : Profile
    {
        public string Id { get; set; }
        public Owner() { }
        public Owner(string id, Profile profile)
        {
            this.Id = id;
            Name = profile.Name;
            Avatar = profile.Avatar;
            Gender = profile.Gender;
        }
    }
}
