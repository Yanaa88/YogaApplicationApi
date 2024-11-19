using Microsoft.AspNetCore.Identity;

namespace YogaApplicationApi.Database
{
    public class User : IdentityUser
    {
        public string? Initials {  get; set; }
    }
}
