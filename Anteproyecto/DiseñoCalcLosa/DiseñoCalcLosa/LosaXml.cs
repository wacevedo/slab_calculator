using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.Xml.XPath;
using DatabaseLosa;

namespace DiseñoCalcLosa
{
    class LosaXml
    {

        public XmlDocument crearLosaXml(CalculosProyecto cp)
        {
            //
            //ejemplo de creacion
            //
           /* XmlDocument xmlDoc = new XmlDocument();
            XmlNode rootNode = xmlDoc.CreateElement("Lista");
            xmlDoc.AppendChild(rootNode);
            XmlNode userNode;
            XmlAttribute attribute;

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                listBox2.SelectedIndex = i;
                listBox1.SelectedIndex = i;
                userNode = xmlDoc.CreateElement("Path");
                attribute = xmlDoc.CreateAttribute("Time");
                attribute.Value = DateTime.Now.ToString("hhmmss");
                userNode.Attributes.Append(attribute);
                userNode.InnerText = Convert.ToString(listBox2.SelectedItem);
                rootNode.AppendChild(userNode);

            }*/

            //creando xml document y el nodo principal
            XmlDocument xmlDoc = new XmlDocument();
            XmlNode rootNode = xmlDoc.CreateElement("Proyecto");
            xmlDoc.AppendChild(rootNode);//anidado nodo al documento

            //
            //creando nodos que estaran dentro del nodo proyecto (datos generadas)
            //
            XmlNode projectNode = xmlDoc.CreateElement("Nombre");
            projectNode.InnerText = cp.proyecto.Nombre;
            rootNode.AppendChild(projectNode);

            //creando nodo para usuario
            projectNode = xmlDoc.CreateElement("Usuario"); 
            projectNode.InnerText = cp.proyecto.Usuario;
            rootNode.AppendChild(projectNode);//anidado nodo al nodo Proyecto

            //creando nodo para Tipo_losa
            projectNode = xmlDoc.CreateElement("Tipo_losa");
            projectNode.InnerText = cp.proyecto.Tipo_losa;
            rootNode.AppendChild(projectNode);//anidado nodo al nodo Proyecto

            //creando nodo para Pandereta
            projectNode = xmlDoc.CreateElement("Pandereta");
            projectNode.InnerText = Convert.ToString(cp.proyecto.Pandereta);
            rootNode.AppendChild(projectNode);//anidado nodo al nodo Proyecto

            //creando nodo para Peso_concreto
            projectNode = xmlDoc.CreateElement("Peso_concreto");
            projectNode.InnerText = Convert.ToString(cp.proyecto.Peso_concreto);
            rootNode.AppendChild(projectNode);//anidado nodo al nodo Proyecto

            //creando nodo para Terminacion
            projectNode = xmlDoc.CreateElement("Terminacion");
            projectNode.InnerText = Convert.ToString(cp.proyecto.Terminacion);
            rootNode.AppendChild(projectNode);//anidado nodo al nodo Proyecto

            //creando nodo para Recubrimiento
            projectNode = xmlDoc.CreateElement("Recubrimiento");
            projectNode.InnerText = Convert.ToString(cp.proyecto.Recubrimiento);
            rootNode.AppendChild(projectNode);//anidado nodo al nodo Proyecto

            //creando nodo para Fy
            projectNode = xmlDoc.CreateElement("Fy");
            projectNode.InnerText = Convert.ToString(cp.proyecto.Fy);
            rootNode.AppendChild(projectNode);//anidado nodo al nodo Proyecto

            //creando nodo para Fc
            projectNode = xmlDoc.CreateElement("Fc");
            projectNode.InnerText = Convert.ToString(cp.proyecto.Fc);
            rootNode.AppendChild(projectNode);//anidado nodo al nodo Proyecto

            //creando nodo para Estado
            projectNode = xmlDoc.CreateElement("Estado");
            projectNode.InnerText = Convert.ToString(cp.proyecto.Estado);
            rootNode.AppendChild(projectNode);//anidado nodo al nodo Proyecto

            //creando nodo para Tipo_edificio
            projectNode = xmlDoc.CreateElement("Tipo_edificio");
            projectNode.InnerText = cp.proyecto.Tipo_edificio;
            rootNode.AppendChild(projectNode);//anidado nodo al nodo Proyecto

            //creando nodo para Fecha
            projectNode = xmlDoc.CreateElement("Fecha");
            projectNode.InnerText = cp.proyecto.Fecha;
            rootNode.AppendChild(projectNode);//anidado nodo al nodo Proyecto

            XmlNode LosasNode = xmlDoc.CreateElement("Losas"); //nodo para las losas
            rootNode.AppendChild(LosasNode);

            XmlNode LosaNode;//nodo para una losa que pertenecera al nodo de las losa
            XmlNode LosaDatoNode;//nodo para los datos de una losa
            int x = 0;//contador para el foreach-cargas
            foreach (DatabaseLosa.Losa l in cp.losas)
            {
                LosaNode = xmlDoc.CreateElement("losa");

                //creando nodo para Nombre
                LosaDatoNode = xmlDoc.CreateElement("Nombre");
                LosaDatoNode.InnerText = Convert.ToString(l.Nombre);
                LosaNode.AppendChild(LosaDatoNode);//anidado nodo al nodo losa

                //creando nodo para Lx
                LosaDatoNode = xmlDoc.CreateElement("Lx");
                LosaDatoNode.InnerText = Convert.ToString(l.Lx);
                LosaNode.AppendChild(LosaDatoNode);//anidado nodo al nodo losa

                //creando nodo para Ly
                LosaDatoNode = xmlDoc.CreateElement("Ly");
                LosaDatoNode.InnerText = Convert.ToString(l.Ly);
                LosaNode.AppendChild(LosaDatoNode);//anidado nodo al nodo losa

                //creando nodo para BordesY
                LosaDatoNode = xmlDoc.CreateElement("BordesY");
                LosaDatoNode.InnerText = Convert.ToString(l.BordesY);
                LosaNode.AppendChild(LosaDatoNode);//anidado nodo al nodo losa

                //creando nodo para BordesX
                LosaDatoNode = xmlDoc.CreateElement("Bordesx");
                LosaDatoNode.InnerText = Convert.ToString(l.Bordesx);
                LosaNode.AppendChild(LosaDatoNode);//anidado nodo al nodo losa    

                //creando nodo para Xy
                LosaDatoNode = xmlDoc.CreateElement("Xy");
                LosaDatoNode.InnerText = Convert.ToString(cp.cargas[x].Xy);
                LosaNode.AppendChild(LosaDatoNode);//anidado nodo al nodo losa  

                //creando nodo para Hinclinacion
                LosaDatoNode = xmlDoc.CreateElement("Hinclinacion");
                LosaDatoNode.InnerText = Convert.ToString(cp.cargas[x].Hinclinacion);
                LosaNode.AppendChild(LosaDatoNode);//anidado nodo al nodo losa 

                //creando nodo para Carga_viva
                LosaDatoNode = xmlDoc.CreateElement("Carga_viva");
                LosaDatoNode.InnerText = Convert.ToString(cp.cargas[x].Carga_viva);
                LosaNode.AppendChild(LosaDatoNode);//anidado nodo al nodo losa 

                //creando nodo para Carga_adicional
                LosaDatoNode = xmlDoc.CreateElement("Carga_adicional");
                LosaDatoNode.InnerText = Convert.ToString(cp.cargas[x].Carga_adicional);
                LosaNode.AppendChild(LosaDatoNode);//anidado nodo al nodo losa

                LosasNode.AppendChild(LosaNode);//anidado nodo losa al nodo losas   
                x++; //siguiente carga
            }


            return xmlDoc;
            //
            //example for save
            //
            /*xmlDoc.Save("ListSong" + DateTime.Now.ToString("hhmmss") + ".xml"); 
             * or
             * SaveFileDialog Save = new SaveFileDialog();
            Save.Title = "Save ListSong Files";
            Save.Filter = "Xml|*.xml|All files(*.*)|*.*";
            Save.FileName = "ListSong" + DateTime.Now.ToString("hhmmss");
            if (Save.ShowDialog() == DialogResult.OK)
            {
                xmlDoc.Save(Save.FileName);
            } */
           

        }
    }
}
