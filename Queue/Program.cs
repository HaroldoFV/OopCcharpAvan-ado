using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    public class Correntista
    {
        public string Agencia;
        public string Conta;
        public string Nome;
        public override string ToString()
        {
            return "Agência: " + Agencia + " - Conta: " + Conta + " - " + Nome;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Correntista() { Agencia = "123", Conta = "456", Nome = "Guinther" };
            var p2 = new Correntista() { Agencia = "456", Conta = "123", Nome = "Rudolfo" };
            var p3 = new Correntista() { Agencia = "789", Conta = "000", Nome = "Fabio" };
            var fila = new Queue<Correntista>();
            fila.Enqueue(p1);
            fila.Enqueue(p2);
            fila.Enqueue(p3);
            //fila.Enqueue(10);
            Console.WriteLine("Correntistas aguardando na fila:");
            foreach (var c in fila)
                Console.WriteLine(c);
            Console.WriteLine("Primeiro da fila: " + fila.Peek().Nome);
            while (fila.Count > 0)
            {
                Console.WriteLine("Pressione uma tecla para chamar correntista");
                Console.ReadKey();
                Console.WriteLine("Chamando: " + fila.Dequeue());
            }
            Console.WriteLine("Fila vazia");
        }
    }

}
