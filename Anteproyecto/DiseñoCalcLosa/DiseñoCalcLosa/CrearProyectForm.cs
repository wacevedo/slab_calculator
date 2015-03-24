using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using DatabaseLosa;

namespace DiseñoCalcLosa
{
    public partial class CrearProyectForm : Form //ponerlo alphaform al final
    {
        public CrearProyectForm()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        public extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        public extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
       
        private void labelTitulo_Click(object sender, EventArgs e)
        {
            
        }

        private void buttSalir_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void rectangleTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        

        private void buttMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttMax_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
            this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            //wMenu = new MenuForm();
            labelPandereta.Visible = false;
            textBoxPandereta.Visible = false;
            labelmedidaPand.Visible = false;

            comboBoxtipoedif.SelectedIndex = 1;
            comboBoxTipoLosa.SelectedIndex = 1;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //label7.Text = Convert.ToString(comboBoxTipoLosa.SelectedValue);
            if (comboBoxTipoLosa.SelectedIndex == 0)
            {
                labelPandereta.Visible = true;
                textBoxPandereta.Visible = true;
                labelmedidaPand.Visible = true;
            }
            else
            {
                labelPandereta.Visible = false;
                textBoxPandereta.Visible = false;
                labelmedidaPand.Visible = false;
            }
        }

        private void buttSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {
            //if((numericUpDownNivel.Value!=0)&&(comboBoxTipoLosa.SelectedItem!=null)&&(comboBoxtipoedif.SelectedItem!=null))
            if ((textBoxPesoEsp.Text != "") && (textBoxTeminacion.Text != "") && (textBoxNombre.Text!= string.Empty))
            {
                
                CalcLosaForm w = new CalcLosaForm();

                //creando proyecto para luego ser guardado
                w.project = new Proyecto();//instanciando clase proyecto
                string id = DateTime.Now.ToString("yyMMddhhmm"); //creando id del proyecto
                w.project.Id = Convert.ToInt64(id);//pasando id del proyecto a la instancia
                w.project.Nombre = textBoxNombre.Text;
                if(numericUpDownNivel.Value > 1)
                    w.project.Tipo_edificio = Convert.ToString(comboBoxtipoedif.SelectedItem)+" a "+ Convert.ToString(numericUpDownNivel.Value)+" niveles";
                else
                    w.project.Tipo_edificio = Convert.ToString(comboBoxtipoedif.SelectedItem) + " a " + Convert.ToString(numericUpDownNivel.Value) + " nivel";

                w.project.Fecha = Convert.ToString(DateTime.Now);

                if (textBoxPandereta.Visible == true)
                    w.project.Pandereta = Convert.ToDouble(textBoxPandereta.Text);
                else
                    w.project.Pandereta = -1;
                w.project.Tipo_losa = Convert.ToString(comboBoxTipoLosa.SelectedItem);
                w.project.Peso_concreto = Convert.ToDouble(textBoxPesoEsp.Text);
                w.project.Terminacion = Convert.ToDouble(textBoxTeminacion.Text);
                w.project.Usuario = labelUser.Text;

                this.Hide();
                w.Show();
            }
            else
            {
                MessageBox.Show("Hay campos vacios que son necesarios para los calculos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } 
        

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuForm wMenu = new MenuForm();
            wMenu.Show();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }

        private void textBoxPesoEsp_KeyPress(object sender, KeyPressEventArgs e)
        {
            char letra = e.KeyChar;


            if (letra == 8 && textBoxPesoEsp.Text.IndexOf(".") != -1)
            {
                e.Handled = true;
                return;
            }


            if (!Char.IsDigit(letra) && letra != 8 && letra != 46)
            {
                e.Handled = true;
            }
        }

        private void textBoxTeminacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            char letra = e.KeyChar;


            if (letra == 8 && textBoxTeminacion.Text.IndexOf(".") != -1)
            {
                e.Handled = true;
                return;
            }
            

            if (!Char.IsDigit(letra) && letra != 8 && letra != 46)
            {
                e.Handled = true;
            }
        }

        private void textBoxPandereta_KeyPress(object sender, KeyPressEventArgs e)
        {
            char letra = e.KeyChar;


            if (letra == 8 && textBoxPandereta.Text.IndexOf(".") != -1)
            {
                e.Handled = true;
                return;
            }


            if (!Char.IsDigit(letra) && letra != 8 && letra != 46)
            {
                e.Handled = true;
            }
        }
    }
}
