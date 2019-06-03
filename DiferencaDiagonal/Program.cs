using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiferencaDiagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = Convert.ToInt32(Console.ReadLine());
            int[][] array = new int[numero][];
            for (int a_i = 0; a_i < numero; a_i++)
            {
                string[] a_temp = Console.ReadLine().Split(' ');
                array[a_i] = Array.ConvertAll(a_temp, Int32.Parse);
            }

            int totalSum = 0;
            int j = numero - 1;
            for (int i = 0; i < numero; i++)
            {
                totalSum = array[i][i] - array[j][i] + totalSum;
                j--;
            }

            Console.WriteLine(Math.Abs(totalSum));
            Console.ReadLine();
        }
    }
}
