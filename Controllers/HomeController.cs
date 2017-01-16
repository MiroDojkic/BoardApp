using Microsoft.AspNetCore.Mvc;

namespace FesbBoardBackend.Controllers
{
    [Route("[controller]")]
    public class HomeController : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
