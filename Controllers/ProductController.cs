using Microsoft.AspNetCore.Mvc;

namespace StudentManagement.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Detail(int id)
        {
            return Content("Product ID = " + id);
        }

        public IActionResult Category(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return Content("Lỗi: Vui lòng truyền tên danh mục.");
            }

            return Content("Category = " + name);
        }
    }
}