using API_CURD.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_CURD.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options)

        {

        }

        public DbSet<Project> project { get; set; }
        public DbSet<Developer> developer { get; set; }

        public DbSet<OrderDemo> orderDemos { get; set; }

        public DbSet<ProductDemo> productDemos { get; set; }

    }
}
