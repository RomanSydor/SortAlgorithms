using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithms
{
    class GnomeSort : SortBase
    {
        public int[] GnomeSorting(int[] Array, ref int ArrayLength)
        {
            var index = 1;
            var nextIndex = index + 1;

            while (index < ArrayLength)
            {
                if (Array[index - 1] < Array[index])
                {
                    index = nextIndex;
                    nextIndex++;
                }
                else
                {
                    Swap(ref Array[index - 1], ref Array[index]);
                    index--;
                    if (index == 0)
                    {
                        index = nextIndex;
                        nextIndex++;
                    }
                }
            }

            return Array;
        }
    }
}
