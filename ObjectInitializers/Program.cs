using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectInitializers
{
    public class Filme
    {
        public string Nome;
        public int Ano;
    }

    public class Ator
    {
        public int Codigo;
        public string Nome;
        public List<Filme> Filmes;
        //public Ator(int codigo, string nome, string filme)
        //{
        //    this.Codigo = codigo;
        //    this.Nome = nome;
        //    this.Filme = filme;
        //}

        //public Ator(string nome)
        //{
        //    this.Nome = nome;
        //}

        //public Ator(int codigo)
        //{
        //    this.Codigo = codigo;
        //}
        //public Ator()
        //{
        //}
    }
    class Program
    {
        static void Main(string[] args)
        {
            Ator a = new Ator()
            {
                Codigo = 1,
                Nome = "Teste",
                Filmes = new List<Filme>()
                {
                   new Filme(){Nome ="Star Wars", Ano = 2005 },
                   new Filme(){Nome = "Programa", Ano = 2001}
                }
            };
        }
    }
}
