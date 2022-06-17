using ProjectChainHotels.Lib.Models;

namespace ProjectChainHotels.XUnit
{
    public class ReserveTest
    {
          [Fact]
        public void TestEmailInTheHotelGuestClass()
        {
            var expectedDeparture = DateTime.Parse("03/03/2022");
            var reserve = new Reserve("1", "2", "3", DateTime.Parse("02/02/2022"), expectedDeparture, DateTime.Parse("02/02/2022"), DateTime.Parse("02/02/2022"));
            var currentDeparture = reserve.GetDepartureDate();
            Assert.Equal(expectedDeparture.ToString(), currentDeparture.ToString());
        }
    }
}