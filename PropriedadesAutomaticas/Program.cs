using System;

namespace PropriedadesAutomaticas
{
    public class Funcionario
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }

        public Funcionario()
        {
            this.Codigo = 0;
            this.Nome = "Sem nome";
            this.Salario = 0;
        }

        public Funcionario(int codigo, string nome, double salario)
        {
            Codigo = codigo;
            Nome = nome;
            Salario = salario;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario(1, "Haroldo", 3900);
            Console.ReadLine();
        }
    }
}
