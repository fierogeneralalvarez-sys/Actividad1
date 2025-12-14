using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Actividad1
{
    internal class Metodos
    {
        private Nodo? head;

        public Nodo? Head
        {
            get { return head; }
            set { head = value; }
        }
        public Metodos()
        {
            this.head = null;
        }

        public string Agregar(int n)
        {
            Nodo nuevoNodo = new Nodo(n);

            if (head == null)
            {
                head = nuevoNodo;
            }
            else
            {
                nuevoNodo.Next = head;
                head = nuevoNodo;
            }

            string s = "";
            Nodo? h = head;

            while (h != null)
            {
                s += h + Environment.NewLine;
                h = h.Next;
            }

            return s;
        }


    }
}
