using Microsoft.AspNetCore.Mvc;

namespace HaberPortalı.UI.Controllers
{
   
    public class AdminController : Controller
    {
        private readonly IConfiguration _configuration;
        public AdminController(IConfiguration configuration)
        {


            _configuration = configuration;


        }
        public IActionResult Index()
        {
            return View();
        }
        
        [Route("Users")]
        public IActionResult AdminUser()
        {
            string ApiBaseUrl = _configuration["ApiBaseUrl"]!;
            ViewBag.ApiBaseUrl = ApiBaseUrl;
            return View();
        }

        [Route("AdminCategories")]
        public IActionResult AdminCategories()
        {
            string ApiBaseUrl = _configuration["ApiBaseUrl"]!;
            ViewBag.ApiBaseUrl = ApiBaseUrl;
            return View();
        }

        [Route("AdminNews")]
        public IActionResult AdminNews()
        {
            string ApiBaseUrl = _configuration["ApiBaseUrl"]!;
            ViewBag.ApiBaseUrl = ApiBaseUrl;
            return View();
        }

        [Route("AdminProducts")]
        public IActionResult AdminProducts()
        {
            string ApiBaseUrl = _configuration["ApiBaseUrl"]!;
            ViewBag.ApiBaseUrl = ApiBaseUrl;
            return View();
        }
    }
}
