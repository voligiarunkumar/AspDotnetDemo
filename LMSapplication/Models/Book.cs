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
       virtual public string BookTitle { get; set; }

        [Required]
        [DefaultValue(1)]
       virtual public string NumberOfCopies { get; set; }

        [Required]
        [DefaultValue(false)]
       virtual public bool IsEnabled { get; set; }
        virtual public string imageUrl { get; set; } = null;
       //foreign key generation 
       virtual public int CategoryId { get; set; }
        [ForeignKey (nameof(Book.CategoryId))]
        public Category Category { get; set; }
    }
}

