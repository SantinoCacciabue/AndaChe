using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AndaChe
{
    public partial class AgregarVehiculo : Form
    {
        public AgregarVehiculo()
        {
            InitializeComponent();
        }

        private void tbCamaras_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbHibrido_CheckedChanged(object sender, EventArgs e)
        {
            gpMotor.Enabled = false;
            gpHibrido.Enabled = true;
        }

        private void rbNormal_CheckedChanged(object sender, EventArgs e)
        {
            gpMotor.Enabled = true;
            gpHibrido.Enabled = false;
        }
    }
    
}
