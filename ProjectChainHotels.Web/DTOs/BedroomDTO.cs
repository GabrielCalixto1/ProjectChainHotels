namespace ProjectChainHotels.Web.DTOs
{
    public class BedroomDTO : ModelBaseDTO
    {
        private string IdHotel;
        private string IdBedroomDescription;
        private string Number;
        private string FloorOfBedroom;

        public BedroomDTO(string id,DateTime registrationDate, DateTime lastUpdateDate) : base(id, registrationDate, lastUpdateDate)
        {
            
        }

    }

}