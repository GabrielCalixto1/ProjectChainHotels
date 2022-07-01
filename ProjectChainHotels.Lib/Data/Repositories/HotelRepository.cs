using ProjectChainHotels.Lib.Models;

namespace ProjectChainHotels.Lib.Data.Repositories
{
    public class HotelRepository : RepositoryBase<Hotel>
    {
        private readonly ChainHotelsContext _context;
        public HotelRepository(ChainHotelsContext context) : base(context.HotelsDb, context)
        {
            _context = context;
        }
    }
}