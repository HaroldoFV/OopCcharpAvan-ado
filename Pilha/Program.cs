using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilha
{
    public class Documento
    {
        public int Codigo;
        public string Tipo;
        public string Nome;
    }

    class Program
    {
        static void Main(string[] args)
        {
            // LIFO - Last in First Out
            var d1 = new Documento() { Codigo = 1, Nome = "Planilha", Tipo = "xlz" };
            var d2 = new Documento() { Codigo = 2, Nome = "Artigo", Tipo = "doc" };
            var d3 = new Documento() { Codigo = 3, Nome = "Apresentacao", Tipo = "ppt" };
            var pilha = new Stack<Documento>();
            pilha.Push(d1);
            pilha.Push(d2);
            pilha.Push(d3);
            var obj = pilha.Pop();

            while (pilha.Count > 0)
                Console.WriteLine(pilha.Pop().Nome);
            //Console.WriteLine(pilha.Count);
            //var obj1 = pilha.Pop();
            //Console.WriteLine(obj1.Nome);
            //var obj2 = pilha.Pop();
            //Console.WriteLine(obj2.Nome);
            //Console.WriteLine(pilha.Count);
            //var obj3 = pilha.Peek();
            //Console.WriteLine(obj3.Nome);
            //Console.WriteLine(pilha.Count);
        }
    }
}
