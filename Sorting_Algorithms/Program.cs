using System;

namespace Sorting_Algorithms
{
    class Program
    {

        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        /// Bubble Sort
        static void BubbleSort1(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        Swap(ref arr[j], ref arr[j + 1]);
                    }
                }
            }
        }

        static void BubbleSort2(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        Swap(ref arr[i], ref arr[j]);
                    }
                }
            }
        }

        static void BubbleSortRecursive(int[] arr, int n)
        {
            if (n == 0 || n == 1) return;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i + 1])
                {

                    Swap(ref arr[i], ref arr[i + 1]);
                }
            }
            BubbleSortRecursive(arr, n - 1);
        }

        static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "\t");
            }
            Console.WriteLine();
        }
        /// Merger Sort

        static void MergeSort(int[] arr, int left, int middle, int right)
        {
            int leftArrLength = middle - left + 1;
            int rightArrLength = right - middle;

            int[] leftArr = new int[leftArrLength];
            int[] rightArr = new int[rightArrLength];

            int i, j;

            for (i = 0; i < leftArr.Length; i++)
            {
                leftArr[i] = arr[left + i];
            }
            for (j = 0; j < rightArr.Length; j++)
            {
                rightArr[j] = arr[middle + j + 1];
            }
            i = 0;
            j = 0;
            int k = left;
            while (i < leftArr.Length && j < rightArr.Length)
            {
                if (leftArr[i] <= rightArr[j])
                {
                    arr[k] = leftArr[i];
                    i++;
                }
                else
                {
                    arr[k] = rightArr[j];
                    j++;
                }
                k++;
            }

            while (i < leftArr.Length)
            {
                arr[k] = leftArr[i];
                i++;
                k++;
            }

            while (j < rightArr.Length)
            {
                arr[k] = rightArr[j];
                j++;
                k++;
            }
        }

        static void Sort_Merge(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int middle = left + (right - left) / 2;

                Sort_Merge(arr, left, middle);
                Sort_Merge(arr, middle + 1, right);

                MergeSort(arr, left, middle, right);
            }
        }

        //  Selection Sort
        static void SelectionSort(int[] arr)
        {
            int min;                                        //  0   1   2   3   4   5   6   7   
            for (int i = 0; i < arr.Length; i++)              //  1   5   4   9   15  0   2   -6
            {
                min = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[min] > arr[j])
                    {
                        min = j;
                    }
                }
                Swap(ref arr[i], ref arr[min]);
            }
        }

        //Quick Sort
        public static void QuickSort(int[]arr, int leftIndex, int rightIndex)
        {
            int i = leftIndex;
            int j = rightIndex;
            int pivot = arr[leftIndex];

            while (i < j)
            {
                while (arr[i] < pivot)
                {
                    i++;
                }
                while (arr[j] > pivot)
                {
                    j--;
                }

                if (i <= j)
                {
                    Swap(ref arr[i], ref arr[j]);
                    i++;
                    j--;
                }
            }

            if (leftIndex < j)
            {
                QuickSort(arr, leftIndex, j);
            }
            if (i<rightIndex)
            {
                QuickSort(arr, i, rightIndex);
            }
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 5, 4, 9, 15, 0, 2, -6, 5 };
            /*
            BubbleSort1(arr);
            PrintArray(arr);
            */
            /*
            BubbleSort2(arr);
            PrintArray(arr);
            */

            /*
            BubbleSortRecursive(arr, arr.Length);
            PrintArray(arr);
            */

            /*
            Sort_Merge(arr, 0, arr.Length - 1);
            PrintArray(arr);
            */

            /*
            SelectionSort(arr);
            PrintArray(arr);
            */

            /*
            QuickSort(arr, 0, arr.Length - 1);
            PrintArray(arr);
            */


        }
    }
}
