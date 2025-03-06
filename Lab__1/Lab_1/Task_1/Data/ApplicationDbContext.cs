using Microsoft.EntityFrameworkCore;
using Task_1.Models; // Модель ParagraphStyle

namespace Task_1.Data
{
    // Контекст БД для Task_1
    public class ApplicationDbContext : DbContext
    {
        // Конструктор який приймає опції контексту
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Власт для доступу до табл ParagraphStyles (розміри та відступи)
        public DbSet<ParagraphStyle> ParagraphStyles { get; set; }
    }
}
