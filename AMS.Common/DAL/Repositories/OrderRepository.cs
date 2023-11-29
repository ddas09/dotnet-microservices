using AMS.Common.DAL.Contracts;
using AMS.Common.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace AMS.Common.DAL.Repositories;

public class OrderRepository : CrudBaseRepository<Order>, IOrderRepository
{
    public OrderRepository(DbContext dbContext) : base(dbContext)
    {
    }
}