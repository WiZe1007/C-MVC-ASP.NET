using System.ComponentModel.DataAnnotations;

namespace Task_2_2.Models
{
    public class ImageDimension
    {
        [Key] 
        public int Id { get; set; }

        // Ширина зображення
        public string Width { get; set; } = string.Empty;

        // Висота зображення
        public string Height { get; set; } = string.Empty;
    }
}
