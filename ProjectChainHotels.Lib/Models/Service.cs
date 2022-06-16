namespace ProjectChainHotels.Lib.Models
{
    public class Service
    {
        private string Id { get; set; }
        private DateTime RegistrationDate { get; set; }
        private DateTime LastUptdateDate { get; set; }

        public Service(string id, DateTime registrationDate, DateTime lastUptdateDate)
        {
            SetId(id);
            SetRegistrationDate(registrationDate);
            SetLastUptdateDate(lastUptdateDate);
        }

        public void SetId(string id)
        {
            Id = id;
        }
        public string GetId()
        {
            return Id;
        }
        public void SetRegistrationDate(DateTime registrationDate)
        {
            RegistrationDate = registrationDate;
        }
        public DateTime GetRegistrationDate()
        {
            return RegistrationDate;
        }
        public void SetLastUptdateDate(DateTime lastUptdateDate)
        {
            LastUptdateDate = lastUptdateDate;
        }
        public DateTime GetLastUptdateDate()
        {
            return LastUptdateDate;
        }
    }
}