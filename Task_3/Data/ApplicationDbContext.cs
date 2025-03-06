using Microsoft.EntityFrameworkCore;
using Task_3.Models; 

namespace Task_3.Data
{
    // Контекст БД для Task_3
    public class ApplicationDbContext : DbContext
    {
        // Конструктор який приймає опції через DI та передає їх у базовий клас
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // DbSet для зберігання кількості стовпчиків (табл ColumnCounts)
        public DbSet<ColumnCount> ColumnCounts { get; set; }
    }
}
