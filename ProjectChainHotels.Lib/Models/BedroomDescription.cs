namespace ProjectChainHotels.Lib.Models
{
    public class BedroomDescription : ModelBase
    {

        private string Name { get; set; }
        private string Review { get; set; }
        private string MaximumCapacity { get; set; }
        private string SingleBedQuantity { get; set; }
        private string DoubleBedQuantity { get; set; }
        private double Price { get; set; }

        public BedroomDescription(string id, string name, string review, string maximumCapacity, string singleBedQuantity, string doubleBedQuantity, double price, DateTime registrationDate, DateTime lastUpdateDate) : base(id, registrationDate, lastUpdateDate)
        {
            SetName(name);
            SetReview(review);
            SetMaximumCapacity(maximumCapacity);
            SetSingleBedQuantity(singleBedQuantity);
            SetDoubleBedQuantity(doubleBedQuantity);
            SetPrice(price);
        }

        public void SetName(string name)
        {
            Name = name;
        }
        public string GetName()
        {
            return Name;
        }
        public void SetReview(string review)
        {
            Review = review;
        }
        public string GetReview()
        {
            return Review;
        }
        public void SetMaximumCapacity(string maximumCapacity)
        {
            MaximumCapacity = maximumCapacity;
        }
        public string GetMaximumCapacity()
        {
            return MaximumCapacity;
        }
        public void SetSingleBedQuantity(string singleBedQuantity)
        {
            SingleBedQuantity = singleBedQuantity;
        }
        public string GetSingleBedQuantity()
        {
            return SingleBedQuantity;
        }
        public void SetDoubleBedQuantity(string doubleBedQuantity)
        {
            DoubleBedQuantity = doubleBedQuantity;
        }
        public string GetDoubleBedQuantity()
        {
            return DoubleBedQuantity;
        }
        public void SetPrice(double price)
        {
            Price = price;
        }
        public double GetPrice()
        {
            return Price;
        }

    }
}