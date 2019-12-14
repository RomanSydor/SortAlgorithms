using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithms
{
    class SelectionSort : SortBase
    {
        public int[] SelectionSorting(int[] Array, ref int ArrayLength) 
        {
            int minIndex = 0;
            for (var i = 0; i < ArrayLength - 1; i++)
            {
                minIndex = i;
                for (var j = i + 1; j < ArrayLength; j++)
                {
                    if (Array[j] < Array[minIndex])
                    {
                        minIndex = j;
                    }
                }
                if (i != minIndex)
                {
                    Swap(ref Array[i], ref Array[minIndex]);
                }
            }
            return Array;
        }
    }
}
