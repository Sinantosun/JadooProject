using JadooProject.DataAccess.Abstract;
using JadooProject.DataAccess.Context;
using JadooProject.DataAccess.Entites;
using JadooProject.DataAccess.Repositories;

namespace JadooProject.DataAccess.Concrete
{
    public class EFFeatureDal : Repository<Feature>, IFeatureDal
    {
        public EFFeatureDal(JadooContext context) : base(context)
        {
        }

        public int GetFeatureCount()
        {
            var context = new JadooContext();
            return context.Features.Count();
        }
    }
}
