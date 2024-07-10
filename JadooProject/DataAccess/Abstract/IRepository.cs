namespace JadooProject.DataAccess.Abstract
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);

        void Update(T entity);
        void Delete(int id);
        List<T> GetList();
        T GetById(int id);
    }
}
