using Microsoft.AspNetCore.Mvc;

namespace BulkyNew.Controllers
{
    public class NewController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
