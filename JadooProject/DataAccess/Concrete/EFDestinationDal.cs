using JadooProject.DataAccess.Abstract;
using JadooProject.DataAccess.Context;
using JadooProject.DataAccess.Entites;
using JadooProject.DataAccess.Repositories;

namespace JadooProject.DataAccess.Concrete
{
    public class EFDestinationDal : Repository<Destination>, IDestinationDal
    {
        public EFDestinationDal(JadooContext context) : base(context)
        {
        }

        public int getDestinationCount()
        {
            var context = new JadooContext();
            return context.Destinations.Count();
        }
    }
}
