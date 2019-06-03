using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesIDisposable
{
    public class Conexao : IDisposable
    {
        // resource
        private string Handle;

        public Conexao()
        {
            this.Handle = "Recurso alocado";
            Console.WriteLine("Recurso alocado");
        }

        public void Conectar()
        {
            Console.WriteLine("Conectado");
        }

        public void Fechar()
        {
            Console.WriteLine("Desconectado");
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void LiberarRecurso()
        {
            Handle = "";
            Console.WriteLine("Recurso liberado com sucesso");
        }

        public virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                // liberar recursos managed
            }
            // liberar recursos unmanaged
            LiberarRecurso();
        }
    }
}
