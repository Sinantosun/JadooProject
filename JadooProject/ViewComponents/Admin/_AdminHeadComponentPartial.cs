using Microsoft.AspNetCore.Mvc;

namespace JadooProject.ViewComponents.Admin
{
    public class _AdminHeadComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
