using Microsoft.AspNetCore.Http;

namespace JadooProject.Features.CQRS.Commands.BrandCommands
{
    public class CreateBrandCommand
    {

        public string ImageURL { get; set; }

        public IFormFile File { get; set; } 
    }
}
