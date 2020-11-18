using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MG_asp_lab2.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public AppDbContext(AppDbContextOptions<AppDbContext> options) : base(options)
        {

        }
    }
}
