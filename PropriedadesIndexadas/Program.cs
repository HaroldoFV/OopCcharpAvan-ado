using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropriedadesIndexadas
{
    public class Produtos
    {
        private List<string> _itens;
        public Produtos()
        {
            this._itens = new List<string>();
        }
        public void Add(string item)
        {
            this._itens.Add(item);
        }
        public string Get(int index)
        {
            return this._itens[index];
        }
        // propriedade indexada
        public string this[int index]
        {
            get
            {
                // return this._itens[index];
                return this._itens[index];
            }
        }
        public int this[string nome]
        {
            get
            {
                return this._itens.IndexOf(nome);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var prods = new Produtos();
            prods.Add("IPhone");
            prods.Add("IPad");
            prods.Add("IPod");
            Console.WriteLine(prods[0]);
            Console.WriteLine(prods[1]);
            Console.WriteLine(prods[2]);
            Console.WriteLine("A posição do item IPAD é " + prods["IPad"]);
            Console.ReadLine();
        }
    }
}
