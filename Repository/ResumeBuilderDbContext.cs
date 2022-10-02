using Data.Files;
using Data.HomePage;
using Data.Language;
using Data.LogEvents;
using Data.Messages;
using Data.SchedulesTasks;
using Data.Settings;
using Data.Templates;
using Data.Users;
using Data.UserTemplates;
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
            modelBuilder.Entity<User>()
                        .Property(b => b.IsLocked)
                        .HasDefaultValue(false);
            modelBuilder.Entity<User>()
                        .Property(b => b.RequireReLogin)
                        .HasDefaultValue(false);
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
            modelBuilder.Entity<TemplateCategory>()
                        .Property(b => b.CreatedDate)
                        .HasDefaultValue(DateTime.UtcNow);
            modelBuilder.Entity<Template>()
                        .Property(b => b.CreatedDate)
                        .HasDefaultValue(DateTime.UtcNow);
            modelBuilder.Entity<TemplateSection>()
                        .Property(b => b.CreatedDate)
                        .HasDefaultValue(DateTime.UtcNow);
            modelBuilder.Entity<TemplateProfile>()
                        .Property(b => b.CreatedDate)
                        .HasDefaultValue(DateTime.UtcNow);
            modelBuilder.Entity<SearchTerm>()
                        .Property(b => b.Count)
                        .HasDefaultValue(0);
            modelBuilder.Entity<Topic>()
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
        DbSet<ScheduleTask> ScheduleTasks { get; set; }
        DbSet<SearchTerm> SearchTerms { get; set; }
        DbSet<Setting> Settings { get; set; }
        DbSet<UserSetting> UserSettings { get; set; }
        DbSet<TemplateCategory> TemplateCategories { get; set; }
        DbSet<Template> Templates { get; set; }
        DbSet<TemplateTag> TemplateTags { get; set; }
        DbSet<TemplateSection> TemplateSections { get; set; }
        DbSet<TemplateComponent> templateComponents { get; set; }
        DbSet<TemplateSubComponent> TemplateSubComponents { get; set; }
        DbSet<TemplateKeyValuePair> TemplateKeyValuePairs { get; set; }
        DbSet<TemplateProfile> TemplateProfiles { get; set; }
        DbSet<TemplateSetting> TemplateSettings { get; set; }
        DbSet<UserTemplateSection> UserTemplateSections { get; set; }
        DbSet<UserTemplateComponent> UserTemplateComponents { get; set; }
        DbSet<UserTemplateSubComponent> UserTemplateSubComponents { get; set; }
        DbSet<UserTemplateKeyValuePair> UserTemplateKeyValuePairs { get; set; }
        DbSet<MenuItem> MenuItems { get; set; }
        DbSet<Topic> Topics { get; set; }

    }
}
