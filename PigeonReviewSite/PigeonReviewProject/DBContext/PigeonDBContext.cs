using Microsoft.EntityFrameworkCore;
using PigeonReviewProject.Models;

namespace PigeonReviewProject.DBContext
{
    public class PigeonDBContext:DbContext
    {
        public PigeonDBContext(DbContextOptions<PigeonDBContext> options)
            : base(options)
        { 
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Pigeon> Pigeon  { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<District> Districts { get; set; }

        public DbSet<PigeonOwner> PigeonOwners { get; set; }
        public DbSet<PigeonCategory> PigeonCategories { get; set; }
        public DbSet<Reviewer> Reviewers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PigeonCategory>()
                .HasKey(p => new { p.PigeonId, p.CategoryId });
            modelBuilder.Entity<PigeonCategory>()
                .HasOne(p => p.Pigeon)
                .WithMany(pc => pc.PigeonCategories)
                .HasForeignKey(c => c.PigeonId);
          
            modelBuilder.Entity<PigeonCategory>()
                .HasOne(p => p.Category)
                .WithMany(pc => pc.PigeonCategories)
                .HasForeignKey(c => c.CategoryId);

            modelBuilder.Entity<PigeonOwner>()
                .HasKey(po => new { po.PigeonId, po.OwnerId });
            modelBuilder.Entity<PigeonOwner>()
                .HasOne(p => p.Pigeon)
                .WithMany(pc => pc.pigeonOwners)
                .HasForeignKey(c => c.PigeonId);

            modelBuilder.Entity<PigeonOwner>()
                .HasOne(p => p.Owner)
                .WithMany(pc => pc.PigeonOwners)
                .HasForeignKey(c => c.OwnerId);
        }



    }
    
}
