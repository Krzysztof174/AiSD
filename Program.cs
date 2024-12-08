using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void bubbleSort(int[] array)
        {
            bool sorted = false;
            while(!sorted)
            {
                sorted = true;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        int temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                        sorted = false;
                    }
                }
            }
        }
        static void insertionSort(int[] arr)
        {
            for(int i = 1; i < arr.Length; i++)
            {
                int temp = arr[i];
                int j;
                for(j = i - 1; j >= 0; j--)
                {
                    if (arr[j] > temp)
                    {
                        arr[j + 1] = arr[j];
                    }
                    else
                    {
                        arr[j + 1] = temp;
                        break;
                    }
                }
                if (j == -1)
                {
                    arr[0] = temp;
                }
            }
        }
        static void selectionSort(int[] arr)
        {
            for(int i = 0; i < arr.Length;i++)
            {
                int minNumber = arr[i];
                int minIndex = i;
                for(int z = i; z < arr.Length; z++)
                {
                    if(arr[z] < minNumber )
                    {
                        minNumber = arr[z];
                        minIndex = z;
                    }
                }

                arr[minIndex] = arr[i];
                arr[i] = minNumber;
            }
        }
        static void countingSort(int[] arr)
        {
            int max = 0;
            for(int i = 0;i < arr.Length;i++)
            {
                if(arr[i] > max )
                {
                    max = arr[i];
                }
            }

            int[] occurences = new int[max+1];

            for (int i = 0; i < arr.Length; i++)
            {
                occurences[arr[i]]++;
            }

            int index = 0;
            for (int i = 0; i < occurences.Length; i++)
            {
                while (occurences[i] > 0)
                {
                    arr[index] = i;
                    index++;
                    occurences[i]--;
                }
            }
        }
        static void quickSort(int[] arr, int left, int right)
        {
            if(left >= right)
            {
                return;
            }
            int i = left - 1;
            int pivot = arr[right];

            for(int j = left; j < arr.Length; j++)
            {
                if(arr[j] >= pivot)
                {
                    continue;
                }

                i++;
                int temp = arr[j];
                arr[j] = arr[i];
                arr[i] = temp;
            }
            i++;
            arr[right] = arr[i];
            arr[i] = pivot;
            quickSort(arr, left, i - 1);
            quickSort(arr, i + 1, right);
        }
        static int[] MergeAddArrays(int[] arr1, int[] arr2)
        {
            int[] addedArray = new int[arr1.Length + arr2.Length];
            int i = 0;
            int j = 0;
            while (i + j < arr1.Length + arr2.Length)
            {
                if (i == arr1.Length)
                {
                    addedArray[i + j] = arr2[j];
                    j++;
                    continue;
                }
                if (j == arr2.Length)
                {
                    addedArray[i + j] = arr1[i];
                    i++;
                    continue;
                }
                if (arr1[i] < arr2[j])
                {
                    addedArray[i + j] = arr1[i];
                    i++;
                }
                else
                {
                    addedArray[i + j] = arr2[j];
                    j++;
                }
            }

            return addedArray;
        }
        static int[] MergeSort(int[] arr)
        {
            int[] mergedArray = new int[arr.Length];
            if (arr.Length == 1)
            {
                return arr;
            }
            if (arr.Length == 2)
            {
                if (arr[0] > arr[1])
                {
                    int temp = arr[0];
                    arr[0] = arr[1];
                    arr[1] = temp;
                }
                return arr;
            }

            int[] leftSide;
            int[] rightSide;
            if (arr.Length % 2 == 0)
            {
                leftSide = new int[arr.Length / 2];
                for (int i = 0; i < arr.Length / 2; i++)
                {
                    leftSide[i] = arr[i];
                }

                rightSide = new int[arr.Length / 2];
                for (int i = 0; i + arr.Length / 2 < arr.Length; i++)
                {
                    rightSide[i] = arr[arr.Length / 2 + i];
                }
            }
            else
            {
                leftSide = new int[(arr.Length - 1) / 2];
                for (int i = 0; i < (arr.Length - 1) / 2; i++)
                {
                    leftSide[i] = arr[i];
                }

                rightSide = new int[(arr.Length - 1) / 2 + 1];
                for (int i = 0; i + (arr.Length - 1) / 2 < arr.Length; i++)
                {
                    rightSide[i] = arr[(arr.Length - 1) / 2 + i];
                }
            }
            int[] leftMerged = MergeSort(leftSide);
            int[] rightMerged = MergeSort(rightSide);
            mergedArray = MergeAddArrays(leftMerged, rightMerged);
            return mergedArray;
        }

        static void Main(string[] args)
        {
            int[] array = { 5, 4, 2, 3, 9, 9, 1, 3, 2 };
            quickSort(array, 0, 8);
            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }    
            Console.WriteLine(3/2);
        }
    }
}
