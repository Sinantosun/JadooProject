using Microsoft.AspNetCore.Http;

namespace JadooProject.Models
{
    public static class ImageViewModel
    {
        public static string CreateImage(IFormFile file)
        {
            var fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);   
            var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Images/",fileName);
            var stream = new FileStream(location, FileMode.Create);
            file.CopyTo(stream);
            return "/Images/" + fileName;
        }
    }
}
