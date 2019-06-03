using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propriedades
{
    public class MensalidadeNegativaException : Exception
    {
        public MensalidadeNegativaException(string message) :
            base(message)
        {

        }
    }

    public enum TipoAluno
    {
        Regular, Especial
    }
    public class Aluno
    {
        private int _matricula;
        public int Matricula
        {
            get { return this._matricula; }
            set { this._matricula = value; }
        }

        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private double mensalidade;
        public double Mensalidade
        {
            get { return mensalidade; }
            set
            {
                if (value < 0)
                    throw new MensalidadeNegativaException("Valor da mensalidade não pode ser negativo");
                else
                    mensalidade = value;
            }
        }

        private TipoAluno tipo;
        public TipoAluno Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Aluno a = new Aluno();
                a.Matricula = 123;
                a.Nome = "Guinther";
                a.Mensalidade = -500;
                a.Tipo = TipoAluno.Regular;
            }
            catch (MensalidadeNegativaException Error)
            {
                Console.WriteLine(Error.Message);
            }
            catch (Exception Error)
            {
                Console.WriteLine(Error.Message);
            }
            Console.ReadLine();
        }
    }
}
