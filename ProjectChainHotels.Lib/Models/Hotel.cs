namespace ProjectChainHotels.Lib.Models
{
    public class Hotel : ModelBase
    {
        private string Name { get; set; }
        private string Address { get; set; }
        private string ZipCode { get; set; }
        private string Review { get; set; }
        private string Tellphone { get; set; }
        private string Email { get; set; }
        private DateTime CheckInTime { get; set; }
        private DateTime CheckOutTime { get; set; }
        public Hotel(string id, string name, string address, string zipCode, string review, string tellphone, string email, DateTime checkInTime, DateTime checkOutTime, DateTime registrationDate, DateTime lastUpdateDate) : base(id, registrationDate, lastUpdateDate)
        {
            SetName(name);
            SetAddress(address);
            SetZipCode(zipCode);
            SetReview(review);
            SetTellphone(tellphone);
            SetEmail(email);
            SetCheckInTime(checkInTime);
            SetCheckOutTime(checkOutTime);
        }

        public void SetName(string name)
        {
            Name = name;
        }
        public string GetName()
        {
            return Name;
        }
        public void SetAddress(string address)
        {
            Address = address;
        }
        public string GetAddress()
        {
            return Address;
        }
        public void SetZipCode(string zipCode)
        {
            ZipCode = zipCode;
        }
        public string GetZipCode()
        {
            return ZipCode;
        }
        public void SetReview(string review)
        {
            Review = review;
        }
        public string GetReview()
        {
            return Review;
        }
        public void SetTellphone(string tellphone)
        {
            TellphoneMustHaveUpToFourteenCharacters(tellphone);
            Tellphone = tellphone;
        }
        public string GetTellphone()
        {
            return Tellphone;
        }
        public void SetEmail(string email)
        {
            EmailMustContainAtSign(email);
            Email = email;
        }
        public string GetEmail()
        {
            return Email;
        }
        public void SetCheckInTime(DateTime checkInTime)
        {
            CheckInTime = checkInTime;
        }
        public DateTime GetCheckInTime()
        {
            return CheckInTime;
        }
        public void SetCheckOutTime(DateTime checkOutTime)
        {
            CheckOutTime = checkOutTime;
        }
        public DateTime GetCheckOutTime()
        {
            return CheckOutTime;
        }

    }
}