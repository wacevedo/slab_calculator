using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DatabaseLosa
{
    public class Losa
    {
        int id;

        public int Id
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

        double lx=0;

        public double Lx
        {
            get { return lx; }
            set { lx = value; }
        }

        double ly=0;

        public double Ly
        {
            get { return ly; }
            set { ly = value; }
        }

        int bordesY;

        public int BordesY
        {
            get { return bordesY; }
            set { bordesY = value; }
        }

        int bordesx;

        public int Bordesx
        {
            get { return bordesx; }
            set { bordesx = value; }
        }

        long idproyecto;

        public long Idproyecto
        {
            get { return idproyecto; }
            set { idproyecto = value; }
        }

        public override string ToString()
        {
            return Nombre;
        }

    }
}
