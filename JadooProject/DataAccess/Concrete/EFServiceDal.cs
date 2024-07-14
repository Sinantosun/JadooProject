using JadooProject.DataAccess.Abstract;
using JadooProject.DataAccess.Context;
using JadooProject.DataAccess.Entites;
using JadooProject.DataAccess.Repositories;

namespace JadooProject.DataAccess.Concrete
{
    public class EFServiceDal : Repository<Service>, IServiceDal
    {
        public EFServiceDal(JadooContext context) : base(context)
        {
        }

        public int getServiceCount()
        {
            var context = new JadooContext();
            return context.Services.Count();
        }
    }
}
