using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithms
{
    public class SortBase
    {
        public int[] Array { get; set; }
        public int ArrayLength
        {
            get 
            {
                return Array.Length;
            }
            set 
            {
            } 
        }
        public void Swap(ref int element1, ref int element2)
        {
            var swap = element1;
            element1 = element2;
            element2 = swap;
        }

        public void ShowArray(int[] Array, ref int ArrayLength) 
        {
            Console.Write("\nArray: ");
            for (var i = 0; i < ArrayLength; i++) 
            {
                Console.Write(Array[i] + " ");
            }
        }

        public void InputArray(int[] Array, ref int ArrayLength)
        {
            var check = false;
            Console.WriteLine("Input array: ");
            for (var i = 0; i < ArrayLength; i++)
            {
                do
                {
                    try
                    {
                        Console.Write($"{i + 1})");
                        Array[i] = int.Parse(Console.ReadLine());
                        check = false;
                    }
                    catch
                    {
                        Console.WriteLine("Invalid input!");
                        check = true;
                    }
                } while (check);
            }
        }

        public void RandomInputArray(int[] Array, ref int ArrayLength) 
        {
            var rnd = new Random();
            for (var i = 0; i < ArrayLength; i++) 
            {
                Array[i] = rnd.Next(1, 101);
            }
        }
    }
}
