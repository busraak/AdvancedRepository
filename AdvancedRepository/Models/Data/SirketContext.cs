using AdvancedRepository.Models.Classes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedRepository.Models.Data
{
    public class SirketContext:DbContext
    {
        public SirketContext(DbContextOptions<SirketContext> options) : base(options)
        {
     
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FatDetail>()
                .HasKey(f => new { f.Id, f.ProductId });
            modelBuilder.Entity<BascetDetail>()
                .HasKey(b => new { b.Id, b.ProductId });
        }
        public DbSet<Products> Products { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Cities> Cities { get; set; }
        public DbSet<Counties> Counties { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Employees> Employees { get; set; }
        public DbSet<Suppliers> Suppliers { get; set; }
        public DbSet<Units> Units { get; set; }
        public DbSet<FatDetail> FatDetails { get; set; }

        public DbSet<FatMaster> FatMasters { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<BascetMaster> BascetMasters { get; set; }
        public DbSet<BascetDetail> BascetDetails { get; set; }




    }
}
