using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;           
using Task_4.Models;           

namespace Task_4.Controllers
{
    public class HomeController : Controller
    {
        // Логгер
        private readonly ILogger<HomeController> _logger;

        // Констр який отримує логгер через dependency injection
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // Дія для головної сторінки
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        // Дія для обробки помилок
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            // Створюємо об'єкт ErrorViewModel з RequestId
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
