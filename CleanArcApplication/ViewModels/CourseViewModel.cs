using CleanArc.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArcApplication.ViewModels
{
    public class CourseViewModel
    {
        public IEnumerable<Course>? cources { get; set; }  
    }
}
