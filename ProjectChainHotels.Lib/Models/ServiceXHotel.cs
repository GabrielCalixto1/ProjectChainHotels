namespace ProjectChainHotels.Lib.Models
{
    public class ServiceXHotel : ModelBase
    {
        public virtual string IdHotel { get; set; }
        public virtual string IdReserve { get; set; }
        public virtual Hotel Hotel { get; set; }
        public virtual Service Services { get; set; }
        public ServiceXHotel(string id, DateTime dataCriacao, DateTime ultimaVez, string idReserve, string idHotel) : base(id, dataCriacao, ultimaVez)
        {
            SetIdReserve(idReserve);
            SetIdHotel(idHotel);
        }
        public ServiceXHotel()
        {
            
        }

        public void SetIdReserve(string idReserve)
        {
            IdReserve = idReserve;
        }

        public string GetIdReserve()
        {
            return IdReserve;
        }

        public void SetIdHotel(string idHotel)
        {
            IdHotel = idHotel;
        }

        public string GetIdHotel()
        {
            return IdHotel;
        }
    }
}