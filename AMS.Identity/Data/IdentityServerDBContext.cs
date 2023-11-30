using AMS.Common.Data;
using AMS.Common.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace AMS.Identity.Data;

public class IdentityServerDBContext : BaseDBContext
{
    public IdentityServerDBContext(DbContextOptions<IdentityServerDBContext> options) : base(options)
    {
    }

    public DbSet<User> Users { get; set; }

    public DbSet<Admin> Admins { get; set; }
}