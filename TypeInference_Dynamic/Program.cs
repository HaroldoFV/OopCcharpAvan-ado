using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeInference_Dynamic
{
    public class Connection
    {
        public string ConnectionString;
        public void Conectar()
        {
            Console.WriteLine("Conectando...");
        }
        public void Fechar()
        {
            Console.WriteLine("Fechando...");
        }
    }

    public class Fabrica
    {
        public static Connection CriarConnection()
        {
            return new Connection();
        }
    }

    class Program
    {
        // utilizando inferência de tipo - tempo de compilação
        // obs: cuidado ao utilizar com herança
        //static void Main(string[] args)
        //{
        //    var con = Fabrica.CriarConnection();
        //    con.Conectar();
        //    con.Fechar();
        //    Console.ReadLine();
        //}


        // utilizando Dynamic - totalmente dinamico - 
        // é resolivdo em tempo de execução
        // muito utilizado para utlizar bibliotecas de terceiros onde 
        // não conhecemos a dll, biblioteca etc.
        // quando não conhecemos a interface q utilizaremos
        static void Main(string[] args)
        {
            dynamic con = Fabrica.CriarConnection();
            con.ConnectionString = "BANCO";
            con.Conectar();
            con.Fechar();
            Console.ReadLine();
        }
    }
}
