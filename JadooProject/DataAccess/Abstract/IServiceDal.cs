using JadooProject.DataAccess.Entites;

namespace JadooProject.DataAccess.Abstract
{
    public interface IServiceDal : IRepository<Service>
    {
        int getServiceCount();
    }
}
