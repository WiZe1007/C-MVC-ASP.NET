using Microsoft.EntityFrameworkCore;
using Task_2_1.Models;  

namespace Task_2_1.Data
{
    // Контекст БД для Task_2_1
    public class ApplicationDbContext : DbContext
    {
        // Конст отримує опції через DI і --> їх у базовий констр
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Властивість для роботи з табл ImageDimensions у БД
        public DbSet<ImageDimension> ImageDimensions { get; set; }
    }
}
