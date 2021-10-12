using System;
namespace TaskDelegate
{
    class Program
    {
        public delegate void Checkher<T>(T number);
        static void Main(string[] args)
        {
            Console.WriteLine("Include test number:");
            int num = int.Parse(Console.ReadLine());
            Action<int> act1 = Find;
            act1.Invoke(num);
        }
        public static void Find (int num1)
        {
            if (CheckNegative(num1))
            {
                Console.WriteLine(num1 + " is negative.");
            }
            else
                Console.WriteLine(num1+ " is not negative.");
        }
        public static bool CheckNegative (int num1)
        {
            return num1 < 0;
        }
    }
}
