﻿using Microsoft.EntityFrameworkCore;

namespace Mission06_Tullis.Models
{
    public class MovieApplicationContext : DbContext
    {
        public MovieApplicationContext(DbContextOptions<MovieApplicationContext> options) : base(options)
        {
        }

        public DbSet<Application> Movies { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
