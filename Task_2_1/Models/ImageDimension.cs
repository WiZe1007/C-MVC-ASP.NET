using System.ComponentModel.DataAnnotations; 

namespace Task_2_1.Models
{
    public class ImageDimension
    {
        [Key]  // Первинний ключ
        public int Id { get; set; }

        // Ширина зображення
        public string Width { get; set; } = string.Empty;

        // Висота зображення 
        public string Height { get; set; } = string.Empty;
    }
}
