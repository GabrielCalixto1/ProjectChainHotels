namespace ProjectChainHotels.Web.DTOs
{
    public class Bedroom : ModelBase
    {
        private string IdHotel;
        private string IdBedroomDescription;
        private string Number;
        private string FloorOfBedroom;

        public Bedroom(string id,DateTime registrationDate, DateTime lastUpdateDate) : base(id, registrationDate, lastUpdateDate)
        {
            
        }

    }

}