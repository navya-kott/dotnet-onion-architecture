using Onion.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.Core.Interfaces
{
    interface IBlogRepository
    {
         Task CreateBlog(Blog blog);

        Task<List<Blog>> GetBlogs();
    }
}
