using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndaChe.models
{
    internal class Reparacion
    {
        public Tecnico tecnico { get; private set; }
        public string Descripcion { get; private set; }
        public double Monto { get; private set; }   
        public Reparacion(string desc,double monto, Tecnico t)
        {
            tecnico = t;
            Descripcion = desc;
            Monto = monto;
        }
        public override string ToString()
        {
            return $"Reparación:\r\nDescripción: {Descripcion}\r\n{tecnico}";
        }
    }
}
