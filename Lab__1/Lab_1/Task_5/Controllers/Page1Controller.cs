using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Task_5.Controllers
{
    public class Page1Controller : Controller
    {
        // GET: Page1/Index
        public IActionResult Index()
        {
            // Ключ для зберігання ліч Стор 1 
            const string sessionKey = "Page1Count";
            // Зчитуємо поточ значення ліч
            int count = (HttpContext.Session.GetInt32(sessionKey) ?? 0) + 1;
            // Записуємо оновлене 
            HttpContext.Session.SetInt32(sessionKey, count);
            // Передаємо значення лічильника у ViewBag
            ViewBag.VisitCount = count;

            return View();
        }
    }
}
