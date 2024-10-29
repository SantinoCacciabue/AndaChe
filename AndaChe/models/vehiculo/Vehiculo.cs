using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AndaChe.models.vehiculo;

namespace AndaChe.models
{
    internal class Vehiculo:IComparable
    {
        public Chasis chasis { get; private set; }
        public MotorElectrico motor { get; private set; }
        public string Modelo { get; private set; }
        public string Patente { get; private set; }
        public string Marca { get; private set; }
        public int Año { get; private set; }
        public double PrecioFinal { get; set; }
        public double MedidaRodado { get; private set; }
        public string Llantas { get; private set; }
        public string Tapizado { get; private set; }
        public double Kilometros { get; private set; }
        public string Color { get; private set; }
        public string CajaDeCambios { get; private set; }
        public int Velocidades { get; private set; }
        public int Pantallas { get; private set; }
        public int Camaras { get; private set; }
        public bool EspejosElectricos { get; private set; }
        public bool AireA { get; private set; }
        public double CapacidadTanque { get; private set; }
        public string EstadoCubiertas { get; private set; }
        public DateTime FechaUltimoCambio { get; private set; }
        public double KmUltimoCambio { get; private set; }
        public Vehiculo(string modelo, string marca, int año, double precioFinal, string patente)
        {
            Patente = patente;
            Modelo = modelo;
            Marca = marca;
            Año = año;
            PrecioFinal = precioFinal;
        }
        public Vehiculo(string patente)
        {
            Patente = patente;
        }
        public override string ToString()
        {
            return $"{Marca}-{Modelo}({Año})-${PrecioFinal}";
        }

        public int CompareTo(object obj)
        {
            Vehiculo v = obj as Vehiculo;
            if (v != null)
            {
                return Patente.CompareTo(v.Patente);
            }
            return -1;
        }

        public virtual void AñadirEspecificaciones(double m, string ll, string t, double km, string color, string caja, int v, int p, int c, bool e, bool aA, double cT, string eC, DateTime fUc, double kUc, MotorElectrico mo, Chasis ch)
        {
            chasis = ch;
            motor = mo;
            MedidaRodado = m;
            Llantas = ll;
            Tapizado = t;
            Kilometros = km;
            Color = color;
            CajaDeCambios = caja;
            Velocidades = v;
            Pantallas = p;
            Camaras = c;
            EspejosElectricos = e;
            CapacidadTanque = cT;
            EstadoCubiertas = eC;
            FechaUltimoCambio = fUc;
            KmUltimoCambio = kUc;
            AireA = aA;
        }
    }
}
