using JadooProject.DataAccess.Entites;

namespace JadooProject.DataAccess.Abstract
{
    public interface ITestimonailDal : IRepository<Testimonail>
    {
        int GetTestimonailCount();
        List<Testimonail> GetTestimonailsForDashboard();
    }
}
