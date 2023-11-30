using AMS.Common.Data;
using AMS.Common.DAL.Contracts;
using AMS.Common.Data.Entities;

namespace AMS.Common.DAL.Repositories;

public class AdminRepository : CrudBaseRepository<Admin>, IAdminRepository
{
    public AdminRepository(BaseDBContext dbContext) : base(dbContext)
    {
    }
}