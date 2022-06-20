namespace ProjectChainHotels.Web.DTOs
{
    public class ServiceXHotelDTO : ModelBaseDTO
    {
        private string Id { get; set; }
        private string IdHotel { get; set; }
        private string IdReserve { get; set; }

        public ServiceXHotelDTO(string id, DateTime registrationDate, DateTime lastUpdateDate) : base(id, registrationDate, lastUpdateDate)
        {
 
        }
    }
}