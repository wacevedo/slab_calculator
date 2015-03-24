using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DatabaseLosa;

namespace DiseñoCalcLosa
{
    public class CalculoCarga
    {
        public double angulo, cargaViva, cargaMuerta, cargaUltima, reaccion, reaccionAng;
        //
        public CalculoCarga(DatabaseLosa.Losa l, CalculosLosa cl, Proyecto p, Carga ca)
        {
             double lc=0.0;
             double ll = 0.0;
            
             if ((l.Lx) <= (l.Ly))
             {
                 ll = l.Ly;
                 lc = l.Lx;
             }
             else
             {
                 ll = l.Lx;
                 lc = l.Ly;
             }
             angulo = Math.Atan(ca.Hinclinacion / lc);
             cargaMuerta = 1.2 * Convert.ToDouble(cl.T) *p.Peso_concreto* Math.Cos(angulo);             
             
             cargaViva = ca.Carga_viva;
             cargaUltima = 1.2 *Math.Cos(ca.Hinclinacion)*cargaMuerta + 1.6 * cargaViva;
             
             double alfa = (3-(lc/ll)*(lc/ll))/2;
             reaccion = (cargaUltima * lc) / 3;
             reaccionAng = reaccion * alfa; 
        }
        
    }
}
