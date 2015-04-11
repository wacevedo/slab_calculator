using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using AlphaForms;

namespace DiseñoCalcLosa
{
    public partial class TablaDeCoeficientesForm : AlphaForm
    {
        public TablaDeCoeficientesForm()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        public extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        public extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void rectangleTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void buttSalir_Click(object sender, EventArgs e)
        {
            //this.Close();
            this.Hide();
            MenuForm wMenu = new MenuForm();
            wMenu.Show();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }

        private void buttMini_Click_1(object sender, EventArgs e)
        {
          this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuForm wMenu = new MenuForm();
            wMenu.Show();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }
    }
}
