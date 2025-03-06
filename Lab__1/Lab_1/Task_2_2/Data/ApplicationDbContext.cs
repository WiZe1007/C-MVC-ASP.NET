using Microsoft.EntityFrameworkCore;  
using Task_2_2.Models;              

namespace Task_2_2.Data
{
    // Контекст БД для Task_2_2
    public class ApplicationDbContext : DbContext
    {
        // Констр який приймає опції БД через DI
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // DbSet для таблиці ImageDimensions
        // Таблиця зберігає розміри зображень (Width, Height)
        public DbSet<ImageDimension> ImageDimensions { get; set; }
    }
}
