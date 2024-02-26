using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafetería_Mi_U
{
    public partial class Contadordejamones : Form
    {
        public Contadordejamones()
        {
            InitializeComponent();
        }
        private void limpiar()
        {
            this.cmbDia.SelectedIndex = 0;
            this.cheBoxAdQuin.Checked = false;
            this.cheBoxAdFest.Checked = false;
            this.lblCant.Text = string.Empty;
            this.lblVrAPagar.Text = string.Empty;
            this.cmbDia.Focus();

        }
        private void llenarcombo()
        {
            this.cmbDia.Items.Add("seleccione un Día");//index=0
            this.cmbDia.Items.Add("lunes");//index=1
            this.cmbDia.Items.Add("martes");//index=2
            this.cmbDia.Items.Add("miércoles");//index=3
            this.cmbDia.Items.Add("jueves");//index=4
            this.cmbDia.Items.Add("viernes");//index=5
            this.cmbDia.Items.Add("sábado");//index=6
            this.cmbDia.SelectedIndex = 0;
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblCant_Click(object sender, EventArgs e)
        {

        }

        private void lblVrAPagar_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbdia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Contadordejamones_Load(object sender, EventArgs e)
        {
            llenarcombo();
        }
    }
}
