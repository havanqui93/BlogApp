using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Shared.Entities
{
    public class Post : Base.Entity<ObjectId>
    {
        public Owner PostBy { get; set; }

        [BsonRepresentation(BsonType.String)]
        public PostPermission PostPermission { get; set; }

        public PostBody PostBody { get; set; } = new PostBody();

        public Dictionary<string, Profile> Lovers { get; set; } = new Dictionary<string, Profile>();
    }
}
