using BlogApp.Shared.Context;
using BlogApp.Shared.Entities;
using BlogApp.Shared.Repositories.Base;
using BlogApp.Shared.Utils;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Shared.Repositories
{
    public class PostRepository : FeedRepository
    {
        public PostRepository(BlogAppDbContext context) : base(context) { }

        #region CREATE
        public async Task CreatePostAsync(Owner owner, PostBody postBody, string postOption)
        {
            PostPermission postPermission = postOption.ToEnum<PostPermission>();

            var post = new Post()
            {
                PostBy = owner,
                PostBody = postBody,
                PostPermission = postPermission
            };

            await CreatePostAsync(post);
        }

        public async Task CreatePostAsync(string userId, string content, string photo, string postOption)
        {
            var profile = blogAppDbContext.Users.Find(x => x.Id == userId)
                .Project(x => x.Profile).SingleOrDefault();

            if (profile != null)
            {
                var owner = new Owner(userId, profile);
                var postBody = new PostBody(content, photo);
                await CreatePostAsync(owner, postBody, postOption);
            }
        }

        async Task CreatePostAsync(Post post)
        {
            await blogAppDbContext.Posts.InsertOneAsync(post);

            await AppendPostAsync(post);

            if (post.PostPermission == PostPermission.Public)
            {
                await AppendPostPublicAsync(post);
            }
        }

        #endregion

        #region UPDATE

        #endregion

        #region DELETE

        public async Task<bool> DeletePostAsync(string postId)
        {
            var filter = Builders<Post>.Filter.Eq("_id", postId);

            var post = await blogAppDbContext.Posts.Find(filter).FirstOrDefaultAsync();
            if (post == null)
                throw new Exception("Id invalid");

            var result = await blogAppDbContext.Posts.DeleteOneAsync(filter);

            return result.DeletedCount > 0;
        }

        #endregion

    }
}
