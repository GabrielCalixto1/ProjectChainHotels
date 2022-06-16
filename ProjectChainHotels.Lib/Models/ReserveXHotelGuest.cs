namespace ProjectChainHotels.Lib.Models
{
    public class ReserveXHotelGuest
    {
        public string Id { get; set; }
        public string IdReserve { get; set; }
        public string IdHotelGuest { get; set; }
        public DateTime RegistrationDate { get; set; }
        public DateTime LastUptdateDate { get; set; }
    }
}