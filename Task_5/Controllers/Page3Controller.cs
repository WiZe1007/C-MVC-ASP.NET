using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Task_5.Controllers
{
    public class Page3Controller : Controller
    {
        // GET: Page3/Index
        public IActionResult Index()
        {
            // Визначаємо ключ сесії для збереження ліч відв Стор 3
            const string sessionKey = "Page3Count";
            // Зчитуємо поточне знач з сесії
            int count = (HttpContext.Session.GetInt32(sessionKey) ?? 0) + 1;
            // Записуємо оновлене значення
            HttpContext.Session.SetInt32(sessionKey, count);
            // Передаємо оновлений ліч у ViewBag
            ViewBag.VisitCount = count;

            return View();
        }
    }
}
