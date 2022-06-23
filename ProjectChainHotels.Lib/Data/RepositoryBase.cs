using ProjectChainHotels.Lib.Data.Repositories.Interfaces;
using ProjectChainHotels.Lib.Models;
using Microsoft.EntityFrameworkCore;

namespace ProjectChainHotels.Lib.Data
{
    public class RepositoryBase<T> where T : IRepositoryBase<T> where T : ModelBase
   
        private readonly ChainHotelsContext _context;
        private readonly DbSet<T> _dbset;

        public RepositoritoryBase(DbSet<T> dbset, ProjectChainHotels context)
        {
            _context = context;
            _dbset = dbset;
        }

        public List<T> GetAlls()
        {
            return (_dbset.AsNoTracking().ToList());
        }

        public T ShowByID(int id)
        {
            return (_dbset.AsNoTracking().First(x => x.Id == id));
        }
        public void AddByItem(T item)
        {
            _dbset.Add(item);
            _context.SaveChanges();

        }
        public void DeleteById(int id)
        {
            var item = _dbset.Find(id);
            _context.Remove(item);
            _context.SaveChanges();

        }
    }
}