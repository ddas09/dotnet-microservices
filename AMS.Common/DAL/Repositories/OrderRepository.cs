using AMS.Common.Data;
using AMS.Common.Data.Entities;
using AMS.Common.DAL.Contracts;

namespace AMS.Common.DAL.Repositories;

public class OrderRepository : CrudBaseRepository<Order>, IOrderRepository
{
    public OrderRepository(BaseDBContext dbContext) : base(dbContext)
    {
    }
}