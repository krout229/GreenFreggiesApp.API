using GreenFreggies.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreenFreggies.API.Data
{
    public class VegetablesDbContext : DbContext
    {
        public VegetablesDbContext(DbContextOptions<VegetablesDbContext> options) : base(options)
        {

        }
        public DbSet<userDetails> userDetails { get; set; }
        public DbSet<vegetableDetails> VegetableDetails { get; set; }
        public DbSet<Transaction> transactions { get; set; }
        public DbSet<cart> Carts { get; set; }
        public DbSet<OrderDetails> orderDetails { get; set; }
        public DbSet<feedback> feedback { get; set; }
    }
}
