namespace ProjectChainHotels.Lib.Models
{
    public class Bedroom : ModelBase
    {
        private string IdHotel;
        private string IdBedroomDescription;
        private string Number;
        private string FloorOfBedroom;

        public Bedroom(string id, string idHotel, string idBedroomDescription, string number, string floorOfBedroom, DateTime registrationDate, DateTime lastUpdateDate) : base(id, registrationDate, lastUpdateDate)
        {
            SetIdHotel(idHotel);
            SetIdBedroomDescription(idBedroomDescription);
            SetNumber(number);
            SetFloorOfBedroom(floorOfBedroom);
        }

        public void SetIdHotel(string idHotel)
        {
            IdHotel = idHotel;
        }
        public string GetIdHotel()
        {
            return IdHotel;
        }
        public void SetIdBedroomDescription(string idBedroomDescription)
        {
            IdBedroomDescription = idBedroomDescription;
        }
        public string GetIdBedroomDescription()
        {
            return IdBedroomDescription;
        }
        public void SetNumber(string number)
        {
            Number = number;
        }
        public string GetNumber()
        {
            return Number;
        }
        public void SetFloorOfBedroom(string floorOfBedroom)
        {
            FloorOfBedroom = floorOfBedroom;
        }
        public string GetFloorOfBedroom()
        {
            return FloorOfBedroom;
        }

    }

}