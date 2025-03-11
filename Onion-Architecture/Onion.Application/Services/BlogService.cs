using AutoMapper;
using Onion.Application.DTO;
using Onion.Application.interfaces;
using Onion.Core.Interfaces;
using Onion.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.Application.Services
{
    public class IBlogService : IBloggerService
    {
        private readonly IRepository _repository;

        private readonly IMapper _mapper;

        public IBlogService(IRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task <bool> CreateBlog(BlogDto blogDto)
        {
            var blog = _mapper.Map<Blog>(blogDto);
            await _repository.CreateBlog(blog);
            return true;
        }

 
       public async Task<IEnumerable<BlogDto>> GetBlogs()
        {
          var blogs =  await _repository.GetBlogs();
            return _mapper.Map<IEnumerable<BlogDto>>(blogs);

        }
    }
}
