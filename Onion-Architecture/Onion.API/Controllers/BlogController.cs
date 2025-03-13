using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Onion.API.Commands;
using Onion.Application.DTO;
using Onion.Application.interfaces;



namespace Onion.API.Controllers
{
    [Route("api/")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private readonly IMediator _meadiator;

        private readonly IBloggerService _bloggerService;

        public BlogController(IBloggerService bloggerService,IMediator mediator)
        {
            _bloggerService = bloggerService;
            _meadiator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllBlogs(){
            return Ok(await _bloggerService.GetBlogs());

        }


        [HttpPost]
        public async Task<IActionResult> CreateBlog([FromBody] BlogDto blog)
        {
            await _meadiator.Send(new BlogCreateCommand(blog.Publisher,blog.Content));
            await _meadiator.Publish(new Notifier($"Blog created successfully by {blog.Publisher}"));
            return Ok("Blog created successfully");

        }


    }
}
