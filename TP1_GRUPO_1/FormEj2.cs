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
    public partial class FormEj2 : Form
    {
        Form1 form1;
        public FormEj2(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void FormEj2_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.Show();
        }

        private void FormEj2_Load(object sender, EventArgs e)
        {

        }
    }
}
