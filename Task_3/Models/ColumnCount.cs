using System.ComponentModel.DataAnnotations; 

namespace Task_3.Models
{
    // Модель для зберігання кількості стовпчиків у таблиці
    public class ColumnCount
    {
        [Key]  
        public int Id { get; set; }

        // Зберігання кількості стовпчиків
        public int Columns { get; set; }
    }
}
