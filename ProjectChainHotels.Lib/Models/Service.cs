namespace ProjectChainHotels.Lib.Models
{
    public class Service : ModelBase
    {
        string Name {get; set;}

        public Service(string id, string name, DateTime registrationDate, DateTime lastUpdateDate) : base(id, registrationDate, lastUpdateDate)
        {
            SetName(name);
        }
        public void SetName(string name)
        {
            Name = name;
        }
        public string GetName()
        {
            return Name;
        }

    }
}