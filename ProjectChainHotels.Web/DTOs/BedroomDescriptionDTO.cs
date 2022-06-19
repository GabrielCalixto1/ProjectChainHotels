namespace ProjectChainHotels.Web.DTOs
{
    public class BedroomDescription : ModelBase
    {

        private string Name { get; set; }
        private string Review { get; set; }
        private int MaximumCapacity { get; set; }
        private int SingleBedQuantity { get; set; }
        private int DoubleBedQuantity { get; set; }
        private double Price { get; set; }

        public BedroomDescription(string id, DateTime registrationDate, DateTime lastUpdateDate) : base(id, registrationDate, lastUpdateDate)
        {
  
        }
    }
}