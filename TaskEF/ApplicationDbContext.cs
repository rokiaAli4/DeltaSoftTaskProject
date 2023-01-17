using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TaskCore.Models;

namespace TaskEF
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<Member> Members { get; set; }
    }

    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Member>().HasData(
                new Member
                {
                    Member_Id = 1,
                    MemberName = "Mohamed",
                    Email = "Mohamed@gmail.com",
                    Address = "mansoura",
                    Phone = "88888888",
                    IsDeleted = false
                },
                new Member
                {
                    Member_Id = 2,
                    MemberName = "Rokia",
                    Email = "Rokia@gmail.com",
                    Address = "Alex",
                    Phone = "999999999",
                    IsDeleted = false
                }
                ,
                new Member
                {
                    Member_Id = 3,
                    MemberName = "Salem",
                    Email = "Salem@gmail.com",
                    Address = "cairo",
                    Phone = "1111111111",
                    IsDeleted = false
                }
                ,
                new Member
                {
                    Member_Id = 4,
                    MemberName = "Noor",
                    Email = "Noor@gmail.com",
                    Address = "mansoura",
                    Phone = "99999999",
                    IsDeleted = false
                }
            );

        }
    }
}
