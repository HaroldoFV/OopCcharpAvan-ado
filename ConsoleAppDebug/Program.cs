using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace ConsoleAppDebug
{
    class Program
    {
        static void Main(string[] args)
        {
            TextWriterTraceListener trl1 = new TextWriterTraceListener(File.CreateText("debug_app_log.txt"));
            Debug.Listeners.Add(trl1);
            TextWriterTraceListener trl2 = new TextWriterTraceListener(Console.Out);
            Debug.Listeners.Add(trl2);

            string NomeProduto = "iPad";
            int Quantidade = 200;
            double Preco = 1500;
            Debug.WriteLine("Testando o objeto Debug");
            Debug.Indent();
            Debug.WriteLine("Produto: " + NomeProduto);
            Debug.WriteLine("Quantidade: " + Quantidade);
            Debug.WriteLine("Preço: " + Preco);
            Debug.WriteLineIf(Preco > 1000, "Debug - Preço maior que 1000");
            //Debug.Assert(Quantidade > 300);
            Debug.Unindent();
            Debug.Flush();
            Console.ReadLine();
        }
    }
}
