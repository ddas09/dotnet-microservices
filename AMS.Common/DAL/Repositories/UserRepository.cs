using AMS.Common.Data;
using AMS.Common.Data.Entities;
using AMS.Common.DAL.Contracts;

namespace AMS.Common.DAL.Repositories;

public class UserRepository : CrudBaseRepository<User>, IUserRepository
{
    public UserRepository(BaseDBContext dbContext) : base(dbContext)
    {
    }
}