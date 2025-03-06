using Microsoft.AspNetCore.Mvc;
using Task_3.Data;      
using Task_3.Models;   
using System.Text;     

namespace Task_3.Controllers
{
    public class HomeController : Controller
    {
        // Контекст БД, отриманий через dependency injection
        private readonly ApplicationDbContext _context;

        // Конструктор отримує контекст і зберігає його в приватній змінній
        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Home/Index
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        // POST: Home/IndexPost
        // Метод для обробки даних введених у формі
        [HttpPost]
        public IActionResult IndexPost()
        {
            // 1. Зчитуємо кількість рядків із форми
            string rowStr = Request.Form["rowCount"];
            int rowCount = 0;
            int.TryParse(rowStr, out rowCount);

            // 2. Отримуємо кіл стовпчиків з БД (запис з Id=1)
            ColumnCount colData = _context.ColumnCounts.Find(1);
            int colCount = colData?.Columns ?? 5;  // Якщо немає даних, встановлюємо 5 стовпчиків за замовчуванням

            // 3. Генер HTML-код шахової таблиці без Razor-циклів
            StringBuilder sb = new StringBuilder();
            sb.Append("<table style='border-collapse: collapse;'>");

            // Нумерація комірок
            int cellNumber = 1;

            // Проходимо по кожному рядку
            for (int r = 0; r < rowCount; r++)
            {
                sb.Append("<tr>");
                // Для кожного рядка проходимо по стовпчиках
                for (int c = 0; c < colCount; c++)
                {
                    // Визначаємо колір комірки (парне - біла; непарне - сіре)
                    string bgColor = ((r + c) % 2 == 0) ? "#ffffff" : "#cccccc";

                    // HTML для комірки із заданими стилями і нумерацією
                    sb.Append($"<td style='width:50px; height:50px; border:1px solid #000; background-color:{bgColor}; text-align:center;'>");
                    sb.Append(cellNumber);
                    sb.Append("</td>");
                    cellNumber++;
                }
                sb.Append("</tr>");
            }
            sb.Append("</table>");

            // Передаємо згенерований HTML-код таблиці у ViewBag 
            ViewBag.TableHtml = sb.ToString();
            // Передаємо кількість рядків та стовпчиків
            ViewBag.Rows = rowCount;
            ViewBag.Cols = colCount;

            // Повертаємо подання Display
            return View("Display");
        }

        // Метод для відображення подання з табл
        public IActionResult Display()
        {
            return View();
        }
    }
}
