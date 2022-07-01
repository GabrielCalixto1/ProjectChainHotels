using ProjectChainHotels.Lib.Data.Repositories.Interfaces;
using ProjectChainHotels.Lib.Models;
using Microsoft.EntityFrameworkCore;

namespace ProjectChainHotels.Lib.Data
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : ModelBase
    {

        private readonly ChainHotelsContext _context;
        private readonly DbSet<T> _dbset;

        public RepositoryBase(DbSet<T> dbset, ChainHotelsContext context)
        {
            _context = context;
            _dbset = dbset;
        }

        public List<T> GetAlls()
        {
            return (_dbset.AsNoTracking().ToList());
        }

        public T ShowByID(string id)
        {
            return (_dbset.AsNoTracking().First(x => x.GetId() == id));
        }
        public void AddByItem(T item)
        {
            _dbset.Add(item);
            _context.SaveChanges();

        }
        public void DeleteById(string id)
        {
            var item = _dbset.Find(id);
            _context.Remove(item);
            _context.SaveChanges();

        }
    
    }
}