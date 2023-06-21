using CRUDOprationAPI.Data;
using CRUDOprationAPI.Interface.Manager;
using CRUDOprationAPI.Model;
using CRUDOprationAPI.Repository;
using EntityFrameworkCore.Repository.Manager;
using EntityFrameworkCore.Repository.Repository;
using Microsoft.EntityFrameworkCore;

namespace CRUDOprationAPI.Manager
{
    public class ProductManager :CommonManager<ProductMaster>, IProductManager
    {
        public ProductManager (ApplicationDBContext _dbContext) : base(new ProductRepository (_dbContext))
        {
        }

        public ProductMaster GetById(int id)
        {
            return GetFirstOrDefault(x => x.P_Id == id);
        }
    }
}
