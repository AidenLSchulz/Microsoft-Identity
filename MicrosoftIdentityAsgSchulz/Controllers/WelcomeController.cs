using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace MicrosoftIdentityAsgSchulz.Controllers
{
    [Authorize] // Only logged-in users can access
    public class WelcomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
