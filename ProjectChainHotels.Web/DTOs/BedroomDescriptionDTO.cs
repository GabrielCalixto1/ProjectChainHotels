namespace ProjectChainHotels.Web.DTOs
{
    public class BedroomDescriptionDTO : ModelBaseDTO
    {

        private string Name { get; set; }
        private string Review { get; set; }
        private int MaximumCapacity { get; set; }
        private int SingleBedQuantity { get; set; }
        private int DoubleBedQuantity { get; set; }
        private double Price { get; set; }

        public BedroomDescriptionDTO(string id, DateTime registrationDate, DateTime lastUpdateDate) : base(id, registrationDate, lastUpdateDate)
        {
  
        }
    }
}