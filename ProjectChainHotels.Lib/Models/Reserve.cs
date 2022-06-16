namespace ProjectChainHotels.Lib.Models
{
    public class Reserve
    {
        public string Id { get; set; }
        public string IdResponsible { get; set; }
        public string IdBedroom { get; set; }
        public string EntryDate { get; set; }
        public string DepartureDate { get; set; }
        public DateTime RegistrationDate { get; set; }
        public DateTime LastUptdateDate { get; set; }
    }
}