using AndaChe.models;
using AndaChe.models.vehiculo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AndaChe.models.operacion;

namespace AndaChe
{
    public partial class Form1 : Form
    {
        Consecionaria cons = new Consecionaria();
        Empleado eVenta;
        Cliente cVenta;
        Vehiculo vVenta;
        public Form1()
        {
            InitializeComponent();
            if (cons.CantidadEmpleados < 1)
            {
                groupBox4.Enabled = false;
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            Agregar agregar = new Agregar();
            agregar.tBesp.Enabled = true;
            agregar.tBcom.Enabled = true;
            agregar.tBdir.Enabled = true;
            string nom;
            string tel;
            int dni;
            int nro;
            Persona p = null;
            if (rBclientes.Checked)
            {
                agregar.tBesp.Enabled = false;
                agregar.tBcom.Enabled = false;
                if (agregar.ShowDialog() == DialogResult.OK)
                {
                    nom = agregar.tBnom.Text;
                    tel = agregar.tBtel.Text;
                    dni = Convert.ToInt32(agregar.tBdni.Text);
                    nro = Convert.ToInt32(agregar.tBnro.Text);
                    string dir = agregar.tBdir.Text;
                    p = new Cliente(dir,nom,tel,dni,nro);
                    
                }
                if (p != null)
                {
                    cons.Agregar(p as Cliente);
                    cBclientes.Items.Add(p);
                }

            }
            if (rBvehiculos.Checked)
            {
                AgregarVehiculo addV = new AgregarVehiculo();
                if (addV.ShowDialog() == DialogResult.OK)
                {
                    Vehiculo v = null;
                    Chasis c;
                    MotorElectrico m = null;
                    string marcaMotor;
                    int nroMotor;
                    string marchaChasis = addV.tbMarcaChasis.Text;
                    int nroChasis = Convert.ToInt32(addV.tbNroChasis.Text);
                    c = new Chasis(marchaChasis, nroChasis);
                    string modelo = addV.tbModelo.Text;
                    string marca = addV.tbMarca.Text;
                    int año = Convert.ToInt32(addV.tbAño.Text);
                    double precio = Convert.ToDouble(addV.tBprecio.Text);
                    string patente = addV.tbPatente.Text;
                    double medidaRodado = Convert.ToDouble(addV.tbMedRodado.Text);
                    string tbTipoLlantas = addV.tbTipollantas.Text;
                    string estadoCub = addV.tbEstadoCubiertas.Text;
                    bool aireAc = addV.rbAireA.Checked;
                    bool espElec = addV.rbEspejosElectricos.Checked;
                    string tap = addV.tbTapizado.Text;
                    int camaras = Convert.ToInt32(addV.nCamaras.TextAlign);
                    int pantallas = Convert.ToInt32(addV.nPantallas.Text);
                    double km = Convert.ToDouble(addV.tbKilometros.Text);
                    string color = addV.tbColor.Text;
                    string caja = addV.tbCajadecambios.Text;
                    double capTan = Convert.ToDouble(addV.nCapacidad.Text);
                    int velocidades = Convert.ToInt32(addV.nVel.Text);
                    DateTime fechaCambio = addV.fechaCambio.Value;
                    double kmCambio = Convert.ToDouble(addV.KmUcambio.Text);
                    if (addV.rbHibrido.Checked)
                    {
                        marcaMotor = addV.tbMarcaME.Text;
                        nroMotor = Convert.ToInt32(addV.tbSerieME.Text);
                        int baterias = Convert.ToInt32(addV.nBaterias.Text);
                        string tipoCarga = addV.tbCarga.Text;
                        double consumoRuta = Convert.ToDouble(addV.tbConsumoPromR.Text);
                        double consumoCiudad = Convert.ToDouble(addV.tbConsPC.Text);

                        m = new MotorElectrico(nroMotor, marcaMotor);
                        v = new Hibrido(modelo, marca, año, precio, patente);                    }
                    if (addV.rbNormal.Checked)
                    {
                        string comb = addV.tbComb.Text;
                        marcaMotor = addV.tbMarcaME.Text;
                        nroMotor = Convert.ToInt32(addV.tbSerieME.Text);
                        m = new Motor(nroMotor, marcaMotor, comb);
                        v = new Vehiculo(modelo, marca, año, precio, patente);
                    }
                    v.AñadirEspecificaciones(medidaRodado, tbTipoLlantas, tap, km, color, caja, velocidades, pantallas, camaras, espElec, aireAc, capTan, estadoCub, fechaCambio, kmCambio, m, c);
                }
            }
            if (rBempleados.Checked)
            {
                agregar.tBesp.Enabled = false;
                agregar.tBdir.Enabled = false;
                if (agregar.ShowDialog() == DialogResult.OK)
                {
                    nom = agregar.tBnom.Text;
                    tel = agregar.tBtel.Text;
                    dni = Convert.ToInt32(agregar.tBdni.Text);
                    nro = Convert.ToInt32(agregar.tBnro.Text);
                    int com = Convert.ToInt32(agregar.tBdir.Text);
                    p = new Empleado(nro, com, dni, nom, tel);
                    
                }
                if (p != null)
                {
                    cons.Agregar(p as Empleado);
                    cBclientes.Items.Add(p);
                }
                
            }
            if (rBtecnicos.Checked)
            {
                agregar.tBcom.Enabled = false;
                agregar.tBdir.Enabled = false;
                if (agregar.ShowDialog() == DialogResult.OK)
                {
                    nom = agregar.tBnom.Text;
                    tel = agregar.tBtel.Text;
                    dni = Convert.ToInt32(agregar.tBdni.Text);
                    nro = Convert.ToInt32(agregar.tBnro.Text);
                    string esp = agregar.tBesp.Text;
                    p = new Tecnico(nro, esp, nom, tel, dni);
                    
                }
                if (p != null)
                {
                    cons.Agregar(p as Tecnico);
                    cBclientes.Items.Add(p);
                }
            }

        }

        private void cBclientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            tBver.Clear();
            Cliente c = cBclientes.SelectedItem as Cliente;
            tBver.Text = c.ToString();

        }

        private void tBdniVenta_TextChanged(object sender, EventArgs e)
        {

        }

        private void tBdniVenta_Leave(object sender, EventArgs e)
        {
            int dni = Convert.ToInt32(tBdniClienteVenta.Text);
            cVenta = cons.BuscarCLientePorDNI(dni);
            if (cVenta != null)
            {
                lBdatosventa.Items.Add(cVenta);
            }
            else
            {
                throw new Exception("Cliente inexistente");
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tBnroClienteVenta_Leave(object sender, EventArgs e)
        {
    
        }

        private void lBdatosventa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
