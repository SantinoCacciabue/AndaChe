using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndaChe.models
{
    internal class Consecionaria : iABM<Cliente>, iABM<Vehiculo>, iABM<Empleado>, iABM<Tecnico>
    {
        List<Cliente> clientes = new List<Cliente>();
        List<Vehiculo> vehiculos = new List<Vehiculo>();
        List<Empleado> empleados = new List<Empleado>();
        private List<Operacion> operaciones = new List<Operacion>();
        List<Tecnico> tecnicos = new List<Tecnico>();
        #region cantidades

        public int CantidadOperaciones
        {
            get
            {
                return operaciones.Count;
            }
        }
        public int CantidadVehiculos
        {
            get
            {
                return vehiculos.Count;
            }
        }
        public int CantidadEmpleados
        {
            get
            {
                return empleados.Count;
            }
        }
        public int CantidadClientes
        {
            get
            {
                return clientes.Count;
            }
        }
        #endregion
        #region abm
        public void Agregar(Cliente c)
        {
            clientes.Add(c);
        }

        public void Agregar(Vehiculo v)
        {
            vehiculos.Add(v);
        }

        public void Agregar(Empleado e)
        {
            empleados.Add(e);
        }

        public void Agregar(Tecnico t)
        {
            tecnicos.Add(t);
        }

        public void Eliminar(Cliente c)
        {
            clientes.Remove(c);
        }

        public void Eliminar(Vehiculo v)
        {
            vehiculos.Remove(v);
        }

        public void Eliminar(Empleado e)
        {
            empleados.Remove(e);
        }

        public void Eliminar(Tecnico t)
        {
            tecnicos.Remove(t);
        }

        public void Modificar(Cliente c)
        {
            clientes.Sort();
            int i = clientes.BinarySearch(new Cliente(c.DNI));
            Cliente existente = null;
            if( existente != null)
            {
                existente.Nombre = c.Nombre;
                existente.Telefono = c.Telefono;
                existente.Direccion = c.Direccion;
                existente.DNI = c.DNI;
            }
        }

        public void Modificar(Vehiculo v)
        {
            vehiculos.Sort();
            int i = vehiculos.BinarySearch(new Vehiculo(v.Patente));
            Vehiculo existente = vehiculos[i];
            if (existente != null)
            {
                existente.PrecioFinal=v.PrecioFinal;
            }
        }

        public void Modificar(Empleado e)
        {
            empleados.Sort();
            int i = empleados.BinarySearch(new Empleado(e.DNI));
            Empleado existente = empleados[i];
            if (existente != null)
            {
                existente.Nombre = e.Nombre;
                existente.DNI = e.DNI;
                existente.PorcComision = e.PorcComision;
            }
        }

        public void Modificar(Tecnico t)
        {
            tecnicos.Sort();
            int i = empleados.BinarySearch(new Empleado(t.DNI));
            Tecnico existente = tecnicos[i];
            if (existente != null)
            {
                existente.Nombre = t.Nombre;
                existente.DNI = t.DNI;
                existente.Especialidad = t.Especialidad;
            }
        }
        #endregion
        public void RegistrarOperacion(Operacion p)
        {
            if(p!= null)
            {
                operaciones.Add(p);
            }
        }
        public string[] VerOperaciones()
        {
            operaciones.Sort();
            double recaudacion = 0;
            string[] ret = new string[CantidadOperaciones+2];
            ret[0] = $"Operaciones({CantidadOperaciones}):";
            Operacion o = null;
            for(int i = 0; i < CantidadOperaciones; i++)
            {
                o = operaciones[i];
                ret[i + 1] = o.ToString();
                recaudacion += o.CalcularMonto();
            }
            ret[ret.Length] = $"Recaudacion total:{recaudacion}";
            return ret;
        }
        public Empleado BuscarEmpleadoPorId(int id)
        {
            empleados.Sort();
            int i = empleados.BinarySearch(new Empleado(id));
            if (i >= 0)
            {
                return empleados[i];
            }
            return null;

        }
        public Cliente BuscarCLientePorDNI(int dni)
        {
            clientes.Sort();
            int i = clientes.BinarySearch(new Cliente (dni));
            if (i >= 0)
            {
                return clientes[i];
            }
            return null;
        }
    }
}
