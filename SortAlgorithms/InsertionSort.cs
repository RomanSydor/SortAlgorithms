using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithms
{
    class InsertionSort : SortBase
    {
        public int[] InsertionSorting(int[] Array, ref int ArrayLength) 
        {
            for (var j = 1; j < ArrayLength; j++)
            {
                var i = j;
                while (i > 0 && Array[i - 1] > Array[i])
                {
                    Swap(ref Array[i - 1], ref Array[i]);
                    i--;
                }
            }
            return Array;
        }
    }
}
