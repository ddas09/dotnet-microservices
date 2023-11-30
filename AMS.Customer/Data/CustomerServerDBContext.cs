using AMS.Common.Data;
using AMS.Common.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace AMS.Customer.Data;

public class CustomerServerDBContext : BaseDBContext
{
    public CustomerServerDBContext(DbContextOptions<CustomerServerDBContext> options) : base(options)
    {
    }

    public DbSet<Order> Orders { get; set; }

    public DbSet<Product> Products { get; set; }

    public DbSet<Order> OrderItems { get; set; }
}