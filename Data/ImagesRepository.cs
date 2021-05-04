using System.Threading.Tasks;
using proyecto.Dts;
using proyecto.Models;

namespace proyecto.Data
{
    public class ImagesRepository
    {
        private readonly WebAppDbContext _context;

        public ImagesRepository(WebAppDbContext context)
        {
            this._context = context;
        }


        public async Task<ImageFile> addImage(string filename, string description, string title, string tags)
        {
            var imageFile = new ImageFile
            {
                Filename = filename,
                ImagePath = filename,
                Description = description,
                Tags = tags,
                Title = title

            };

            await this._context.ImageFiles.AddAsync(imageFile);
            await this._context.SaveChangesAsync();

            return imageFile;

        }
    }
}