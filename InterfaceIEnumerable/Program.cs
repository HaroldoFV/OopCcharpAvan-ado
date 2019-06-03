using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceIEnumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            var clis = new ListaClientes();
            clis.Add("Guinther");
            clis.Add("Paulo");
            clis.Add("Rodolfo");
            clis.Add("Wesley");
            clis.Add("Teste 1");
            clis.Add("Teste 2");
            clis.Add("Teste 3");
            foreach (var s in clis)
                Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}
