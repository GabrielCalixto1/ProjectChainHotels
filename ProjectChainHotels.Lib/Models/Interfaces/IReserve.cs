namespace ProjectChainHotels.Lib.Interfaces
{
    public interface IReserve
    {
        bool DepartureDateIsGreaterThanEntryDate(DateTime departureDate);
    }
}