using System;
using System.Collections;
using System.Collections.Generic;

namespace SobrecargaMetodosOverride
{
    public abstract class Arquivo
    {
        public string Nome;
        public int Tamanho;
        //public abstract void Abrir();// não existe nada em comum - abstrato
        public virtual void Abrir()// Comum a todas as classes bases
        {
            Console.WriteLine("Abrindo arquivo " + Nome);
        }
    }

    public class Musica : Arquivo
    {
        public override void Abrir()
        {
            base.Abrir();
            Console.WriteLine("Tocando música " + Nome);
        }
    }

    public class DocumentoWord : Arquivo
    {
        public override void Abrir()
        {
            base.Abrir();
            Console.WriteLine("Mostrando documento do Word: " + Nome);
        }
    }

    public class Image : Arquivo
    {
        public override void Abrir()
        {
            base.Abrir();
            Console.WriteLine("Exibindo imagem: " + Nome);
        }
    }

    public class Txt : Arquivo
    {
        public override void Abrir()
        {
            base.Abrir();
            Console.WriteLine("Mostrando arquivo texto: " + Nome);
        }
    }


    public class Windows
    {
        private List<Arquivo> _arquivos;
        public Windows()
        {
            this._arquivos = new List<Arquivo>();
        }

        public void Add(Arquivo arquivo)
        {
            this._arquivos.Add(arquivo);
        }

        public void AbrirTodos()
        {
            foreach (Arquivo arquivo in _arquivos)
                Abrir(arquivo);
        }

        public void Abrir(Arquivo arquivo)
        {
            // Delegação
            //if (arquivo is Musica)
            //    (arquivo as Musica).Abrir();
            //if (arquivo is Image)
            //    (arquivo as Image).Abrir();
            //if (arquivo is DocumentoWord)
            //    (arquivo as DocumentoWord).Abrir();
            //if (arquivo is Txt)
            //    (arquivo as Txt).Abrir();

            arquivo.Abrir();
        }
    }


}
