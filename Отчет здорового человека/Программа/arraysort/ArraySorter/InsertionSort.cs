using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokolov_InsertionSort
{
    public class InsertionSorter
    {
        public static int[] SortArray(int[] array)
        {
            int length = array.Length;

            for (int i = 1; i < length; i++)
            {
                var key = array[i];
                var flag = 0;
                for (int j = i - 1; j >= 0 && flag != 1;)
                {
                    if (key < array[j])
                    {
                        array[j + 1] = array[j];
                        j--;
                        array[j + 1] = key;
                    }
                    else flag = 1;
                }
            }
            return array;
        }
       

    }
}
