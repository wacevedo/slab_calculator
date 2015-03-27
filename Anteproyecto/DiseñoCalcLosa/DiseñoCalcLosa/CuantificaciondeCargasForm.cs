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
    public partial class CuantificaciondeCargasForm : Form
    {
        public CuantificaciondeCargasForm()
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
        public Proyecto project;
        private CalculosProyecto cp;
        private void EspesoresViwsForm_Load(object sender, EventArgs e)
        {
            cp = new CalculosProyecto(project);
            dataGridView1.Rows.Add(cp.losas.Count);
            lblTitulo.Text += " " + project.Nombre;
            for (int i = 0; i <= cp.losas.Count - 1; i++)
            {
                cmbLosas.Items.Add(cp.losas[i].Nombre);                
                dataGridView1.Rows[i].Cells[0].Value = cp.losas[i].Nombre;
                dataGridView1.Rows[i].Cells[1].Value = cp.calculosLosas[i].T;                
            }

            cmbLosas.SelectedIndex = 0;
            comboBoxXY.SelectedIndex = 0;
            //labelTipoEdificio.Text = project.Nombre.Substring(0, project.Nombre.IndexOf(" a "));
            //string tipoedificio = project.Nombre.Substring(0, project.Nombre.IndexOf(" a "));
        }

        private void buttMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttSalir_Click(object sender, EventArgs e)
        {
            //MenuForm m = new MenuForm();
            //this.Hide();
            //m.Show();
            
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            if ((txtCargaAdicional.Text != "") && (textBoxCarga.Text != "") && (txtInclinacion.Text != ""))
            {
                Carga car = new Carga();
                car.Hinclinacion = Convert.ToDouble(txtInclinacion.Text);
                car.Xy = Convert.ToString(comboBoxXY.SelectedItem);
                car.Carga_adicional = Convert.ToDouble(txtCargaAdicional.Text);
                car.Carga_viva = Convert.ToDouble(cargaV);
                DatabaseLosa.Losa l = cp.losas[cmbLosas.SelectedIndex];
                CalculosLosa cl = cp.calculosLosas[cmbLosas.SelectedIndex];
                car.Id_losa = l.Id;
                CalculoCarga caca = new CalculoCarga(l, cl, project, car);
                dataGridView1.Rows[cmbLosas.SelectedIndex].Cells[2].Value = Convert.ToString(car.Hinclinacion) + " " + car.Xy;
                dataGridView1.Rows[cmbLosas.SelectedIndex].Cells[3].Value = caca.angulo;
                dataGridView1.Rows[cmbLosas.SelectedIndex].Cells[4].Value = caca.cargaMuerta;
                dataGridView1.Rows[cmbLosas.SelectedIndex].Cells[5].Value = caca.cargaViva;
                dataGridView1.Rows[cmbLosas.SelectedIndex].Cells[6].Value = car.Carga_adicional;
                dataGridView1.Rows[cmbLosas.SelectedIndex].Cells[7].Value = caca.cargaUltima;
                dataGridView1.Rows[cmbLosas.SelectedIndex].Cells[8].Value = caca.reaccion;
                dataGridView1.Rows[cmbLosas.SelectedIndex].Cells[9].Value = caca.reaccionAng;


            }
            else
            {
                MessageBox.Show("Hay campos vacios", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void treeViewCargasVivas_MouseLeave(object sender, EventArgs e)
        {
            int h = 64;
            int w = 117;            
            treeViewCargasVivas.Size = new Size(w, h);                 
        }

        private void treeViewCargasVivas_MouseEnter(object sender, EventArgs e)
        {
            
            int h = 384;
            for (int w = 117; w <= 230; w++)
                treeViewCargasVivas.Size = new Size(w, h);
        }

        string cargaV, angV;
        private void treeViewCargasVivas_DoubleClick(object sender, EventArgs e)
        {
            if (Convert.ToString(treeViewCargasVivas.SelectedNode.Tag) != "")
            {
                textBoxCarga.Text = Convert.ToString(treeViewCargasVivas.SelectedNode.Tag);
                cargaV = Convert.ToString(treeViewCargasVivas.SelectedNode.Tag).Substring(0, 3);
                angV = Convert.ToString(treeViewCargasVivas.SelectedNode.Tag).Substring(Convert.ToString(treeViewCargasVivas.SelectedNode.Tag).IndexOf("-"));
            }
        }

        private void buttMax_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Maximized;
                buttMax.Text = "2";
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                buttMax.Text = "1";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool cheack = true;

            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                for (int i = 2; i <= 9; i++)
                {
                    if (r.Cells[i].Value == null)
                    {
                        cheack = false;
                    }
                }
            }
            
            if (cheack == true)
            {
                                
                project.Estado = "Terminado";
                Broker b = new Broker();
                b.UpdateEstadoProyecto(project);

                for (int i = 0; i < cmbLosas.Items.Count; i++)
                {
                    DatabaseLosa.Carga caga = new DatabaseLosa.Carga();
                    cmbLosas.SelectedIndex = i;

                    int HiX = Convert.ToString(dataGridView1.Rows[cmbLosas.SelectedIndex].Cells[2].Value).IndexOf("X");
                    int HiY = Convert.ToString(dataGridView1.Rows[cmbLosas.SelectedIndex].Cells[2].Value).IndexOf("Y");

                    if (HiX == -1)
                    {
                        caga.Hinclinacion = Convert.ToDouble(Convert.ToString(dataGridView1.Rows[cmbLosas.SelectedIndex].Cells[2].Value).Substring(0, HiY - 1));
                        caga.Xy = Convert.ToString(dataGridView1.Rows[cmbLosas.SelectedIndex].Cells[2].Value).Substring(HiY);
                    }
                    else
                    {
                        caga.Hinclinacion = Convert.ToDouble(Convert.ToString(dataGridView1.Rows[cmbLosas.SelectedIndex].Cells[2].Value).Substring(0, HiX - 1));
                        caga.Xy = Convert.ToString(dataGridView1.Rows[cmbLosas.SelectedIndex].Cells[2].Value).Substring(HiX);
                    }
                    caga.Carga_viva = Convert.ToInt32(dataGridView1.Rows[cmbLosas.SelectedIndex].Cells[5].Value);
                    caga.Carga_adicional = Convert.ToInt32(dataGridView1.Rows[cmbLosas.SelectedIndex].Cells[6].Value);
                    caga.Id_losa = cp.losas[cmbLosas.SelectedIndex].Id;
                    b.InsertCarga(caga);

                }
                //MenuForm menu = new MenuForm();
                VerProyectoForm vp = new VerProyectoForm();
                vp.project = new DatabaseLosa.Proyecto();
                vp.project = b.selectProyecto(project.Id);
                this.Hide();
                vp.Show();
            }
            else
            {
                MessageBox.Show("Aun hay cargas sin calcular", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void allowNumber(object sender, KeyPressEventArgs e, char csymbol)
        {
            if (!char.IsControl(e.KeyChar) && (!char.IsDigit(e.KeyChar)) && (e.KeyChar != csymbol))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == csymbol) && (sender as TextBox).Text.IndexOf(csymbol) > -1)
            {
                e.Handled = true;
            }
        }
        private void validateTxtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            allowNumber(sender, e, '.');
        }
        
    }
}
