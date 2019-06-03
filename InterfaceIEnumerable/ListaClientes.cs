using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceIEnumerable
{
    public class ListaClientes : IEnumerable
    {
        private List<string> _clientes = new List<string>();
        private int _index = 0;

        public void Add(string str)
        {
            this._clientes.Add(str);
            this._index = this._index + 1;
        }

        //public IEnumerable<string> getClientes()
        //{
        //    yield return this._clientes[0];
        //    yield return this._clientes[1];
        //    yield return this._clientes[2];
        //    yield return this._clientes[3];
        //}

        public IEnumerator GetEnumerator()
        {
            //foreach (string str in this._clientes)
            for (int i = 0; i < _index; i++)
                yield return this._clientes[i]; // manter o estado, posição do índice
        }
    }
}
