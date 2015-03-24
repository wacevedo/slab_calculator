using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DatabaseLosa
{
    public class Carga
    {
        int id_carga;

        public int Id_carga
        {
            get { return id_carga; }
            set { id_carga = value; }
        }

        double hinclinacion;


        public double Hinclinacion
        {
            get { return hinclinacion; }
            set { hinclinacion = value; }
        }

        string xy;

        public string Xy
        {
            get { return xy; }
            set { xy = value; }
        }

        double carga_adicional;

        public double Carga_adicional
        {
            get { return carga_adicional; }
            set { carga_adicional = value; }
        }

        double carga_viva;

        public double Carga_viva
        {
            get { return carga_viva; }
            set { carga_viva = value; }
        }

        int id_losa;

        public int Id_losa
        {
            get { return id_losa; }
            set { id_losa = value; }
        }
    }
}
