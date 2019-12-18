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

            var array = nextBiggerNumber.NumberSorted(str);

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }

            Console.ReadKey();
        }

    }
}
