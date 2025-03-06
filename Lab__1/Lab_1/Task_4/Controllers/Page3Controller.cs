using Microsoft.AspNetCore.Mvc;

namespace Task_4.Controllers
{
    public class Page3Controller : Controller
    {
        // GET: Page3/Index
        // Повертаємо подання для Стор 3
        public IActionResult Index()
        {
            // Повертаємо подання View для Стор 3
            return View();
        }
    }
}
