using JadooProject.DataAccess.Abstract;
using JadooProject.DataAccess.Context;
using JadooProject.DataAccess.Entites;
using JadooProject.DataAccess.Repositories;

namespace JadooProject.DataAccess.Concrete
{
    public class EFTestimonailDal : Repository<Testimonail>, ITestimonailDal
    {

        public EFTestimonailDal(JadooContext context) : base(context)
        {
        }

        public int GetTestimonailCount()
        {
            var context = new JadooContext();
            return context.Testimonails.Count();
        }

        public List<Testimonail> GetTestimonailsForDashboard()
        {
            var context = new JadooContext();
            return context.Testimonails.Take(6).ToList();
        }
    }
}
