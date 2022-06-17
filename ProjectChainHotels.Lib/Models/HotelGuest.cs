namespace ProjectChainHotels.Lib.Models
{
    public class HotelGuest : ModelBase
    {
        private string Name { get; set; }
        private string Cpf { get; set; }
        private string Tellphone { get; set; }
        private string Email { get; set; }
        private DateTime BirthDate { get; set; }

        public HotelGuest(string id, string name, string cpf, string tellphone, string email, DateTime birthDate, DateTime registrationDate, DateTime lastUpdateDate) : base(id, registrationDate, lastUpdateDate)
        {
            SetName(name);
            SetCpf(cpf);
            SetTellphone(tellphone);
            SetBirthDate(birthDate);
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
            TellphoneMustHaveUpToFourteenCharacters(tellphone);
            Tellphone = tellphone;
        }
        public string GetTellphone()
        {
            return Tellphone;
        }
       public void SetEmail(string email)
        {
            EmailMustContainAtSign(email);
            Email = email;
        }
        public string GetEmail()
        {
            return Email;
        }
        public void SetBirthDate(DateTime birthDate)
        {
            BirthDate = birthDate;
        }
        public DateTime GetBirthDate()
        {
            return BirthDate;
        }
        public bool CpfMustHaveOnlyNumbers(string cpf)
        {
            if (cpf.Where(x => char.IsLetter(x)).Count() > 0)
            {
                return false;
            }
            return true;
        }
    }
}