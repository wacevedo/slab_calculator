using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiseñoCalcLosa
{
    class Losa
    {
        public string Nombre = "";

        public double Lx = 0;

        public double Ly = 0;

        public double fy = 0;

        public double fc = 0;

        public double recubrimiento = 0;        

        public int BordeX = 0;

        public int BordeY = 0;
        

        public override string ToString()
        {
            return Nombre;
        }

    }
}
