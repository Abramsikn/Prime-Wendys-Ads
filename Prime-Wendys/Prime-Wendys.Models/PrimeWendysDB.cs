using Microsoft.EntityFrameworkCore;
using System;

namespace PrimeWendys.Models
{
    public class PrimeWendysDB : DbContext
    {
        public PrimeWendysDB(DbContextOptions<PrimeWendysDB> dbContext) : base(dbContext) { }

        //DBSet is used to query data and also save data to or from DB
        public DbSet<Door> Doors { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<Wendy> Wendies { get; set; }
        public DbSet<Window> Windows { get; set; }
        public DbSet<Wood> Woods { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Post>()
            //    .HasOne(p => p.Blog)
            //    .WithMany(b => b.Posts);

            //modelBuilder.Entity<User>()
            //    .HasOne(u => u.Role)
            //    .WithOne(r => r.User);
        }
    }
}
