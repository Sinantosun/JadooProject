using Microsoft.AspNetCore.Http;

namespace JadooProject.Features.CQRS.Commands.BrandCommands
{
    public class UpdateBrandCommand
    {
        public int BrandID { get; set; }
        public string ImageURL { get; set; }

        public IFormFile File { get; set; }
    }
}
