using Microsoft.AspNetCore.Mvc;
using Task_1.Data;       // Контекст БД
using Task_1.Models;     // Модель ParagraphStyle

namespace Task_1.Controllers
{
    public class HomeController : Controller
    {
        // Контекст БД для роботи з табл ParagraphStyles
        private readonly ApplicationDbContext _context;

        // Констр отримує контекст через dependency injection
        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Home/Index
        [HttpGet]
        public IActionResult Index()
        {
            // Повертаємо форму для введення даних (нетипізована форма)
            return View();
        }

        // POST: Home/IndexPost
        [HttpPost]
        public IActionResult IndexPost()
        {
            // Зчитуємо дані з форми через Request.Form (нетипізовано)
            string paragraph1Text = Request.Form["paragraph1Text"];
            string paragraph1Color = Request.Form["paragraph1Color"];
            string paragraph1Align = Request.Form["paragraph1Align"];
            string paragraph1BackgroundColor = Request.Form["paragraph1BgColor"];
            string paragraph1BackgroundImage = Request.Form["paragraph1BgImage"];

            string paragraph2Text = Request.Form["paragraph2Text"];
            string paragraph2Color = Request.Form["paragraph2Color"];
            string paragraph2Align = Request.Form["paragraph2Align"];
            string paragraph2BackgroundColor = Request.Form["paragraph2BgColor"];
            string paragraph2BackgroundImage = Request.Form["paragraph2BgImage"];

            string paragraph3Text = Request.Form["paragraph3Text"];
            string paragraph3Color = Request.Form["paragraph3Color"];
            string paragraph3Align = Request.Form["paragraph3Align"];
            string paragraph3BackgroundColor = Request.Form["paragraph3BgColor"];
            string paragraph3BackgroundImage = Request.Form["paragraph3BgImage"];

            // Отримуємо з БД дані стилю для кожного абзацу
            ParagraphStyle style1 = _context.ParagraphStyles.Find(1);
            ParagraphStyle style2 = _context.ParagraphStyles.Find(2);
            ParagraphStyle style3 = _context.ParagraphStyles.Find(3);

            // Передаємо дані для 1 абзацу через ViewBag
            ViewBag.Paragraph1Text = paragraph1Text;
            ViewBag.Paragraph1Color = paragraph1Color;
            ViewBag.Paragraph1Align = paragraph1Align;
            ViewBag.Paragraph1BgColor = paragraph1BackgroundColor;
            ViewBag.Paragraph1BgImage = paragraph1BackgroundImage;
            // Явне приведення літералів до string
            ViewBag.Paragraph1FontSize = style1?.FontSize ?? (string)"16px";
            ViewBag.Paragraph1Margin = style1?.Margin ?? (string)"0px";
            ViewBag.Paragraph1Padding = style1?.Padding ?? (string)"0px";

            // Передаємо дані для 2 абзацу через ViewBag
            ViewBag.Paragraph2Text = paragraph2Text;
            ViewBag.Paragraph2Color = paragraph2Color;
            ViewBag.Paragraph2Align = paragraph2Align;
            ViewBag.Paragraph2BgColor = paragraph2BackgroundColor;
            ViewBag.Paragraph2BgImage = paragraph2BackgroundImage;
            ViewBag.Paragraph2FontSize = style2?.FontSize ?? (string)"16px";
            ViewBag.Paragraph2Margin = style2?.Margin ?? (string)"0px";
            ViewBag.Paragraph2Padding = style2?.Padding ?? (string)"0px";

            // Передаємо дані для 3 абзацу через ViewBag
            ViewBag.Paragraph3Text = paragraph3Text;
            ViewBag.Paragraph3Color = paragraph3Color;
            ViewBag.Paragraph3Align = paragraph3Align;
            ViewBag.Paragraph3BgColor = paragraph3BackgroundColor;
            ViewBag.Paragraph3BgImage = paragraph3BackgroundImage;
            ViewBag.Paragraph3FontSize = style3?.FontSize ?? (string)"16px";
            ViewBag.Paragraph3Margin = style3?.Margin ?? (string)"0px";
            ViewBag.Paragraph3Padding = style3?.Padding ?? (string)"0px";

            // Перенаправляємо дані до подання Display
            return View("Display");
        }

        // Дод екшн для відображення подання
        public IActionResult Display()
        {
            return View();
        }
    }
}
