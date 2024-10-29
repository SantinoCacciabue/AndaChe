using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndaChe.models
{
    abstract class Persona : IComparable
    {
        public string Nombre { get; set; }
        public int DNI { get; set; }
        public string Telefono { get;  set; }
        public int Nro { get; private set; }
        public Persona(string nom, int dni, string tel, int nro)
        {
            Nombre = nom;
            DNI = dni;
            Telefono = tel;
            Nro = nro;
        }
        public Persona(int nro)
        {
            Nro = nro;
        }
        public override string ToString()
        {
            return $"{Nombre}({DNI})-Tel:{Telefono}";
        }

        public int CompareTo(object obj)
        {
            Persona p = obj as Persona;
            if (p != null)
            {
                return p.DNI.CompareTo(DNI);
            }
            return -1;
        }
    }

}
