using Microsoft.AspNetCore.Mvc;

namespace Identity_app.Controllers
{
    public class Accounts : Controller
    {
        public IActionResult SignUp()
        {
            return View();
        }
    }
}
