namespace ProjectChainHotels.Lib.Models
{
    public class Hotel
    {
        private string Id { get; set; }
        private string Name { get; set; }
        private string Address { get; set; }
        private string ZipCode { get; set; }
        private string Review { get; set; }
        private string Tellphone { get; set; }
        private string Email { get; set; }
        private DateTime CheckInTime { get; set; }
        private DateTime CheckOutTime { get; set; }
        private DateTime RegistrationDate { get; set; }
        private DateTime LastUpdateDate { get; set; }
        public Hotel(string id, string name, string address, string zipCode, string review, string tellphone, string email, DateTime checkInTime, DateTime checkOutTime, DateTime registrationDate, DateTime lastUpdateDate)
        {
            SetId(id);
            SetName(name);
            SetAddress(address);
            SetZipCode(zipCode);
            SetReview(review);
            SetTellphone(tellphone);
            SetEmail(email);
            SetCheckInTime(checkInTime);
            SetCheckOutTime(checkOutTime);
            SetRegistrationDate(registrationDate);
            SetLastUpdateDate(lastUpdateDate);
        }

        public void SetId(string id)
        {
            Id = id;
        }
        public string GetId()
        {
            return Id;
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
            Tellphone = tellphone;
        }
        public string GetTellphone()
        {
            return Tellphone;
        }
        public void SetEmail(string email)
        {
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
        public void SetRegistrationDate(DateTime registrationDate)
        {
            RegistrationDate = registrationDate;
        }
        public DateTime GetRegistrationDate()
        {
            return RegistrationDate;
        }
        public void SetLastUpdateDate(DateTime lastUpdateDate)
        {
            LastUpdateDate = lastUpdateDate;
        }
        public DateTime GetLastUpdateDate()
        {
            return LastUpdateDate;
        }


    }
}