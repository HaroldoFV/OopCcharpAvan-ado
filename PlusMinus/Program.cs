using System;
using System.Linq;

namespace PlusMinus
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = Double.Parse(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
            ;
            plusMinus(arr, n);

            //var n = Double.Parse(Console.ReadLine());
            //var a = Console.ReadLine().Split(' ').Select(val => Int32.Parse(val));

            //Console.WriteLine(a.Count(val => val > 0) / n);
            //Console.WriteLine(a.Count(val => val < 0) / n);
            //Console.WriteLine(a.Count(val => val == 0) / n);
            //Console.ReadLine();
        }

        static void plusMinus(int[] arr, Double n)
        {
            var positive = 0;
            var negative = 0;
            var zero = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    positive += 1;
                }
                else if (arr[i] < 0)
                {
                    negative += 1;
                }
                else
                {
                    zero += 1;
                }
            }

            Console.WriteLine(Math.Round((positive / n), 6));
            Console.WriteLine(Math.Round((negative / n), 6));
            Console.WriteLine(Math.Round((zero / n), 6));
            Console.ReadLine();

        }
    }
}
