using Microsoft.AspNetCore.Mvc;

namespace JadooProject.ViewComponents.Admin
{
    public class _AdminSideBarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
