using System;
using System.Data.Common;

namespace Test_Project
{
    public class Programm
    {
        public static void multiplicationTable(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    Console.Write((i * j).ToString().PadLeft(4));
                }
                Console.WriteLine();
            }
        }

        public static void factorial(int n)
        {
            int sum = 1;
            for (int i = 1; i <= n; i++)
            {
                sum *= i;
            }
            Console.WriteLine(sum);
        }

        public static bool isPalindrome(int n)
        {
            char[] arr = n.ToString().ToCharArray();
            int start = 0;
            int end = arr.Length - 1;
            while (start < end)
            {
                if (!arr[start].Equals(arr[end]))
                    return false;
                start++;
                end--;
            }
            return true;
        }

        public static void fibonacci(int n)
        {
            int a = 0, b = 1;

            for (int i = 0; i < n; i++)
            {
                Console.Write(a + " ");

                int next = a + b;
                a = b;
                b = next;
            }

            Console.WriteLine();
        }

        public static void Main(string[] args)
        {
            //რიცხვების ბეჭდვა (Print Numbers 1–10)
            Console.Write("[");
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("]");
            //რიცხვების ჯამი (Sum of Numbers 1–100)
            int sum = 0;
            for (int i = 1; i <= 100; i++)
            {
                sum += i;
            }
            Console.WriteLine("Sum is: " + sum);
            //კენტი რიცხვების ბეჭდვა (Odd Numbers)
            Console.Write("[");
            for (int i = 1; i < 20; i += 2)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("]");
            //რიცხვის ტაბულა (Multiplication Table)
            Console.WriteLine("Enter number from 1 to 10, or more idc");
            int n = int.Parse(Console.ReadLine());
            multiplicationTable(n);
            //უკუღმა ბეჭდვა (Reverse Numbers)
            Console.Write("[");
            for (int i = 10; i > 0; i--)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("]");
            //რიცხვის ფაქტორიალი (Factorial)
            Console.WriteLine("Enter number: ");
            int a = int.Parse(Console.ReadLine());
            factorial(a);
            //სიმბოლოს გამეორება (Repeat Character)
            for (int i = 0; i < 10; i++)
            {
                Console.Write('*');
            }
            Console.WriteLine();
            //While ციკლი – ჯამი სანამ არ გადავაჭარბებთ
            sum = 0;
            while (sum <= 50)
            {
                Console.Write(sum + " ");
                sum += 7;
            }
            Console.WriteLine();
            //Do-While ციკლი – პაროლ
            string password;
            do
            {
                Console.WriteLine("Enter password(hint: 1234): ");
                password = Console.ReadLine();
            }
            while (password != "1234");
            Console.WriteLine("Correct!");
            //რიცხვის პალინდრომი (Palindrome Number Check)
            Console.WriteLine("Enter a number to see if its a polindrome");
            int numberToCheck = int.Parse(Console.ReadLine());
            // უფრო ადვილი და ლოგიკური იქნებოდა, თუ input მნიშვნელობა string-ი ყოფილიყო,
            // მაგრამ პირობაში რიცხვი ეწერა, ამიტომ დავწერე int
            if (isPalindrome(numberToCheck))
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not Palindrome");
            }
            //რიცხვების ფიბონაჩის მიმდევრობა (Fibonacci Sequence)
            Console.WriteLine("Enter number: ");
            int x = int.Parse(Console.ReadLine());
            fibonacci(x);
        }
    }
}