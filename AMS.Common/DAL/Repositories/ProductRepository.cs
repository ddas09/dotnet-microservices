using AMS.Common.Data;
using AMS.Common.Data.Entities;
using AMS.Common.DAL.Contracts;

namespace AMS.Common.DAL.Repositories;

public class ProductRepository : CrudBaseRepository<Product>, IProductRepository
{
    public ProductRepository(BaseDBContext dbContext) : base(dbContext)
    {
    }
}