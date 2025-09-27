using System;
using System.Runtime.InteropServices;

namespace Test_Project
{
    public class Programm
    {
        public static int LinearSearch(int[] arr, int x)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == x)
                {
                    return i;
                }
            }
            return -1;
        }
        public static int[] RotateLeft(int[] arr, int n)
        {
            int[] newArr = new int[arr.Length];
            int pos = n % arr.Length;
            for (int i = 0; i < arr.Length - pos; i++)
            {
                newArr[i] = arr[i + pos];
            }
            for (int i = 0; i < pos; i++)
            {
                newArr[arr.Length - pos + i] = arr[i];
            }

            return newArr;
        }

        public static int[] RotateRight(int[] arr, int n)
        {
            int[] newArr = new int[arr.Length];
            int pos = n % arr.Length;
            for (int i = 0; i < pos; i++)
            {
                newArr[i] = arr[arr.Length - pos + i];
            }
            for (int i = 0; i < arr.Length - pos; i++)
            {
                newArr[i + pos] = arr[i];
            }

            return newArr;
        }

        public static int[] BubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            return arr;
        }

        public static void PrintArray(int[] arr)
        {
            Console.Write("[ ");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("]");

        }

        public static int[] MergeArrays(int[] arr1, int[] arr2)
        {
            int[] mergedArray = new int[arr1.Length + arr2.Length];
            for (int i = 0; i < arr1.Length; i++)
            {
                mergedArray[i] = arr1[i];
            }
            int count = 0;
            for (int i = arr1.Length; i < arr1.Length + arr2.Length; i++)
            {
                mergedArray[i] = arr2[count];
                count++;
            }
            BubbleSort(mergedArray);
            return mergedArray;
        }

        public static int[] InsertElement(int[] arr, int element, int position)
        {
            if (position < 0 || position > arr.Length)
            {
                Console.WriteLine("Invalid position!!!");
                return arr;
            }

            int[] newArr = new int[arr.Length + 1];

            for (int i = 0; i < position; i++)
            {
                newArr[i] = arr[i];
            }

            newArr[position] = element;

            for (int i = position; i < arr.Length; i++)
            {
                newArr[i + 1] = arr[i];
            }


            return newArr;
        }

        public static int[] DeleteElement(int[] arr, int element)
        {
            int index = -1;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == element)
                {
                    index = i;
                    break;
                }
            }

            if (index == -1)
            {
                return arr;
            }

            int[] newArr = new int[arr.Length - 1];

            for (int i = 0; i < index; i++)
            {
                newArr[i] = arr[i];
            }

            for (int i = index + 1; i < arr.Length; i++)
            {
                newArr[i - 1] = arr[i];
            }

            return newArr;
        }

        public static void FindPairsWithSum(int[] arr, int target)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] + arr[j] == target)
                    {
                        Console.WriteLine($"{arr[i]} + {arr[j]} = {target}");
                    }
                }
            }
        }

        public static bool IsPalindrome(int[] arr)
        {
            int i = 0;
            int j = arr.Length - 1;

            while (i < j)
            {
                if (arr[i] != arr[j])
                {
                    return false;
                }
                i++;
                j--;
            }
            return true;
        }

        public static int FindMissingNum(int[] arr)
        {
            BubbleSort(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != i + 1)
                {
                    return i + 1;
                }
            }
            return -1;
        }

        public static void CountConsecutiveDuplicates(int[] arr)
        {
            int maxElement = arr[0];
            int maxCount = 1;

            int currentElement = arr[0];
            int currentCount = 1;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] == currentElement)
                {
                    currentCount++;
                }
                else
                {
                    currentElement = arr[i];
                    currentCount = 1;
                }

                if (currentCount > maxCount)
                {
                    maxCount = currentCount;
                    maxElement = currentElement;
                }
            }

            Console.WriteLine(maxElement + " appears " + maxCount + " times in a row.");
        }

        public static (int min, int max) FindMinMax(int[] arr)
        {
            int min = arr[0];
            int max = arr[0];

            foreach (int num in arr)
            {
                if (num < min) min = num;
                if (num > max) max = num;
            }

            return (min, max);
        }

        public static int SumArray(int[] arr)
        {
            int sum = 0;
            foreach (int num in arr)
            {
                sum += num;
            }
            return sum;
        }

        public static void ReverseArray(int[] arr)
        {
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        public static (int even, int odd) CountEvenOdd(int[] arr)
        {
            int even = 0, odd = 0;
            foreach (int num in arr)
            {
                if (num % 2 == 0) even++;
                else odd++;
            }
            return (even, odd);
        }

        public static int SecondLargest(int[] arr)
        {
            (int min, int max) = FindMinMax(arr);
            int secondMax = arr[0];
            foreach (int num in arr)
            {
                if (num > secondMax && num < max)
                {
                    secondMax = num;
                }
            }
            return secondMax;
        }

        public static void Frequency(int[] arr)
        {
            HashSet<int> set = new HashSet<int>(arr);
            int[] unique = set.ToArray();
            foreach (int num in unique)
            {
                int count = 0;
                foreach (int el in arr)
                {
                    if (el == num) count++;
                }
                Console.WriteLine($"{num} was met {count} times");
            }
        }

        public static void Main(string[] args)
        {
            int[] arr = [ 5, 12, 7, 15, 20 ];

            //1) Print Array Elements
            Console.WriteLine("Array elements:");
            PrintArray(arr);

            //2) Find Maximum Element
            (int min, int max) = FindMinMax(arr);
            Console.WriteLine("Maximum element: " + max);

            //3) Find Minimum Element
            Console.WriteLine("Minimum element: " + min);

            //4) Sum of Array Elements
            int sum = SumArray(arr);
            Console.WriteLine("Sum of array elements: " + sum);

            //5) Reverse Array
            Console.WriteLine("Reversed array:");
            ReverseArray(arr);

            //6) Count Even and Odd Numbers
            (int even, int odd) = CountEvenOdd(arr);
            Console.WriteLine("Even count: " + even + ", Odd count: " + odd);

            //7) Search Element in Array
            Console.WriteLine("Enter a number to search:");
            int searchNum = int.Parse(Console.ReadLine());
            int index = LinearSearch(arr, searchNum);
            if (index != -1) Console.WriteLine("Found at index " + index);
            else Console.WriteLine("Not found");

            //8) Copy Array
            int[] copy = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++) copy[i] = arr[i];
            Console.WriteLine("Copied array:");
            PrintArray(copy);

            //9) Second Largest Number
            int secondLargest = SecondLargest(arr);
            Console.WriteLine("Second largest number: " + secondLargest);

            //10) Frequency of Elements
            Console.WriteLine("Frequency of elements:");
            Frequency(arr);

            //Middle-Level Array & Loop Exercises (C#)

            //1) Array Rotation
            Console.WriteLine("Rotate Left by 2:");
            PrintArray(RotateLeft(arr, 2));
            Console.WriteLine("Rotate Right by 2:");
            PrintArray(RotateRight(arr, 2));

            //2) Sort Array Without Built-in Sort
            Console.WriteLine("Sorted array (Bubble Sort):");
            PrintArray(BubbleSort((int[])arr.Clone()));

            //3) Remove Duplicates
            Console.WriteLine("Array without duplicates:");
            HashSet<int> set = new HashSet<int>(arr);
            int[] unique = new int[set.Count];
            set.CopyTo(unique);
            PrintArray(unique);

            //4) Merge Two Arrays
            int[] arr2 = [ 2, 8, 25 ];
            Console.WriteLine("Merged array:");
            PrintArray(MergeArrays(arr, arr2));

            //5) Insert Element in Array
            Console.WriteLine("Insert 99 at position 2:");
            PrintArray(InsertElement(arr, 99, 2));

            //6) Delete Element from Array
            Console.WriteLine("Delete element 7:");
            PrintArray(DeleteElement(arr, 7));

            //7) Find Pairs with Given Sum
            Console.WriteLine("Pairs with sum 27:");
            FindPairsWithSum(arr, 27);

            //8) Check if Array is Palindrome
            Console.WriteLine("Is array palindrome? " + IsPalindrome(arr));

            //9) Find Missing Number
            int[] arrWithMissing = [ 1, 2, 3, 5 ];
            Console.WriteLine("Missing number: " + FindMissingNum(arrWithMissing));

            //10) Count Consecutive Duplicates
            int[] arrWithDup = [ 1, 1, 2, 2, 2, 3 ];
            CountConsecutiveDuplicates(arrWithDup);
        }

    }
}