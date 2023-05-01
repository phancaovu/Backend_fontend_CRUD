using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Models
{
    [Table("User")]
    public class User
    {
        [Key]
        public int UserID { get; set; } 
       
   
        public string Username { get; set; } = string.Empty;
      
        public string Email { get; set; } = string.Empty;
   
        public string Password { get; set; }= string.Empty;
        public string FullName { get; set; } = string.Empty;
        public string Avatar { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }

    }
}
