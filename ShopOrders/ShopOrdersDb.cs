using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopOrders.Models;

namespace ShopOrders
{
    public class ShopOrdersDb: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($@"Data Source={AppDomain.CurrentDomain.BaseDirectory}\ShopOrders.db");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
            new User { ID = 1, Login = "1", Password = "1", IsAdmin = true });
        }
        public DbSet<Product> Tovars { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
