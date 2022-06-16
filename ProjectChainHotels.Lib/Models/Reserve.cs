namespace ProjectChainHotels.Lib.Models
{
    public class Reserve
    {
        private string Id { get; set; }
        private string IdResponsible { get; set; }
        private string IdBedroom { get; set; }
        private string EntryDate { get; set; }
        private string DepartureDate { get; set; }
        private DateTime RegistrationDate { get; set; }
        private DateTime LastUpdateDate { get; set; }

        public Reserve(string id, string idResponsible, string idBedroom, string entryDate, string departureDate, DateTime registrationDate, DateTime lastUpdateDate)
        {
            SetId(id);
            SetIdResponsible(idResponsible);
            SetIdBedroom(idBedroom);
            SetEntryDate(entryDate);
            SetDepartureDate(departureDate);
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
        public void SetEntryDate(string entryDate)
        {
            EntryDate = entryDate;
        }
        public string GetEntryDate()
        {
            return EntryDate;
        }
        public void SetDepartureDate(string departureDate)
        {
            DepartureDate = departureDate;
        }
        public string GetDepartureDate()
        {
            return DepartureDate;
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