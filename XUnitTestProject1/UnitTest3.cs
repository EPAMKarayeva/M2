using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using M2_5;

namespace XUnitTestProject1
{
    public class UnitTest3
    {
        NextBiggerNumber nextBiggerNumber = new NextBiggerNumber();

        [Fact(DisplayName ="Check correct result for finding next bigger number")]
        public void TestForFindingNextBigger()
        {
            //Arrange
            string str = "12";

            int expected = 21;

            //Act
            var array = nextBiggerNumber.FindAllNumbers(str);

            var arrayofMax = nextBiggerNumber.FindArrayOfMax(str, array);

            int result = nextBiggerNumber.FindNextBigger(str, arrayofMax);

            //Assert

            Assert.Equal(result, expected);
        }

        [Fact(DisplayName = "Check correct result for finding next bigger number")]
        public void TestForFindingNextBigger1()
        {
            //Arrange
            string str = "513";

            int expected = 531;

            //Act
            var array = nextBiggerNumber.FindAllNumbers(str);

            var arrayofMax = nextBiggerNumber.FindArrayOfMax(str, array);

            int result = nextBiggerNumber.FindNextBigger(str, arrayofMax);

            //Assert

            Assert.Equal(result, expected);
        }

        [Fact(DisplayName = "Check correct result for finding next bigger number")]
        public void TestForFindingNextBigger2()
        {
            //Arrange
            string str = "2017";

            int expected = 2071;

            //Act
            var array = nextBiggerNumber.FindAllNumbers(str);

            var arrayofMax = nextBiggerNumber.FindArrayOfMax(str, array);

            int result = nextBiggerNumber.FindNextBigger(str, arrayofMax);

            //Assert

            Assert.Equal(result, expected);
        }

        [Fact(DisplayName = "Check correct result for finding next bigger number")]
        public void TestForFindingNextBigger3()
        {
            //Arrange
            string str = "414";

            int expected = 441;

            //Act
            var array = nextBiggerNumber.FindAllNumbers(str);

            var arrayofMax = nextBiggerNumber.FindArrayOfMax(str, array);

            int result = nextBiggerNumber.FindNextBigger(str, arrayofMax);

            //Assert

            Assert.Equal(result, expected);
        }

        [Fact(DisplayName = "Check correct result for finding next bigger number")]
        public void TestForFindingNextBigger4()
        {
            //Arrange
            string str = "144";

            int expected = 414;

            //Act
            var array = nextBiggerNumber.FindAllNumbers(str);

            var arrayofMax = nextBiggerNumber.FindArrayOfMax(str, array);

            int result = nextBiggerNumber.FindNextBigger(str, arrayofMax);

            //Assert

            Assert.Equal(result, expected);
        }

        [Fact(DisplayName = "Check correct result for finding next bigger number")]
        public void TestForFindingNextBigger5()
        {
            //Arrange
            string str = "1234321";

            int expected = 1241233;

            //Act
            var array = nextBiggerNumber.FindAllNumbers(str);

            var arrayofMax = nextBiggerNumber.FindArrayOfMax(str, array);

            int result = nextBiggerNumber.FindNextBigger(str, arrayofMax);

            //Assert

            Assert.Equal(result, expected);
        }

        [Fact(DisplayName = "Check correct result for finding next bigger number")]
        public void TestForFindingNextBigger6()
        {
            //Arrange
            string str = "1234126";

            int expected = 1234162;

            //Act
            var array = nextBiggerNumber.FindAllNumbers(str);

            var arrayofMax = nextBiggerNumber.FindArrayOfMax(str, array);

            int result = nextBiggerNumber.FindNextBigger(str, arrayofMax);

            //Assert

            Assert.Equal(result, expected);
        }

        [Fact(DisplayName = "Check correct result for finding next bigger number")]
        public void TestForFindingNextBigger7()
        {
            //Arrange
            string str = "3456432";

            int expected = 3462345;

            //Act
            var array = nextBiggerNumber.FindAllNumbers(str);

            var arrayofMax = nextBiggerNumber.FindArrayOfMax(str, array);

            int result = nextBiggerNumber.FindNextBigger(str, arrayofMax);

            //Assert

            Assert.Equal(result, expected);
        }

        [Fact(DisplayName = "Check correct result for finding next bigger number")]
        public void TestForFindingNextBigger8()
        {
            //Arrange
            string str = "10";

            int expected = -1;

            //Act
            var array = nextBiggerNumber.FindAllNumbers(str);

            var arrayofMax = nextBiggerNumber.FindArrayOfMax(str, array);

            int result = nextBiggerNumber.FindNextBigger(str, arrayofMax);

            //Assert

            Assert.Equal(result, expected);
        }

        [Fact(DisplayName = "Check correct result for finding next bigger number")]
        public void TestForFindingNextBigger9()
        {
            //Arrange
            string str = "20";

            int expected = -1;

            //Act
            var array = nextBiggerNumber.FindAllNumbers(str);

            var arrayofMax = nextBiggerNumber.FindArrayOfMax(str, array);

            int result = nextBiggerNumber.FindNextBigger(str, arrayofMax);

            //Assert

            Assert.Equal(result, expected);
        }
    }
}
