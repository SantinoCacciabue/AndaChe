using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndaChe.models.operacion
{
    public class Registro
    {
        public string Tipo { get; private set; }
        public string Descripcion { get; private set; }
        public double Valor { get; private set; }
        public Registro(string tipo, string descripcion, double valor)
        {
            Tipo = tipo;
            Descripcion = descripcion;
            Valor = valor;
        }
        public override string ToString()
        {
            return $"{Tipo}: {Descripcion}(${Valor:f2})";
            
        }
    }
}
