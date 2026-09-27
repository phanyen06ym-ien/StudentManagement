using Microsoft.AspNetCore.Mvc;

namespace StudentManagement.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Content("Welcome to ASP.NET MVC");
        }

        public IActionResult About()
        {
            return Content("Sinh viên: Nguyễn Văn A");
        }

        public IActionResult Contact()
        {
            return Content("Email: nguyenvana@example.com");
        }
    }
}