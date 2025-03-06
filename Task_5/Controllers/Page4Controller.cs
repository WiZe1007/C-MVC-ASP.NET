using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Task_5.Controllers
{
    public class Page4Controller : Controller
    {
        // GET: Page4/Index 
        public IActionResult Index()
        {
            // Визначаємо ключ сесії для збереження ліч відв Стор 4
            const string sessionKey = "Page4Count";
            // Зчитуємо поточне знач з сесії
            int count = (HttpContext.Session.GetInt32(sessionKey) ?? 0) + 1;
            // Записуємо оновлене значення ліч
            HttpContext.Session.SetInt32(sessionKey, count);
            // Передаємо значення ліч у ViewBag 
            ViewBag.VisitCount = count;

            return View();
        }
    }
}
