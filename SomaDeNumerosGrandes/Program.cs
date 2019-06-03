using System;
using System.Linq;

namespace SomaDeNumerosGrandes
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = Convert.ToInt32(Console.ReadLine());
            long[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt64(arTemp));

            long result = ar.Sum();


            Console.WriteLine(result);
            Console.ReadLine();

            //SomarArray();
            //SomarArrayComAcumulador();
            //SomarArrayComForeach();
        }

        public static void SomarArray()
        {
            int[] numbers = { 5, 8, 4 };
            var result = numbers.Sum();
            Console.WriteLine(result);
            Console.ReadLine();
        }

        public static void SomarArrayComAcumulador()
        {
            int[] numbers = { 5, 8, 4 };
            int result = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                result += numbers[i];
            }

            Console.WriteLine(result);
            Console.ReadLine();
        }

        public static void SomarArrayComForeach()
        {
            int[] numbers = { 5, 8, 4 };
            int result = 0;
            foreach (var item in numbers)
            {
                result += item;
            }

            Console.WriteLine(result);
            Console.ReadLine();
        }


        //static long aVeryBigSum(int n, long[] ar)
        //{
        //    // Complete this function
        //    Int64 total = 0;

        //    for (int i = 0; i < n; i++)
        //    {
        //        total += ar[i];
        //    }
        //    return total;

        //}
        //static void Main(String[] args)
        //{
        //    int n = Convert.ToInt32(Console.ReadLine());
        //    string[] ar_temp = Console.ReadLine().Split(' ');
        //    long[] ar = Array.ConvertAll(ar_temp, Int64.Parse);
        //    long result = aVeryBigSum(n, ar);
        //    Console.WriteLine(result);
        //    Console.ReadLine();
        //}
    }
}
