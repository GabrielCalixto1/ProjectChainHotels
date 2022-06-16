namespace ProjectChainHotels.Lib.Models
{
    public class HotelGuest
    {
        private string Id { get; set; }
        private string Name { get; set; }
        private string Cpf { get; set; }
        private string Tellphone { get; set; }
        private DateTime BirthDate { get; set; }
        private DateTime RegistrationDate { get; set; }
        private DateTime LastUpdateDate { get; set; }
         public HotelGuest(string id, string name, string cpf, string tellphone, DateTime birthDate, DateTime registrationDate, DateTime lastUpdateDate)
        {
            SetId(id);
            SetName(name);
            SetCpf(cpf);
            SetTellphone(tellphone);
            SetBirthDate(birthDate);
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
        public void SetCpf(string cpf)
        {
            Cpf = cpf;
        }
        public string GetCpf()
        {
            return Cpf;
        }
        public void SetTellphone(string tellphone)
        {
            Tellphone = tellphone;
        }
        public string GetTellphone()
        {
            return Tellphone;
        }
        public void SetBirthDate(DateTime birthDate)
        {
            BirthDate = birthDate;
        }
        public DateTime GetBirthDate()
        {
            return BirthDate;
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