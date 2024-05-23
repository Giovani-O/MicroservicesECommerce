﻿using MicroservicesECommerce.ProductApi.Models;
using Microsoft.EntityFrameworkCore;

namespace MicroservicesECommerce.ProductApi.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    { }

    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }


}
