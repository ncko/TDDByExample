using Xunit;

namespace Money
{
    public class DollarTest
    {
        [Fact]
        public void TestTimes()
        {
            const int expected = 10;
            
            Dollar five = new Dollar(5);
            five.Times(2);
            int actual = five.Amount;
            Assert.Equal(expected, actual);
        }
    }
}