using CRUDOprationAPI.Data;
using CRUDOprationAPI.Interface.Repository;
using CRUDOprationAPI.Model;
using EntityFrameworkCore.Repository.Repository;
using Microsoft.EntityFrameworkCore;

namespace CRUDOprationAPI.Repository
{
    public class ProductRepository : CommonRepository<ProductMaster>, IProductRepository
    {
        public ProductRepository(ApplicationDBContext dbContext) : base(dbContext)
        {
        }
    }
}
