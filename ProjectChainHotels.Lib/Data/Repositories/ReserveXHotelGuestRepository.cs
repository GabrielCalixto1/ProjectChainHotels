using ProjectChainHotels.Lib.Models;

namespace ProjectChainHotels.Lib.Data.Repositories
{
    public class ReserveXHotelGuestRepository : RepositoryBase<ReserveXHotelGuest>
    {
        private readonly ChainHotelsContext _context;
        public ReserveXHotelGuestRepository(ChainHotelsContext context) : base(context.ReserveXHotelGuestsDb, context)
        {
            _context = context;
        }
    }
}