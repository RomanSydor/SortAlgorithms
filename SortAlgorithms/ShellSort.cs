using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithms
{
    class ShellSort : SortBase
    {
        public int[] ShellSorting(int[] Array, ref int ArrayLength)
        {
            var step = ArrayLength;
            while (step > 0)
            {
                for (var i = step; i < ArrayLength; i++)
                {
                    int j = i;
                    while ((j >= step) && Array[j - step] > Array[j])
                    {
                        Swap(ref Array[j - step], ref Array[j]);
                        j -= step;
                    }
                }
                step /= 2;
            }
            return Array;
        }
    }
}
