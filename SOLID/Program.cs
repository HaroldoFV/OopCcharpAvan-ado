using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{

    // Sem usar SOLID - 
    public enum TIPO_FUNCIONARIO { ANALISTA, ARQUITETO }

    public class Funcionario
    {
        public TIPO_FUNCIONARIO TipoFuncionario { get; set; }
    }

    public class CalculaSalario
    {
        private decimal fValorSalario;

        public CalculaSalario(Funcionario pFuncionario)
        {
            if (pFuncionario.TipoFuncionario == TIPO_FUNCIONARIO.ANALISTA)
            {
                this.fValorSalario = 5000;
            }
            else if (pFuncionario.TipoFuncionario == TIPO_FUNCIONARIO.ARQUITETO)
            {
                this.fValorSalario = 7000;
            }
        }

        public decimal ValorSalario { get { return this.fValorSalario; } }
    }
    ////////

    // Usando SOLID - Open Close Principle
    public abstract class CalculaSalarioBase
    {
        public abstract decimal CalcularSalario();
    }

    public class CalculaSalarioAnalista : CalculaSalarioBase
    {
        public override decimal CalcularSalario()
        {
            return 5000;
        }
    }

    public class CalculaSalarioArquiteto : CalculaSalarioBase
    {
        public override decimal CalcularSalario()
        {
            return 7000;
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            var funcionario = new Funcionario();
            funcionario.TipoFuncionario = TIPO_FUNCIONARIO.ANALISTA;
            var salario = new CalculaSalarioAnalista().CalcularSalario();
            Console.WriteLine(funcionario.TipoFuncionario);
            Console.WriteLine(salario);
            Console.ReadLine();
        }

        private static void ExemploSemUsarPrincipioAbertoFechado()
        {
            var funcionario = new Funcionario();
            funcionario.TipoFuncionario = TIPO_FUNCIONARIO.ARQUITETO;
            var salario = new CalculaSalario(funcionario);
            Console.WriteLine(funcionario.TipoFuncionario);
            Console.WriteLine(salario.ValorSalario);
        }
    }
}
