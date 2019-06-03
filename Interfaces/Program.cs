using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{

    public interface IMyInterface
    {
        void MyMethod();
    }

    public class MyClass : IMyInterface
    {
        public void MyMethod()
        {
            Console.WriteLine("Olá Mundo!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IMyInterface obj = new MyClass();
            obj.MyMethod();
            Console.Read();
        }
    }
}
