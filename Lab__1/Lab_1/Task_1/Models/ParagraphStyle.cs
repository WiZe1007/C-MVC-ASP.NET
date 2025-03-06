using System.ComponentModel.DataAnnotations;

namespace Task_1.Models
{
    public class ParagraphStyle
    {
        [Key]
        public int Id { get; set; }

        // Розмір шрифту
        public string FontSize { get; set; } = string.Empty;

        // Відступи ззовні
        public string Margin { get; set; } = string.Empty;

        // Відступи зсередини
        public string Padding { get; set; } = string.Empty;
    }
}
