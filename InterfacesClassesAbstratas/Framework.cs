using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesClassesAbstratas
{
    interface IDBConnection
    {
        void Close();
        void Open();
    }

    interface ITransactional
    {
        void StartTransaction();
    }

    public abstract class DBConnection : IDBConnection
    {
        public string ConnectionString { get; set; }
        public virtual void Close()
        {
            Console.WriteLine("Fechando conexão ...");
        }

        public virtual void Open()
        {
            Console.WriteLine("Abrindo conexão...");
            Console.WriteLine("Conectado a " + ConnectionString);
        }
    }

    public class SqlConnection : DBConnection
    {
        public override void Open()
        {
            base.Open();
            // código específico para SQL
        }
        public override void Close()
        {
            base.Close();
        }
    }

    public class OracleConnection : DBConnection
    {
        public override void Close()
        {
            base.Close();
        }

        public override void Open()
        {
            base.Open();
        }
    }

}
