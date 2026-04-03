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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim(); 
            string apellido = txtApellido.Text.Trim();
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido))
            {
                MessageBox.Show("Por favor ingrese un nombre y apellido");
            }
            else
            {
                string nombreCompleto = nombre + " " + apellido;
                bool existe = false;

                foreach (var item in lstNombres.Items)
                {
                    if (nombreCompleto.ToUpper() == item.ToString().Trim().ToUpper())
                    {
                        existe = true;
                        break;
                    }
                }

                if (existe)
                {
                    MessageBox.Show("Ese nombre ya está en la lista");
                    txtNombre.Clear();
                    txtApellido.Clear();
                }
                else
                {
                    MessageBox.Show("Nombre completo: " + nombreCompleto);
                    lstNombres.Items.Add(nombre + " " + apellido);

                    for (int i = 0; i < lstNombres.Items.Count - 1; i++)
                    {
                        for (int j = i + 1; j < lstNombres.Items.Count; j++)
                        {
                            string nombre1 = lstNombres.Items[i].ToString();
                            string nombre2 = lstNombres.Items[j].ToString();

                            if (nombre1.CompareTo(nombre2) > 0)
                            {
                                lstNombres.Items[i] = nombre2;
                                lstNombres.Items[j] = nombre1;
                            }
                        }
                    }

                    txtNombre.Clear();
                    txtApellido.Clear();
                }
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (lstNombres.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un elemento para borrar");
            }
            else
            {
                while (lstNombres.SelectedItems.Count > 0)
                {
                    lstNombres.Items.Remove(lstNombres.SelectedItems[0]);
                }
            }

        }
    }
    }

