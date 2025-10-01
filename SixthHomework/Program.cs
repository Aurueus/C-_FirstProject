using System;

namespace Test_Project
{
    public class Program
    {
        public static string LettersToBiggerRegister(string text)
        {
            char[] arr = text.ToCharArray();
            bool isBigNext = true;

            for (int i = 0; i < arr.Length; i++)
            {
                if (isBigNext && Char.IsLetter(arr[i]))
                {
                    arr[i] = Char.ToUpper(arr[i]);
                    isBigNext = false;
                }

                if (arr[i] == '.' || arr[i] == '!' || arr[i] == '?')
                {
                    isBigNext = true;
                }
            }

            string result = new string(arr);
            return result;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter text:");
            string input = Console.ReadLine();
            string result = LettersToBiggerRegister(input);
            Console.WriteLine(result);
        }
    }
}
