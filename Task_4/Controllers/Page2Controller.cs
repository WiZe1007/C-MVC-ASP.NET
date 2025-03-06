using Microsoft.AspNetCore.Mvc;

namespace Task_4.Controllers
{
    public class Page2Controller : Controller
    {
        // GET: Page2/Index
        // Повертаємо подання для Стор 2
        public IActionResult Index()
        {
            // Повертаємо View для Стор 2
            return View();
        }
    }
}
