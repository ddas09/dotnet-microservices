using AMS.Common.DAL.Contracts;
using AMS.Common.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace AMS.Common.DAL.Repositories;

public class ProductRepository : CrudBaseRepository<Product>, IProductRepository
{
    public ProductRepository(DbContext dbContext) : base(dbContext)
    {
    }
}