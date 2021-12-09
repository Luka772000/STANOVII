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
        .HasOne(a => a.Card).WithOne(b => b.User)
        .HasForeignKey<Card>(e => e.UserId);

        }

        public DbSet<Apartment> Apartments { get; set; }

        public DbSet<User> Users { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<Adress> Adresses { get; set; }
        public DbSet<Contract> Contracts { get; set; }
    }
}
