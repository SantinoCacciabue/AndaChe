using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndaChe.models
{
    internal class Venta:Operacion
    {
        public Taller taller { get; private set; }
        public Venta(int nro,Taller t,Vehiculo v, Cliente c, Empleado e) : base(nro, c, e, v)
        {
            taller = t;
        }
        public override double CalcularMonto()
        {
            double montoTaller = taller.MontoFinal;
            return montoTaller + ComisionEmpleado + MontoAuto + MontoRegistros;
        }
        public override string ToString()
        {
            string ret = $@"Venta a cargo de {empleado}
Cliente: {cliente}
Vehiculo: {auto}
Comision empleado: {ComisionEmpleado}
Reparaciones: {taller}
Registros contables: {VerRegistros()}
Monto final:{CalcularMonto()}";
            return ret;
        }


    }
}
