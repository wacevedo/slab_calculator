using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Interop.Word;//agregar referencia Microsoft Word object library 
using DatabaseLosa;
using System.Runtime.InteropServices; //de aqui se saca la clase paciente para llenar la plantilla, esto cambia segun el objeto

/*antes que nada es necesario crear una plantilla de word para utilizar esta clase*/

namespace DiseñoCalcLosa //arreglar namespace para que funcione en el proyecto deseado
{
    
    class PlantillaProyecto
    {
            public int progreso=0;
            // creando objeto de salida
            private Object oMissing = System.Reflection.Missing.Value;
            
            // localizando el objeto de salido con la ruta
            private Object oTemplatePath = "C:/Users/Willson Acevedo/slab_calculator/Anteproyecto/DiseñoCalcLosa/DiseñoCalcLosa/bin/Debug/complementos/Plantilla_losa2.dotx";//arreglar // o \\ 
                                          
            //creando instancia de aplicacion que se usara 
            private Application wordApp = new Application();
            // creando instancia del documento
            private Document wordDoc = new Document();
            
            //metodo constructos... se puede cambiar para que la clase trabaje con diferentes metodos y funciones para difentetes plantillas
            public PlantillaProyecto(CalculosProyecto c)
            {
                
                try
                {

                    
                //agregando la ruta y otros espesificaciones a la instancia del documento
                wordDoc = wordApp.Documents.Add(ref oTemplatePath, ref oMissing, ref oMissing, ref oMissing);

                //for que recorre cada campo de la plantilla del documento
                
                foreach (Field myMergeField in wordDoc.Fields)
                {

                    bool nofound = true;
                    Range rngFieldCode = myMergeField.Code; 

                    String fieldText = rngFieldCode.Text;





                    if (fieldText.StartsWith(" MERGEFIELD"))//validacion para llenar campos que sean MERGEFIELD
                    {



                        //string merge = " MERGEFIELD";                    

                        Int32 endMerge = fieldText.IndexOf("\\"); // final del campo

                        Int32 fieldNameLength = fieldText.Length - endMerge; //tamaño del campo a llenar

                        String fieldName = fieldText.Substring(11); //, endMerge - 11);//corte del nombre del campo por defecto

                       
                      fieldName = fieldName.Trim(); //se eleminan espacios en blanco

                       //estructura de la plantilla
                      /*FNombre
                       * Nombre_losa1»
                        •	«Direccion_losa1»
                        •	«Apoyo_direccion1»
                        •	«Espesores1» 
                        o	«tmin1»
                        o	«p1801»
                        o	«t1»
                        o	«a_usar1»
                        •	«Carga_viva1»
                        •	«Carga_muerta1»
                        •	«Carga_ultima1»
                        •	Reaccion hacia los apoyos:
                        o	«Angulos1»
                        o	«Tonm1»
                       * Tipo de edificio 
                       */
                        //se llena cada campo con su respectivo dato
                      
                       //for(int x=0; x<10; x++)       {
                        if (fieldName == "Nombre_Ing")
                        {
                             myMergeField.Select();
                             wordApp.Selection.TypeText(c.proyecto.Usuario);
                             nofound = false;
                        }
                        for (int x = 0; x < c.losas.Count; x++)
                        {
                            if (fieldName == ("Nombre_losa"+ Convert.ToString(x + 1)))
                            {
                                myMergeField.Select();
                                wordApp.Selection.TypeText(c.losas[x].Nombre);
                                nofound = false;
                                break;
                            }
                            if (fieldName == ("Direccion_losa" + Convert.ToString(x + 1)))
                            {
                                myMergeField.Select();
                                wordApp.Selection.TypeText("Losa armada en "+c.calculosLosas[x].direccionLosa);
                                nofound = false;
                                break;
                            }

                            if (fieldName == ("Apoyo_direccion" + Convert.ToString(x + 1)))
                            {
                                myMergeField.Select();
                                if (c.calculosLosas[x].apoyoArmadoEnUnaDireccion != "...")
                                {
                                    wordApp.Selection.TypeText("Apoyos en Losas armadas en una dirección: " + c.calculosLosas[x].apoyoArmadoEnUnaDireccion);
                                    nofound = false;
                                }
                                else
                                {
                                    wordApp.Selection.TypeText(" ");
                                    nofound = false;
                                }
                                break;
                            }

                            if (fieldName == "Espesores")
                            {
                                myMergeField.Select();
                                wordApp.Selection.TypeText("Espesores");
                                nofound = false;
                                break;
                            }

                            if (fieldName == ("tmin" + Convert.ToString(x + 1)))
                            {
                                myMergeField.Select();
                                wordApp.Selection.TypeText("Tmin: "+c.calculosLosas[x].tmin+"(cm.)");
                                nofound = false;
                                break;
                            }

                            if (fieldName == ("p180" + Convert.ToString(x + 1)))
                            {
                                myMergeField.Select();
                                wordApp.Selection.TypeText("P/180: "+Convert.ToString(c.calculosLosas[x].p180)+"(cm.)");
                                nofound = false;
                                break;
                            }

                            if (fieldName == ("t" + Convert.ToString(x + 1)))
                            {
                                myMergeField.Select();
                                wordApp.Selection.TypeText("T: "+Convert.ToString(c.calculosLosas[x].T)+"(cm.)");
                                nofound = false;
                                break;
                            }
                            if (fieldName == ("a_usar" + Convert.ToString(x + 1)))
                            {
                                myMergeField.Select();
                                wordApp.Selection.TypeText("T a usar: " +Convert.ToString(c.calculosLosas[x].usar)+"(cm.)");
                                nofound = false;
                                break;
                            }
                            if (fieldName == ("carga_viva" + Convert.ToString(x + 1)))
                            {
                                myMergeField.Select();
                                wordApp.Selection.TypeText("Carga viva: " +Convert.ToString(c.calculosCargas[x].cargaViva)+" (to/m²)");
                                nofound = false;
                                break;
                            }
                            if (fieldName == ("carga_muerta" + Convert.ToString(x + 1)))
                            {
                                myMergeField.Select();
                                wordApp.Selection.TypeText("Carga muerta: " +Convert.ToString(c.calculosCargas[x].cargaMuerta)+" (to/m²)");
                                nofound = false;
                                break;
                            }
                            if (fieldName == ("carga_ultima" + Convert.ToString(x + 1)))
                            {
                                myMergeField.Select();
                                wordApp.Selection.TypeText("Carga ultima: " + Convert.ToString(c.calculosCargas[x].cargaUltima) + " (to/m²)");
                                nofound = false;
                                break;                                
                            }
                            if (fieldName == ("angulos" + Convert.ToString(x + 1)))
                            {
                                myMergeField.Select();
                                wordApp.Selection.TypeText("Angulo de inclinacion en Grados: "+Convert.ToString(c.calculosCargas[x].angulo));
                                nofound = false;
                                break;
                            }
                            if (fieldName == ("Tonm" + Convert.ToString(x + 1)))
                            {
                                myMergeField.Select();
                                wordApp.Selection.TypeText("Reacción hacia los apoyos: "+Convert.ToString(c.calculosCargas[x].reaccion)+"(to/m²), "+Convert.ToString(c.calculosCargas[x].reaccionAng)+" (to/m²)");//vacio
                                nofound = false;
                                break;
                            }
                        }
                        if (fieldName == "Tipo_Edificio")
                        {
                            myMergeField.Select();
                            wordApp.Selection.TypeText(c.proyecto.Nombre+" - "+Convert.ToString(c.proyecto.Tipo_edificio));
                            nofound = false;
                        }
                        if (nofound)
                        {
                            myMergeField.Select();
                            wordApp.Selection.TypeText(" "); 
                        }
                    
                        

                    }

                }
                progreso = 100;     
                wordDoc.SaveAs(c.proyecto.Nombre + ".doc");//save as
                wordApp.Documents.Open(c.proyecto.Nombre +".doc");//opcional: abre el documento para visualizar despues de haber guardado
                //wordApp.Application.Quit();
                

                }
                catch (COMException)
                {

                    throw;
                    
                }
            }

    }
}
