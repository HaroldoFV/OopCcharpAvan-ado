using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var turma = new ArrayList();
            turma.Add("Guinther");
            turma.Add("Rudolfo");
            turma.Add(new DataSet());
            foreach (var item in turma)
                Console.WriteLine(item);
            Console.WriteLine("Capacidade: " + turma.Capacity);
            Console.WriteLine("Count: " + turma.Count);
            Console.ReadLine();
        }
    }
}
