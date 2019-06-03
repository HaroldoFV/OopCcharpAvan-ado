using System;

namespace ValueRef
{
    public class PosicaoClass // reference type
    {
        public int X;
        public int Y;
    }

    class Program
    {
        public static void Dobrar(ref int valor)// passando valor como referência
        {
            valor = valor * 2;
        }

        public static void DobrarRefType(PosicaoClass valor)// passando valor como referência
        {
            valor.X = valor.X * 2;
            valor.Y = valor.Y * 2;
        }

        static void Main(string[] args)
        {
            PosicaoClass pos1 = new PosicaoClass();
            pos1.X = 10;
            pos1.Y = 20;

            PosicaoClass pos2 = new PosicaoClass();
            pos2.X = 30;
            pos2.Y = 40;
            DobrarRefType(pos1);
            DobrarRefType(pos2);
            Console.WriteLine(pos1.X);
            Console.WriteLine(pos1.Y);
            Console.WriteLine(pos2.X);
            Console.WriteLine(pos2.Y);
            Console.ReadLine();
        }

        private static void DobrarValor()
        {
            int x = 10;
            Dobrar(ref x);// passando valor como referência
            Console.WriteLine(x);
        }

        private static void RefTypeInt()
        {
            PosicaoClass pos1 = new PosicaoClass();
            pos1.X = 10;
            pos1.Y = 20;

            PosicaoClass pos2 = new PosicaoClass();
            pos2.X = 30;
            pos2.Y = 40;
            pos2 = pos1; // apontando ambos para a mesma posição de memória
            pos2.X = 50;
            Console.WriteLine(pos1.X);
            Console.WriteLine(pos1.Y);
            Console.WriteLine(pos2.X);
            Console.WriteLine(pos2.Y);
        }

        private static void ValueTypeInt()
        {
            int x = 10;
            int y = 20;
            y = x; // cópia do 
            Console.WriteLine(x);
            Console.WriteLine(y);
        }
    }
}
