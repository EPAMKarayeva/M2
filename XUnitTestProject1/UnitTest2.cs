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
            //Arrange
            int[] array = { 2, 4, 1, 3, 3 };

            int expected = 2;

            //Act
            var result = index.FindIndex(array);

            //Assert
            Assert.Equal(result, expected);
        }

        [Fact(DisplayName = "Compare of sums")]
        public void TestForCompareSums()
        {
            //Arrange
            int sumBeforeElement = 10; 
                
            int sumAfterElement = 10;

            var expected = true;

            //Act
            var result = index.CompareSums(sumBeforeElement, sumAfterElement);

            //Assert
            Assert.Equal(expected, result);
           
        }

        [Fact(DisplayName = "Check for count correct sum before current element")]
        public void TestForCorrectSumBeforeElement()
        {
            //Arrange
            int[] array = { -2, 4, 1, -1, 3 };

            int expected = 2;

            //Act
            var result = index.GetSumBeforeElement(array, 2);

            //Assert
            Assert.Equal(expected, result);

        }


        [Fact(DisplayName = "Check for counting correct sum after current element")]
        public void TestForCorrectSumAfterElement()
        {
            //Arrange
            int[] array = { -2, 4, 1, -1, 3 };

            int expected = 2;

            //Act
            var result = index.GetSumAfterElement(array, 2);

            //Assert
            Assert.Equal(expected, result);


        }
    }
}