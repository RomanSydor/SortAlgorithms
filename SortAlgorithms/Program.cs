using System;

namespace SortAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int isContinue;
            bool check = false;
            do
            {
                try
                {
                    do
                    {

                        Console.WriteLine("Input way: \n1)Manually \n2)Randomly");
                        var isManually = int.Parse(Console.ReadLine());

                        Console.Write("Input array size: ");
                        var ArrayLength = int.Parse(Console.ReadLine());

                        int[] Array = new int[ArrayLength];
                        var sortBase = new SortBase();

                        Console.Write("Choose algorithm: \n1)Bubble sort \n2)Coctail sort \n3)Gnome sort \n4)Insertion sort \n5)Selection sort \n6)Shell sort \n7)Quick sort \n8)Marge sort \n");
                        var choose = int.Parse(Console.ReadLine());
                        switch (choose)
                        {
                            case 1:
                                var bubbleSort = new BubbleSort();
                                if (isManually == 1)
                                {
                                    sortBase.InputArray(Array, ref ArrayLength);
                                }
                                else
                                {
                                    sortBase.RandomInputArray(Array, ref ArrayLength);
                                    sortBase.ShowArray(Array, ref ArrayLength);
                                    Console.WriteLine("\nPress <Enter> to sort");
                                    Console.ReadLine();
                                }
                                Console.WriteLine("Bubble sort");
                                var watchSort = System.Diagnostics.Stopwatch.StartNew();
                                bubbleSort.BubbleSorting(Array, ref ArrayLength);
                                sortBase.ShowArray(Array, ref ArrayLength);
                                Console.Write($"\nTime: {watchSort.Elapsed}");
                                break;
                            case 2:
                                var coctailSort = new CoctailSort();
                                if (isManually == 1)
                                {
                                    sortBase.InputArray(Array, ref ArrayLength);
                                }
                                else
                                {
                                    sortBase.RandomInputArray(Array, ref ArrayLength);
                                    sortBase.ShowArray(Array, ref ArrayLength);
                                    Console.WriteLine("\nPress <Enter> to sort");
                                    Console.ReadLine();
                                }
                                Console.WriteLine("Coctail sort");
                                watchSort = System.Diagnostics.Stopwatch.StartNew();
                                coctailSort.CoctailSorting(Array, ref ArrayLength);
                                sortBase.ShowArray(Array, ref ArrayLength);
                                Console.Write($"\nTime: {watchSort.Elapsed}");
                                break;
                            case 3:
                                var gnomeSort = new GnomeSort();
                                if (isManually == 1)
                                {
                                    sortBase.InputArray(Array, ref ArrayLength);
                                }
                                else
                                {
                                    sortBase.RandomInputArray(Array, ref ArrayLength);
                                    sortBase.ShowArray(Array, ref ArrayLength);
                                    Console.WriteLine("\nPress <Enter> to sort");
                                    Console.ReadLine();
                                }
                                Console.WriteLine("Gnome sort");
                                watchSort = System.Diagnostics.Stopwatch.StartNew();
                                gnomeSort.GnomeSorting(Array, ref ArrayLength);
                                sortBase.ShowArray(Array, ref ArrayLength);
                                Console.Write($"\nTime: {watchSort.Elapsed}");
                                break;
                            case 4:
                                var insertionSort = new InsertionSort();
                                if (isManually == 1)
                                {
                                    sortBase.InputArray(Array, ref ArrayLength);
                                }
                                else
                                {
                                    sortBase.RandomInputArray(Array, ref ArrayLength);
                                    sortBase.ShowArray(Array, ref ArrayLength);
                                    Console.WriteLine("\nPress <Enter> to sort");
                                    Console.ReadLine();
                                }
                                Console.WriteLine("Insertion sort");
                                watchSort = System.Diagnostics.Stopwatch.StartNew();
                                insertionSort.InsertionSorting(Array, ref ArrayLength);
                                sortBase.ShowArray(Array, ref ArrayLength);
                                Console.Write($"\nTime: {watchSort.Elapsed}");
                                break;
                            case 5:
                                var selectionSort = new SelectionSort();
                                if (isManually == 1)
                                {
                                    sortBase.InputArray(Array, ref ArrayLength);
                                }
                                else
                                {
                                    sortBase.RandomInputArray(Array, ref ArrayLength);
                                    sortBase.ShowArray(Array, ref ArrayLength);
                                    Console.WriteLine("\nPress <Enter> to sort");
                                    Console.ReadLine();
                                }
                                Console.WriteLine("Selection sort");
                                watchSort = System.Diagnostics.Stopwatch.StartNew();
                                selectionSort.SelectionSorting(Array, ref ArrayLength);
                                sortBase.ShowArray(Array, ref ArrayLength);
                                Console.Write($"\nTime: {watchSort.Elapsed}");
                                break;
                            case 6:
                                var shellSort = new ShellSort();
                                if (isManually == 1)
                                {
                                    sortBase.InputArray(Array, ref ArrayLength);
                                }
                                else
                                {
                                    sortBase.RandomInputArray(Array, ref ArrayLength);
                                    sortBase.ShowArray(Array, ref ArrayLength);
                                    Console.WriteLine("\nPress <Enter> to sort");
                                    Console.ReadLine();
                                }
                                Console.WriteLine("Shell sort");
                                watchSort = System.Diagnostics.Stopwatch.StartNew();
                                shellSort.ShellSorting(Array, ref ArrayLength);
                                sortBase.ShowArray(Array, ref ArrayLength);
                                Console.Write($"\nTime: {watchSort.Elapsed}");
                                break;
                            case 7:
                                var quickSort = new QuickSort();
                                if (isManually == 1)
                                {
                                    sortBase.InputArray(Array, ref ArrayLength);
                                }
                                else
                                {
                                    sortBase.RandomInputArray(Array, ref ArrayLength);
                                    sortBase.ShowArray(Array, ref ArrayLength);
                                    Console.WriteLine("\nPress <Enter> to sort");
                                    Console.ReadLine();
                                }
                                Console.WriteLine("Quick sort");
                                watchSort = System.Diagnostics.Stopwatch.StartNew();
                                quickSort.QuickSorting(Array, ref ArrayLength);
                                watchSort.Stop();
                                sortBase.ShowArray(Array, ref ArrayLength);
                                Console.Write($"\nTime: {watchSort.Elapsed}");
                                break;
                            case 8:
                                var mergeSort = new MergeSort();
                                if (isManually == 1)
                                {
                                    sortBase.InputArray(Array, ref ArrayLength);
                                }
                                else
                                {
                                    sortBase.RandomInputArray(Array, ref ArrayLength);
                                    sortBase.ShowArray(Array, ref ArrayLength);
                                    Console.WriteLine("\nPress <Enter> to sort");
                                    Console.ReadLine();
                                }
                                Console.WriteLine("Merge sort");
                                watchSort = System.Diagnostics.Stopwatch.StartNew();
                                mergeSort.MergeSorting(Array, ref ArrayLength);
                                watchSort.Stop();
                                sortBase.ShowArray(Array, ref ArrayLength);
                                Console.Write($"\nTime: {watchSort.Elapsed}");
                                break;
                            default:
                                Console.WriteLine("Invalid method choosing!");
                                break;
                        }
                        check = false;

                        Console.WriteLine("\nRepeat? \n1)yes \n2)no");
                        isContinue = int.Parse(Console.ReadLine());
                        check = false;
                    } while (isContinue == 1);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input!");
                    check = true;
                }
            } while (check);
        }
    }
}