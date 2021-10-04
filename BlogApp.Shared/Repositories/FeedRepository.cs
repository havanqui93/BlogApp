using BlogApp.Shared.Context;
using BlogApp.Shared.Entities;
using BlogApp.Shared.Repositories.Base;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Shared.Repositories
{
    public class FeedRepository : BaseRepository
    {
        public FeedRepository(BlogAppDbContext context) : base(context) { }

        const int PAGE_SIZE = 10;
        public Task<List<Post>> GetWallFeed(string userId, int page = 0)
        {
            return GetFeedAsync(blogAppDbContext.Wall, userId, page * PAGE_SIZE, PAGE_SIZE);
        }

        public Task<List<Post>> GetNewsFeed(string userId, int page = 0)
        {
            return GetFeedAsync(blogAppDbContext.News, userId, page * PAGE_SIZE, PAGE_SIZE);
        }

        async Task<List<Post>> GetFeedAsync(IMongoCollection<Feed> collection, string userId, int skip, int limit)
        {
            PipelineDefinition<Feed, Feed> pipeline = new[]
            {
                new BsonDocument {{"$match", new BsonDocument {{nameof(Feed.UserId), userId}}}},
                new BsonDocument {{"$unwind", "$Posts"}},
                new BsonDocument {{"$sort", new BsonDocument {{"Posts.Meta.Created", -1}}}},
                new BsonDocument {{"$skip", skip}},
                new BsonDocument {{"$limit", limit}},
                new BsonDocument {{"$group", new BsonDocument {{"_id", BsonNull.Value}, {"Posts", new BsonDocument("$push", "$Posts")}}}},
                new BsonDocument {{"$project", new BsonDocument {{"_id", 0}, {"Posts", 1}}}}
            };

            return (await collection.AggregateAsync(pipeline)).FirstOrDefault().Posts;
        }


        public async Task AppendPostAsync(Post post)
        {
            var wallList = new List<string> { post.PostBy.Id };
            var newsList = new List<string> { post.PostBy.Id };

            await Task.WhenAll(AppendPostAsync(blogAppDbContext.Wall, post, wallList), AppendPostAsync(blogAppDbContext.News, post, newsList));
        }

        public async Task AppendPostPublicAsync(Post post)
        {
            var friends = await blogAppDbContext.Users.Find(x => x.Id != post.PostBy.Id)
                .ToListAsync();

            var newsList = friends.Select(x => x.Id);
            await AppendPostAsync(blogAppDbContext.News, post, newsList.ToList());
        }

        public async Task<bool> AppendPostAsync(IMongoCollection<Feed> collection, Post post, List<string> destUsers)
        {
            var filter = Builders<Feed>.Filter.In(nameof(Feed.UserId), destUsers);
            var update = Builders<Feed>.Update.Push(nameof(Feed.Posts), post);
            var result = await collection.UpdateManyAsync(filter, update);
            return result.ModifiedCount > 0;
        }

    }
}
