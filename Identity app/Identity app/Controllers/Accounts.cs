using Microsoft.AspNetCore.Mvc;

namespace Identity_app.Controllers
{
    public class Accounts : Controller
    {
        public IActionResult SignUp()
        {
            return View();
        }


        public IActionResult SignUp(IActionResult actionResult)
        {
            return null;

        }

    }
}
