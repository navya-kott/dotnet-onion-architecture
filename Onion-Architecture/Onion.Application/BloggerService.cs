

using Onion.Core.Models;

namespace Onion.Application
{
    public interface IBloggerService
    {
        Task<IEnumerable<Blog>> GetAllProducts();
       
    }
}
