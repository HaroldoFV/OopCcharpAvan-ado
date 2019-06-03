using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateFunc
{
    public class Produto
    {
        public int Id;
        public string Nome;
        public double Preco;
        public override string ToString()
        {
            return Id + "-" + Nome + "-" + Preco;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Func<Produto, Produto> func = new Func<Produto, Produto>(Teste);
            Func<Produto, bool> func = new Func<Produto, bool>(p => p.Preco >= 2000);
            List<Produto> prods = new List<Produto>()
            {
                new Produto(){Id=1,Nome="Ipad", Preco=2450.50},
                new Produto(){Id=2,Nome="Iphone", Preco=1500.00},
                new Produto(){Id=3,Nome="Google Glass", Preco=2000.00},
                new Produto(){Id=1,Nome="Dream Theater DVD", Preco=100}
            };
            //foreach (Produto p in prods)
            //    if (Teste(p) != null)
            //        Console.WriteLine(p.Nome);

            //foreach (var p in prods.Select(func))
            foreach (var p in prods.Where(func))
                //if (p != null)
                Console.WriteLine(p);

            Console.ReadLine();
        }

        public static Produto Teste(Produto p)
        {
            if (p.Preco >= 2000)
                return p;
            else
                return null;
        }
    }
}
