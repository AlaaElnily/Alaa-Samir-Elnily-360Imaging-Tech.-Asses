using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alaa_Samir_Elnily_360Imaging_Tech._Asses.Models
{
    public class BlogContext : DbContext
    {
        public BlogContext(DbContextOptions<BlogContext>options) : base(options)
        {

        }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }

    }
}
