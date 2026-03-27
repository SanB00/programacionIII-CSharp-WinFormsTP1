using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_TP1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEjercicio1_Click(object sender, EventArgs e)
        {
            /*ejercicio1 ejercicio1 = new ejercicio1(this);
            ejercicio1.Show();
            this.Hide();
            */
            this.Hide();
            using (frmEjercicio1 frmEjercicio1 = new frmEjercicio1())
            {
                frmEjercicio1.ShowDialog();
            }
            this.Show();
        }

        private void btnEjercicio2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblIntegrante1_Click(object sender, EventArgs e)
        {

        }

        private void lblIntegrantes_Click(object sender, EventArgs e)
        {

        }

        private void labelIntegrante4_Click(object sender, EventArgs e)
        {

        }
    }
}
