
using ProjectChainHotels.Lib.Models;

namespace ProjectChainHotels.XUnit
{
    public class HotelTest
    {
        public void TestTellphoneInTheHotelGuestClass()
        {
            var expectedTellphone = "32999681739";
            var hotel = new Hotel("1", "Gabriel", "california", "28080425", "awesome", expectedTellphone, "gabriel@test", DateTime.Parse("06/15/2022"), DateTime.Parse("06/15/2022"), DateTime.Parse("06/14/2022"), DateTime.Parse("06/14/2022"));
            var currentTellphone = hotel.GetTellphone();
            Assert.Equal(expectedTellphone, currentTellphone);
        }
        [Fact]
        public void TestEmailInTheHotelGuestClass()
        {
            var expectedEmail = "gabriel@test.com";
            var hotel = new Hotel("1", "Gabriel", "california", "28080425", "awesome", "32999681739", expectedEmail, DateTime.Parse("06/15/2022"), DateTime.Parse("06/15/2022"), DateTime.Parse("06/14/2022"), DateTime.Parse("06/14/2022"));
            var currentEmail = hotel.GetEmail();
            Assert.Equal(expectedEmail, currentEmail);
        }
    }
}