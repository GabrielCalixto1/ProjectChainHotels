namespace ProjectChainHotels.Lib.Models
{
    public class Bedroom
    {
        private string Id;
        private string IdHotel;
        private string IdBedroomDescription;
        private string Number;
        private string FloorOfBedroom;
        private DateTime RegistrationDate;
        private DateTime LastUptdateDate;

        public Bedroom(string id, string idHotel, string idBedroomDescription, string number, string floorOfBedroom, DateTime registrationDate, DateTime lastUptdateDate)
        {
            SetId(id);
            SetIdHotel(idHotel);
            SetIdBedroomDescription(idBedroomDescription);
            SetNumber(number);
            SetFloorOfBedroom(floorOfBedroom);
            SetRegistrationDate(registrationDate);
            SetLastUptdateDate(lastUptdateDate);
        }
        public void SetId(string id)
        {
            id = id;
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
        public void SetIdBedroomDescription(string IdBedroomDescription)
        {
            IdBedroomDescription = IdBedroomDescription;
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
        public void SetFloorOfBedroom(string FloorOfBedroom)
        {
            FloorOfBedroom = FloorOfBedroom;
        }
        public string GetFloorOfBedroom()
        {
            return FloorOfBedroom;
        }
        public void SetRegistrationDate(DateTime restrationDate)
        {
            RegistrationDate = restrationDate;
        }
        public DateTime GetRegistrationDate()
        {
            return RegistrationDate;
        }

        public void SetLastUptdateDate(DateTime lastUpdateDate)
        {
            LastUptdateDate = lastUpdateDate;
        }
        public DateTime GetLastUptdateDate()
        {
            return LastUptdateDate;
        }

    }

}