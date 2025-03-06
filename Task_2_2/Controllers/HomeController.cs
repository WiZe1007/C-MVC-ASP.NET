using Microsoft.AspNetCore.Mvc;
using Task_2_2.Data;     
using Task_2_2.Models; 

namespace Task_2_2.Controllers
{
    public class HomeController : Controller
    {
        // Змінна для роботи з БД через EF Core
        private readonly ApplicationDbContext _context;

        // Конструктор що отримує контекст через dependency injection
        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: /Home/Index
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        // POST: /Home/IndexPost
        [HttpPost]
        public IActionResult IndexPost()
        {
            // Зчитуємо URL зображень з форми (нетипізовано)
            string image1Url = Request.Form["image1Url"];
            string image2Url = Request.Form["image2Url"];
            string image3Url = Request.Form["image3Url"];

            // Отримуємо дані розмірів з БД для зображень з Id 1, 2 та 3
            var dim1 = _context.ImageDimensions.Find(1);
            var dim2 = _context.ImageDimensions.Find(2);
            var dim3 = _context.ImageDimensions.Find(3);

            // Передаємо URL зображень у ViewBag
            ViewBag.Image1Url = image1Url;
            ViewBag.Image2Url = image2Url;
            ViewBag.Image3Url = image3Url;

            // Передаємо розміри зображень у ViewBag
            ViewBag.Image1Width = dim1?.Width ?? "60px";
            ViewBag.Image1Height = dim1?.Height ?? "120px";

            ViewBag.Image2Width = dim2?.Width ?? "300px";
            ViewBag.Image2Height = dim2?.Height ?? "100px";

            ViewBag.Image3Width = dim3?.Width ?? "150px";
            ViewBag.Image3Height = dim3?.Height ?? "50px";

            // Перенаправляємо дані до подання Display
            return View("Display");
        }

        // Метод для відображення подання Display
        public IActionResult Display()
        {
            return View();
        }
    }
}
