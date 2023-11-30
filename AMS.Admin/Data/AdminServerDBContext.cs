using AMS.Common.Data;
using AMS.Common.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace AMS.Admin.Data;

public class AdminServerDBContext : BaseDBContext
{
    public AdminServerDBContext(DbContextOptions<AdminServerDBContext> options) : base(options)
    {
    }

    public DbSet<Order> Orders { get; set; }

    public DbSet<Product> Products { get; set; }

    public DbSet<Order> OrderItems { get; set; }
}