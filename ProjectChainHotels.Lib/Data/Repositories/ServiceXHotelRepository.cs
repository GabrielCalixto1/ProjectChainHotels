using ProjectChainHotels.Lib.Models;

namespace ProjectChainHotels.Lib.Data.Repositories
{
    public class ServiceXHotelRepository : RepositoryBase<ServiceXHotel>
    {
        private readonly ChainHotelsContext _context;
        public ServiceXHotelRepository(ChainHotelsContext context) : base(context.ServiceXHotelsDb, context)
        {
            _context = context;
        }
    }
}