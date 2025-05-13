using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace Assignment24SocialMediaLinks.Controllers
{
    public class HomeController : Controller
    {
        private readonly SocialMediaLinksOptions _options;

        public HomeController(IOptions<SocialMediaLinksOptions> options)
        {
            _options = options.Value;
        }

        [Route("/")]
        public IActionResult Index()
        {
            ViewBag.SocialMediaLinksOptions = _options;
            return View();
        }
    }
}
