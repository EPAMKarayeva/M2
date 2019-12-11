using System;
using Xunit;
using ArrayFindIndex;


namespace XUnitTestProject1
{
    public class UnitTest2
    {

        SearchIndex index = new SearchIndex();

        [Fact(DisplayName ="Find correct index")]
        public void TestForFindingCorrectIndex()
        {
            int[] array = { 2, 4, 1, 3, 3 };

            var result = index.FindIndex(array);

            int expected = 2;

            Assert.Equal(result, expected);
        }

        [Fact(DisplayName = "Compare of sums")]
        public void TestForCompareSums()
        {
            int sum = 10; 
                
            int sum1 = 10;

            var result = index.CompareSums(sum, sum1);

            var expected = true;

            Assert.Equal(expected, result);
           
        }

        [Fact(DisplayName = "Check for count correct sum before current element")]
        public void TestForCorrectSumBeforeElement()
        {
            int[] array = { -2, 4, 1, -1, 3 };

            var result = index.GetSumBeforeElement(array, 2);

            var expected = 2;

            Assert.Equal(expected, result);


        }


        [Fact(DisplayName = "Check for counting correct sum after current element")]
        public void TestForCorrectSumAfterElement()
        {
            int[] array = { -2, 4, 1, -1, 3 };

            var result = index.GetSumAfterElement(array, 2);

            var expected = 2;

            Assert.Equal(expected, result);


        }
    }
}