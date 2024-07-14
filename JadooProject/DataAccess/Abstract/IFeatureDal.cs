using JadooProject.DataAccess.Entites;

namespace JadooProject.DataAccess.Abstract
{
    public interface IFeatureDal : IRepository<Feature>
    {
        int GetFeatureCount();
    }
}
