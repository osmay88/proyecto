using System.ComponentModel.DataAnnotations;

namespace proyecto.Models
{
    public class ImageFile
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Filename { get; set; }
        public string ImagePath { get; set; }
        public string Description { get; set; }
        public string Tags { get; set; }
    }
}