using Mongo2Go;
using MongoDB.Driver;
using Onion.Core.Models;
using Onion.Infrastructure;

namespace Onion.Test.IntegrationTester
{
    public class BlogCreation : IDisposable
    {
        private readonly MongoDbRunner _mongoRunner;
        private readonly IMongoDatabase _database;
        private readonly BlogRepository _mockBlogRepository;

        public BlogCreation()
        {
            // ✅ Start an in-memory MongoDB instance
            _mongoRunner = MongoDbRunner.Start();
            var client = new MongoClient(_mongoRunner.ConnectionString);
            _database = client.GetDatabase("testdb");
            _mockBlogRepository = new BlogRepository(_database);
        }

        [Fact]
        public async Task InsertAsync_ValidOrder_SavesToMongoDB()
        {
            // Arrange
            var order = new Blog
            {
                Content = "aaa",
                Publisher = "aaaa"
            };

            // Act
            await _mockBlogRepository.CreateBlog(order);
            var fetchedOrder = await _mockBlogRepository.GetBlogs();
            //Console.WriteLine(fetchedOrder);
            // Assert
            Assert.NotNull(fetchedOrder);
        }

        public void Dispose()
        {
            _mongoRunner.Dispose(); // ✅ Stop MongoDB instance after tests
        }
    }

}
