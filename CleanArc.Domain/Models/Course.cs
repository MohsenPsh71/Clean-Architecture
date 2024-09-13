using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArc.Domain.Models
{
    public class Course
    {
        public int id { get; set; }
        public string? name { get; set; }
        public string? description { get; set; }
        public string? ImageUrl { get; set; }
    }
}
