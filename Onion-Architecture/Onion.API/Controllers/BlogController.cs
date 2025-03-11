using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Onion.Application.DTO;
using Onion.Application.interfaces;



namespace Onion.API.Controllers
{
    [Route("api/")]
    [ApiController]
    public class BlogController : ControllerBase
    {

        private readonly IBloggerService _bloggerService;

        public BlogController(IBloggerService bloggerService)
        {
            _bloggerService = bloggerService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllBlogs(){
            return Ok(await _bloggerService.GetBlogs());

        }


        [HttpPost]
        public async Task<IActionResult> CreateBlog([FromBody] BlogDto blog)
        {
            await _bloggerService.CreateBlog(blog);
            return Ok("Blog created successfully");

        }


    }
}
