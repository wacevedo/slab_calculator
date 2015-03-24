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
    public class CalculosProyecto
    {
        public Proyecto proyecto;
        public List<CalculosLosa> calculosLosas;
        public List<DatabaseLosa.Losa> losas;        
        public List<DatabaseLosa.Carga> cargas;
        public List<CalculoCarga> calculosCargas;
        public bool existCarga = false;
        /// <summary>
        /// Calcula los datos de espesores de losa de todo el 
        /// proyecto que se retornan en la listas 
        /// (calculoslosas son respectivos mismo indice que le correponde a losas)
        /// Ejemplo: los calculos de la losas[3] estan en calculosLosas[3]
        /// </summary>
        /// <param name="p">Proyecto</param>
        /// <param name="xmlDoc">Documento Xml</param>
        public CalculosProyecto(Proyecto p)
        {
            //inicializando variables
            proyecto = new Proyecto();
            Broker b = new Broker();
            losas = new List<DatabaseLosa.Losa>();
            cargas = new List<DatabaseLosa.Carga>();
            calculosLosas = new List<CalculosLosa>();
            calculosCargas = new List<CalculoCarga>();

            //llenando datos basicos para calculos
            proyecto = p;            
            losas = b.selectLosas(p.Id);
            cargas = b.selectCargas(p.Id);
            
            int x = 0;
            //calculando losas 
            foreach (DatabaseLosa.Losa losa in losas)
            {
                CalculosLosa cl = new CalculosLosa(losa);                
                calculosLosas.Add(cl);                
                x++;
            }
        }

        public void calcularCargasDelProyecto(){
            Broker b = new Broker();
            int x = 0;
            cargas = b.selectCargas(proyecto.Id);
            //calculando cargas
            foreach (DatabaseLosa.Losa losa in losas)
            {
                CalculosLosa cl = new CalculosLosa(losa);
                CalculoCarga ccarg = new CalculoCarga(losa,cl,proyecto,cargas[x]);                
                calculosCargas.Add(ccarg);
                x++;
            }
            existCarga = true;
        }
        public CalculosProyecto(XmlDocument xmlDoc)
        {
            //inicializando variables de listas y proyectos
            proyecto = new Proyecto();
            losas = new List<DatabaseLosa.Losa>();
            cargas = new List<DatabaseLosa.Carga>();
            calculosLosas = new List<CalculosLosa>();
            calculosCargas = new List<CalculoCarga>();
            
            proyecto.Id = Convert.ToInt64(DateTime.Now.ToString("yyMMddhhmm"));//asignando a id al proyecto exportado

            XmlNode projectNode = xmlDoc.SelectSingleNode("Proyecto");//tomando nodo principal proyecto
                       
            //tomando datos del nodo: nombre
            XmlNode nodeData = projectNode.SelectSingleNode("Nombre");
            proyecto.Nombre = nodeData.InnerText;

            //tomando datos del nodo: Usuario
            nodeData = projectNode.SelectSingleNode("Usuario");
            proyecto.Usuario = nodeData.InnerText;

            //tomando datos del nodo: Tipo_losa
            nodeData = projectNode.SelectSingleNode("Tipo_losa");
            proyecto.Tipo_losa = nodeData.InnerText;

            //tomando datos del nodo: Pandereta
            nodeData = projectNode.SelectSingleNode("Pandereta");
            proyecto.Pandereta = Convert.ToDouble(nodeData.InnerText);

            //tomando datos del nodo: Peso_concreto
            nodeData = projectNode.SelectSingleNode("Peso_concreto");
            proyecto.Peso_concreto = Convert.ToDouble(nodeData.InnerText);

            //tomando datos del nodo: Peso_concreto
            nodeData = projectNode.SelectSingleNode("Terminacion");
            proyecto.Terminacion = Convert.ToDouble(nodeData.InnerText);

            //tomando datos del nodo: Recubrimiento
            nodeData = projectNode.SelectSingleNode("Recubrimiento");
            proyecto.Recubrimiento = Convert.ToDouble(nodeData.InnerText);

            //tomando datos del nodo: Fy
            nodeData = projectNode.SelectSingleNode("Fy");
            proyecto.Fy = Convert.ToDouble(nodeData.InnerText);

            //tomando datos del nodo: Fc
            nodeData = projectNode.SelectSingleNode("Fc");
            proyecto.Fc = Convert.ToDouble(nodeData.InnerText);

            //tomando datos del nodo: Estado
            nodeData = projectNode.SelectSingleNode("Estado");
            proyecto.Estado = nodeData.InnerText;

            //tomando datos del nodo: Tipo_edificio
            nodeData = projectNode.SelectSingleNode("Tipo_edificio");
            proyecto.Tipo_edificio = nodeData.InnerText;

            //tomando datos del nodo: Fecha
            nodeData = projectNode.SelectSingleNode("Fecha");
            proyecto.Fecha= nodeData.InnerText;

            XmlNode nodeLosa = projectNode.SelectSingleNode("Losas");
            XmlNodeList nodeLosas = nodeLosa.SelectNodes("losa");
                        
            foreach (XmlElement item in nodeLosas)
            {
                //variables para add to list
                DatabaseLosa.Losa losa = new DatabaseLosa.Losa();
                DatabaseLosa.Carga carga = new DatabaseLosa.Carga();

                //obteniendo datos de losa
                losa.Nombre = item.SelectSingleNode("Nombre").InnerText;
                losa.Lx = Convert.ToDouble(item.SelectSingleNode("Lx").InnerText);
                losa.Ly = Convert.ToDouble(item.SelectSingleNode("Ly").InnerText);
                losa.BordesY = Convert.ToInt32(item.SelectSingleNode("BordesY").InnerText);
                losa.Bordesx = Convert.ToInt32(item.SelectSingleNode("Bordesx").InnerText);

                //obteniendo datos de carga
                carga.Xy = item.SelectSingleNode("Xy").InnerText;
                carga.Hinclinacion = Convert.ToDouble(item.SelectSingleNode("Hinclinacion").InnerText);
                carga.Carga_viva = Convert.ToDouble(item.SelectSingleNode("Carga_viva").InnerText);
                carga.Carga_adicional = Convert.ToDouble(item.SelectSingleNode("Carga_adicional").InnerText);

                losas.Add(losa);
                cargas.Add(carga);
            }

            
            int x = 0;
            //calculando losas y cargas
            foreach (DatabaseLosa.Losa losa in losas)
            {
                CalculosLosa cl = new CalculosLosa(losa);
                CalculoCarga ccarg = new CalculoCarga(losa, cl, proyecto, cargas[x]);
                calculosLosas.Add(cl);
                calculosCargas.Add(ccarg);
                x++;                
            }
        }
    }
}
