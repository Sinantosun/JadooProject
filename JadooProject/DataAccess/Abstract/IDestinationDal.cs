using JadooProject.DataAccess.Entites;

namespace JadooProject.DataAccess.Abstract
{
    public interface IDestinationDal : IRepository<Destination>
    {
        int getDestinationCount();
        List<Destination> GetLast6Destination();
        List<Destination> GetLast3Destination();
        Destination GetLastDestination();
    }
}
