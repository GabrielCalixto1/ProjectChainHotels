namespace ProjectChainHotels.Web.DTOs
{
    public class ReserveXHotelGuestDTO : ModelBaseDTO
    {
        private string IdReserve { get; set; }
        private string IdHotelGuest { get; set; }

        public ReserveXHotelGuestDTO(string id, DateTime registrationDate, DateTime lastUpdateDate) : base(id, registrationDate, lastUpdateDate)
        {
    
        }

    }

}
