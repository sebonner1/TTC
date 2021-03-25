using System.Reflection;
using Xunit;

// try to add to the group project!!

namespace xunitnotes.tests
{
    [Fact]
    public class Test_Utility
    {
        public void Test_Add()
        {
            Utility myUtility = new Utility();
            int expected = 4;

            int actual = myUtility.Add(3,1);

            Assert.Equal(expected, actual);
        }   

        [Theory]
        [InlineData(3)]
        [InlineData(7)]
        [InlineData(9)]
        public void Test_IsOdd(int x)
        {
            Utility myUtility = new Utility();

            Assert.True(myUtility.IsOdd(x));
        }
    }
}