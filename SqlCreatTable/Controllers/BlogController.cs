using Microsoft.AspNetCore.Mvc;

namespace SqlCreatTable.Controllers
{
    public class BlogController:Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
