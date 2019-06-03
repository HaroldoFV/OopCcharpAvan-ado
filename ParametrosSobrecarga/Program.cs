using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametrosSobrecarga
{
    public class CaixaDialogo
    {
        // default
        public void Show(string Mensagem)
        {
            Console.WriteLine(Mensagem);
        }

        public void Show(string Mensagem, int Delay)
        {
            // configuração do delay
            Show(Mensagem);// default
        }

        public void Show(string Mensagem, int Delay, bool Ok, bool No)
        {
            // configuração do delay
            // configuração dos botões Ok e No
            Show(Mensagem);// default
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //string x = "10";
            //int y = Convert.ToInt32(x);

            var dig1 = new CaixaDialogo();
            dig1.Show("Confirmar?");
            var dig2 = new CaixaDialogo();
            dig2.Show("Excluir?", 20);
            var dig3 = new CaixaDialogo();
            dig3.Show("Are you sure?", Delay: 10, Ok: true, No: false);
            Console.ReadLine();
        }
    }
}
