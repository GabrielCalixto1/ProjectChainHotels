namespace ProjectChainHotels.Web.DTOs
{
    public class ModelBase
    {
        private string Id { get; set; }
        private DateTime RegistrationDate;
        private DateTime LastUptdateDate;
        public ModelBase(string id, DateTime registrationDate, DateTime lastUptdateDate)
        {
            Id = id;
            RegistrationDate = registrationDate;
            LastUptdateDate = lastUptdateDate;
        }

    }
}