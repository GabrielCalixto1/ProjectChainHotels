namespace ProjectChainHotels.Lib.Models
{
    public class ServiceXHotel : ModelBase
    {
        private string Id { get; set; }
        private string IdHotel { get; set; }
        private string IdReserve { get; set; }
        private DateTime RegistrationDate { get; set; }
        private DateTime LastUpdateDate { get; set; }

        public ServiceXHotel(string id, string idHotel, string idReserve, DateTime registrationDate, DateTime lastUpdateDate) : base(id, registrationDate, lastUpdateDate)
        {
            SetId(id);
            SetIdHotel(idHotel);
            SetIdReserve(idReserve);
        }

        public void SetId(string id)
        {
            Id = id;
        }
        public string GetId()
        {
            return Id;
        }
        public void SetIdHotel(string idHotel)
        {
            IdHotel = idHotel;
        }
        public string GetIdHotel()
        {
            return IdHotel;
        }
        public void SetIdReserve(string idReserve)
        {
            IdReserve = idReserve;
        }
        public string GetIdReserve()
        {
            return IdReserve;
        }
        public void SetRegistrationDate(DateTime registrationDate)
        {
            RegistrationDate = registrationDate;
        }
        public DateTime GetRegistrationDate()
        {
            return RegistrationDate;
        }
    }
}