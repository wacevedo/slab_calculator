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
using System.Xml;

namespace DiseñoCalcLosa
{
    public partial class AbrirProyectoForm : Form
    {
        public AbrirProyectoForm()
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
        List<DatabaseLosa.Proyecto> listp;
        ImageList il, ilxl;
        private void AbrirProyectoForm_Load(object sender, EventArgs e)
        {
            il = new ImageList();
            groupBoxAbrir.AllowDrop = true; 
            DirectoryInfo dir = new DirectoryInfo(@"complementos\ico");//C:\Users\Willson Acevedo\Documents\Anteproyecto\Anteproyecto\DiseñoCalcLosa\
            foreach (FileInfo file in dir.GetFiles())
            {
                try
                {
                    il.Images.Add(Image.FromFile(file.FullName));
                }
                catch
                {
                    MessageBox.Show("El icono de tamaño 32x32 no ha podido ser cargado." , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            ilxl = new ImageList();

            DirectoryInfo dirxl = new DirectoryInfo(@"complementos\ico\large");//C:\Users\Willson Acevedo\Documents\Anteproyecto\Anteproyecto\DiseñoCalcLosa\
            foreach (FileInfo file in dirxl.GetFiles())
            {
                try
                {
                    ilxl.Images.Add(Image.FromFile(file.FullName));
                }
                catch
                {
                    MessageBox.Show("El icono de tamaño 50x50 no ha podido ser cargado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
               
                                    
            ilxl.ImageSize = new Size(50, 50);
            int count = 0;
            listViewProyectosRecientes.LargeImageList = ilxl;
            listViewProyectosRecientes.SmallImageList = il;            
            listp = new List<DatabaseLosa.Proyecto>();
            DatabaseLosa.Broker b = new DatabaseLosa.Broker();            
            listp = b.selectProyectos();
            foreach (DatabaseLosa.Proyecto p in listp)
            {
                ListViewItem lst = new ListViewItem();
                lst.Text = p.Nombre;
                lst.SubItems.Add(p.Fecha);//s
                lst.ImageIndex = count;
                listViewProyectosRecientes.Items.Add(lst);
            }
        }

        private void buttSalir_Click(object sender, EventArgs e)
        {
            MenuForm m = new MenuForm();
            this.Hide();            
            m.Show();
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            if (listViewProyectosRecientes.View == View.Details)
            {
                listViewProyectosRecientes.View = View.SmallIcon;
            }
            else if (listViewProyectosRecientes.View == View.SmallIcon)
            {
                listViewProyectosRecientes.View = View.LargeIcon;
            }
            else if (listViewProyectosRecientes.View == View.LargeIcon)
            {
                listViewProyectosRecientes.View = View.Tile;
            }
            else if (listViewProyectosRecientes.View == View.Tile)
            {
                listViewProyectosRecientes.View = View.List;
            }
            else if (listViewProyectosRecientes.View == View.List)
            {
                listViewProyectosRecientes.View = View.Details;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            ///para cada item del listp, verificar si el nombre del item es igual al .startswith o es null, agregar ese item cambiar nombre a otro fore color con la coninsidencia
            listViewProyectosRecientes.Items.Clear(); // clear list items before adding 
              
            foreach (DatabaseLosa.Proyecto p in listp)
            {                
                if (p.Nombre.ToLower().Contains(textBox1.Text.ToLower()) || string.IsNullOrEmpty(textBox1.Text))
                {
                    ListViewItem it = new ListViewItem();
                    it.Text = p.Nombre;
                    it.SubItems.Add(p.Fecha);//
                    it.ImageIndex = 0;
                    listViewProyectosRecientes.Items.Add(it);
                }
            } 
        }

        private void listViewProyectosRecientes_DoubleClick(object sender, EventArgs e)
        {
            if (listViewProyectosRecientes.SelectedItems.Count > 0)
            {
                VerProyectoForm vp = new VerProyectoForm();
                vp.project = new DatabaseLosa.Proyecto();
                vp.project = listp[listViewProyectosRecientes.SelectedIndices[0]];
                this.Hide();
                vp.Show();

            }
        }

        private void groupBoxProRecient_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))

                e.Effect = DragDropEffects.Copy;

            else
                e.Effect = DragDropEffects.None;
        }

        private void groupBoxProRecient_DragDrop(object sender, DragEventArgs e)
        {
            string[] Filelist = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            if ((System.IO.Path.GetExtension(Filelist[0]).ToUpperInvariant() == ".XML") || (System.IO.Path.GetExtension(Filelist[0]).ToUpperInvariant() == ".SLC"))
            {                
                XmlDocument doc = new XmlDocument();
                doc.Load(Filelist[0]);                
                VerProyectoForm vp = new VerProyectoForm();
                vp.project = new DatabaseLosa.Proyecto();
                vp.isLoadingAFile = true;
                vp.cp= new CalculosProyecto(doc);                 
                this.Hide();
                vp.Show();

            }
            else
            {
                MessageBox.Show("Archivo no compatible", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }    
        }
    }
}
