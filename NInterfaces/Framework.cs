using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NInterfaces
{
    public interface IComprimivel
    {
        void Compactar();
        void Descompactar();
    }

    public interface IArmazenavel
    {
        void Ler();
        void Escrever();
    }

    public class Arquivo
    {
        public string Nome;
    }

    public class Compactador : Object, IComprimivel
    {
        public void Compactar()
        {
            Console.WriteLine("Compactando arquivo...");
        }

        public void Descompactar()
        {
            Console.WriteLine("Descompactando arquivo...");
        }
    }

    // Não repete código em cada classe que implementa interface
    public class Armazenador : Object, IArmazenavel
    {
        public void Escrever()
        {
            Console.WriteLine("Escrevendo arquivo...");
        }

        public void Ler()
        {
            Console.WriteLine("Lendo arquivo...");
        }
    }

    // C# não suporta herança múltipla, mas pode implementar n interfaces
    public class Documento : Arquivo, IArmazenavel, IComprimivel
    {
        // herança de "caixa preta"
        private Armazenador _armazenador = new Armazenador();
        private Compactador _compactador = new Compactador();
        // implementação de n interfaces por delegação
        // simulando herança múltipla
        public void Ler()
        {
            // delegação
            this._armazenador.Ler();
        }
        public void Escrever()
        {
            this._armazenador.Escrever();
        }
        public void Compactar()
        {
            this._compactador.Compactar();
        }
        public void Descompactar()
        {
            this._compactador.Descompactar();
        }
    }

    public class Imagem : Arquivo, IArmazenavel, IComprimivel
    {
        public void Ler()
        {
            Console.WriteLine("Lendo arquivo...");
        }

        public void Escrever()
        {
            Console.WriteLine("Escrevendo arquivo...");
        }

        public void Compactar()
        {
            Console.WriteLine("Compactando arquivo...");
        }

        public void Descompactar()
        {
            Console.WriteLine("Descompactar arquivo...");
        }
    }

}
