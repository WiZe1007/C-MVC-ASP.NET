using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Task_5.Controllers
{
    public class Page2Controller : Controller
    {
        // GET: Page2/Index
        public IActionResult Index()
        {
            // Визначаємо ключ для збереження ліч відв Стор 2
            const string sessionKey = "Page2Count";
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
