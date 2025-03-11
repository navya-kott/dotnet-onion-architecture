using AutoMapper;
using NSubstitute;
using Onion.Application.DTO;
using Onion.Application.Services;
using Onion.Core.Interfaces;
using Onion.Core.Models;


namespace Onion.Test.BlogTester
{
    public class BlogCreationTest
    {
        private readonly IRepository _mockBlogRepository;
        private readonly IMapper _mockMapper;
        private readonly IBlogService _blogService;

        public BlogCreationTest() {
            _mockBlogRepository = Substitute.For<IRepository>();
            _mockMapper = Substitute.For<IMapper>();
            _blogService = new IBlogService(_mockBlogRepository, _mockMapper);
        }

        [Fact] // no params 
        public async Task createBlogValidator()
        {
            var blogDto = new BlogDto
            {
                
                Content = "fsdf",
                Publisher = "uuuu"
            };

            var result = await _blogService.CreateBlog(blogDto);
            result = false;
            Assert.True(result);
        }

        

    }
}
