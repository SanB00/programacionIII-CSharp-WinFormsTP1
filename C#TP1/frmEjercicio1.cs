using C_TP1;
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
    public partial class frmEjercicio1 : Form
    {
        Form1 form1;
        public frmEjercicio1()
        {
            InitializeComponent();
        }
        public frmEjercicio1(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void frmEjercicio1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool existe = false;

            if (tbNombres.Text.Trim().Length > 0)
            {
                foreach (string item in lbNombres.Items)
                {
                    if (tbNombres.Text.Trim().ToUpper() == item)
                    {
                        existe = true;
                        break;
                    }
                }

                if (existe)
                {
                    MessageBox.Show("Ese nombre ya fue ingresado.");
                    tbNombres.Text = string.Empty;
                }
                else
                {
                    lbNombres.Items.Add(tbNombres.Text.Trim().ToUpper());
                    tbNombres.Text = string.Empty;
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar un Nombre");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                if (lbNombres.SelectedItem == null)
                {
                    MessageBox.Show("Debe seleccionar un elemento");
                    return;
                }

                var item = lbNombres.SelectedItem;

                lbNombres2.Items.Add(item);

                lbNombres.Items.Remove(item);
            }
        }

        private void lbNombres2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbNombres_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void frmEjercicio1_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.Show();
        }

    }
}

