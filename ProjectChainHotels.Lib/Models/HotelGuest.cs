namespace ProjectChainHotels.Lib.Models
{
    public class HotelGuest
    {
        public string Id { get; set; }
        public string Name {get;set;}
        public string Cpf {get;set;}
        public string Tellphone {get;set;}
        public DateTime BirthDate {get;set;}
        public DateTime RegistrationDate { get; set; }
        public DateTime LastUptdateDate { get; set; }
    }
}