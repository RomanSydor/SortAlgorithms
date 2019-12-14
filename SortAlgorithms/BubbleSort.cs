using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithms
{
    class BubbleSort : SortBase
    {
        public int[] BubbleSorting(int[] Array, ref int ArrayLength)
        {
            for (var j = 0; j < ArrayLength; j++)
            {
                for (var i = 0; i < ArrayLength - 1 - j; i++)
                {
                    if (Array[i] > Array[i + 1])
                    {
                        Swap(ref Array[i], ref Array[i + 1]);
                    }
                }
            }
            return Array;
        }
    }
}
