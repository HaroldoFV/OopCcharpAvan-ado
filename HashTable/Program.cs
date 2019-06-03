using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HashTable
{
    public class Aluno
    {
        public int Matricula;
        public string Nome;
        public override string ToString()
        {
            return Matricula.ToString() + ":" + Nome;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var alunos = new Hashtable();
            var a1 = new Aluno() { Matricula = 123, Nome = "Guinther" };
            var a2 = new Aluno() { Matricula = 456, Nome = "Rudolfo" };
            alunos.Add("123", a1);
            alunos.Add("456", a2);

            foreach (var obj in alunos.Values)
                Console.WriteLine(obj);
        }
    }
}
