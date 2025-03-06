using Microsoft.AspNetCore.Mvc;

namespace Task_4.Controllers
{
    public class Page4Controller : Controller
    {
        // GET: Page4/Index
        // Повертаємо View для Сторінки 4
        public IActionResult Index()
        {
            // Повертаємо View Стор 4)
            return View();
        }
    }
}
