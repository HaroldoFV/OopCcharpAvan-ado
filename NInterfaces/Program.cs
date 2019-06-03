using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Documento doc = new Documento() { Nome = "Artigo.docx" };
            doc.Ler();
            doc.Escrever();
            doc.Compactar();
            doc.Descompactar();
            Imagem img = new Imagem() { Nome = "Foto.jpg" };
            Console.WriteLine("Arquivo:" + img.Nome);
            img.Ler();
            img.Escrever();
            img.Compactar();
            img.Descompactar();
            Console.ReadLine();
        }
    }
}
