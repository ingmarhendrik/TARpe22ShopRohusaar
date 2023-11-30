using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TARpe22ShopRohusaar.Core.Domain;

namespace TARpe22ShopRohusaar.Data
{
    public class TARpe22ShopRohusaarContext : DbContext
    {
        public TARpe22ShopRohusaarContext(DbContextOptions<TARpe22ShopRohusaarContext> options) : base(options) { }

        public DbSet<Spaceship> Spaceships { get; set; }
        public DbSet<FileToDatabase> FilesToDatabase { get; set; }
        public DbSet<RealEstate> RealEstates { get; set; }
        public DbSet<FileToApi> FilesToApi { get; set; }
    }
}
