using AMS.Common.DAL.Contracts;
using AMS.Common.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace AMS.Common.DAL.Repositories;

public class UserRepository : CrudBaseRepository<User>, IUserRepository
{
    public UserRepository(DbContext dbContext) : base(dbContext)
    {
    }
}