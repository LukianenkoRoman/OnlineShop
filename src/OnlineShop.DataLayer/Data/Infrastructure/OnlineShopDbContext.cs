﻿using Microsoft.EntityFrameworkCore;
using OnlineShop.DataLayer.Data.Entities_Configurations;
using OnlineShop.DataLayer.Entities;

namespace OnlineShop.DataLayer.Data.Infrastructure;

public class OnlineShopDbContext : DbContext
{
    public OnlineShopDbContext(DbContextOptions<OnlineShopDbContext> options)
        : base(options)
    {
    }

    public DbSet<Item> Items { get; set; }
    public DbSet<Category> Categories { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new ItemConfiguration());
        modelBuilder.ApplyConfiguration(new CategoryConfiguration());

        base.OnModelCreating(modelBuilder);
    }
}