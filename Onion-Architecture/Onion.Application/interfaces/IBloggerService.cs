using Onion.Core.Models;
using System.Reflection.Metadata;

namespace Onion.Application.interfaces
{
    public interface IBloggerService
    {
        Task CreateBlog(Blog blog);

        Task<IEnumerable<Blog>> GetBlogs();
        

    }
}
