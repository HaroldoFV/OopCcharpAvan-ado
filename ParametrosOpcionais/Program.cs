using System;

namespace ParametrosOpcionais
{
    public class CaixaDialogo
    {
        public void Show(
            string Mensagem,
            bool Ok,
            bool No,
            int Tam = 200,
            bool Cancel = false,
            int Delay = 10
            )
        {
            Console.WriteLine(Mensagem);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            var dig1 = new CaixaDialogo();
            dig1.Show(Mensagem: "Confirmar ?", Ok: true, No: true);
            var dig2 = new CaixaDialogo();
            dig2.Show(Mensagem: "Excluir ?", Ok: true, No: true, Tam: 20);
            Console.ReadLine();
        }
    }
}
