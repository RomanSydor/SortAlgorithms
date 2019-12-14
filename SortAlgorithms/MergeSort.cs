using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithms
{
    class MergeSort : SortBase
    {
        public void Merging(int[] Array, int lowIndex, int middleIndex, int highIndex)
        {
            var left = lowIndex;
            var right = middleIndex + 1;
            var tempArray = new int[highIndex - lowIndex + 1];
            var index = 0;

            while ((left <= middleIndex) && (right <= highIndex))
            {
                if (Array[left] < Array[right])
                {
                    tempArray[index] = Array[left];
                    left++;
                }
                else
                {
                    tempArray[index] = Array[right];
                    right++;
                }

                index++;
            }

            for (var i = left; i <= middleIndex; i++)
            {
                tempArray[index] = Array[i];
                index++;
            }

            for (var i = right; i <= highIndex; i++)
            {
                tempArray[index] = Array[i];
                index++;
            }

            for (var i = 0; i < tempArray.Length; i++)
            {
                Array[lowIndex + i] = tempArray[i];
            }
        }

        public int[] Merge(int[] array, int lowIndex, int highIndex)
        {
            if (lowIndex < highIndex)
            {
                var middleIndex = (lowIndex + highIndex) / 2;
                Merge(array, lowIndex, middleIndex);
                Merge(array, middleIndex + 1, highIndex);
                Merging(array, lowIndex, middleIndex, highIndex);
            }

            return array;
        }

        public int[] MergeSorting(int[] Array, ref int ArrayLength)
        {
            return Merge(Array, 0, ArrayLength - 1);
        }
    }
}
