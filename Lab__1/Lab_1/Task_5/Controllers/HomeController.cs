using Microsoft.AspNetCore.Mvc;
using System.Diagnostics; 
using Task_5.Models;      

namespace Task_5.Controllers
{
    public class HomeController : Controller
    {
        // Логгер для запису інформ
        private readonly ILogger<HomeController> _logger;

        // Констр який отримує логгер через DI
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // GET: Home/Index
        // Повертаємо головну сторінку
        public IActionResult Index()
        {
            return View();
        }

        // GET: Home/Privacy
        public IActionResult Privacy()
        {
            return View();
        }

        // GET: Home/Error
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel
            {
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            });
        }
    }
}
