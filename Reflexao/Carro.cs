using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflexao
{
    internal class Carro : ICarro, IPintado
    {
        public string Cor;
        private int _Velocidade;
        public int Velocidade
        {
            get { return this._Velocidade; }
        }
        public void Acelerar(int quantidade)
        {
            this._Velocidade += quantidade;
        }
        public bool estaMovendo()
        {
            if (Velocidade == 0)
                return false;
            else
                return true;
        }
        public Carro()
        {
        }
        public Carro(string ACor, int AVelocidade)
        {
            Cor = ACor;
            this._Velocidade = AVelocidade;
        }
        public double CalcularKilometrosPorLitro(int kmInicial, int kmFinal, double litros)
        {
            return (kmFinal - kmInicial) / litros;
        }

        public bool ehPintado()
        {
            return (Cor != null);
        }
    }

    internal class CarroSport : Carro
    {
        public CarroSport()
        {
            Cor = "Azul";
        }


    }
}
