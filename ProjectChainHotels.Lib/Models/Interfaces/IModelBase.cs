namespace ProjectChainHotels.Lib.Interfaces
{
    public interface IModelBase
    {
        bool EmailMustContainAtSign(string email);
        bool TellphoneMustHaveUpToFourteenCharacters(string tellphone);
        bool RegistrationDateIsGreaterThanUpdateDate(DateTime departureDate);
    }
}