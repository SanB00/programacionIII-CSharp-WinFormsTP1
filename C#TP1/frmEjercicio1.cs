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
    public partial class FrmEjercicio1 : Form
    {
        public FrmEjercicio1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            bool existe = false;

            String strTxtNombre = tbNombres.Text.Trim();

            if (strTxtNombre.Length <= 0)
            {
                MessageBox.Show("Debe ingresar un Nombre");
                tbNombres.Text = string.Empty;
                return;
            }

            if (elNombreEstaEnLaLista(strTxtNombre, lbNombres))
            {
                MessageBox.Show("Ese nombre ya fue ingresado en la lista 1.");
                tbNombres.Text = string.Empty;
                return;
            }

            if (elNombreEstaEnLaLista(strTxtNombre, lbNombres2))
            {
                MessageBox.Show("Ese nombre ya fue ingresado en la lista 2.");
                tbNombres.Text = string.Empty;
                return;
            }

            lbNombres.Items.Add(tbNombres.Text.Trim());
            tbNombres.Text = string.Empty;
        }

        private bool elNombreEstaEnLaLista(String nombreAValidar, ListBox lstNombres)
        {
            foreach (string item in lstNombres.Items)
            {
                if (nombreAValidar.Trim().ToUpper() == item.ToUpper())
                {
                    return true;
                }
            }
            return false;
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
        private void button3_Click(object sender, EventArgs e)
        {
            foreach (var item in lbNombres.Items)
            {
                lbNombres2.Items.Add(item);
            }
            lbNombres.Items.Clear();
        }
    }
}
