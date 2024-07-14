using JadooProject.DataAccess.Abstract;
using JadooProject.DataAccess.Context;
using JadooProject.DataAccess.Entites;
using JadooProject.DataAccess.Repositories;

namespace JadooProject.DataAccess.Concrete
{
    public class EFNewsLetterDal : Repository<NewsLetter>, INewsLetterDal
    {

        public EFNewsLetterDal(JadooContext context) : base(context)
        {
        }

        public int GetNewsLetterCount()
        {
            var context = new JadooContext();
            return context.NewsLetters.Count();
        }
    }
}
