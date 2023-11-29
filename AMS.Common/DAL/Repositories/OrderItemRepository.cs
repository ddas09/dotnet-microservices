using AMS.Common.DAL.Contracts;
using AMS.Common.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace AMS.Common.DAL.Repositories;

public class OrderItemRepository : CrudBaseRepository<OrderItem>, IOrderItemRepository
{
    public OrderItemRepository(DbContext dbContext) : base(dbContext)
    {
    }
}