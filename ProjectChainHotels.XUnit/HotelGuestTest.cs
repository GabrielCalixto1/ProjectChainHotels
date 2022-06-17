using Xunit;
using ProjectChainHotels.Lib.Models;
namespace ProjectChainHotels.XUnit
{
    public class HotelGuestTest
    {
                  [Fact]
        public void TestTellphoneInTheHotelGuestClass()
        {
            var expectedTellphone = "32999681739";
            var hotelGuest = new HotelGuest("1", "Gabriel", "10665552326", expectedTellphone, "Gabriel@test.com", DateTime.Parse("02/02/2022"), DateTime.Parse("01/01/2022"), DateTime.Parse("01/01/2022") );
            var currentTellphone = hotelGuest.GetTellphone();
            Assert.Equal(expectedTellphone, currentTellphone);
        }
        [Fact]
        public void TestEmailInTheHotelGuestClass()
        {
            var expectedEmail = "Gabriel@test.com";
            var hotelGuest = new HotelGuest("2", "Gabriel", "10665552326", "32999681739", expectedEmail, DateTime.Parse("02/02/2022"), DateTime.Parse("01/01/2022"), DateTime.Parse("01/01/2022") );
            var currentEmail = hotelGuest.GetEmail();
            Assert.Equal(expectedEmail, currentEmail);
        }
        [Fact]
        public void TestCpfInTheHotelGuestClass()
        {
            var expectedCpf = "10665552326";
            var hotelGuest = new HotelGuest("3", "Gabriel", expectedCpf, "32999681739", "Gabriel@test.com" , DateTime.Parse("02/02/2022"), DateTime.Parse("01/01/2022"), DateTime.Parse("01/01/2022") );
            var currentCpf = hotelGuest.GetCpf();
            Assert.Equal(expectedCpf, currentCpf);
        }
    }
}