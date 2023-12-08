using Microsoft.AspNetCore.Mvc;
using App.Filters;

namespace App.Areas.Controllers
{
    [Area("Admin")]
    [AdminAuthorize]
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}