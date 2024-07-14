using JadooProject.DataAccess.Entites;

namespace JadooProject.DataAccess.Abstract
{
    public interface IDestinationDal : IRepository<Destination>
    {
        int getDestinationCount();
    }
}
