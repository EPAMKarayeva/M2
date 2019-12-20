using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2_5
{
    public class NextBiggerNumber
    {


        public int[] ConvertingToInt(string str)
        {
            var chrArray = str.ToCharArray();
            var array = new int[str.Length];

            for (int i = 0; i < chrArray.Length; i++)
            {
                var temp = chrArray[i].ToString();
                array[i] = Convert.ToInt32(temp);
            }

            return array;
        }

        public int[] NumberSorted(string str)
        {
            var array = ConvertingToInt(str);
            int temp;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }

            return array;
        }

        public int ConvertInInt(char[] arrayChar)
        {

            string str = new string(arrayChar);
            int n = Convert.ToInt32(str);

            return n;
        }

        public char[] SwapSymbols(string str, int m)
        {
            char[] charArray = str.ToCharArray();
            char temp;

            for (int i = m; i < charArray.Length; i++)
            {
                for (int j = m+1; j <= charArray.Length; j++)
                {
                    if (j < charArray.Length)
                    {
                        temp = charArray[i];
                        charArray[i] = charArray[j];
                        charArray[j] = temp;
                        Console.WriteLine(charArray);

                        return charArray;
                    }

                    if (j >= charArray.Length)
                    {
                        temp = charArray[0];
                        charArray[0] = charArray[charArray.Length - 1];
                        charArray[charArray.Length - 1] = temp;
                        Console.WriteLine(charArray);

                       return charArray;
                    }


                }
            }

             return charArray;
        }

        public ArrayList FindAllNumbers(string str)
        {
            var chrArray = new char[str.Length];

            ArrayList arrayList = new ArrayList();

            for (int i = 0; i < 5040; i++)
            {
                var charArray = SwapSymbols(str, i);

                arrayList.Add(charArray);
            }

            ArrayList arList = new ArrayList();

            int n = 0;

            foreach (char[] item in arrayList)
            {
                n = ConvertInInt(item);
                arList.Add(n);
            }

            return arList;
        }

        public ArrayList FindArrayOfMax(string str, ArrayList arrayList)
        {
            int n = Convert.ToInt32(str);

            int[] array = (int[])arrayList.ToArray(typeof(Int32));


            ArrayList arrayOfMax = new ArrayList();

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > n)
                {
                    arrayOfMax.Add(array[i]);
                }
            }

            return arrayOfMax;
        }


        public int FindNextBigger(string str, ArrayList arrayList)
        {
            int n = Convert.ToInt32(str);
            
            
            
            int[] array = (int[])arrayList.ToArray(typeof(Int32));

            if (array.Length != 0)
            {
                int min = array[0];

                for (int i = 0; i < array.Length; i++)
                {

                    if (array[i] < min)
                    {
                        min = array[i];
                    }
                }

                return min;
            }
            else
            {
                return -1;
            }

        }

    }
}
