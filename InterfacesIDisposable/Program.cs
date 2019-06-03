using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesIDisposable
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Conexao con = new Conexao())
            {
                con.Conectar();
                con.Fechar();
            }
            Console.ReadLine();
        }

        private static void TesteSqlConnection()
        {
            var obj = new SqlConnection();
            try
            {
                // ..
            }
            finally
            {
                if (obj != null)
                    obj.Dispose();
            }
            using (var obj2 = new SqlConnection())
            {

            }
        }
    }
}
