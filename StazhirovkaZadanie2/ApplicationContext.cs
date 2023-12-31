﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StazhirovkaZadanie2
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<LoginsHistory> LoginsHistory { get; set; }
        public ApplicationContext()
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().HasIndex(b => b.Name);
            modelBuilder.Entity<User>().HasIndex(b => b.RoleId);
            modelBuilder.Entity<User>().HasIndex(b => b.Login).IsUnique();
            modelBuilder.Entity<LoginsHistory>().HasIndex(b => b.UserId);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=SportDB;Username=postgres;Password=12345");
        }

    }
}
