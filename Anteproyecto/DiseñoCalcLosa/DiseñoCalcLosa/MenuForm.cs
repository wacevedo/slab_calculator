using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using AlphaForms;

namespace DiseñoCalcLosa
{
    public partial class MenuForm : AlphaForm
    {
        public MenuForm()
        {
            InitializeComponent();             
        }
        //----Singleton 
        private static MenuForm instance = null;

        public static MenuForm Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MenuForm();
                }
                return instance;
            }
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
        
        private void MenuForm_Load(object sender, EventArgs e)
        {
            buttonExport.Visible = false;
            buttonLosa.Visible = false;

            axWindowsMediaPlayer1.uiMode = "none";
            axWindowsMediaPlayer1.stretchToFit = true;
            
            axWindowsMediaPlayer1.URL = "video.mp4";//cargando video            
            axWindowsMediaPlayer1.settings.setMode("loop",true);
            axWindowsMediaPlayer1.settings.mute = true;
            

            groupBoxProRecient.Visible = false;
            buttonArcXml.Visible = false;
            buttonDropbox.Visible = false;
            buttonOnedrive.Visible = false;
            buttonSettings.Visible = false;
           
        }

        private void buttSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            CrearProyectForm cpf = new CrearProyectForm(); 
            this.Hide();            
            cpf.Show();            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //CalcLosaForm f = new CalcLosaForm();
            //f.Show();
            //DatabaseLosa.Broker b = new DatabaseLosa.Broker();
            //CalculosProyecto cp = new CalculosProyecto(b.selectProyecto(1502120128));            
            //Plantilla p = new Plantilla(cp.losas[0]);
            //PlantillaProyecto pp = new PlantillaProyecto(cp);
            //------------------------
            /*
            DatabaseLosa.Broker b = new DatabaseLosa.Broker();
            CuantificaciondeCargasForm ccf = new CuantificaciondeCargasForm();
            ccf.project = b.selectProyecto(1503140911);
            ccf.Show();*/
            //------------------------
            /*
            DatabaseLosa.Proyecto po = new DatabaseLosa.Proyecto();
            po.Id = 1;
            po.Estado = "Terminado";
            DatabaseLosa.Broker b = new DatabaseLosa.Broker();
            b.UpdateEstadoProyecto(po);
            buttonLosa.Text = "listo";*/
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SaveFileDialog s = new SaveFileDialog();
            s.InitialDirectory = "‪C:/Users/Willson Acevedo/SkyDrive";
            s.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (buttonArcXml.Visible == false)
            {
                buttonArcXml.Visible = true;
                buttonDropbox.Visible = true;
                buttonOnedrive.Visible = true;               
            }
            else
            {
                buttonArcXml.Visible = false;
                buttonDropbox.Visible = false;
                buttonOnedrive.Visible = false;               
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirProyectoForm s = new AbrirProyectoForm();
            //s.InitialDirectory = "‪C:/Users/Willson Acevedo/SkyDrive";
            this.Hide();
            s.Show();
            

        }
        List<DatabaseLosa.Proyecto> listp;
        private void button6_Click(object sender, EventArgs e)
        {
            if (groupBoxProRecient.Visible == false)
            {
                groupBoxProRecient.Visible = true;
                buttonProyectosRecientes.BackColor = Color.LightSeaGreen;
                //ListViewItem i = new ListViewItem("projecto 1");;
                //i.BackColor = Color.Red;
                
                ImageList il = new ImageList();
                //foreach (string img in adress)
                //{
                    /*System.Net.WebRequest request = System.Net.WebRequest.Create(adress);//img
                    System.Net.WebResponse resp = request.GetResponse();
                    System.IO.Stream respStream = resp.GetResponseStream();
                    Bitmap bmp = new Bitmap(respStream);
                    respStream.Dispose();*/
                // il.Images.Add(bmp);
                // }


                DirectoryInfo dir = new DirectoryInfo(@"complementos\ico");//C:\Users\Willson Acevedo\Documents\Anteproyecto\Anteproyecto\DiseñoCalcLosa\
                foreach (FileInfo file in dir.GetFiles())
                {
                    try
                    {
                        il.Images.Add(Image.FromFile(file.FullName));
                    }
                    catch
                    {
                        
                    }
                }
                   
                   
                   
                    
               
                //.Items.e("C:/Users/Willson Acevedo/Documents/win8 icons/document-26.png");
                    //il.ImageSize = new Size(32, 32);
                    int count = 0;
                    listViewProyectosRecientes.LargeImageList = il;
                    listViewProyectosRecientes.SmallImageList = il;
                    //List<string> names = new List<string>() { "1", "2", "3", "4" };
                     //string names = "proyecto 1";
                     listp = new List<DatabaseLosa.Proyecto>();
                     DatabaseLosa.Broker b = new DatabaseLosa.Broker();
                     //listp = b.selectProyectosRecientes();
                     listp = b.selectUltimosProyectos(5);
                    foreach (DatabaseLosa.Proyecto p in listp)
                    {
                        ListViewItem lst = new ListViewItem();
                        lst.Text = p.Nombre; //s
                        lst.ImageIndex = count;
                        listViewProyectosRecientes.Items.Add(lst);
                   }


                //listViewProyectosRecientes.Items.Add(i);

            }
            else
            {
                listViewProyectosRecientes = new ListView();
                groupBoxProRecient.Visible = false;
                buttonProyectosRecientes.BackColor = Color.SeaGreen;
            }
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            buttonArcXml.Visible = false;
            buttonDropbox.Visible = false;
            buttonOnedrive.Visible = false;

            buttonCrearPro.BackColor = Color.LightSeaGreen;
            
        }

        private void buttonArcXml_Click(object sender, EventArgs e)
        {
          // this.AllowTransparency = true;
          // this.DoubleBuffered = true;     
          // this.Opacity = 0.5;
           
        }

        private void buttonCrearPro_MouseLeave(object sender, EventArgs e)
        {
            buttonCrearPro.BackColor = Color.SeaGreen;
        }

        private void buttonAbrirPro_MouseEnter(object sender, EventArgs e)
        {
           buttonAbrirPro.BackColor = Color.LightSeaGreen;
        }

        private void buttonAbrirPro_MouseLeave(object sender, EventArgs e)
        {
            buttonAbrirPro.BackColor = Color.SeaGreen;
        }

        private void buttonExport_MouseEnter(object sender, EventArgs e)
        {
            buttonExport.BackColor = Color.LightSeaGreen;
        }

        private void buttonExport_MouseLeave(object sender, EventArgs e)
        {
            buttonExport.BackColor = Color.SeaGreen;
        }

        private void buttonProyectosRecientes_MouseEnter(object sender, EventArgs e)
        {
            if(groupBoxProRecient.Visible== false)
                buttonProyectosRecientes.BackColor = Color.LightSeaGreen;
        }

        private void buttonProyectosRecientes_MouseLeave(object sender, EventArgs e)
        {
            if(groupBoxProRecient.Visible== false)
              buttonProyectosRecientes.BackColor = Color.SeaGreen;
        }

        private void listViewProyectosRecientes_DoubleClick(object sender, EventArgs e)
        {
            if(listViewProyectosRecientes.SelectedItems.Count > 0)
            {
                VerProyectoForm vp = new VerProyectoForm();
                vp.project = new DatabaseLosa.Proyecto();
                vp.project = listp[listViewProyectosRecientes.SelectedIndices[0]];
                this.Hide();
                vp.Show();
            }
        }

        private void listViewProyectosRecientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBoxProRecient_Enter(object sender, EventArgs e)
        {

        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            //CuantificaciondeCargasForm f3 = new CuantificaciondeCargasForm();
            //f3.Show();
        }
    }
}
