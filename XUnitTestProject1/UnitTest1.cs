using System;
using Xunit;
using Max_Rec;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact(DisplayName = "Check result for finding max element")]
        public void TestFindingMaxResult()
        {
            int[] array = { -2, -1, 0, 1, 2 };

            int result = array.FindMaxElement(-2);

            int expected = 2;

            Assert.Equal(result, expected);
        }
    }
}
