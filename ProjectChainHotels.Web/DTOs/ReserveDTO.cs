namespace ProjectChainHotels.Web.DTOs
{
    public class ReserveDTO : ModelBaseDTO
    {
        private string IdResponsible { get; set; }
        private string IdBedroom { get; set; }
        private DateTime EntryDate { get; set; }
        private DateTime DepartureDate { get; set; }
        private BedroomDescriptionDTO BedroomDescription { get; set; }

        public ReserveDTO(string id, DateTime registrationDate, DateTime lastUpdateDate) : base(id, registrationDate, lastUpdateDate)
        {
    
        }

    }
}