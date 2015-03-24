using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DatabaseLosa;

namespace DiseñoCalcLosa
{
    public class CalculosLosa
    {
        public string LcLl, direccionLosa, bordesDiscontinuos, apoyoArmadoEnUnaDireccion, tmin, p180, T, usar;
        public DatabaseLosa.Losa losa;
        public DatabaseLosa.Proyecto proyecto;
        /// <summary>
        /// Calcula los datos sobre espesores de losa 
        /// 
        /// </summary>
        /// <param name="l">Losa del proyecto</param>
        public CalculosLosa(DatabaseLosa.Losa L)
        {
            DatabaseLosa.Broker b = new DatabaseLosa.Broker();
            losa = new DatabaseLosa.Losa();
            losa = L;
            proyecto = new Proyecto();
            proyecto = b.selectProyecto(L.Idproyecto);
            double m, tmi = 0, P180 = -1, t = 10.00;
            // bordes discontinuos
            int bordes = L.Bordesx + L.BordesY;
            bordesDiscontinuos = Convert.ToString(bordes);

            // Lc/Ll
            if (L.Lx <= L.Ly)
            {
                m = L.Lx / L.Ly;
            }
            else
            {
                m = L.Ly / L.Lx;
            }
            LcLl = Convert.ToString(m);


            if ((m >= 0.5))
            {
                
                direccionLosa = "En dos direcciones";
                apoyoArmadoEnUnaDireccion = "...";
                if ((L.Lx) <= (L.Ly))
                {
                    double bs = (L.Ly / L.Lx);
                    //hacer select del proyecto para buscar fy
                    tmi = ((L.Ly * 100) * (0.8 + proyecto.Fy / 14000)) / (36 + (9 * bs));
                }
                else
                {
                    double bs = (L.Lx / L.Ly);
                    tmi = ((L.Lx * 100) * (0.8 + proyecto.Fy / 14000)) / (36 + (9 * bs));
                }
                                
                
                P180 = (2 * 100 * (L.Lx + L.Ly)) / 180;

            }
            else
            {
                direccionLosa = "En una dirección";
                if (bordes == 1)
                {//empotrada-articulada
                    apoyoArmadoEnUnaDireccion = "empotrada-articulada";
                    if ((L.Lx) <= (L.Ly))
                    {
                        tmi = (L.Lx * 100) / 20 * (0.4 + proyecto.Fy / 7000);
                    }
                    else
                    {
                        tmi = (L.Ly * 100) / 20 * (0.4 + proyecto.Fy / 7000);
                    }

                }
                else if ((bordes == 4) || (bordes == 2))
                {//simplemente apoyada
                    apoyoArmadoEnUnaDireccion = "simplemente apoyada";
                    if ((L.Lx) <= (L.Ly))
                    {
                        tmi = (L.Lx * 100) / 24 * (0.4 + proyecto.Fy / 7000);
                    }
                    else
                    {
                        tmi = (L.Ly * 100) / 24 * (0.4 + proyecto.Fy / 7000);
                    }

                }
                else if (bordes == 3)
                {//en voladizo
                    apoyoArmadoEnUnaDireccion = "en voladizo";
                    if ((L.Lx) <= (L.Ly))
                    {
                        tmi = (L.Lx * 100) / 10 * (0.4 + proyecto.Fy / 7000);
                    }
                    else
                    {
                        tmi = (L.Ly * 100) / 10 * (0.4 + proyecto.Fy / 7000);
                    }
                }
                else if ((bordes == 0))
                {//empotrada-empotrada
                    apoyoArmadoEnUnaDireccion = "empotrada-empotrada";
                    if ((L.Lx) <= (L.Ly))
                    {
                        tmi = (L.Lx * 100) / 28 * (0.4 + proyecto.Fy / 7000);
                    }
                    else
                    {
                        tmi = (L.Ly * 100) / 28 * (0.4 + proyecto.Fy / 7000);
                    }
                }
            }

            tmin = Convert.ToString(tmi);
            if (P180 != -1)
            {
                p180 = Convert.ToString(P180);
            }
            else
            {
                p180 = "...";
            }



             if (P180 >= tmi)
                {
                    if (P180 <= 10)
                    {
                        t = 10.00;
                    }
                    else 
                    {
                        t = System.Math.Ceiling(P180);
                        if (((Convert.ToInt32(t) % 2) != 0)&&(t!=15))
                        { t++; }
                    }
                        
                    
                }
                else
                {
                    if (tmi <= 10.00)
                    {
                        t = 10.00;
                    }
                    else
                    {
                        t = System.Math.Ceiling(tmi);
                        if (((Convert.ToInt32(t) % 2) != 0) && (t != 15))
                        { t++; }
                    }
                        
                }

             T = Convert.ToString(t);
             if (t < 12)
             {
                 usar = "12";
             }
             else
             {
                 usar = Convert.ToString(t);
             }













            //fin
            }
            
            
        }
     
   
}
