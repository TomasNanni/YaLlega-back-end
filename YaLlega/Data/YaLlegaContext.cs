using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YaLlega.Entities;

namespace YaLlega.Data
{
    internal class YaLlegaContext : DbContext
    {
        public DbSet<Product>Products { get; set; }

        public DbSet<Category> Categories{ get; set; }

        public DbSet<User> Users{ get; set; }

        public DbSet<Restaurant> Restaurants{ get; set; }

        public DbSet<Cart> Carts { get; set; }
        public YaLlegaContext(DbContextOptions<YaLlegaContext> options) : base(options) { }
    }
}
