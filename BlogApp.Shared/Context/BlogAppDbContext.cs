using BlogApp.Shared.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Shared.Context
{
    public class BlogAppDbContext
    {
        private IMongoClient MongoClient { get; }
        private IMongoDatabase MongoDatabase { get; }

        public BlogAppDbContext(string connectionString, string dbName)
        {
            MongoClient = new MongoClient(connectionString);
            MongoDatabase = MongoClient.GetDatabase(dbName);
        }

        public IMongoCollection<User> Users => MongoDatabase.GetCollection<User>("users");
        public IMongoCollection<Post> Posts => MongoDatabase.GetCollection<Post>("posts");
        public IMongoCollection<Feed> Wall => MongoDatabase.GetCollection<Feed>("wall");
        public IMongoCollection<Feed> News => MongoDatabase.GetCollection<Feed>("news");

    }
}
