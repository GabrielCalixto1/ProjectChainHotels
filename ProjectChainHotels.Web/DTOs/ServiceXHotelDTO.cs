namespace ProjectChainHotels.Web.DTOs
{
    public class ServiceXHotel : ModelBase
    {
        private string Id { get; set; }
        private string IdHotel { get; set; }
        private string IdReserve { get; set; }

        public ServiceXHotel(string id, DateTime registrationDate, DateTime lastUpdateDate) : base(id, registrationDate, lastUpdateDate)
        {
 
        }
    }
}