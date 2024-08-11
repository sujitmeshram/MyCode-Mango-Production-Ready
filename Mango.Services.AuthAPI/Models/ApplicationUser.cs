using Microsoft.AspNetCore.Identity;

namespace Mango.Services.AuthAPI.Models
{
    //to add more custom fields for identity, like our own fields
    public class ApplicationUser:IdentityUser
    {
        public string Name { get; set; }    
    }
}
