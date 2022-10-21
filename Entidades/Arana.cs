using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Arana<T> : ICazador, IInterfazGenerica<T> 
        where T : class
    {
        public Arana()
        {

        }
        public string Cazador()
        {
            return "Estoy esperando que la presa caiga en la trampa";
        }

        public T Metodo(T tipo)
        {
            return tipo;
        }
    }
}
