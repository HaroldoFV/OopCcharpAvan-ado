using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Reflexao2
{
    public class Cliente
    {
        private string _nome;
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public Cliente(string nome)
        {
            this._nome = nome;
        }

        public void Imprimir(string Titulo)
        {
            Console.WriteLine(Titulo + _nome);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Type t = Type.GetType("Reflexao2.Cliente");
            ConstructorInfo ctor = t.GetConstructor(new Type[] { typeof(string) });
            var obj = ctor.Invoke(new object[] { "Haroldo" });

            MethodInfo mi = t.GetMethod("Imprimir");
            mi.Invoke(obj, new Object[] { "Sr. " });
            Console.ReadLine();
        }
    }
}
