﻿using BlazorBattles.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorBattles.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Battle>()
                .HasOne(x => x.Attacker)
                .WithMany()
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Battle>()
                .HasOne(x => x.Opponent)
                .WithMany()
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Battle>()
                .HasOne(x => x.Winner)
                .WithMany()
                .OnDelete(DeleteBehavior.NoAction);
        }

        public DbSet<Unit> Units { get; set; }

        public DbSet<AppUser> AppUsers { get; set; }

        public DbSet<UserUnit> UserUnits { get; set; }

        public DbSet<Battle> Battles { get; set; }
    }
}
