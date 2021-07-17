using Xunit;

namespace Money
{
    public class DollarTest
    {
        [Fact]
        public void TestTimes()
        {
            Dollar five = new Dollar(5);
            Assert.Equal(new Dollar(10), five.Times(2));
            Assert.Equal(new Dollar(15), five.Times(3));
        }

        [Fact]
        public void TestEquals()
        {
            Assert.True(new Dollar(5).Equals(new Dollar(5)));
            Assert.False(new Dollar(5).Equals(new Dollar(6)));
        }

        [Fact]
        public void TestToString()
        {
            Assert.Equal("$5", new Dollar(5).ToString());
        }
    }
}