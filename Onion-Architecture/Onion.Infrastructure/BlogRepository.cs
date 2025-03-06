using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Onion.Core.Interfaces;
using Onion.Core.Models;

namespace Onion.Infrastructure
{
    class BlogRepository : IRepository
    {

        public Task CreateBlog(Blog blog)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Blog>> GetBlogs()
        {
            throw new NotImplementedException();
        } 
    }
}

