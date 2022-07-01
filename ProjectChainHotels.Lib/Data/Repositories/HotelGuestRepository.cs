using ProjectChainHotels.Lib.Models;

namespace ProjectChainHotels.Lib.Data.Repositories
{
    public class HotelGuestRepository : RepositoryBase<HotelGuest>
    {
        private readonly ChainHotelsContext _context;
        public HotelGuestRepository(ChainHotelsContext context) : base(context.HotelGuestsDb, context)
        {
            _context = context;
        }
    }
}