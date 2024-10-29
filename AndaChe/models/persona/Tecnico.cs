using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndaChe.models
{
    internal class Tecnico:Persona
    {
        public string Especialidad { get; set; }
        public Tecnico( int nro,string esp, string nom,string tel, int dni) : base(nom, dni, tel,nro)
        {
            Especialidad = esp;
        }
        public Tecnico(int nro) : base(nro) { }
        public override string ToString()
        {
            return $"Técnico {Especialidad}({Nro}): {base.ToString()}";
        }
    }
}
