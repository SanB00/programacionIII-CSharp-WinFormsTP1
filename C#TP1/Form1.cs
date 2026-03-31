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
            this.Hide();
            using (FrmEjercicio1 frmEjercicio1 = new FrmEjercicio1())
            {
                frmEjercicio1.ShowDialog();
            }
            this.Show();
        }

        private void btnEjercicio2_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (FrmEjercicio2 frmEjercicio2 = new FrmEjercicio2())
            {
                frmEjercicio2.ShowDialog();
            }
            this.Show();
        }

        private void btnEjercicio3_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (FrmEjercicio3 frmEjercicio3 = new FrmEjercicio3())
            {
                frmEjercicio3.ShowDialog();
            }
            this.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             
        }
    }
}
