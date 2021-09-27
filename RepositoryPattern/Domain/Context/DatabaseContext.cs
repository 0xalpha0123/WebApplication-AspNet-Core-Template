﻿using Microsoft.EntityFrameworkCore;
using RepositoryPattern.Domain.Entities;
using RepositoryPattern.Domain.EntityTypeConfigurations;

namespace RepositoryPattern.Domain.Context
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder) =>
            modelBuilder.ApplyConfiguration(new SongEntityTypeConfiguration());

        public DbSet<Song> Songs { get; set; }
    }
}
