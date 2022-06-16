namespace ProjectChainHotels.Lib.Models
{
    public class ReserveXHotelGuest
    {
        private string Id { get; set; }
        private string IdReserve { get; set; }
        private string IdHotelGuest { get; set; }
        private DateTime RegistrationDate { get; set; }
        private DateTime LastUpdateDate { get; set; }

        public ReserveXHotelGuest(string id, string idReserve, string idHotelGuest, DateTime registrationDate, DateTime lastUpdateDate)
        {
            SetId(id);
            SetIdReserve(idReserve);
            SetIdHotelGuest(idHotelGuest);
            SetRegistrationDate(registrationDate);
            SetLastUpdateDate(lastUpdateDate);
        }

          public void SetId(string id)
        {
            Id = id;
        }
        public string GetId()
        {
            return Id;
        }

        public void SetIdReserve(string idReserve)
        {
            IdReserve = idReserve;
        }
        public string GetIdReserve()
        {
            return IdReserve;
        }
        public void SetIdHotelGuest(string idHotelGuest)
        {
            IdHotelGuest = idHotelGuest;
        }
        public string GetIdHotelGuest()
        {
            return IdHotelGuest;
        }
        public void SetRegistrationDate(DateTime registrationDate)
        {
            RegistrationDate = registrationDate;
        }
        public DateTime GetRegistrationDate()
        {
            return RegistrationDate;
        }
        public void SetLastUpdateDate(DateTime lastUpdateDate)
        {
            LastUpdateDate = lastUpdateDate;
        }
        public DateTime GetLastUpdateDate()
        {
            return LastUpdateDate;
        }

    }
}