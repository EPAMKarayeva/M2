using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Rec
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;

            int[] array = new int[n];

            FillArray(array);
            var test = array.FindMaxElement(array[0]);
            Console.WriteLine(test);
            Console.ReadKey();
        }

        static void FillArray(int [] array)
        {
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-15, 15);
                //Console.Write(array[i] + " ");
            }
        }


    }


    public static class ArrayExtension
    {
        public static int FindMaxElement(this int[] array, int tmp, int i = 0)
        {

            if (i < array.Length)
            {
                if (array[i] > tmp)
                {
                    tmp= array[i];
                }

                i++;

                tmp = array.FindMaxElement(tmp, i);
                return tmp;
            }
            else
            {
                return tmp;
            }
        }
    }
}
