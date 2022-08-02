using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LMSapplication.Models
{
    [Table(name: "Books")]
    public class Book
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
         virtual public int BookId { get; set; }
        [Required]
        [StringLength(100)]
        public string BookTitle { get; set; }

        [Required]
        [DefaultValue(1)]
        public string NumberOfCopies { get; set; }

        [Required]
        [DefaultValue(false)]
        public bool IsEnabled { get; set; }
       //foreign key generation 
        public int CategoryId { get; set; }
        [ForeignKey (nameof(Book.CategoryId))]
        public Category Category { get; set; }
    }
}

