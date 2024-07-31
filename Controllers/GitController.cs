using Microsoft.AspNetCore.Mvc;

namespace testingCommandGithub.Controllers
{
    public class GitController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
