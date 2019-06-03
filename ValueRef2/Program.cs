using System;
using System.Text;

namespace ValueRef2
{
    public class Cliente : Object // References Type
    {
        public int Codigo;
        public string Nome;
        public string Telefone;

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Codigo: " + Codigo);
            sb.AppendLine("Nome: " + Nome);
            sb.AppendLine("Telefone: " + Telefone);
            return sb.ToString();
        }

    }

    class Program
    {
        public static void MostrarValueTypes()
        {
            int x = 10;
            string s = "haroldo";
            bool b = false;
            Console.WriteLine(x);
            Console.WriteLine(s);
            Console.WriteLine(b);
        }

        static void Main(string[] args)
        {
            Cliente c1 = new Cliente();
            c1.Codigo = 123;
            c1.Nome = "Haroldo";
            c1.Telefone = "999999999";
            Cliente c2 = new Cliente();

            //c2 = c1; // aponta para a mesma posição de memória c1
            c2.Nome = "Ronaldo";
            Console.WriteLine(c1);
            Console.WriteLine(c2);
            if (c1.Equals(c2))
            {
                Console.WriteLine("c1 e c2 são os mesmos objetos");
            }
            else
            {
                Console.WriteLine("c1 e c2 são objetos diferentes");
            }
            //Console.WriteLine(c.Codigo);
            //Console.WriteLine(c.Nome);
            //Console.WriteLine(c.Telefone);

            Console.ReadLine();
        }
    }
}
