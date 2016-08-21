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
using AlphaForms;

using System.Threading;
using System.Xml;

namespace DiseñoCalcLosa
{
    public partial class VerProyectoForm : AlphaForm //ponerlo alphaform al final
    {
        public VerProyectoForm()
        {
            InitializeComponent();
        }

        public DatabaseLosa.Proyecto project;
        public bool isLoadingAFile = false;
        public CalculosProyecto cp;
       

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        public extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        public extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void rectangleTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0); 
        }

        private void VerProyectoForm_Load(object sender, EventArgs e)
        {
                
            groupBoxCargando.Visible = false;
            if (isLoadingAFile)
            {                
                project = cp.proyecto;
            }
            else
            {
                cp = new CalculosProyecto(project);
                if (cp.proyecto.Estado == "Terminado")
                cp.calcularCargasDelProyecto();                
            }
            lblTitulo.Text += " "+project.Nombre+" "+project.Tipo_edificio;
            txtFx.Text = Convert.ToString(project.Fc);
            txtFy.Text = Convert.ToString(project.Fy);
            txtRecublimiento.Text = Convert.ToString(project.Recubrimiento);
            
            dataGridView1.Rows.Add(cp.losas.Count);
            dataGridView2.Rows.Add(cp.losas.Count);

            for (int i = 0; i <= cp.losas.Count - 1; i++)
            {
                //Espesores
                dataGridView1.Rows[i].Cells[0].Value = cp.losas[i].Nombre;
                dataGridView2.Rows[i].Cells[0].Value = cp.losas[i].Nombre;//carga
                dataGridView1.Rows[i].Cells[1].Value = cp.losas[i].Lx;
                dataGridView1.Rows[i].Cells[2].Value = cp.losas[i].Ly;
                dataGridView1.Rows[i].Cells[3].Value = cp.calculosLosas[i].LcLl;
                dataGridView1.Rows[i].Cells[4].Value = cp.calculosLosas[i].direccionLosa;
                dataGridView1.Rows[i].Cells[5].Value = cp.calculosLosas[i].bordesDiscontinuos;
                dataGridView1.Rows[i].Cells[6].Value = cp.losas[i].Bordesx;
                dataGridView1.Rows[i].Cells[7].Value = cp.losas[i].BordesY;
                dataGridView1.Rows[i].Cells[8].Value = cp.calculosLosas[i].apoyoArmadoEnUnaDireccion;
                dataGridView1.Rows[i].Cells[9].Value = cp.calculosLosas[i].tmin;
                dataGridView1.Rows[i].Cells[10].Value = cp.calculosLosas[i].p180;
                dataGridView1.Rows[i].Cells[11].Value = cp.calculosLosas[i].T;
                dataGridView1.Rows[i].Cells[12].Value = cp.calculosLosas[i].usar;
                dataGridView2.Rows[i].Cells[1].Value = cp.calculosLosas[i].usar;//carga
                
                //Cargas
                dataGridView2.Rows[i].Cells[2].Value = cp.cargas[i].Hinclinacion;
                dataGridView2.Rows[i].Cells[3].Value = cp.calculosCargas[i].angulo;
                dataGridView2.Rows[i].Cells[4].Value = cp.calculosCargas[i].cargaMuerta;
                dataGridView2.Rows[i].Cells[5].Value = cp.calculosCargas[i].cargaViva;
                dataGridView2.Rows[i].Cells[6].Value = cp.cargas[i].Carga_adicional;
                dataGridView2.Rows[i].Cells[7].Value = cp.calculosCargas[i].cargaUltima;
                dataGridView2.Rows[i].Cells[8].Value = cp.calculosCargas[i].reaccion;
                dataGridView2.Rows[i].Cells[9].Value = cp.calculosCargas[i].reaccionAng;

            }
        }

        private void buttSalir_Click(object sender, EventArgs e)
        {
            MenuForm mf = MenuForm.Instance;
            this.Hide();            
            mf.Show();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }
        Point lastpoint;
        private void buttMax_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
            {
                lastpoint = this.Location;
                this.Location = new Point(1,1);
                this.WindowState = FormWindowState.Maximized;
                this.Size = new Size(this.Size.Width, 900);
                buttMax.Text = "2";
            }
            else
            {
                this.Location = lastpoint;
                this.WindowState = FormWindowState.Normal;
                buttMax.Text = "1";
            }
        }

        private void buttMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private PlantillaProyecto pp;

        delegate void SetVisibleCallback(bool value);

        private void SetVisible(bool value)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.groupBoxCargando.InvokeRequired)
            {
                SetVisibleCallback d = new SetVisibleCallback(SetVisible);
                this.Invoke(d, new object[] { value });
            }
            else
            {
                this.groupBoxCargando.Visible = value;
            }
        }

        delegate void SetXmlCallback(XmlDocument value);
        public XmlDocument xmlDoc;
        private void SetXml(XmlDocument value)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.groupBoxCargando.InvokeRequired)
            {
                SetXmlCallback d = new SetXmlCallback(SetXml);
                this.Invoke(d, new object[] { value });
            }
            else
            {
                xmlDoc = value;
            }
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {           
            groupBoxCargando.Visible = true;           
            Thread thread2 = new Thread(
                () =>
                {
                   PlantillaProyecto pp = new PlantillaProyecto(cp);
                   SetVisible(false);
                });
            thread2.Start();      
                     
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            xmlDoc = new XmlDocument();
            groupBoxCargando.Visible = true;
            Thread thread2 = new Thread(
                () =>
                {
                    LosaXml lxml = new LosaXml();
                    
                    SetXml(lxml.crearLosaXml(cp));
                                   

                    SetVisible(false);
                });
            thread2.Start();
            SaveFileDialog Saver = new SaveFileDialog();
            Saver.Title = "Save Slab Calculator Files";
            Saver.Filter = "SLC (*.slc)|*.slc|XML (*.xml)|*.xml|All files(*.*)|*.*";
            Saver.FileName = cp.proyecto.Nombre;
            if (Saver.ShowDialog() == DialogResult.OK)
            {
                xmlDoc.Save(Saver.FileName);
            } 
        }

        

        
    }
}
