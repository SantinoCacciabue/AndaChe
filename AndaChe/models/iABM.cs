using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndaChe.models
{
    internal interface iABM<T>
    {
        void Agregar(T entidad);
        void Eliminar(T entidad);
        void Modificar(T entidad);
    }
}
