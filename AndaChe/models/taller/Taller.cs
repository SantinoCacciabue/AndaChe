using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndaChe.models
{
    internal class Taller
    {
        List<Reparacion> reparaciones = new List<Reparacion>();
        public int CantidadReparaciones
        {
            get
            {
                return reparaciones.Count;
            }
        }
        public double MontoFinal
        {
            get
            {
                double monto = 0;
                foreach(Reparacion r in reparaciones)
                {
                    monto += r.Monto;
                }
                return monto;
            }
        }
        public void AgregarReparacion(Reparacion r)
        {
            if(r!= null)
            {
                reparaciones.Add(r);
            }
            else
            {
                throw new Exception("Reparación inexistente");
            }
        }
        public override string ToString()
        {
            
            string ret = "";
            if(CantidadReparaciones == 0)
            {
                ret = "No hubo reparaciones";
            }
            else
            {
                ret += $"Reparaciones: {CantidadReparaciones}";
                foreach (Reparacion r in reparaciones)
                {
                    ret += r.ToString();
                }
                ret += $"Monto final: ${MontoFinal:f2}";
            }
            
            return ret;
        }
    }
}
