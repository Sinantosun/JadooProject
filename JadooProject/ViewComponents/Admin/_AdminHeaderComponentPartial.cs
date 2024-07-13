using Microsoft.AspNetCore.Mvc;

namespace JadooProject.ViewComponents.Admin
{
    public class _AdminHeaderComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
