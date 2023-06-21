using CRUDOprationAPI.Model;
using EntityFrameworkCore.Repository.Interface.Manager;

namespace CRUDOprationAPI.Interface.Manager
{
    public interface IProductManager:ICommonManager<ProductMaster>
    {
        ProductMaster GetById(int id);
    }
}
