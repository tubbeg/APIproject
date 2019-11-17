using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace APIproject.Models
{
    public class APIprojectContext : DbContext
    {
        public APIprojectContext (DbContextOptions<APIprojectContext> options)
            : base(options)
        {
        }

        public DbSet<APIproject.Models.TodoItem> TodoItem { get; set; }
    }
}
