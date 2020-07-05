using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Entities
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions<RepositoryContext> options):base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<User>()
                .HasAlternateKey(c => c.RID)
                .HasName("RID");

            modelBuilder.Entity<People>()
                .HasAlternateKey(c => c.RID)
                .HasName("RID");
        }
    }
}
