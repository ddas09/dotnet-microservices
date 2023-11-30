using AMS.Common.Data;
using AMS.Common.Data.Entities;
using AMS.Common.DAL.Contracts;

namespace AMS.Common.DAL.Repositories;

public class OrderItemRepository : CrudBaseRepository<OrderItem>, IOrderItemRepository
{
    public OrderItemRepository(BaseDBContext dbContext) : base(dbContext)
    {
    }
}