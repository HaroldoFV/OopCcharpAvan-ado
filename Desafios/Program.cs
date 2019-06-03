using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafios
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calculadora();

            //Fibonacci();

            Console.WriteLine("Digite o valor do saque");
            int saque = Convert.ToInt32(Console.ReadLine());

            int quantidadeNotas10 = 0, quantidadeNotas20 = 0, quantidadeNotas50 = 0;

            if (saque % 10 != 0)
            {
                Console.WriteLine("Não existe notas disponiveis");
                Console.ReadKey();
            }

            while (saque > 0)
            {
                if (saque >= 50)
                {
                    quantidadeNotas50 = saque / 50;
                    saque = saque % 50;
                }
                else if (saque >= 20)
                {
                    quantidadeNotas20 = saque / 20;
                    saque = saque % 20;
                }
                else if (saque >= 10)
                {
                    quantidadeNotas10 = saque / 10;
                    saque = saque % 10;
                }
            }

            Console.WriteLine("1º Opção de saque: ");
            Console.WriteLine("{0} nota(s) de R$ 50", quantidadeNotas50);
            Console.WriteLine("{0} nota(s) de R$ 20", quantidadeNotas20);
            Console.WriteLine("{0} nota(s) de R$ 10", quantidadeNotas10);
            Console.ReadKey();
        }

        private static void Fibonacci()
        {
            int atual = 0;
            int proximo = 1;

            for (int i = 0; i < 5; i++)
            {
                Console.Write(atual + " " + proximo + " ");
                atual += proximo;
                proximo += atual;
            }
        }

        private static void Calculadora()
        {
            Console.WriteLine("Escolha a operação: + - / *");
            string operacao = Console.ReadLine();
            //Console.WriteLine(operacao);
            Console.WriteLine("Digite o primeiro numero: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());
            int resultado = 0;

            switch (operacao)
            {
                case "+":
                    resultado = numero1 + numero2;
                    break;
                case "-":
                    resultado = numero1 - numero2;
                    break;
                case "/":
                    resultado = numero1 / numero2;
                    break;
                case "*":
                    resultado = numero1 * numero2;
                    break;
                default:
                    Console.WriteLine("Opção Invalida");
                    break;
            }

            Console.WriteLine("Resultado: {0}", resultado);
        }
    }
}
