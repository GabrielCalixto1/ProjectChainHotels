using ProjectChainHotels.Lib.Models;

namespace ProjectChainHotels.Lib.Data.Repositories.Interfaces
{
     public interface IRepositoryBase<T> where T : ModelBase
    {
        List<T> GetTodos();
        T MostrarPorId(int id);
        void AdicionarItem(T item);
        void DeletarPorId(int id);
        
    }
}