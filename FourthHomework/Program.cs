using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace Test_Project
{
    public class Programm
    {
        public static int linearSearch(int[] arr, int x)
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
        public static int[] rotateLeft(int[] arr, int n)
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

        public static int[] rotateRight(int[] arr, int n)
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

        public static int[] bubbleSort(int[] arr)
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

        public static void printArray(int[] arr)
        {
            Console.Write("[ ");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("]");

        }

        public static int[] mergeArrays(int[] arr1, int[] arr2)
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
            bubbleSort(mergedArray);
            return mergedArray;
        }

        public static int[] insertElement(int[] arr, int element, int position)
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

        public static int[] deleteElement(int[] arr, int element)
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

        public static void findPairsWithSum(int[] arr, int target)
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

        public static bool isPalindrome(int[] arr)
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

        public static int findMissingNum(int[] arr)
        {
            bubbleSort(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != i + 1)
                {
                    return i + 1;
                }
            }
            return -1;
        }

        public static void countConsecutiveDuplicates(int[] arr)
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


        public static void Main(string[] args)
        {
            int[] numbers = [5, 12, 7, 15, 20, 3, 15, 8, 9, 12, 7, 11];
            //Print Array Elements
            printArray(numbers);
            //Find Maximum Element
            int max = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            Console.WriteLine("\nMax is: " + max);
            //Find Minimum Elemen
            int min = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (min > numbers[i])
                {
                    min = numbers[i];
                }
            }
            Console.WriteLine("Min is: " + min);
            //Sum of Array Elements
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine("Sum is: " + sum);
            //Reverse Array
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                Console.Write(numbers[i] + " ");
            }
            //Count Even and Odd Numbers
            int even = 0;
            int odd = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 1)
                {
                    odd++;
                }
                else
                {
                    even++;
                }
            }
            Console.WriteLine("\nOdd numbers in array: " + odd);
            Console.WriteLine("Even numbers in array: " + even);
            //Search Element in Array
            Console.WriteLine("Enter number you want to find in array: ");
            int x = int.Parse(Console.ReadLine());
            int index = linearSearch(numbers, x);
            if (index == -1)
            {
                Console.WriteLine($"{x} wasn't found in array");
            }
            else
            {
                Console.WriteLine($"{x} was found at index {index}");
            }
            //Copy Array
            int[] copyArr = new int[numbers.Length];
            Console.WriteLine("Copied array: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                copyArr[i] = numbers[i];
                Console.Write(copyArr[i] + " ");
            }
            //Second Largest Number
            int secondMax = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > secondMax && numbers[i] < max)
                {
                    secondMax = numbers[i];
                }
            }
            Console.WriteLine("\nSecond largest number in array is: " + secondMax);
            //Frequency of Elements
            HashSet<int> set = new HashSet<int>(numbers);
            int[] arr = set.ToArray();
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (numbers[j] == arr[i])
                    {
                        count++;
                    }
                }
                Console.WriteLine($"{arr[i]} was met {count} times");
                count = 0;
            }

            //Array Rotation
            int[] beautifulArr = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12];
            while (true)
            {
                Console.WriteLine("Enter 'L' to rotate left, 'R' to rotate right, or 'X' to exit: ");
                string choice = Console.ReadLine();
                choice = choice.ToUpper();

                if (choice.Equals("X"))
                {
                    Console.WriteLine("Exiting program.");
                    break;
                }

                if (!choice.Equals("L") && !choice.Equals("R"))
                {
                    Console.WriteLine("Invalid choice! Please enter 'L', 'R', or 'X'.");
                    continue;
                }

                Console.WriteLine("Enter number of positions to rotate: ");
                string input = Console.ReadLine();

                try
                {
                    int n = int.Parse(input);

                    if (choice == "L")
                    {
                        beautifulArr = rotateLeft(beautifulArr, n);
                    }
                    else
                    {
                        beautifulArr = rotateRight(beautifulArr, n);
                    }

                    Console.WriteLine("Array after rotation: ");
                    printArray(beautifulArr);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            //Sort Array Without Built-in Sort
            numbers = bubbleSort(numbers);
            Console.WriteLine("Sorted array: ");
            printArray(numbers);
            //Remove Duplicates
            HashSet<int> noDuplicates = new HashSet<int>(numbers);
            int[] numbersWithNoDuplicates = noDuplicates.ToArray();
            Console.WriteLine("Array after duplicates got removed: ");
            printArray(numbersWithNoDuplicates);
            //Merge Two Arrays
            int[] merge = mergeArrays(numbers, beautifulArr);
            Console.WriteLine("Merged array: ");
            printArray(merge);
            //Insert Element in Array
            numbers = insertElement(numbers, 23, 3);
            Console.WriteLine("Array after we added element: ");
            printArray(numbers);
            //Delete Element from Arr
            numbers = deleteElement(numbers, 5);
            Console.WriteLine("Array after element got deleted: ");
            printArray(numbers);
            //Find Pairs with Given Sum
            Console.WriteLine("Elements with sum of 20: ");
            findPairsWithSum(numbers, 20);
            //Check if Array is Palindrome
            int[] paliArr = [1, 2, 3, 2, 1];
            printArray(paliArr);
            if (isPalindrome(paliArr))
            {
                Console.WriteLine("This array is palindrome!!!");
            }
            else
            {
                Console.WriteLine("This array is not palindrome!!");
            }
            //Find Missing Number
            int[] arrWithMissingNum = [5, 2, 4, 1];
            if (findMissingNum(arrWithMissingNum) == -1)
            {
                Console.WriteLine("No number is missing");
            }
            else
            {
                Console.WriteLine("Missing number is: " + findMissingNum(arrWithMissingNum));
            }
            //Count Consecutive Duplicate
            numbers = [1, 1, 2, 2, 2, 3, 3, 3, 3, 2, 2 ];
            printArray(numbers);
            countConsecutiveDuplicates(numbers);
        }
    }
}