using System;

namespace SobrecargaMetodosOverride
{
    class Program
    {
        static void Main(string[] args)
        {
            Arquivo mp3 = new Musica() { Nome = "Dream Theater - Illumination Theory" };
            Arquivo doc = new DocumentoWord() { Nome = ".net Magazine - Artigo POO" };
            Arquivo img = new Image() { Nome = "Golden Gate Bridge" };
            Arquivo txt = new Txt() { Nome = "Lista de Compras" };
            Windows windows = new Windows();
            windows.Add(mp3);
            windows.Add(doc);
            windows.Add(img);
            windows.Add(txt);

            windows.AbrirTodos();
            //windows.Abrir(mp3);
            //windows.Abrir(doc);
            //windows.Abrir(img);

            Console.ReadLine();
        }
    }
}
