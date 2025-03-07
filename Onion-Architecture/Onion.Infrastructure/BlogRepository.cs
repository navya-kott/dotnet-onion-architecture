using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using Onion.Application.interfaces;
using Onion.Core.Interfaces;
using Onion.Core.Models;


namespace Onion.Infrastructure
{
   
    public class BlogRepository : IBloggerService
    {
        private readonly IMongoCollection<Blog> _blog;

        public BlogRepository(MongoDbSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            _blog = database.GetCollection<Blog>("Blog");
        }
        public async Task CreateBlog(Blog blog)
        {
            await _blog.InsertOneAsync(blog);
        }

        public async Task<IEnumerable<Blog>> GetBlogs()
        {
            return await _blog.Find(p => true).ToListAsync();
        }
    }
}
