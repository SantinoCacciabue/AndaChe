using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndaChe.models.vehiculo
{
    internal class Chasis
    {
        public string Marca { get; private set; }
        public int NroSerie { get; private set; }

        public Chasis(string marca, int nro)
        {
            Marca = marca;
            NroSerie = nro;
        }
    }
}
