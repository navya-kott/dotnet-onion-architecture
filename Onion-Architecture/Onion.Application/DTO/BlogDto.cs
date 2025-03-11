using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.Application.DTO
{
    public class BlogDto
    {
        public  string? Id { get; set; }

        public required string Content { get; set; }

        public required string Publisher { get; set; }


    }
}
