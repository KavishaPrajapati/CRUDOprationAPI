using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUDOprationAPI.Model
{
    public class ProductMaster
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int P_Id { get; set; }
        [Required]

        [ForeignKey("CategoryMaster")]
        public int? CategoryId { get; set; }
        public string ProductName { get; set;}
        public decimal ProductQuntity { get; set;}
        [Required]
        public int ProductPrice { get; set;}
        public decimal Total { get; set;}
        //// Foreign key 
        //[Display(Name = "Category")]
        //public int CategoryId { get; set; }
        //[ForeignKey("CategoryId")]
        //public virtual CategoryMaster CategoryMaster { get; set; }

    }
}
