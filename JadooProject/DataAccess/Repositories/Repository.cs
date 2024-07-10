using JadooProject.DataAccess.Abstract;
using JadooProject.DataAccess.Context;

namespace JadooProject.DataAccess.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly JadooContext _context;

        public Repository(JadooContext context)
        {
            _context = context;
        }

        public void Add(T entity)
        {
            _context.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var value = GetById(id);
            _context.Remove(value); 
            _context.SaveChanges();
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public List<T> GetList()
        {
            return _context.Set<T>().ToList();
        }

        public void Update(T entity)
        {
            _context.Update(entity);    
            _context.SaveChanges();
        }
    }

}
