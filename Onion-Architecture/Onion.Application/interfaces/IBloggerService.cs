using Onion.Application.DTO;
using Onion.Core.Models;
using System.Reflection.Metadata;

namespace Onion.Application.interfaces
{
    public interface IBloggerService
    {
        Task CreateBlog(BlogDto blog);

        Task<IEnumerable<BlogDto>> GetBlogs();
        

    }
}
