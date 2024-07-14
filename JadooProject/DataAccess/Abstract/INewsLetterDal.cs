using JadooProject.DataAccess.Entites;

namespace JadooProject.DataAccess.Abstract
{
    public interface INewsLetterDal : IRepository<NewsLetter>
    {
        int GetNewsLetterCount();
    }
}
