using System;
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

        //public char [] SwapSymbols(string str, int m)
        //{  
        //    char[] charArray = str.ToCharArray();
        //    char temp; 

        //    for (int i =m; i <charArray.Length; i++)
        //    {
        //        for (int j = i + 1; j < charArray.Length; i++)
        //        {
        //            temp = charArray[i];
        //            charArray[i] = charArray[j];
        //            charArray[j] = temp;
        //        }
        //    }

        //    return charArray;
        //}

        //public void FindNextBigger(string str)
        //{
        //    var chrArray = new char[str.Length];

        //    for (int i = 0; i < chrArray.Length; i++)
        //    {
    

        //    }

        //}


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



    }
}
