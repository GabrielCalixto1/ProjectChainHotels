namespace ProjectChainHotels.Lib.Models
{
    public class BedroomDescription : ModelBase
    {

        private string Name { get; set; }
        private string Review { get; set; }
        private int MaximumCapacity { get; set; }
        private int SingleBedQuantity { get; set; }
        private int DoubleBedQuantity { get; set; }
        private double Price { get; set; }

        public BedroomDescription(string id, string name, string review, int maximumCapacity, int singleBedQuantity, int doubleBedQuantity, double price, DateTime registrationDate, DateTime lastUpdateDate) : base(id, registrationDate, lastUpdateDate)
        {
            SetName(name);
            SetReview(review);
            SetMaximumCapacity();
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
        public void SetMaximumCapacity()
        {
            MaximumCapacity = MaximumCapacityIsTheSumOfSpaceInTheBed();
        }
        public int GetMaximumCapacity()
        {
            return MaximumCapacity;
        }
        public void SetSingleBedQuantity(int singleBedQuantity)
        {
            SingleBedQuantity = singleBedQuantity;
        }
        public int GetSingleBedQuantity()
        {
            return SingleBedQuantity;
        }
        public void SetDoubleBedQuantity(int doubleBedQuantity)
        {
            DoubleBedQuantity = doubleBedQuantity;
        }
        public int GetDoubleBedQuantity()
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
        public int MaximumCapacityIsTheSumOfSpaceInTheBed()
        {
            return GetSingleBedQuantity() + GetDoubleBedQuantity();
        }

    }
}