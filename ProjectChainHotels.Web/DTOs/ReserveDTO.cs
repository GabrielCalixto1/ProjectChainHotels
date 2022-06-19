namespace ProjectChainHotels.Web.DTOs
{
    public class Reserve : ModelBase
    {
        private string IdResponsible { get; set; }
        private string IdBedroom { get; set; }
        private DateTime EntryDate { get; set; }
        private DateTime DepartureDate { get; set; }
        private BedroomDescription BedroomDescription { get; set; }

        public Reserve(string id, DateTime registrationDate, DateTime lastUpdateDate) : base(id, registrationDate, lastUpdateDate)
        {
    
        }

    }
}