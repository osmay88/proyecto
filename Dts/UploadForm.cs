using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace proyecto.Dts
{
    public class UploadForm
    {
        [Required]
        [Display(Name = "File")]
        public IFormFile FormFile { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        public string Tags { get; set; }
    }
}