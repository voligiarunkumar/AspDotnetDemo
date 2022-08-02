using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LMSapplication.Models
{
    [Table(name: "Products")]
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        [StringLength(50)]
        public string ProductName { get; set; }
        [Required]
        public string ProductDescription { get; set; }
        [Required]
        public string productTitle{ get; set; }
        public int CategoryId { get; set; }

        [ForeignKey(nameof(Product.CategoryId))]
        public Category Category { get; set; }
    }
}
