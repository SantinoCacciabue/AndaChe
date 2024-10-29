using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndaChe.models.vehiculo
{
    internal class MotorElectrico
    {
        public string Tipo { get; private set; }
        public int NroSerie { get; private set; }
        public string Marca { get; private set; }

        public MotorElectrico(int serie, string marca)
        {
            NroSerie = serie;
            Marca = marca;
        }
    }
}
