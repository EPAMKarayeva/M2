using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayFindIndex
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = 10;

            int[] array = new int[n];

            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-5,5);
                Console.Write(array[i]+" ");
            }

            SearchIndex searchIndex = new SearchIndex();

            var index = searchIndex.FindIndex(array);

            Console.WriteLine("\nResult:"+index);

            Console.ReadKey();
        }

    }

    public class SearchIndex
    {
        public int FindIndex(int[] array)
        {
            int temp = 0;

            for (int i = 0; i < array.Length; i++)
            {
                int sumBeforeElement=GetSumBeforeElement(array, i);
                int sumAfterElement=GetSumAfterElement(array, i);

                if (CompareSums(sumBeforeElement, sumAfterElement))
                {
                    temp = i;
                }
            }

            int x = (temp == 0)? -1 : temp;

            return x;

        }


        public bool CompareSums(int i, int j)
        {
            return i == j; 
        }

        public int GetSumBeforeElement(int[] array, int x)
        {
            int sum = 0;

            for (int i = 0; i < x; i++)
            {
               sum += array[i];
            }

            return sum;

        }

        public int GetSumAfterElement(int[] array, int x)
        {
            int sum = 0;

            for (int m = x+1; m < array.Length; m++)
            {
                sum += array[m];
            }

            return sum;
        }
    }
}
