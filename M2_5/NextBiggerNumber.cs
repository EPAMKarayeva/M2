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

        public int ConvertInInt(char[] arrayChar)
        {

            string str = new string(arrayChar);
            int n = Convert.ToInt32(str);

            return n;
        }

        public void SwapSymbols(string str, int m, ref ArrayList arrayList)
        {
            char[] charArray = str.ToCharArray();
            char temp;

            for (int i = m; i < charArray.Length; i++)
            {
                for (int j = m+1; j < charArray.Length; j++)
                {
                    
                        temp = charArray[i];
                        charArray[i] = charArray[j];
                        charArray[j] = temp;
                        Console.WriteLine(charArray);
                        arrayList.Add(charArray);
  
                }

            }
        }

        public ArrayList FindAllNumbers(string str)
        {
            var chrArray = new char[str.Length];

            ArrayList arrayList = new ArrayList();

            for (int i = 0; i < 100; i++)
            {
                SwapSymbols(str, i, ref arrayList);
            }

            ArrayList arList = new ArrayList();
            int n = 0;

            foreach (char[] item in arrayList)
            {
                n = ConvertInInt(item);
                arList.Add(n);
                Console.WriteLine("After:"+n);
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
