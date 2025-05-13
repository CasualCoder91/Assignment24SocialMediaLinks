using Microsoft.AspNetCore.Mvc;

namespace Assignment24SocialMediaLinks.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfiguration _configuration;

        public HomeController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [Route("/")]
        public IActionResult Index()
        {
            SocialMediaLinksOptions? options = _configuration.GetSection("SocialMediaLinks").Get<SocialMediaLinksOptions>();

            ViewBag.SocialMediaLinksOptions = options;

            return View();
        }
    }
}
