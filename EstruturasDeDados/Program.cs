using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturasDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Stack(Pilha)
            //Stack<string> nomeDaVariavel = new Stack<string>();

            //nomeDaVariavel.Push("grade de cuca 00");
            //nomeDaVariavel.Push("grade de cuca 01");
            //nomeDaVariavel.Push("grade de cuca 02");
            //nomeDaVariavel.Push("grade de cuca 03");
            //nomeDaVariavel.Push("grade de cuca 04");
            //nomeDaVariavel.Push("grade de cuca 05");

            //// Remove dois elementos da pilha
            //Console.WriteLine(nomeDaVariavel.Pop());
            //Console.WriteLine(nomeDaVariavel.Pop());


            // Queue(fila)
            Queue<string> filaDoBanco = new Queue<string>();

            // 1° da fila
            filaDoBanco.Enqueue("Sousa Gaspar");
            //2º da fila
            filaDoBanco.Enqueue("Dumilda Yordanca");
            //3º da fila
            filaDoBanco.Enqueue("João Leitão");
            //4º da fila
            filaDoBanco.Enqueue("Jose Antonio");
            //5º da fila
            filaDoBanco.Enqueue("Josenio Caxicula");

            //Retira uma pessoa da fila
            Console.WriteLine(filaDoBanco.Dequeue());

            //e mais uma
            Console.WriteLine(filaDoBanco.Dequeue());

            //e mais outra
            Console.WriteLine(filaDoBanco.Dequeue());

            //Retorna o numero de pessoas na fila
            Console.WriteLine(filaDoBanco.Count);


            //Digit dig = new Digit(7);
            ////This call invokes the implicit "double" operator
            //double num = dig;
            ////This call invokes the implicit "Digit" operator
            //Digit dig2 = 12;
            //Console.WriteLine("num = {0} dig2 = {1}", num, dig2.val);
            //Console.ReadLine();

        }

        //class Digit
        //{
        //    public Digit(double d) { val = d; }
        //    public double val;
        //    // ...other members

        //    // User-defined conversion from Digit to double
        //    public static implicit operator double(Digit d)
        //    {
        //        return d.val;
        //    }
        //    //  User-defined conversion from double to Digit
        //    public static implicit operator Digit(double d)
        //    {
        //        return new Digit(d);
        //    }
        //}
    }
}
