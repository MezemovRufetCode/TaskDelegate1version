using System;
namespace TaskDelegate
{
    class Program
    {
        public delegate void Checkher<T>(T number);
        static void Main(string[] args)
        {
            Console.WriteLine("Include number for to check negative or not:");
            int num = int.Parse(Console.ReadLine());
            Action<int> act1 = CheckNegative;
            act1.Invoke(num);
            Console.WriteLine();

            Console.WriteLine("Include a number for check prime or not:");
            int num2 = int.Parse(Console.ReadLine());
            Action<int> act2 = FindPrime;
            act2.Invoke(num2);
            Console.WriteLine();

            //Iki cur yazdim bilmedim hansini isteyirsiz,bu hisseye uygun funksiya da comment kimi qeyd olunub.
            #region Even or Odd 1 version
            //Console.WriteLine("Include a number for check is Odd or not:");
            //int num3 = int.Parse(Console.ReadLine());
            //Predicate<int> predicate = IsOdd;
            //Console.WriteLine(predicate.Invoke(num3));
            //Console.WriteLine();

            //Console.WriteLine("Include a number for check is Even or not:");
            //int num4 = int.Parse(Console.ReadLine());
            //Predicate<int> predicate1 = IsEven;
            //Console.WriteLine(predicate1.Invoke(num4));
            //Console.ReadLine();
            #endregion

            Console.WriteLine("Include a number for check is Even or Odd:");
            int num3 = int.Parse(Console.ReadLine());
            Action<int> act3 = CheckEvenOdd;
            act3.Invoke(num3);
            Console.WriteLine();
        }
        public static void FindPrime(int num2)
        {
            int count = 0;
            if (num2 == 1 || num2 == 0)
            {
                Console.WriteLine(num2+" is not prime or composite");
            }
            else
                if (num2 > 1)
            {
                for (int i = 2; i*i <= num2; i++)
                {
                    if (num2%i==0)
                    {
                        count++;
                    }
                }
                if (count == 0)
                {
                    Console.WriteLine(num2 + " is prime");
                }
                else
                if (count > 0)
                {
                    Console.WriteLine(num2 + " is not prime");
                }
            }
        }
        public static void CheckNegative (int num1)
        {
            if (num1 < 0)
            {
                Console.WriteLine(num1+" is negative");
            }
            else
                Console.WriteLine(num1+" is not negative");
        }
        public static void CheckEvenOdd(int num1)
        {
            if (num1 != 0) { 
            if (num1 % 2 == 0)
            {
                Console.WriteLine(num1 + " is even");
            }
            else
                Console.WriteLine(num1 + " is odd");}
            else Console.WriteLine(num1+" is not even or odd.");
        }
        //Yuxarida commente alinmis regionun methodu
        #region Even or Odd version 1 method
        //public static bool IsOdd(int num)
        //{
        //    return num % 2 == 1;
        //}
        //public static bool IsEven(int num1)
        //{
        //    return num1 % 2 == 0;       
        //}
        #endregion
    }
}
