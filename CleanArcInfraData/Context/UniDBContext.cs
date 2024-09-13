using CleanArc.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArc.Infra.Data.Context
{
    public class UniDBContext:DbContext
    {
        public UniDBContext(DbContextOptions<UniDBContext> options)
           : base(options)
        {

        }

        DbSet<Course> DbSet { get; set; }
    }
}
