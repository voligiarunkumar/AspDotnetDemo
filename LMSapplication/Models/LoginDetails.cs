using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LMSapplication.Models
{
    [Table(name:"LoginDetails")]
    public class LoginDetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string UserName { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public int ContactNumber { get; set;}
        [Required]
        public string Address {get; set; }  
    }
}
