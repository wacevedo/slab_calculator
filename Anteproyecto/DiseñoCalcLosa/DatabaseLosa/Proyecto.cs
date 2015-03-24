using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DatabaseLosa
{
    public class Proyecto
    {        

        long id;

        public long Id
        {
            get { return id; }
            set { id = value; }
        }

        string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        string tipo_edificio;

        public string Tipo_edificio
        {
            get { return tipo_edificio; }
            set { tipo_edificio = value; }
        }

        string usuario;

        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        double peso_concreto=0;

        public double Peso_concreto
        {
            get { return peso_concreto; }
            set { peso_concreto = value; }
        }

        double terminacion=0;

        public double Terminacion
        {
            get { return terminacion; }
            set { terminacion = value; }
        }

        double fc;

        public double Fc
        {
            get { return fc; }
            set { fc = value; }
        }

        double fy;

        public double Fy
        {
            get { return fy; }
            set { fy = value; }
        }

        string tipo_losa;

        public string Tipo_losa
        {
            get { return tipo_losa; }
            set { tipo_losa = value; }
        }

        double pandereta=0;

        public double Pandereta
        {
            get { return pandereta; }
            set { pandereta = value; }
        }

        double recubrimiento=0;

        public double Recubrimiento
        {
            get { return recubrimiento; }
            set { recubrimiento = value; }
        }

        string estado;

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        string fecha;

        public string Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
 
        public override string ToString()
        {
            return Nombre;
        }
    }
}
