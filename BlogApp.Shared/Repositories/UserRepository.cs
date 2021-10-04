using BlogApp.Shared.Context;
using BlogApp.Shared.Entities;
using BlogApp.Shared.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Shared.Repositories
{
    public class UserRepository : BaseRepository
    {

        public UserRepository(BlogAppDbContext context) : base(context) { }


        public async Task CreateAsync(string userId, string name, string gender, string avatar)
        {
            var user = new User()
            {
                Id = userId,
                Profile =  new Profile(name, avatar, gender)
            };

            await CreateAsync(user);
        }

        public async Task CreateAsync(string userId, Profile profile)
        {
            var user = new User()
            {
                Id = userId,
                Profile = profile
            };

            await CreateAsync(user);
        }

        public async Task CreateAsync(User user)
        {
            await Task.WhenAll(blogAppDbContext.Users.InsertOneAsync(user),
                blogAppDbContext.Wall.InsertOneAsync(new Feed() { UserId = user.Id }),
                blogAppDbContext.News.InsertOneAsync(new Feed() { UserId = user.Id }));
        }

    }
}
