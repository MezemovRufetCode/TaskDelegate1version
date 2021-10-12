using System;
namespace TaskDelegate
{
    class Program
    {
        delegate void Checkher(int number);
        static void Main(string[] args)
        {
            Checkher checkher1 = new Checkher(Find);
            Console.WriteLine("Include test number:");
            int num = int.Parse(Console.ReadLine());
            checkher1.Invoke(num);

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
