using BusinessLayer.Model;
using Microsoft.EntityFrameworkCore;
using System;

namespace DataAccessLayer.Context
{
    public class WalletOneContext : DbContext
    {
        public WalletOneContext(DbContextOptions<WalletOneContext> options)
            : base(options)
        {
            if (Database.EnsureCreated())
                LoadTestData();
        }

        public DbSet<User> Users { get; set; }
        public DbSet<TaskUser> TaskUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TaskUser>(builder =>
            {
                builder.HasKey(o => o.Id);
                builder.Property(o => o.Id)
                    .ValueGeneratedNever();
                builder.Property(o => o.Name);
                builder.Property(o => o.DateCreate);
                builder.Property(o => o.DateLastEdit);
                builder.Property(o => o.Description);
                builder.Property(o => o.Status);
                builder.Property(o => o.DirectorId);
                builder.Property(o => o.PerformerId);
            });

            modelBuilder.Entity<User>(builder =>
            {
                builder.HasKey(o => o.Id);
                builder.Property(o => o.Id)
                        .ValueGeneratedNever();

                builder.Property(o => o.DateCreate);
                builder.Property(o => o.DateLastEdit);
                builder.Property(o => o.FirstName);
                builder.Property(o => o.MiddleName);
                builder.Property(o => o.Status);

            });

            base.OnModelCreating(modelBuilder);
        }
        private void LoadTestData()
        {
            User user = new User(1, "test1", "test1", DateTime.Now, DateTime.Now, UserStatus.Active);
            User user2 = new User(2, "test2", "test2", DateTime.Now, DateTime.Now, UserStatus.Active);
            User user3 = new User(3, "test3", "test3", DateTime.Now, DateTime.Now, UserStatus.Rejected);
            User user4 = new User(4, "test4", "test4", DateTime.Now, DateTime.Now, UserStatus.Ban);
            User user5 = new User(5, "test5", "test5", DateTime.Now, DateTime.Now, UserStatus.Active);

            Users.AddRange(user, user2, user3, user4, user5);
            SaveChanges();
        }
    }
}
