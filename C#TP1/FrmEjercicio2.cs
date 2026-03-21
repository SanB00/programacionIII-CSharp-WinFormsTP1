using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace C_TP1
{
    public partial class FrmEjercicio2 : Form
    {
        public FrmEjercicio2()
        {
            InitializeComponent();
        }

        private void FrmEjercicio2_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido))
            {
                MessageBox.Show("Por favor ingrese un nombre y apellido");
            }
            else
            {
              MessageBox.Show("Nombre completo: " + nombre +" " + apellido);
            }
        }
    }
}
