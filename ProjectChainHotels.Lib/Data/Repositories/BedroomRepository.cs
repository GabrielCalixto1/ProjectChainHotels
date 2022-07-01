using ProjectChainHotels.Lib.Models;

namespace ProjectChainHotels.Lib.Data.Repositories
{
    public class BedroomRepository : RepositoryBase<Bedroom>
    {
        private readonly ChainHotelsContext _context;
        public BedroomRepository(ChainHotelsContext context) : base(context.BedroomsDb, context)
        {
            _context = context;
        }
    }
}