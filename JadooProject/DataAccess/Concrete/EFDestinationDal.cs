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

        public List<Destination> GetLast3Destination()
        {
            var context = new JadooContext();
            return context.Destinations.OrderByDescending(x => x.DestinationId).Take(3).ToList();
        }

        public List<Destination> GetLast6Destination()
        {
            var context = new JadooContext();
            return context.Destinations.OrderByDescending(x=>x.DestinationId).Take(6).ToList();
        }

        public Destination GetLastDestination()
        {
            var context = new JadooContext();
            return context.Destinations.OrderByDescending(x => x.DestinationId).Take(1).FirstOrDefault();
        }
    }
}
