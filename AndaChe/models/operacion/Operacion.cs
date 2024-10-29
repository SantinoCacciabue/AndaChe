using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AndaChe.models.operacion;

namespace AndaChe.models
{
    abstract class Operacion
    {
        List<Registro> registros = new List<Registro>();
        public Vehiculo auto { get; private set; }
        public Empleado empleado { get; private set; }
        public Cliente cliente { get; private set; }
        public int NumOperacion { get; private set; }
        public int CantidadRegistros
        {
            get
            {
                return registros.Count;
            }
        }
        public double MontoRegistros
        {
            get
            {
                double monto = 0;
                foreach(Registro r in registros)
                {
                    monto += r.Valor;
                }
                return monto;
            }
        }
        public double ComisionEmpleado
        {
            get
            {
                return MontoAuto*(empleado.PorcComision/100);
            }
        }
        public double MontoAuto
        {
            get
            {
                return auto.PrecioFinal;
            }
        }
        public Operacion(int nro, Cliente c,Empleado e, Vehiculo v)
        {
            NumOperacion = nro;
            empleado = e;
            cliente = c;
            v = auto;
        }
        public void AgregarRegistro(string tipo, string desc, double valor)
        {
            Registro r = new Registro(tipo,desc,valor);
            registros.Add(r);
        }
        public string VerRegistros()
        {
            string reg = "";
            foreach(Registro r in registros)
            {
                reg += r.ToString();
            }
            return reg;
        }
        public abstract double CalcularMonto();
    }
}
