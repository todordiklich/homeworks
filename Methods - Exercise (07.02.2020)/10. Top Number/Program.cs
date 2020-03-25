using System;

namespace _10._Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            TopNumber(number);
        }
        static void TopNumber(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                if (SumDigit(i) % 8 == 0 && OddDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
        static int SumDigit(int number)
        {
            if (number < 10)
            {
                return 1;
            }
            else
            {
                char[] arr = number.ToString().ToCharArray();
                int sum = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    sum += arr[i];
                }
                return sum;
            }
        }
        static bool OddDigit(int number)
        {
            bool isOdd = false;
            char[] digits = number.ToString().ToCharArray();
            for (int i = 0; i < digits.Length; i++)
            {
                if (digits[i] % 2 == 1)
                {
                    isOdd = true;
                    break;
                }
            }
            return isOdd;
        }
    }
}
