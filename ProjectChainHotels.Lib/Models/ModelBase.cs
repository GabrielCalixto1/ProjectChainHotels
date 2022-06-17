using ProjectChainHotels.Lib.Exceptions;

namespace ProjectChainHotels.Lib.Models
{
    public class ModelBase
    {
        private string Id { get; set; }
        private DateTime RegistrationDate;
        private DateTime LastUptdateDate;
        public ModelBase(string id, DateTime registrationDate, DateTime lastUptdateDate)
        {
            SetId(id);
            SetRegistrationDate(registrationDate);
            SetLastUptdateDate(lastUptdateDate);
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
            throw new ValidationErrorException("Email must cotains at sign");
        }
        public bool TellphoneMustHaveUpToFourteenCharacters(string tellphone)
        {

            if (tellphone.Length <= 14)
            {
                return true;
            }
            throw new ValidationErrorException("Tellphone must have up to fourteen characters");
        }
        public bool UpdateCantLessThanRegistrationDate(DateTime lastUpdateDate)
        {
         
            if (GetRegistrationDate() < lastUpdateDate)
            {
                return true;
            }
            throw new ValidationErrorException("Update date cant less than registration date");
        }
    }
}