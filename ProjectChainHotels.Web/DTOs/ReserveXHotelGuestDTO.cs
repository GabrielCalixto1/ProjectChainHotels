namespace ProjectChainHotels.Web.DTOs
{
    public class ReserveXHotelGuest : ModelBase
    {
        private string IdReserve { get; set; }
        private string IdHotelGuest { get; set; }

        public ReserveXHotelGuest(string id, DateTime registrationDate, DateTime lastUpdateDate) : base(id, registrationDate, lastUpdateDate)
        {
    
        }

    }

}
