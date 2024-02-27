using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using libOpeComp;

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

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            bool boolQuinc;
            bool boolFest;
            try
            {
                int intDia = this.cmbDia.SelectedIndex;
                switch (intDia)
                {
                    case 1:
                        intDia = 1;
                        break;
                    case 2:
                        intDia = 2;
                        break;
                    case 3:
                        intDia = 3;
                        break;
                    case 4:
                        intDia = 4;
                        break;
                    case 5:
                        intDia = 5;
                        break;
                    case 6:
                        intDia = 6;
                        break;
                    default:

                        break;
                }
                clsOpeComp opeComp = new clsOpeComp();

                boolFest = this.cheBoxAdQuin.Checked;
                boolQuinc = this.cheBoxAdQuin.Checked;
                this.lblCant.Text = Convert.ToString(opeComp.Cantidad);
                this.lblVrAPagar.Text = Convert.ToString(opeComp.CantApagar);

            }
            catch (Exception ex)
            {

                mensaje(ex.Message);
            }
            

        }
        private void mensaje(string texto)
        {
            MessageBox.Show(texto);

        }
    }
}
