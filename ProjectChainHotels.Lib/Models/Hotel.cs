namespace ProjectChainHotels.Lib.Models
{
    public class Hotel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public string ZipCode { get; set; }
        public string Review { get; set; }
        public string Tellphone { get; set; }
        public string Email { get; set; }
        public DateTime Check_In_Time { get; set; }
        public DateTime Check_Out_Time { get; set; }        
        public DateTime RegistrationDate { get; set; }
        public DateTime LastUptdateDate { get; set; }
    }
}