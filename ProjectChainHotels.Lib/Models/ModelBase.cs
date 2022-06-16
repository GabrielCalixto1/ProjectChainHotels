namespace ProjectChainHotels.Lib.Models
{
    public class ModelBase
    {
        private string Id { get; set; }
        private DateTime RegistrationDate;
        private DateTime LastUptdateDate;
        public ModelBase(string id, DateTime registrationDate, DateTime lastUptdateDate)
        {
            Id = id;
            RegistrationDate = registrationDate;
            LastUptdateDate = lastUptdateDate;
        }
        public void SetId(string id)
        {
            Id = id;
        }
        public string GetId()
        {
            return Id;
        }
        public void SetRegistrationDate(DateTime restrationDate)
        {
            RegistrationDate = restrationDate;
        }
        public DateTime GetRegistrationDate()
        {
            return RegistrationDate;
        }

        public void SetLastUptdateDate(DateTime lastUpdateDate)
        {
            LastUptdateDate = lastUpdateDate;
        }
        public DateTime GetLastUptdateDate()
        {
            return LastUptdateDate;
        }
        public bool EmailMustContainAtSign(string email)
        {
            if (email.Contains('@'))
            {
                return true;
            }
            return false;
        }
        public bool TellphoneMustHaveUpToFourteenCharacters(string tellphone)
        {
            if (tellphone.Length <= 14)
            {
                return true;
            }
            return false;
        }
        public bool RegistrationDateIsGreaterThanUpdateDate(DateTime departureDate)
        {
            if (GetRegistrationDate() < departureDate)
            {
                return true;
            }
            return false;
        }
    }
}