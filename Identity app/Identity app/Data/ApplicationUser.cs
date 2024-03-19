using Microsoft.AspNetCore.Identity;


namespace Identity_app.Data
{
    public class ApplicationUser :IdentityUser
    {
        public string FisrtName { get; set; }
        public int Age { get; set; }
       
    }
}
