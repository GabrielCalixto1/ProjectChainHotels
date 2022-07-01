using ProjectChainHotels.Lib.Models;

namespace ProjectChainHotels.Lib.Data.Repositories
{
    public class ServiceRepository : RepositoryBase<Service>
    {
        private readonly ChainHotelsContext _context;
        public ServiceRepository(ChainHotelsContext context) : base(context.ServicesDb, context)
        {
            _context = context;
        }
    }
}