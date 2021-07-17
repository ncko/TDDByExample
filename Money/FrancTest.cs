using Xunit;

namespace Money
{
    public class FrancTest
    {
        [Fact]
        public void TestTimes()
        {
            Franc five = new Franc(5);
            Assert.Equal(new Franc(10), five.Times(2));
            Assert.Equal(new Franc(15), five.Times(3));
        }

        [Fact]
        public void TestEquals()
        {
            Assert.True(new Franc(5).Equals(new Franc(5)));
            Assert.False(new Franc(5).Equals(new Franc(6)));
        }

        [Fact]
        public void TestToString()
        {
            Assert.Equal("$5", new Franc(5).ToString());
        }
    }
}