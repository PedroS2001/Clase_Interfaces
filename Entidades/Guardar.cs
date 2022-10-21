using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Guardar<T> : IIGuardar<T>
        where T : class
    {
        public T Leer()
        {
            throw new NotImplementedException();
        }

        bool IIGuardar<T>.Guardar(T obj)
        {
            Console.WriteLine(   obj.ToString()  );
            if( true)
            {
                return true;
            }

            return false;
        }
    }
}
