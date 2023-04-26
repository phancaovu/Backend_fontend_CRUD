using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Backend.Data
{
    public class ApplicationUser : IdentityUser
    {
        public string Username { get; set; } =null!;
        public string FullName { get; set; } = null!;
    }
}
