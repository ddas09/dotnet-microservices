using AMS.Common.DAL.Contracts;
using AMS.Common.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace AMS.Common.DAL.Repositories;

public class AdminRepository : CrudBaseRepository<Admin>, IAdminRepository
{
    public AdminRepository(DbContext dbContext) : base(dbContext)
    {
    }
}