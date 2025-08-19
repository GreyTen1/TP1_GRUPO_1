using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1_GRUPO_1
{
    public partial class FormEj1 : Form
    {
        Form1 form1;
        public FormEj1(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void FormEj1_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bool repetido = false;
            foreach (string nombre in lbNombres1.Items)
            {
                if (tbxNombre.Text.ToUpper() == nombre.ToUpper()) {repetido = true;}
            }

            if (tbxNombre.Text == "") {
                MessageBox.Show("Debe ingresar un nombre.", "Error");
                tbxNombre.Focus();
            } else if (repetido)
            {
                MessageBox.Show("El nombre ya está en la lista.", "Error");
                tbxNombre.Clear();
            }
            else
            {
            lbNombres1.Items.Add(tbxNombre.Text);
            tbxNombre.Clear();
            }

            
        }

        private void lbNombres2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
