using BlogApp.Shared.Context;
using BlogApp.Shared.Repositories;
using System;
using Xunit;

namespace BlogApp.Test
{
    public class UserTest
    {
        static BlogAppDbContext Repo()
        {
            return new BlogAppDbContext("mongodb://localhost:27017", "BlogApp");
        }

        static UserRepository Context()
        {
            var userRepo = new UserRepository(Repo());
            return userRepo;
        }


        [Fact]
        public async void RegisterUser()
        {
            try
            {
                var context = Context();
                var userId = "25f87da1-b460-40dd-b028-3e370e02ec6d";
                await context.CreateAsync(userId, "Ha QUi", "Male", "");
            }
            catch
            {
                Assert.True(false);
            }
            Assert.True(true);
        }
    }
}
