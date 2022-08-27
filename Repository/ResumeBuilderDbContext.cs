using Data.Files;
using Data.Language;
using Data.Log;
using Data.Logs;
using Data.Messages;
using Data.Users;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class ResumeBuilderDbContext : DbContext
    {
        public ResumeBuilderDbContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                        .Property(b => b.CreatedDate)
                        .HasDefaultValue(DateTime.UtcNow);
            modelBuilder.Entity<UserPassword>()
                        .Property(b => b.CreatedDate)
                        .HasDefaultValue(DateTime.UtcNow);
            modelBuilder.Entity<Log>()
                        .Property(b => b.CreatedDate)
                        .HasDefaultValue(DateTime.UtcNow);
            modelBuilder.Entity<UserActivity>()
                        .Property(b => b.CreatedDate)
                        .HasDefaultValue(DateTime.UtcNow);
            modelBuilder.Entity<UserReview>()
                        .Property(b => b.TotalLike)
                        .HasDefaultValue(0);
            modelBuilder.Entity<UserReview>()
                        .Property(b => b.TotalDislike)
                        .HasDefaultValue(0);
            modelBuilder.Entity<UserReview>()
                        .Property(b => b.CreatedDate)
                        .HasDefaultValue(DateTime.UtcNow);
            modelBuilder.Entity<Document>()
                        .Property(b => b.CreatedDate)
                        .HasDefaultValue(DateTime.UtcNow);
            modelBuilder.Entity<QueuedEmail>()
                        .Property(b => b.CreatedDate)
                        .HasDefaultValue(DateTime.UtcNow);

            //modelBuilder.Entity<Child>()
            //.HasRequired(c => c.Parent)
            //.WithMany(p => p.Childs)
            //.HasForeignKey(c => c.ParentId);

            base.OnModelCreating(modelBuilder);
        }
        DbSet<Picture> Pictures { get; set; }
        DbSet<User> Users { get; set; }
        DbSet<UserPassword> UsersPassword { get; set; }
        DbSet<Language> Languages { get; set; }
        DbSet<LocaleStringResource> LocaleStringResource { get; set; }
        DbSet<LocalizedProperty> LocalizedProperties { get; set; }
        DbSet<Log> Logs { get; set; }
        DbSet<UserActivity> UserActivities { get; set; }
        DbSet<UserReview> UserReviews { get; set; }
        DbSet<Document> Documents { get; set; }
        DbSet<QueuedEmail> QueuedEmails { get; set; }

    }
}
