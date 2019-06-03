using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaRevelo
{
    class TextWriter
    {
        protected dynamic config;

        public TextWriter(dynamic config)
        {
            this.config = config;
        }
        public void getFilename()
        {
            Console.WriteLine(config.Filename + config.Extension);
        }

    }

    public static class Armstrong
    {
        public static bool IsArmstrong(int number)
        {
            int remainder, sum = 0;
            for (int i = number; i > 0; i = i / 10)
            {
                remainder = i % 10;
                sum += (int)Math.Pow(remainder, 3.0);
            }
            if (sum == number)
                return true;
            else
                return false;
        }

    }

    public class Person
    {
        protected string name = "Peter";

        public virtual void Print()
        {
            Console.WriteLine("Name: {0}", this.name);
        }
    }
    public class Employee : Person
    {
        protected string role = "CTO";
        public override void Print()
        {
            base.Print();
            Console.WriteLine("Role: {0}", this.role);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            //Questao1();

            //CalcularNumeroArmstrong();

            //Console.WriteLine("3/10 = {0} --- 3 % 10 = {1}", 3 / 10, 3 % 10);
            //MostrarInformacao();

            TratamentoAritmetico();
        }

        private static void TratamentoAritmetico()
        {
            try
            {
                throw new ArithmeticException("B");
                Console.WriteLine("A");
            }
            catch (Exception e)
            {
                Console.WriteLine("C");
            }
        }

        private static void MostrarInformacao()
        {
            Person employee = new Employee();

            employee.Print();
        }

        private static void CalcularNumeroArmstrong()
        {
            Console.WriteLine(Armstrong.IsArmstrong(371));
        }

        private static void Questao1()
        {
            var config = new { Extension = ".txt", Filename = "poem" };
            TextWriter txt = new TextWriter(config);
            txt.getFilename();
        }
    }
}
