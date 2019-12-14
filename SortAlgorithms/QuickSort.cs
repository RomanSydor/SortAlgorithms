using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithms
{
    class QuickSort : SortBase
    {
        public int Partition(int[] Array, int minIndex, int maxIndex)
        {
            var pivot = minIndex - 1;
            for (var i = minIndex; i < maxIndex; i++)
            {
                if (Array[i] < Array[maxIndex])
                {
                    pivot++;
                    Swap(ref Array[pivot], ref Array[i]);
                }
            }

            pivot++;
            Swap(ref Array[pivot], ref Array[maxIndex]);
            return pivot;
        }

        public int[] Quick(int[] Array, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex)
            {
                return Array;
            }

            var pivotIndex = Partition(Array, minIndex, maxIndex);
            Quick(Array, minIndex, pivotIndex - 1);
            Quick(Array, pivotIndex + 1, maxIndex);

            return Array;
        }
        public int[] QuickSorting(int[] Array, ref int ArrayLength)
        {
            return Quick(Array, 0, ArrayLength - 1);
        }
    }
}