//calls namespace for IdentityUser
using Microsoft.AspNetCore.Identity;

//matching to project folder structure
namespace Backend.Models
{
    //IdentityUser is provided by ASP.NET
    //adds ID, UserName, Email, PasswordHash, PhoneNumber ext
    public class User : IdentityUser
    {
        //custom properties, name shown in chatroom, not login
        public string DisplayName { get; set; } = string.Empty;
    }
}