using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }   
        public DateTime CreatedDate { get; set; }  = DateTime.Now;
        [Required]
        public DateTime BirthDate { get; set; }
    }
}
