using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StanAPI.Models
{
    public class ApContext : DbContext
    {
        public ApContext(DbContextOptions<ApContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Apartment>()
        .HasOne(a => a.Adress).WithOne(b => b.Apartment)
        .HasForeignKey<Adress>(e => e.ApartmentId);

            modelBuilder.Entity<User>()
        .HasOne(c => c.Card).WithOne(d => d.User)
        .HasForeignKey<Card>(f => f.UserId);

            modelBuilder.Entity<Contract>()
        .HasKey(bc => new { bc.UserId, bc.ApartmentId });

            modelBuilder.Entity<Contract>()
        .HasOne(bc => bc.User)
        .WithMany(b => b.Contracts)
        .HasForeignKey(bc => bc.UserId);

            modelBuilder.Entity<Contract>()
        .HasOne(bc => bc.Apartment)
        .WithMany(b => b.Contracts)
        .HasForeignKey(bc => bc.UserId);
        }

        public DbSet<Apartment> Apartments { get; set; }

        public DbSet<User> Users { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<Adress> Adresses { get; set; }
        public DbSet<Contract> Contracts { get; set; }
    }
}
