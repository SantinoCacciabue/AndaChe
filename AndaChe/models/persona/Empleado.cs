using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndaChe.models
{
    internal class Empleado:Persona
    {
        public double PorcComision { get; set; }
        public Empleado(int nro, double porc,int dni,string nom,string tel):base(nom,dni,tel,nro)
        {
            PorcComision = porc;
        }
        public Empleado(int nro):base(nro) { }
        public override string ToString()
        {
            return $"Vendedor {Nro}: {base.ToString()} Comisión:%{PorcComision}";
        }
    }
}
