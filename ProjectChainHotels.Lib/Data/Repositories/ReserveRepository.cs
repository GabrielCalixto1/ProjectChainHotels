using ProjectChainHotels.Lib.Models;

namespace ProjectChainHotels.Lib.Data.Repositories
{
    public class ReserveRepository : RepositoryBase<Reserve>
    {
        private readonly ChainHotelsContext _context;
        public ReserveRepository(ChainHotelsContext context) : base(context.ReservesDb, context)
        {
            _context = context;
        }
    }
}