using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShoppinG_Cart.Models;

namespace ShoppinG_Cart.DB
{
    public class Shopping_Cart_DBContext : DbContext
    {
        protected IConfiguration configuration;
        public Shopping_Cart_DBContext(DbContextOptions<Shopping_Cart_DBContext> options) : base(options)
        {

        }

        public Shopping_Cart_DBContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder model)
        {
            // composite key
            model.Entity<ActivationCode>().HasKey(ac => new { ac.OrderId, ac.ActivationCodeId, ac.ProductId });
            model.Entity<Cart>().HasKey(c => new { c.CartId, c.ProductId });
            model.Entity<OrderDetail>().HasKey(tbl => new { tbl.OrderId, tbl.ProductId });
            model.Entity<Order>().HasKey(o => new { o.OrderId, o.UserId });

        }

        public DbSet<ActivationCode> ActivationCodes { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
