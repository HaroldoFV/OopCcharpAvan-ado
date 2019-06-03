using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{

    //public class Boleto
    //{
    //    public void Pagar(double valor)
    //    {
    //        Console.WriteLine("Boleto pago no valor de " + valor);
    //    }
    //}

    //public class Pedido
    //{

    //    private Boleto _boleto = new Boleto();

    //    public void Fechar(double valor)
    //    {
    //        // Delegação...
    //        this._boleto.Pagar(valor);
    //    }
    //}

    //public delegate void PagarEvent(double valor);// Tipo delegate

    //public class Pedido
    //{
    //    public event PagarEvent Pagar; // evento

    //    public void Fechar(double valor)
    //    {
    //        // delegação
    //        this.Pagar(valor);
    //    }


    //}

    public delegate void PagarEvent(double valor);// Tipo delegate

    public class Pedido
    {
        public event PagarEvent Pagar; // ponteiro para um método

        public void Fechar(double valor)
        {
            // delegação
            this.Pagar(valor);
        }

    }
}
