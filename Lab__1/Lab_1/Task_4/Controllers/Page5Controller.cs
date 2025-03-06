using Microsoft.AspNetCore.Mvc;

namespace Task_4.Controllers
{
    public class Page5Controller : Controller
    {
        // GET: Page5/Index
        // Метод повертає подання для Стор 5
        public IActionResult Index()
        {
            // Повертаємо подання для Стор 5
            return View();
        }
    }
}