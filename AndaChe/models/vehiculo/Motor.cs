using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndaChe.models.vehiculo
{
    internal class Motor :MotorElectrico
    {
        public string Combustible { get; private set; }

        public Motor(int serie, string marca, string comb) : base(serie, marca)
        {
            Combustible = comb;
        }
    }
}
