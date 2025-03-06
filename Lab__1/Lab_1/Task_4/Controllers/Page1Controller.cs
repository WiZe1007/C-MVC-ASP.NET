using Microsoft.AspNetCore.Mvc;

namespace Task_4.Controllers
{
    public class Page1Controller : Controller
    {
        // GET: Page1/Index
        // Метод повертає подання для Сторінки 1
        public IActionResult Index()
        {
            // Повертаємо View для відображ Стор 1
            return View();
        }
    }
}
