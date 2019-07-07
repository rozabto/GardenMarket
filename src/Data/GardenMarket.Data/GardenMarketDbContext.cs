using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace GardenMarket.Data
{
    public class GardenMarketDbContext : IdentityDbContext
    {
        public GardenMarketDbContext(DbContextOptions<GardenMarketDbContext> options)
            : base(options)
        {
        }
    }
}
