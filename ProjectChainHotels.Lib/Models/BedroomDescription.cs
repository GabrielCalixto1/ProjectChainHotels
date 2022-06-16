namespace ProjectChainHotels.Lib.Models
{
    public class BedroomDescription
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Review { get; set; }
        public string MaximumCapacity { get; set; }
        public string SingleBedQuantity { get; set; }
        public string DoubleBedQuantity { get; set; }
        public double Price { get; set; }
        public DateTime RegistrationDate { get; set; }
        public DateTime LastUptdateDate { get; set; }
    }
}