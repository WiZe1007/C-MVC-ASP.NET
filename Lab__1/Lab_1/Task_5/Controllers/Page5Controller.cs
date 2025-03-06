using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Task_5.Controllers
{
    public class Page5Controller : Controller
    {
        // GET: Page5/Index
        public IActionResult Index()
        {
            // Визначаємо ключ для ліч відв Стор 5
            const string sessionKey = "Page5Count";
            // Зчитуємо поточне знач з сесії
            int count = (HttpContext.Session.GetInt32(sessionKey) ?? 0) + 1;
            // Записуємо оновлене знач
            HttpContext.Session.SetInt32(sessionKey, count);
            // Передаємо ліч у ViewBag
            ViewBag.VisitCount = count;

            return View();
        }
    }
}
