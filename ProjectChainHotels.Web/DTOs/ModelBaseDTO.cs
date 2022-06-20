namespace ProjectChainHotels.Web.DTOs
{
    public class ModelBaseDTO
    {
        private string Id { get; set; }
        private DateTime RegistrationDate;
        private DateTime LastUptdateDate;
        public ModelBaseDTO(string id, DateTime registrationDate, DateTime lastUptdateDate)
        {
            Id = id;
            RegistrationDate = registrationDate;
            LastUptdateDate = lastUptdateDate;
        }

    }
}