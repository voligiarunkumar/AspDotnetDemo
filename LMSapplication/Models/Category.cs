using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LMSapplication.Models
{
    [Table(name: "Categories")]
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryId { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        [StringLength(50)]
        public string CategoryName { get; set; }
        public string CatogoryTitle { get; set; }

        public string CatogoryNumber { get; set; }
        public string CategoryDescription { get; set; }
        //foriegn key generation by sir
        public  ICollection<Book> Books { get; set; }
        // foriegn key generation by me task 
        public ICollection<Product> Products { get; set; }
    }
}