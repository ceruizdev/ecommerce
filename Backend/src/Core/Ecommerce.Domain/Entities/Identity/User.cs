using Microsoft.AspNetCore.Identity;

namespace Ecommerce.Domain.Identity;
public class User : IdentityUser
{
    public string? Name{get; set;}
    public string? LastName { get; set; }
    public string? Phone { get; set; }
    public string? AvatarURL { get; set; }      
    public bool IsActive { get; set; }
}