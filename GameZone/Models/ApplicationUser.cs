using Microsoft.AspNetCore.Identity;

namespace GameZone.Models
{
    public class ApplicationUser  : IdentityUser
{
    [Required(ErrorMessage = "First Name is required")]
    [StringLength(50, ErrorMessage = "First Name cannot be longer than 50 characters")]
    public string FirstName { get; set; }

    [Required(ErrorMessage = "Last Name is required")]
    [StringLength(50, ErrorMessage = "Last Name cannot be longer than 50 characters")]
    public string LastName { get; set; }
}
    
}
