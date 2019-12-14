using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithms
{
    class CoctailSort : SortBase
    {
        public bool isSwap1
        {
            get
            {
                return false;
            }
            set { }
        }
        public bool isSwap2
        {
            get
            {
                return false;
            }
            set { }
        }
        public int[] CoctailSorting(int[] Array, ref int ArrayLength)
        {
            for (var j = 0; j < ArrayLength; j++)
            {
                for (var i = 0; i < ArrayLength - 1 - j; i++)
                {
                    if (Array[i] > Array[i + 1])
                    {
                        Swap(ref Array[i], ref Array[i + 1]);
                        isSwap1 = true;
                    }
                    else isSwap1 = false;
                }

                for (var k = ArrayLength - 1 - j; k > 0; k--)
                {
                    if (Array[k] < Array[k - 1])
                    {
                        Swap(ref Array[k], ref Array[k - 1]);
                        isSwap2 = true;
                    }
                    else isSwap2 = false;
                }
                if (!isSwap1 && !isSwap2) 
                {
                    break;
                }
                
            }
            return Array;
        }
    }
}
