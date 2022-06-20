namespace ProjectChainHotels.Web.DTOs
{
    public class ServiceDTO : ModelBaseDTO
    {
        string Name {get; set;}

        public ServiceDTO(string id, DateTime registrationDate, DateTime lastUpdateDate) : base(id, registrationDate, lastUpdateDate)
        {

        }

    }
}