using HilarioMarket.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HilarioMarket.Data
{
    public class HilarioMarketServiceContext:DbContext
    {
        public HilarioMarketServiceContext(DbContextOptions<HilarioMarketServiceContext> options)
        : base(options)
        { }

        public DbSet<Company> HilarioMarket_Company { get; set; }
        public DbSet<Customer> HilarioMarket_Customer { get; set; }
        public DbSet<Product> HilarioMarket_Product { get; set; }
        public DbSet<Purchase> HilarioMarket_Purchase { get; set; }
        public DbSet<PurchaseDetails> HilarioMarket_PurchaseDetail { get; set; }
        public DbSet<User> HilarioMarket_User { get; set; }
    }
}
