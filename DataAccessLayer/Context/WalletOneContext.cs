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
            Database.EnsureCreated();
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

                builder.HasData(new TaskUser(1, "test1", "test1", TaskStatus.Process, 1, 2));
                builder.HasData(new TaskUser(2, "test2", "test2", TaskStatus.Process, 1, 3));
                builder.HasData(new TaskUser(3, "test3", "test3", TaskStatus.Process, 1, 4));
                builder.HasData(new TaskUser(4, "test4", "test4", TaskStatus.Rejected, 1, 5));
                builder.HasData(new TaskUser(5, "test5", "test5", TaskStatus.Process, 2, 1));
                builder.HasData(new TaskUser(6, "test6", "test6", TaskStatus.Process, 1, 2));
                builder.HasData(new TaskUser(7, "test7", "test7", TaskStatus.Complete, 1, 3));
                builder.HasData(new TaskUser(8, "test8", "test8", TaskStatus.Process, 4, 2));
                builder.HasData(new TaskUser(9, "test9", "test9", TaskStatus.Process, 1, 4));
                builder.HasData(new TaskUser(10, "test10", "test10", TaskStatus.DontStart, 2, 3));
                builder.HasData(new TaskUser(11, "test11", "test11", TaskStatus.DontStart, 4, 2));
                builder.HasData(new TaskUser(12, "test12", "test12", TaskStatus.DontStart, 5, 2));
                builder.HasData(new TaskUser(13, "test13", "test13", TaskStatus.DontStart, 1, 2));
                builder.HasData(new TaskUser(14, "test14", "test14", TaskStatus.DontStart, 2, 5));
                builder.HasData(new TaskUser(15, "test15", "test15", TaskStatus.DontStart, 3, 4));
                builder.HasData(new TaskUser(16, "test16", "test16", TaskStatus.DontStart, 3, 1));
                builder.HasData(new TaskUser(17, "test17", "test17", TaskStatus.DontStart, 3, 2));
                builder.HasData(new TaskUser(18, "test18", "test18", TaskStatus.DontStart, 3, 1));
                builder.HasData(new TaskUser(19, "test19", "test19", TaskStatus.DontStart, 4, 2));
                builder.HasData(new TaskUser(20, "test20", "test20", TaskStatus.DontStart, 5, 2));
                builder.HasData(new TaskUser(21, "test21", "test21", TaskStatus.DontStart, 5, 1));
                builder.HasData(new TaskUser(22, "test22", "test22", TaskStatus.DontStart, 5, 4));
                builder.HasData(new TaskUser(23, "test23", "test23", TaskStatus.DontStart, 5, 3));
                builder.HasData(new TaskUser(24, "test24", "test24", TaskStatus.DontStart, 1, 2));
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

                builder.HasData(new User(1, "test1", "test1", DateTime.Now, DateTime.Now, UserStatus.Active));
                builder.HasData(new User(2, "test2", "test2", DateTime.Now, DateTime.Now, UserStatus.Active));
                builder.HasData(new User(3, "test3", "test3", DateTime.Now, DateTime.Now, UserStatus.Rejected));
                builder.HasData(new User(4, "test4", "test4", DateTime.Now, DateTime.Now, UserStatus.Ban));
                builder.HasData(new User(5, "test5", "test5", DateTime.Now, DateTime.Now, UserStatus.Active));
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
