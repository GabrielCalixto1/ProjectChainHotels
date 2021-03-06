using ProjectChainHotels.Lib.Exceptions;

namespace ProjectChainHotels.Lib.Models
{
    public class Reserve : ModelBase
    {
        private string IdResponsible { get; set; }
        private string IdBedroom { get; set; }
        private DateTime EntryDate { get; set; }
        private DateTime DepartureDate { get; set; }
        private BedroomDescription BedroomDescription { get; set; }

        public Reserve(string id, string idResponsible, string idBedroom, DateTime entryDate, DateTime departureDate, DateTime registrationDate, DateTime lastUpdateDate) : base(id, registrationDate, lastUpdateDate)
        {
            SetIdResponsible(idResponsible);
            SetIdBedroom(idBedroom);
            SetEntryDate(entryDate);
            SetDepartureDate(departureDate);
        }

        public void SetIdResponsible(string idResponsible)
        {
            IdResponsible = idResponsible;
        }
        public string GetIdResponsible()
        {
            return IdResponsible;
        }
        public void SetIdBedroom(string idBedroom)
        {
            IdBedroom = idBedroom;
        }
        public string GetIdBedroom()
        {
            return IdBedroom;
        }
        public void SetEntryDate(DateTime entryDate)
        {
            EntryDate = entryDate;
        }
        public DateTime GetEntryDate()
        {
            return EntryDate;
        }
        public void SetDepartureDate(DateTime departureDate)
        {
            DepartureDateIsGreaterThanEntryDate(departureDate);
            DepartureDate = departureDate;
        }
        public DateTime GetDepartureDate()
        {
            return DepartureDate;
        }
        public bool DepartureDateIsGreaterThanEntryDate(DateTime departureDate)
        {
            if (GetEntryDate() <= departureDate)
            {
                return true;
            }
            throw new ValidationErrorException("Departure date must be greater than entry date!!");
        }

    }
}