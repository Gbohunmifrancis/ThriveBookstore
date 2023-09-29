using Microsoft.AspNetCore.Mvc;

namespace BookstoreMVC.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View(); 
        }

        public ViewResult About()
        {
            return View();
        }

        public ViewResult ContactUs()
        {
            return View();
        }
    }
}
