using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface IInterfazGenerica<T> where T : class
    {
        T Metodo(T tipo);
    }
}
