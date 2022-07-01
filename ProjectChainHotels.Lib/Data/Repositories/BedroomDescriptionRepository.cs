using ProjectChainHotels.Lib.Models;

namespace ProjectChainHotels.Lib.Data.Repositories
{
    public class BedroomDescriptionRepository : RepositoryBase<Bedroom>
    {
        private readonly ChainHotelsContext _context;
        public BedroomDescriptionRepository(ChainHotelsContext context) : base(context.BedroomsDb, context)
        {
            _context = context;
        }
    }
}