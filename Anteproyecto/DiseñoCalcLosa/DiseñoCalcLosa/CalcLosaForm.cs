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
    public partial class CalcLosaForm : Form //ponerlo alphaform al final
    {
        public DatabaseLosa.Proyecto project;        

        public CalcLosaForm()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        public extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        public extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        List<Losa> aLosas = new List<Losa>();
        DatabaseLosa.Losa[] almLosas; 

        private void MainForm_Load(object sender, EventArgs e)
        {  
            almLosas = new DatabaseLosa.Losa[60];
            groupBoxEn1DirecX.Visible = false;
            groupBoxEn1DirecY.Visible = false;
            groupBoxEn2Direc.Visible = false;
            lblTitulo.Text = lblTitulo.Text+" - " + project.Nombre;
           
            buttonCalcular.Enabled = false;
            
            
            for (int x = 0; x <= 59; x++)
            {
                Losa l = new Losa();
                l.Nombre = "L" + (x + 1);
                aLosas.Add(l);
            }
            //numericUpDownCantidadLosa.Value = 1;
            dataGridView1.Rows.Add(1);
            dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0].Value = "L-1";

        }
        

        private void labelTitulo_Click(object sender, EventArgs e)
        {

        }

        private void buttSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rectangleTitulo_MouseDown(object sender, MouseEventArgs e)//metodo para mover asistido por el dll intanciado mas arriba
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

        #region Regtangles
        private void rectangleShape3_Click(object sender, EventArgs e)
        {
            if ((rectangleShapeBordeDer.FillStyle == Microsoft.VisualBasic.PowerPacks.FillStyle.Transparent) &
                (rectangleShapeBordeDer.BorderStyle == System.Drawing.Drawing2D.DashStyle.Solid))
            {
                rectangleShapeBordeDer.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.BackwardDiagonal;
                rectangleShapeBordeDer.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            }
            else if (rectangleShapeBordeDer.FillStyle == Microsoft.VisualBasic.PowerPacks.FillStyle.BackwardDiagonal)
            {
                rectangleShapeBordeDer.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Transparent;
                rectangleShapeBordeDer.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            }
            else if (rectangleShapeBordeDer.BorderStyle == System.Drawing.Drawing2D.DashStyle.Dash)
            {
                rectangleShapeBordeDer.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Transparent;
                rectangleShapeBordeDer.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            }

        }

        private void rectangleShape4_Click(object sender, EventArgs e)
        {
            if ((rectangleShapeBordeInf.FillStyle == Microsoft.VisualBasic.PowerPacks.FillStyle.Transparent) &
                (rectangleShapeBordeInf.BorderStyle == System.Drawing.Drawing2D.DashStyle.Solid))
            {
                rectangleShapeBordeInf.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.BackwardDiagonal;
                rectangleShapeBordeInf.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            }
            else if (rectangleShapeBordeInf.FillStyle == Microsoft.VisualBasic.PowerPacks.FillStyle.BackwardDiagonal)
            {
                rectangleShapeBordeInf.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Transparent;
                rectangleShapeBordeInf.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            }
            else if (rectangleShapeBordeInf.BorderStyle == System.Drawing.Drawing2D.DashStyle.Dash)
            {
                rectangleShapeBordeInf.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Transparent;
                rectangleShapeBordeInf.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            }
        }

        private void rectangleShape5_Click(object sender, EventArgs e)
        {
            if ((rectangleShapeBordeSup.FillStyle == Microsoft.VisualBasic.PowerPacks.FillStyle.Transparent)&
                (rectangleShapeBordeSup.BorderStyle == System.Drawing.Drawing2D.DashStyle.Solid))
            {
                rectangleShapeBordeSup.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.BackwardDiagonal;
                rectangleShapeBordeSup.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            }
            else if (rectangleShapeBordeSup.FillStyle == Microsoft.VisualBasic.PowerPacks.FillStyle.BackwardDiagonal)
            {
                rectangleShapeBordeSup.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Transparent;
                rectangleShapeBordeSup.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            }
            else if (rectangleShapeBordeSup.BorderStyle == System.Drawing.Drawing2D.DashStyle.Dash)
            {
                rectangleShapeBordeSup.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Transparent;
                rectangleShapeBordeSup.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            }
        }

        private void rectangleShape2_Click(object sender, EventArgs e)
        {
            if ((rectangleShapeBordeIzq.FillStyle == Microsoft.VisualBasic.PowerPacks.FillStyle.Transparent) &
                (rectangleShapeBordeIzq.BorderStyle == System.Drawing.Drawing2D.DashStyle.Solid))
            {
                rectangleShapeBordeIzq.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.BackwardDiagonal;
                rectangleShapeBordeIzq.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            }
            else if (rectangleShapeBordeIzq.FillStyle == Microsoft.VisualBasic.PowerPacks.FillStyle.BackwardDiagonal)
            {
                rectangleShapeBordeIzq.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Transparent;
                rectangleShapeBordeIzq.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            }
            else if (rectangleShapeBordeIzq.BorderStyle == System.Drawing.Drawing2D.DashStyle.Dash)
            {
                rectangleShapeBordeIzq.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Transparent;
                rectangleShapeBordeIzq.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            }
        }

        private void rectangleShape16_Click(object sender, EventArgs e)
        {
            if ((rectangleShapeXArriba.FillStyle == Microsoft.VisualBasic.PowerPacks.FillStyle.Transparent) &
                (rectangleShapeXArriba.BorderStyle == System.Drawing.Drawing2D.DashStyle.Solid))
            {
                rectangleShapeXArriba.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.BackwardDiagonal;
                rectangleShapeXArriba.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            }
            else if (rectangleShapeXArriba.FillStyle == Microsoft.VisualBasic.PowerPacks.FillStyle.BackwardDiagonal)
            {
                rectangleShapeXArriba.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Transparent;
                rectangleShapeXArriba.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            }
            else if (rectangleShapeXArriba.BorderStyle == System.Drawing.Drawing2D.DashStyle.Dash)
            {
                rectangleShapeXArriba.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Transparent;
                rectangleShapeXArriba.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            }
        }

        private void rectangleShape18_Click(object sender, EventArgs e)
        {
            if ((rectangleShapeXIzq.FillStyle == Microsoft.VisualBasic.PowerPacks.FillStyle.Transparent) &
                (rectangleShapeXIzq.BorderStyle == System.Drawing.Drawing2D.DashStyle.Solid))
            {
                rectangleShapeXIzq.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.BackwardDiagonal;
                rectangleShapeXIzq.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            }
            else if (rectangleShapeXIzq.FillStyle == Microsoft.VisualBasic.PowerPacks.FillStyle.BackwardDiagonal)
            {
                rectangleShapeXIzq.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Transparent;
                rectangleShapeXIzq.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            }
            else if (rectangleShapeXIzq.BorderStyle == System.Drawing.Drawing2D.DashStyle.Dash)
            {
                rectangleShapeXIzq.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Transparent;
                rectangleShapeXIzq.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            }
        }

        private void rectangleShape19_Click(object sender, EventArgs e)
        {
            if ((rectangleShapeXDer.FillStyle == Microsoft.VisualBasic.PowerPacks.FillStyle.Transparent) &
                (rectangleShapeXDer.BorderStyle == System.Drawing.Drawing2D.DashStyle.Solid))
            {
                rectangleShapeXDer.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.BackwardDiagonal;
                rectangleShapeXDer.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            }
            else if (rectangleShapeXDer.FillStyle == Microsoft.VisualBasic.PowerPacks.FillStyle.BackwardDiagonal)
            {
                rectangleShapeXDer.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Transparent;
                rectangleShapeXDer.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            }
            else if (rectangleShapeXDer.BorderStyle == System.Drawing.Drawing2D.DashStyle.Dash)
            {
                rectangleShapeXDer.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Transparent;
                rectangleShapeXDer.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            }
        }

        private void rectangleShape17_Click(object sender, EventArgs e)
        {
            if ((rectangleShapeXAbajo.FillStyle == Microsoft.VisualBasic.PowerPacks.FillStyle.Transparent) &
                (rectangleShapeXAbajo.BorderStyle == System.Drawing.Drawing2D.DashStyle.Solid))
            {
                rectangleShapeXAbajo.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.BackwardDiagonal;
                rectangleShapeXAbajo.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            }
            else if (rectangleShapeXAbajo.FillStyle == Microsoft.VisualBasic.PowerPacks.FillStyle.BackwardDiagonal)
            {
                rectangleShapeXAbajo.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Transparent;
                rectangleShapeXAbajo.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            }
            else if (rectangleShapeXAbajo.BorderStyle == System.Drawing.Drawing2D.DashStyle.Dash)
            {
                rectangleShapeXAbajo.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Transparent;
                rectangleShapeXAbajo.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            }
            
        }

#endregion

        private void resetRegtangles()
        {
            rectangleShapeBordeDer.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Transparent;
            rectangleShapeBordeDer.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;

            rectangleShapeYArriba.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Transparent;
            rectangleShapeYArriba.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;

            rectangleShapeBordeInf.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Transparent;
            rectangleShapeBordeInf.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;

            rectangleShapeBordeIzq.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Transparent;
            rectangleShapeBordeIzq.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;

            rectangleShapeBordeSup.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Transparent;
            rectangleShapeBordeSup.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;

            rectangleShapeXAbajo.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Transparent;
            rectangleShapeXAbajo.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;

            rectangleShapeXArriba.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Transparent;
            rectangleShapeXArriba.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;

            rectangleShapeXDer.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Transparent;
            rectangleShapeXDer.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;

            rectangleShapeXIzq.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Transparent;
            rectangleShapeXIzq.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;

            rectangleShapeYAbajo.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Transparent;
            rectangleShapeYAbajo.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;

            rectangleShapeYDer.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Transparent;
            rectangleShapeYDer.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;

            rectangleShapeYIzq.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Transparent;
            rectangleShapeYIzq.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;

            groupBoxEn1DirecX.Visible = false;
            groupBoxEn1DirecY.Visible = false;
            groupBoxEn2Direc.Visible = false;
               
        }
        private void button1_Click(object sender, EventArgs e)
        {            
            almLosas[cmbLosas.SelectedIndex] = new DatabaseLosa.Losa();
            almLosas[cmbLosas.SelectedIndex].Lx = Convert.ToDouble(txtLx.Text);
            dataGridView1.Rows[cmbLosas.SelectedIndex].Cells[1].Value = txtLx.Text;
            almLosas[cmbLosas.SelectedIndex].Ly = Convert.ToDouble(txtLy.Text);
            dataGridView1.Rows[cmbLosas.SelectedIndex].Cells[2].Value = txtLy.Text;
            double m;
            if ((Convert.ToDouble(txtLx.Text)) <= (Convert.ToDouble(txtLy.Text)))
            {
                  m = Convert.ToDouble(txtLx.Text) / Convert.ToDouble(txtLy.Text);
            }
            else
            {
                 m = Convert.ToDouble(txtLy.Text) / Convert.ToDouble(txtLx.Text);
            }
            if ((m >= 0.5))
            {

                if (rectangleShapeBordeSup.FillStyle != Microsoft.VisualBasic.PowerPacks.FillStyle.BackwardDiagonal)
                {
                    //bordes++;
                    //bordeX++;
                    almLosas[cmbLosas.SelectedIndex].Bordesx++;
                }
                if (rectangleShapeBordeInf.FillStyle != Microsoft.VisualBasic.PowerPacks.FillStyle.BackwardDiagonal)
                {
                    //bordes++;
                    //bordeX++;
                    almLosas[cmbLosas.SelectedIndex].Bordesx++;
                }
                if (rectangleShapeBordeIzq.FillStyle != Microsoft.VisualBasic.PowerPacks.FillStyle.BackwardDiagonal)
                {
                    //bordes++;
                    //bordeY++;
                    almLosas[cmbLosas.SelectedIndex].BordesY++;
                }
                if (rectangleShapeBordeDer.FillStyle != Microsoft.VisualBasic.PowerPacks.FillStyle.BackwardDiagonal)
                {
                    //bordes++;
                    //bordeY++;
                    almLosas[cmbLosas.SelectedIndex].BordesY++;
                }
            }
            else
            {
                if ((m < 0.5) && (groupBoxEn1DirecX.Visible == true))
                {
                    if (rectangleShapeXArriba.FillStyle != Microsoft.VisualBasic.PowerPacks.FillStyle.BackwardDiagonal)
                    {
                        //bordes++;
                        //bordeX++;
                        almLosas[cmbLosas.SelectedIndex].Bordesx++;
                    }
                    if (rectangleShapeXAbajo.FillStyle != Microsoft.VisualBasic.PowerPacks.FillStyle.BackwardDiagonal)
                    {
                        //bordes++;
                        //bordeX++;
                        almLosas[cmbLosas.SelectedIndex].Bordesx++;
                    }
                    if (rectangleShapeXIzq.BorderStyle == System.Drawing.Drawing2D.DashStyle.Dash)
                    {
                        //bordes++;
                        //bordeY++;
                        almLosas[cmbLosas.SelectedIndex].BordesY++;
                    }
                    if (rectangleShapeXDer.BorderStyle == System.Drawing.Drawing2D.DashStyle.Dash)
                    {
                        //bordes++;
                        //bordeY++;
                        almLosas[cmbLosas.SelectedIndex].BordesY++;
                    }
                }
                else if (((m < 0.5) && (groupBoxEn1DirecY.Visible == true)))
                {
                    if (rectangleShapeYArriba.BorderStyle == System.Drawing.Drawing2D.DashStyle.Dash)
                    {
                        //bordes++;
                        //bordeX++;
                        almLosas[cmbLosas.SelectedIndex].Bordesx++;
                    }
                    if (rectangleShapeYAbajo.BorderStyle == System.Drawing.Drawing2D.DashStyle.Dash)
                    {
                        //bordes++;
                        //bordeX++;
                        almLosas[cmbLosas.SelectedIndex].Bordesx++;
                    }
                    if (rectangleShapeYIzq.FillStyle != Microsoft.VisualBasic.PowerPacks.FillStyle.BackwardDiagonal)
                    {
                        //bordes++;
                        //bordeY++;
                        almLosas[cmbLosas.SelectedIndex].BordesY++;
                    }
                    if (rectangleShapeYDer.FillStyle != Microsoft.VisualBasic.PowerPacks.FillStyle.BackwardDiagonal)
                    {
                        //bordes++;
                        //bordeY++;
                        almLosas[cmbLosas.SelectedIndex].BordesY++;
                    }
                }
            }
            CalculosLosa cl = new CalculosLosa(almLosas[cmbLosas.SelectedIndex]);
            dataGridView1.Rows[cmbLosas.SelectedIndex].Cells[3].Value = cl.LcLl;
            dataGridView1.Rows[cmbLosas.SelectedIndex].Cells[4].Value = cl.direccionLosa;
            dataGridView1.Rows[cmbLosas.SelectedIndex].Cells[5].Value = cl.bordesDiscontinuos;
            dataGridView1.Rows[cmbLosas.SelectedIndex].Cells[6].Value = cl.losa.Bordesx;
            dataGridView1.Rows[cmbLosas.SelectedIndex].Cells[7].Value = cl.losa.BordesY;
            dataGridView1.Rows[cmbLosas.SelectedIndex].Cells[8].Value = cl.apoyoArmadoEnUnaDireccion;
            dataGridView1.Rows[cmbLosas.SelectedIndex].Cells[9].Value = cl.tmin;
            dataGridView1.Rows[cmbLosas.SelectedIndex].Cells[10].Value = cl.p180;
            dataGridView1.Rows[cmbLosas.SelectedIndex].Cells[11].Value = cl.T;
            dataGridView1.Rows[cmbLosas.SelectedIndex].Cells[12].Value = cl.usar;

            resetRegtangles();
            if ((Convert.ToDouble(cl.T) >= 16.00)&&(dataGridView1.Rows[cmbLosas.SelectedIndex].Cells[8].Value != "en voladizo"))
            {                 
                MessageBox.Show("Es recomendable dividir la losa "+Convert.ToString(cmbLosas.SelectedIndex + 1), "Recomendación", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
            }

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            /*cmbLosas.Items.Clear();
            dataGridView1.Rows.Clear();
            //Borra items del combobox
            dataGridView1.Rows.Add(Convert.ToInt32(numericUpDownCantidadLosa.Value));

            for (int x = 0; x <= numericUpDownCantidadLosa.Value-1; x++)
            {
                cmbLosas.Items.Add(aLosas[x]);
                dataGridView1.Rows[x].Cells[0].Value = "L-"+ Convert.ToString(x+1);
            }
            //Inserta los itemes del arreglo al combobox
           // dataGridView1.DataSource = cmbLosas;

            cmbLosas.SelectedIndex = 0;*/
            int nl= Convert.ToInt32(numericUpDownCantidadLosa.Value);
            cmbLosas.Items.Clear();
            for (int x = 0; x <= numericUpDownCantidadLosa.Value - 1; x++)
            {
                cmbLosas.Items.Add(aLosas[x]);
            }
            if (numericUpDownCantidadLosa.Value > dataGridView1.Rows.Count)
            { 
                dataGridView1.Rows.Add(1);
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0].Value = "L-"+ Convert.ToString(nl);
            }
            else if (numericUpDownCantidadLosa.Value < dataGridView1.Rows.Count)
            {    
                dataGridView1.Rows.RemoveAt(dataGridView1.Rows.Count - 1);
            }

            cmbLosas.SelectedIndex = 0;
            
        }

        private void cmbLosas_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonCalcular.Enabled = false;
            txtLx.Text = Convert.ToString(aLosas[cmbLosas.SelectedIndex].Lx);
            txtLy.Text = Convert.ToString(aLosas[cmbLosas.SelectedIndex].Ly);
            if ((txtLx.Text != " ") && (txtLy.Text != " ") && (txtLy.Text != "") && (txtLx.Text != "") && (txtLx.Text != null) && (txtLy.Text != null) &&
                (txtLy.Text != ".") && (txtLx.Text != ".") && (Convert.ToDouble(txtLy.Text) > 0) && (Convert.ToDouble(txtLx.Text) > 0) && (txtRecublimiento.Text != ".") &&
                (Convert.ToDouble(txtRecublimiento.Text) > 0) && (txtRecublimiento.Text != ".0") && (txtRecublimiento.Text != "0.") && (txtLy.Text != ".0")
                && (txtLx.Text != ".0") && (txtLy.Text != "0.") && (txtLx.Text != "0."))
            {
                buttonCalcular.Enabled = true;
            }
        }
        
        private void txtLy_TextChanged(object sender, EventArgs e)
        {
            //muestra el boton calcular si no estan vacios. No lo muestran si estan vacios o son iguales o menores 0
            if ((txtLx.Text != " ") && (txtLy.Text != " ") && (txtLy.Text != "") && (txtLx.Text != "") && (txtLx.Text != null) && (txtLy.Text != null) &&
                (txtLy.Text != ".") && (txtLx.Text != ".") && (Convert.ToDouble(txtLy.Text) > 0) && (Convert.ToDouble(txtLx.Text) > 0) && (txtRecublimiento.Text != ".") &&
                (Convert.ToDouble(txtRecublimiento.Text) > 0) && (txtRecublimiento.Text != ".0") && (txtRecublimiento.Text != "0.") && (txtLy.Text != ".0")
                && (txtLx.Text != ".0") && (txtLy.Text != "0.") && (txtLx.Text != "0."))
            {
                buttonCalcular.Enabled = true;
                numericUpDownCantidadLosa.Enabled = false;
            }
            else
            {
                buttonCalcular.Enabled = false;
                numericUpDownCantidadLosa.Enabled = true;
            }
        }

        private void txtLx_TextChanged(object sender, EventArgs e)
        {
            double m=0.0;
            if ((txtLx.Text != " ") && (txtLy.Text != " ") && (txtLy.Text != "") && (txtLx.Text != "") && (txtLx.Text != null) && (txtLy.Text != null) &&
                (txtLy.Text != ".") && (txtLx.Text != ".") && (Convert.ToDouble(txtLy.Text) > 0) && (Convert.ToDouble(txtLx.Text) > 0) && /*(txtRecublimiento.Text != ".") &&
                (Convert.ToDouble(txtRecublimiento.Text) > 0) && (txtRecublimiento.Text != ".0") && (txtRecublimiento.Text != "0.") && */ (txtLy.Text != ".0")
                && (txtLx.Text != ".0") && (txtLy.Text != "0.") && (txtLx.Text != "0."))
            {
                buttonCalcular.Enabled = true;
                if ((Convert.ToDouble(txtLx.Text)) <= (Convert.ToDouble(txtLy.Text)))
                {
                    m = Convert.ToDouble(txtLx.Text) / Convert.ToDouble(txtLy.Text);
                }
                else
                {
                    m = Convert.ToDouble(txtLy.Text) / Convert.ToDouble(txtLx.Text);
                }

                if ((m >= 0.5))
                {
                    groupBoxEn1DirecX.Visible = false;
                    groupBoxEn1DirecY.Visible = false;
                    groupBoxEn2Direc.Visible = true;

                }
                else if ((m < 0.5) && (Convert.ToDouble(txtLx.Text) > Convert.ToDouble(txtLy.Text)))
                {
                    groupBoxEn1DirecX.Visible = true;
                    groupBoxEn1DirecY.Visible = false;
                    groupBoxEn2Direc.Visible = false;
                }
                else if ((m < 0.5) && (Convert.ToDouble(txtLx.Text) < Convert.ToDouble(txtLy.Text)))
                {
                    groupBoxEn1DirecX.Visible = false;
                    groupBoxEn1DirecY.Visible = true;
                    groupBoxEn2Direc.Visible = false;
 
                }
                aLosas[cmbLosas.SelectedIndex].Lx = Convert.ToDouble(txtLx.Text);
                aLosas[cmbLosas.SelectedIndex].Ly = Convert.ToDouble(txtLy.Text);                
            }
                        
        }

        private void rectangleShapeYArriba_Click(object sender, EventArgs e)
        {
            if ((rectangleShapeYArriba.FillStyle == Microsoft.VisualBasic.PowerPacks.FillStyle.Transparent) &
                (rectangleShapeYArriba.BorderStyle == System.Drawing.Drawing2D.DashStyle.Solid))
            {
                rectangleShapeYArriba.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.BackwardDiagonal;
                rectangleShapeYArriba.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            }
            else if (rectangleShapeYArriba.FillStyle == Microsoft.VisualBasic.PowerPacks.FillStyle.BackwardDiagonal)
            {
                rectangleShapeYArriba.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Transparent;
                rectangleShapeYArriba.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            }
            else if (rectangleShapeYArriba.BorderStyle == System.Drawing.Drawing2D.DashStyle.Dash)
            {
                rectangleShapeYArriba.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Transparent;
                rectangleShapeYArriba.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            }
        }

        private void rectangleShapeYAbajo_Click(object sender, EventArgs e)
        {
            if ((rectangleShapeYAbajo.FillStyle == Microsoft.VisualBasic.PowerPacks.FillStyle.Transparent) &
                (rectangleShapeYAbajo.BorderStyle == System.Drawing.Drawing2D.DashStyle.Solid))
            {
                rectangleShapeYAbajo.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.BackwardDiagonal;
                rectangleShapeYAbajo.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            }
            else if (rectangleShapeYAbajo.FillStyle == Microsoft.VisualBasic.PowerPacks.FillStyle.BackwardDiagonal)
            {
                rectangleShapeYAbajo.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Transparent;
                rectangleShapeYAbajo.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            }
            else if (rectangleShapeYAbajo.BorderStyle == System.Drawing.Drawing2D.DashStyle.Dash)
            {
                rectangleShapeYAbajo.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Transparent;
                rectangleShapeYAbajo.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            }
        }

        private void rectangleShapeYIzq_Click(object sender, EventArgs e)
        {
            if ((rectangleShapeYIzq.FillStyle == Microsoft.VisualBasic.PowerPacks.FillStyle.Transparent) &
                (rectangleShapeYIzq.BorderStyle == System.Drawing.Drawing2D.DashStyle.Solid))
            {
                rectangleShapeYIzq.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.BackwardDiagonal;
                rectangleShapeYIzq.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            }
            else if (rectangleShapeYIzq.FillStyle == Microsoft.VisualBasic.PowerPacks.FillStyle.BackwardDiagonal)
            {
                rectangleShapeYIzq.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Transparent;
                rectangleShapeYIzq.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            }
            else if (rectangleShapeYIzq.BorderStyle == System.Drawing.Drawing2D.DashStyle.Dash)
            {
                rectangleShapeYIzq.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Transparent;
                rectangleShapeYIzq.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            }
        }

        private void rectangleShapeYDer_Click(object sender, EventArgs e)
        {
            if ((rectangleShapeYDer.FillStyle == Microsoft.VisualBasic.PowerPacks.FillStyle.Transparent) &
                (rectangleShapeYDer.BorderStyle == System.Drawing.Drawing2D.DashStyle.Solid))
            {
                rectangleShapeYDer.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.BackwardDiagonal;
                rectangleShapeYDer.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            }
            else if (rectangleShapeYDer.FillStyle == Microsoft.VisualBasic.PowerPacks.FillStyle.BackwardDiagonal)
            {
                rectangleShapeYDer.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Transparent;
                rectangleShapeYDer.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            }
            else if (rectangleShapeYDer.BorderStyle == System.Drawing.Drawing2D.DashStyle.Dash)
            {
                rectangleShapeYDer.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Transparent;
                rectangleShapeYDer.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //dataGridView1.Rows.Clear();
            //numericUpDownCantidadLosa.Value += 1;
            //numericUpDownCantidadLosa.Value -= 1;
        }

        private void buttonRehacer_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            bool check=true;

            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                for (int i = 0; i <= 12; i++ )
                {
                    if (r.Cells[i].Value == null)
                    {
                        check = false;
                    }
                } 
            }
           
            if (check==true)
            {
                CuantificaciondeCargasForm ccf = new CuantificaciondeCargasForm();
                ccf.project = project;                 
                project.Fc = Convert.ToDouble(txtFx.Text);
                project.Fy = Convert.ToDouble(txtFy.Text);
                project.Recubrimiento = Convert.ToDouble(txtRecublimiento.Text);
                project.Estado = "En proceso";
                Broker b = new Broker();
                b.InsertProyecto(project);

                for (int i = 0; i < cmbLosas.Items.Count; i++)
                {
                    DatabaseLosa.Losa los = new DatabaseLosa.Losa();
                    cmbLosas.SelectedIndex = i;
                    los.Nombre = "Losa " + Convert.ToString(cmbLosas.SelectedIndex + 1);//Convert.ToString(dataGridView1.Rows[cmbLosas.SelectedIndex].Cells[0].Value);
                    los.Lx = Convert.ToDouble(dataGridView1.Rows[cmbLosas.SelectedIndex].Cells[1].Value);
                    los.Ly = Convert.ToDouble(dataGridView1.Rows[cmbLosas.SelectedIndex].Cells[2].Value);
                    los.Bordesx = Convert.ToInt32(dataGridView1.Rows[cmbLosas.SelectedIndex].Cells[6].Value);
                    los.BordesY = Convert.ToInt32(dataGridView1.Rows[cmbLosas.SelectedIndex].Cells[7].Value);
                    los.Idproyecto = project.Id;
                    b.InsertLosa(los);
                    
                }
                
                this.Hide();
                ccf.Show();
            }
            else
            {
                MessageBox.Show("Aun hay losas sin calcular", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            

        }
        /*char letra = e.KeyChar;


            if (letra == 8 && txtFy.Text.IndexOf(".") != -1)
            {
                e.Handled = true;
                return;
            }


            if (!Char.IsDigit(letra) && letra != 8 && letra != 46)
            {
                e.Handled = true;
            }*/
        public static void allowNumber(object sender, KeyPressEventArgs e,char csymbol)
            {
                if (!char.IsControl(e.KeyChar) && (!char.IsDigit(e.KeyChar)) && (e.KeyChar != csymbol)) 
                {
                    e.Handled = true;
                }
                
                if((e.KeyChar== csymbol)&&(sender as TextBox).Text.IndexOf(csymbol)>-1)
                {
                    e.Handled = true;
                }
            }
        private void validateTxtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            allowNumber(sender,e,'.');
        }
               

        private void rectangleTitulo_Click(object sender, EventArgs e)
        {

        }


    }
}
