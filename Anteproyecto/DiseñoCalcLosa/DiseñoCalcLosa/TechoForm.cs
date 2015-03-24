using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DiseñoCalcLosa
{
    public partial class TechoForm : Form
    {
        public TechoForm()
        {
            InitializeComponent();
        }

        private void rectangleTitulo_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void buttMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
