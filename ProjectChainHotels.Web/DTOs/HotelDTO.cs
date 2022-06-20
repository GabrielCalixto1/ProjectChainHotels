namespace ProjectChainHotels.Web.DTOs
{
    public class HotelDTO : ModelBaseDTO
    {
        private string Name { get; set; }
        private string Address { get; set; }
        private string ZipCode { get; set; }
        private string Review { get; set; }
        private string Tellphone { get; set; }
        private string Email { get; set; }
        private DateTime CheckInTime { get; set; }
        private DateTime CheckOutTime { get; set; }
        public HotelDTO(string id, DateTime registrationDate, DateTime lastUpdateDate) : base(id, registrationDate, lastUpdateDate)
        {
 
        }
    }
}