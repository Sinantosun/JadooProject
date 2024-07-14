using JadooProject.DataAccess.Abstract;
using JadooProject.DataAccess.Context;
using JadooProject.DataAccess.Entites;
using JadooProject.DataAccess.Repositories;

namespace JadooProject.DataAccess.Concrete
{
    public class EFBrandDal : Repository<Brand>, IBrandDal
    {
        public EFBrandDal(JadooContext context) : base(context)
        {
        }

        public int GetBrandCount()
        {
            var context = new JadooContext();
            return context.Brands.Count();
        }
    }
}
