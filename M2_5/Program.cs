using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");

            var str = Console.ReadLine();

            NextBiggerNumber nextBiggerNumber = new NextBiggerNumber();

            var array = nextBiggerNumber.FindAllNumbers(str);

            //foreach (var item in array)
            //{
            //    Console.WriteLine(item);
            //}

            var arrayofMax = nextBiggerNumber.FindArrayOfMax(str, array);

            int nextBiggerNum = nextBiggerNumber.FindNextBigger(str, arrayofMax);

            Console.WriteLine("Result: {0}", nextBiggerNum);


            Console.ReadKey();
        }

    }
}
