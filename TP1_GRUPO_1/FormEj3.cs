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
    public partial class FormEj3 : Form
    {
        Form1 form1;
        public FormEj3(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void FormEj3_Load(object sender, EventArgs e)
        {

        }

        private void FormEj3_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.Show();
        }
    }
}
