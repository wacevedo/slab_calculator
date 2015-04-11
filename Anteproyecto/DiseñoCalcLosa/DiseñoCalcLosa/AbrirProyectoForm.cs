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
using AlphaForms;

namespace DiseñoCalcLosa
{
    public partial class AbrirProyectoForm : AlphaForm
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
        //lista de proyectos que va a despregarse en el listviws
        List<DatabaseLosa.Proyecto> listp;
        ImageList il, ilxl;//lista de imagenes de los iconos

        private void AbrirProyectoForm_Load(object sender, EventArgs e)
        {
            groupBoxAbrir.AllowDrop = true;//cambiando propiedad de para arrastras archivos 

            il = new ImageList();//inicializando variable de lista de iconos pequeños
            
            DirectoryInfo dir = new DirectoryInfo(@"complementos\ico"); //directorio de los iconos pequeños
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

            ilxl = new ImageList();//inicializando variable de lista de iconos pequeños

            DirectoryInfo dirxl = new DirectoryInfo(@"complementos\ico\large");//directorio de los iconos pequeños
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
               
                                    
            ilxl.ImageSize = new Size(50, 50);//cambiando tamaño para los iconos grandes
            int count = 0;
            listViewProyectosRecientes.LargeImageList = ilxl;//agregando iconos grandes
            listViewProyectosRecientes.SmallImageList = il;  //agregando iconos pequeños          
            listp = new List<DatabaseLosa.Proyecto>();       //inicializando lista de proyectos    
            DatabaseLosa.Broker b = new DatabaseLosa.Broker();//inicializando la clase que conecta a la base de datos
            listp = b.selectProyectos();                     //llenando lista de proyectos 

            //llenando listview
            foreach (DatabaseLosa.Proyecto p in listp)        
            {
                ListViewItem lst = new ListViewItem();
                lst.Text = p.Nombre;
                lst.SubItems.Add(p.Fecha);
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

        //metodo para el boton que cambia las vistas de listview
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
                    ListViewItem it = new ListViewItem();//crea item del listview
                    it.Text = p.Nombre;
                    it.SubItems.Add(p.Fecha); //agreaganto atributo
                    it.ImageIndex = 0; //tomando primera (y unica imagen)
                    listViewProyectosRecientes.Items.Add(it);//agregando item
                }
            } 
        }
        //metodo que llama el doble click para abrir el proyecto
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

        //metodo para el drag del "arrastre y suelte" que copia el archivo arrastrado
        private void groupBoxProRecient_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))

                e.Effect = DragDropEffects.Copy;

            else
                e.Effect = DragDropEffects.None;
        }
        //metodo que habre el archivo .slc o .xml
        private void groupBoxProRecient_DragDrop(object sender, DragEventArgs e)
        {
            string[] Filelist = (string[])e.Data.GetData(DataFormats.FileDrop, false); //toma la lista de archivos que fueron arrastrados

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
