using MediatR;
using Onion.API.Commands;
using Onion.Application.DTO;
using Onion.Application.interfaces;

namespace Onion.API.Handlers
{
    public class BlogCreationHandler : IRequestHandler<BlogCreateCommand, bool>
    {
        private readonly IBloggerService _bloggerService;
        public BlogCreationHandler(IBloggerService bloggerService)
        {
            _bloggerService = bloggerService;
        }

        public async Task<bool> Handle(BlogCreateCommand request, CancellationToken cancellationToken)
        {
            var blog = new BlogDto {
                Content=request.Content,
                Publisher=request.Publisher
            };

          return  await _bloggerService.CreateBlog(blog );
        }
    }
}
