using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSet
{
    public class Conta
    {
        private string _cliente;
        private double _valor;
        public Conta(string nomeCliente)
        {
            this._cliente = nomeCliente;
        }

        public Conta()
        {
        }

        public string getCliente()
        {
            return this._cliente;
        }

        public void setCliente(string value)
        {
            this._cliente = value;
        }

        public void Sacar(double valor)
        {
            this._valor = this._valor - valor;
        }

        public void Depositar(double valor)
        {
            this._valor = this._valor + valor;
        }

        public double getValor()
        {
            return this._valor;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta();
            conta.setCliente("Haroldo");
            conta.Depositar(1000);
            conta.Sacar(500);
            Console.WriteLine("Cliente: " + conta.getCliente());
            Console.WriteLine("Saldo na data = " + conta.getValor());
            Console.ReadLine();
        }
    }
}
