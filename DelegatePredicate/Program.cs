using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatePredicate
{
    class Program
    {
        public class Pessoa
        {
            public string Nome;
            public int Idade;
        }

        static void Main(string[] args)
        {
            List<Pessoa> Nomes = new List<Pessoa>()
            {
                new Pessoa(){ Nome = "Guinther", Idade = 35 },
                new Pessoa(){ Nome = "Rodolfo", Idade = 20 },
                new Pessoa(){ Nome = "Michael", Idade = 18 },
                new Pessoa(){ Nome = "Ronaldo", Idade = 26 }
            };
            //Predicate<Pessoa> pred = new Predicate<Pessoa>(Contains);
            Predicate<Pessoa> pred = new Predicate<Pessoa>(p => p.Idade >= 35);
            var lst = Nomes.FindAll(pred);
            foreach (var s in lst)
                Console.WriteLine(s.Nome);

            //foreach (var s in Nomes)
            //    if (Contains(s))
            //        Console.WriteLine(s);
            Console.ReadLine();
        }

        //public static string st = "i";

        public static bool Contains(Pessoa p)
        {
            //return arg.Contains(st);
            return p.Idade >= 30;
        }
    }
}


