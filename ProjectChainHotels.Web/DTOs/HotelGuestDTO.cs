namespace ProjectChainHotels.Web.DTOs
{
    public class HotelGuest : ModelBase
    {
        private string Name { get; set; }
        private string Cpf { get; set; }
        private string Tellphone { get; set; }
        private string Email { get; set; }
        private DateTime BirthDate { get; set; }

        public HotelGuest(string id, DateTime registrationDate, DateTime lastUpdateDate) : base(id, registrationDate, lastUpdateDate)
        {

        }
    
    }
}