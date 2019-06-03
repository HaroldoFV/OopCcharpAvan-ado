using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            //var pedido = new Pedido();
            //pedido.Fechar(2000);
            //Console.ReadLine();

            //var pedido = new Pedido();
            //pedido.Pagar += pedido_Pagar;
            ////pedido.Pagar += pedido_Pagar_Cartao;
            //pedido.Fechar(2000);
            //Console.ReadLine();


            //var pedido = new Pedido();
            //pedido.Pagar += delegate (double valor)// Metodo anonimo
            //{
            //    Console.WriteLine("Pago no boleto valor de " + valor);
            //};
            //pedido.Fechar(500);
            //Console.ReadLine();

            var pedido = new Pedido();
            pedido.Pagar += v => Console.WriteLine("Pago boleto no valor de " + v);//usando expressão lambda
            pedido.Fechar(750);
            Console.ReadLine();
        }

        private static void pedido_Pagar(double valor)
        {
            Console.WriteLine("Pago no boleto valor de " + valor);
        }

        private static void pedido_Pagar_Cartao(double valor)
        {
            Console.WriteLine("Pago no cartão no valor de " + valor);
        }
    }
}
