namespace ProjectChainHotels.Lib.Models
{
    public class ReserveXHotelGuest : ModelBase
    {
        private string IdReserve { get; set; }
        private string IdHotelGuest { get; set; }

        public ReserveXHotelGuest(string id, string idReserve, string idHotelGuest, DateTime registrationDate, DateTime lastUpdateDate) : base(id, registrationDate, lastUpdateDate)
        {
            SetIdReserve(idReserve);
            SetIdHotelGuest(idHotelGuest);
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

    }

}
