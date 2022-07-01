using ProjectChainHotels.Lib.Models;

namespace ProjectChainHotels.Lib.Data.Repositories.Interfaces
{
     public interface IRepositoryBase<T> where T : ModelBase
    {
        List<T> GetAlls();
        T ShowByID(string id);
        void AddByItem(T item);
        void DeleteById(string id);
        
    }
}