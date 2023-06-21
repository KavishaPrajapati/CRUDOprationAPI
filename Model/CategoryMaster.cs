using System.ComponentModel.DataAnnotations;

namespace CRUDOprationAPI.Model
{
    public class CategoryMaster
    {
        [Key]
        public int CategoryId { get; set; }
        
        public string CategoryName { get; set; }
    }
}
