using Microsoft.AspNetCore.Mvc;

namespace JadooProject.ViewComponents.Admin
{
    public class _AdminFooterComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
