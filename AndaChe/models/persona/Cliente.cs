using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AndaChe.models
{
    internal class Cliente : Persona
    {
        public string Direccion { get; set; }
        public Cliente(string direccion,string nom,string tel, int dni, int nro):base(nom,dni,tel, nro)
        {
            Direccion = direccion;
        }
        public Cliente(int nro):base(nro) { }
        public override string ToString()
        {
            return $"Cliente {Nro}: {base.ToString()} Dirección: {Direccion}";
        }
    }
}
