using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndaChe.models.vehiculo
{
    internal class Hibrido:Vehiculo
    {
        public int Baterias { get; private set; }
        public string TipoCarga { get; private set; }
        public double ConsumoRuta { get; private set; }
        public double ConsumoCiudad { get; private set; }

        public Hibrido(string modelo, string marca, int año, double precioFinal, string patente) : base(modelo, marca, año, precioFinal, patente) { }

        public void AñadirEspecificaciones(double m, string ll, string t, double km, string color, string caja, int v, int p, int c, bool e, bool aA, double cT, string eC, DateTime fUc, double kUc, MotorElectrico mo, Chasis ch,int baterias, string carga, double cR, double cC)
        {
            base.AñadirEspecificaciones(m, ll, t, km, color, caja, v, p, c, e, aA, cT, eC, fUc, kUc, mo, ch);
            Baterias = baterias;
            TipoCarga = carga;
            ConsumoRuta = cR;
            ConsumoCiudad = cC;
        }
    }
}
