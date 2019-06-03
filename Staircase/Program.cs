using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staircase
{
    class Program
    {
        // Complete the staircase function below.
        static void staircase(int n)
        {
            for (int i = 0; i < n; i++)
                Console.WriteLine(new string('#', i + 1).PadLeft(n, ' '));

        }

        static void Main(string[] args)
        {
            //int n = Convert.ToInt32(Console.ReadLine());
            //staircase(n);
            //Console.ReadLine();

            //Int64[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt64(arrTemp));
            //miniMaxSum(arr);



            //int arCount = Convert.ToInt32(Console.ReadLine());

            //int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
            //;
            //int result = birthdayCakeCandles(ar);
            //Console.WriteLine(result);
            //Console.ReadLine();


            //string s = Console.ReadLine();
            //string result = timeConversion(s);
            //Console.WriteLine(result);
            //Console.ReadLine();

            int n = Convert.ToInt32(Console.ReadLine());

            int[] grades = new int[n];

            for (int gradesItr = 0; gradesItr < n; gradesItr++)
            {
                int gradesItem = Convert.ToInt32(Console.ReadLine());
                grades[gradesItr] = gradesItem;
            }

            int[] result = solve(grades);

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }
            Console.ReadLine();
        }

        static int[] solve(int[] grades)
        {
            // Complete this function
            for (int i = 0; i < grades.Length; i++)
            {
                if (grades[i] >= 38)
                {
                    if (grades[i] + (5 - grades[i] % 5) - grades[i] < 3)
                        grades[i] = (grades[i] + (5 - grades[i] % 5));
                }
            }
            return grades;
        }

        static string timeConversion(string s)
        {
            return DateTime.Parse(s).ToString("HH:mm:ss");
        }

        static int birthdayCakeCandles(int[] ar)
        {
            int maior = 0;
            for (int i = 0; i < ar.Length; i++)
                if (ar[i] > maior)
                    maior = ar[i];

            int count = 0;
            for (int i = 0; i < ar.Length; i++)
                if (ar[i] >= maior)
                    count++;

            return count;
        }

        // Complete the miniMaxSum function below.
        static void miniMaxSum(Int64[] arr)
        {
            var maior = arr.Max();
            var menor = arr.Min();

            Int64 somaMinimos = arr.Sum() - maior;
            Int64 somaMaximos = arr.Sum() - menor;

            Console.WriteLine(somaMinimos + " " + somaMaximos);
            Console.ReadLine();
        }
    }
}
