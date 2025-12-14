using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad1
{
    internal class Nodo
    {
        public int Valor;
        public Nodo? Next;

        public Nodo(int valor)
        {
            Valor = valor;
            Next = null;
        }

        public override string ToString()
        {
            return Valor.ToString();
        }
    }
}
