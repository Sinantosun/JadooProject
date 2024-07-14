using JadooProject.DataAccess.Entites;

namespace JadooProject.DataAccess.Abstract
{
    public interface IBrandDal : IRepository<Brand>
    {
        int GetBrandCount();
    }
}
