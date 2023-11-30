using Microsoft.EntityFrameworkCore;

namespace AMS.Common.Data;

public abstract class BaseDBContext : DbContext
{
    public BaseDBContext(DbContextOptions options) : base(options)
    {
    }
}

