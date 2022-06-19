namespace ProjectChainHotels.Web.DTOs
{
    public class Service : ModelBase
    {
        string Name {get; set;}

        public Service(string id, DateTime registrationDate, DateTime lastUpdateDate) : base(id, registrationDate, lastUpdateDate)
        {

        }

    }
}