using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WineShop_Manav.Models;

namespace WineShop_Manav.Data
{
    public class WineShopDbContext: DbContext
    {
        public WineShopDbContext(DbContextOptions<WineShopDbContext> options)
            : base(options)
        {

        }
        public DbSet<Wine> Wines { get; set; }
        public DbSet<RateList> RateLists { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
