using CRUDOprationAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace CRUDOprationAPI.Data
{
    public class ApplicationDBContext : DbContext
    {
        

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }
        public DbSet<ProductMaster> ProductMaster { get; set; } 
        public DbSet<CategoryMaster> CategoryMaster { get; set; }



    }
}
