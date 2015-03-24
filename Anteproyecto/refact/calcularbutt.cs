double m, tmin = 0, P180 = -1, t = 10.00, us = 0 ;
            
             int bordes=0, bordeX=0 , bordeY=0 ;
             if ((Convert.ToDouble(txtLx.Text)) <= (Convert.ToDouble(txtLy.Text)))
             {
                  m = Convert.ToDouble(txtLx.Text) / Convert.ToDouble(txtLy.Text);
             }
             else
             {
                 m = Convert.ToDouble(txtLy.Text) / Convert.ToDouble(txtLx.Text);
             }

            dataGridView1.Rows[cmbLosas.SelectedIndex].Cells[3].Value = Convert.ToString(m);

            if((m>=0.5))
            {
                
                dataGridView1.Rows[cmbLosas.SelectedIndex].Cells[4].Value = "En dos direcciones";
                if (rectangleShapeBordeSup.FillStyle != Microsoft.VisualBasic.PowerPacks.FillStyle.BackwardDiagonal)
                {
                    bordes++;
                    bordeX++;
                }
                if (rectangleShapeBordeInf.FillStyle != Microsoft.VisualBasic.PowerPacks.FillStyle.BackwardDiagonal)
                {
                    bordes++;
                    bordeX++;
                }
                if (rectangleShapeBordeIzq.FillStyle != Microsoft.VisualBasic.PowerPacks.FillStyle.BackwardDiagonal)
                {
                    bordes++;
                    bordeY++;
                }
                if (rectangleShapeBordeDer.FillStyle != Microsoft.VisualBasic.PowerPacks.FillStyle.BackwardDiagonal)
                {
                    bordes++;
                    bordeY++;
                }

                dataGridView1.Rows[cmbLosas.SelectedIndex].Cells[8].Value = "...";

                if ((Convert.ToDouble(txtLx.Text)) <= (Convert.ToDouble(txtLy.Text)))
                {
                    double bs = (Convert.ToDouble(txtLy.Text) / Convert.ToDouble(txtLx.Text));
                    tmin = ((Convert.ToDouble(txtLy.Text)*100) * (0.8 + Convert.ToDouble(txtFy.Text) / 14000)) / (36 + (9 * bs));
                }
                else
                {
                    double bs = (Convert.ToDouble(txtLx.Text) / Convert.ToDouble(txtLy.Text));                    
                    tmin = ((Convert.ToDouble(txtLx.Text)*100) * (0.8 + Convert.ToDouble(txtFy.Text) / 14000)) / (36 + (9 * bs));
                }

                P180 = (2 * 100 * (Convert.ToDouble(txtLx.Text) + Convert.ToDouble(txtLy.Text)))/180;
            }
            else
            {
                dataGridView1.Rows[cmbLosas.SelectedIndex].Cells[4].Value = "En una dirección";
                if ((m < 0.5)&&(groupBoxEn1DirecX.Visible==true))
                {
                    if (rectangleShapeXArriba.FillStyle != Microsoft.VisualBasic.PowerPacks.FillStyle.BackwardDiagonal)
                    {
                        bordes++;
                        bordeX++;
                    }
                    if (rectangleShapeXAbajo.FillStyle != Microsoft.VisualBasic.PowerPacks.FillStyle.BackwardDiagonal)
                    {
                        bordes++;
                        bordeX++;
                    }
                    if (rectangleShapeXIzq.BorderStyle == System.Drawing.Drawing2D.DashStyle.Dash)
                    {
                        bordes++;
                        bordeY++;
                        
                    }
                    if (rectangleShapeXDer.BorderStyle == System.Drawing.Drawing2D.DashStyle.Dash)
                    {
                        bordes++;
                        bordeY++;
                    }                
                }
                else if (((m < 0.5) && (groupBoxEn1DirecY.Visible == true)))
                {
                    if (rectangleShapeYArriba.BorderStyle == System.Drawing.Drawing2D.DashStyle.Dash)
                    {
                        bordes++;
                        bordeX++;
                    }
                    if (rectangleShapeYAbajo.BorderStyle == System.Drawing.Drawing2D.DashStyle.Dash)
                    {
                        bordes++;
                        bordeX++;
                    }
                    if (rectangleShapeYIzq.FillStyle != Microsoft.VisualBasic.PowerPacks.FillStyle.BackwardDiagonal)
                    {
                        bordes++;
                        bordeY++;
                    }
                    if (rectangleShapeYDer.FillStyle != Microsoft.VisualBasic.PowerPacks.FillStyle.BackwardDiagonal)
                    {
                        bordes++;
                        bordeY++;
                    }
                }
                if (bordes == 1)
                {//empotrada-articulada
                    dataGridView1.Rows[cmbLosas.SelectedIndex].Cells[8].Value = "empotrada-articulada";
                    if ((Convert.ToDouble(txtLx.Text)) <= (Convert.ToDouble(txtLy.Text)))
                    {
                        tmin = (Convert.ToDouble(txtLx.Text)*100) / 20 * (0.4 + Convert.ToDouble(txtFy.Text) / 7000);
                    }
                    else
                    {
                        tmin = (Convert.ToDouble(txtLy.Text)*100) / 20 * (0.4 + Convert.ToDouble(txtFy.Text) / 7000);
                    }  

                }
                else if ((bordes == 4)||(bordes == 2))
                {//simplemente apoyada
                    dataGridView1.Rows[cmbLosas.SelectedIndex].Cells[8].Value = "simplemente apoyada";
                    if ((Convert.ToDouble(txtLx.Text)) <= (Convert.ToDouble(txtLy.Text)))
                    {
                        tmin = (Convert.ToDouble(txtLx.Text) * 100) / 24 * (0.4 + Convert.ToDouble(txtFy.Text) / 7000);
                    }
                    else
                    {
                        tmin = (Convert.ToDouble(txtLy.Text) * 100) / 24 * (0.4 + Convert.ToDouble(txtFy.Text) / 7000);
                    } 
 
                }
                else if (bordes == 3)
                {//en voladizo
                    dataGridView1.Rows[cmbLosas.SelectedIndex].Cells[8].Value = "en voladizo";
                    if ((Convert.ToDouble(txtLx.Text)) <= (Convert.ToDouble(txtLy.Text)))
                    {
                        tmin = (Convert.ToDouble(txtLx.Text) * 100) / 10 * (0.4 + Convert.ToDouble(txtFy.Text) / 7000);
                    }
                    else
                    {
                        tmin = (Convert.ToDouble(txtLy.Text) * 100) / 10 * (0.4 + Convert.ToDouble(txtFy.Text) / 7000);
                    } 
                }
                else if (bordes == 0)
                {//empotrada-empotrada
                    dataGridView1.Rows[cmbLosas.SelectedIndex].Cells[8].Value = "empotrada-empotrada";
                    if ((Convert.ToDouble(txtLx.Text)) <= (Convert.ToDouble(txtLy.Text)))
                    {
                        tmin = (Convert.ToDouble(txtLx.Text) * 100) / 28 * (0.4 + Convert.ToDouble(txtFy.Text) / 7000);
                    }
                    else
                    {
                        tmin = (Convert.ToDouble(txtLy.Text) * 100) / 28 * (0.4 + Convert.ToDouble(txtFy.Text) / 7000);
                    } 
                }
            }
            almLosas[cmbLosas.SelectedIndex].Bordesx = Convert.ToInt32(bordeX);
            almLosas[cmbLosas.SelectedIndex].BordesY = Convert.ToInt32(bordeY);
            almLosas[cmbLosas.SelectedIndex].Nombre = aLosas[cmbLosas.SelectedIndex].Nombre;
            almLosas[cmbLosas.SelectedIndex].Idproyecto = project.Id;
            dataGridView1.Rows[cmbLosas.SelectedIndex].Cells[5].Value = Convert.ToString(bordes);
            dataGridView1.Rows[cmbLosas.SelectedIndex].Cells[6].Value = Convert.ToString(bordeX);
            dataGridView1.Rows[cmbLosas.SelectedIndex].Cells[7].Value = Convert.ToString(bordeY);
            dataGridView1.Rows[cmbLosas.SelectedIndex].Cells[9].Value = Convert.ToString(tmin);
            if (P180 == -1)
            {
                dataGridView1.Rows[cmbLosas.SelectedIndex].Cells[10].Value = "---";
                if(tmin<=10.00)
                {
                    t = 10.00;
                }
                else
                {
                    t = System.Math.Ceiling(tmin);
                    if (((Convert.ToInt32(t) % 2) != 0) && (t != 15))
                    { t++; }
                }
                    /*
                else if ((tmin > 10.00) && (tmin <= 12.00))
                {
                    t = 12.00; 
                }
                else if ((tmin > 12.00) && (tmin <= 14.00))
                {
                    t = 14.00;
                }
                else if ((tmin > 14.00) && (tmin <= 15.00))
                {
                    t = 15.00;
                }
                else if (tmin > 15.00)
                {
                    t = 16.00;
                }*/
            }
            else
            {
                dataGridView1.Rows[cmbLosas.SelectedIndex].Cells[10].Value = Convert.ToString(P180);
                if (P180 >= tmin)
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
                        /*
                    else if ((P180 > 10.00) && (P180 <= 12.00))
                    {
                        t = 12.00;
                    }
                    else if ((P180 > 12.00) && (P180 <= 14.00))
                    {
                        t = 14.00;
                    }
                    else if ((P180 > 14.00) && (P180 <= 15.00))
                    {
                        t = 15.00;
                    }
                    else if (P180 > 15.00)
                    {
                        t = System.Math.Ceiling(P180);
                    }*/

                }
                else
                {
                    if (tmin <= 10.00)
                    {
                        t = 10.00;
                    }
                    else
                    {
                        t = System.Math.Ceiling(tmin);
                        if (((Convert.ToInt32(t) % 2) != 0) && (t != 15))
                        { t++; }
                    }
                        /*
                    else if ((tmin > 10.00) && (tmin <= 12.00))
                    {
                        t = 12.00;
                    }
                    else if ((tmin > 12.00) && (tmin <= 14.00))
                    {
                        t = 14.00;
                    }
                    else if ((tmin > 14.00) && (tmin <= 15.00))
                    {
                        t = 15.00;
                    }
                    else if (tmin > 15.00)
                    {                        
                        t = System.Math.Ceiling(tmin);
                    } */
                }
            }

            dataGridView1.Rows[cmbLosas.SelectedIndex].Cells[11].Value = Convert.ToString(t);
            if (t < 12)
            {
                dataGridView1.Rows[cmbLosas.SelectedIndex].Cells[12].Value = "12";
            }
            else 
            {
                dataGridView1.Rows[cmbLosas.SelectedIndex].Cells[12].Value = Convert.ToString(t);
            }
            
            /*if (dataGridView1.Rows[0].Cells[0].Value != "Losa1")
            {
                dataGridView1.Rows[0].Cells[2].Value = "5";
                dataGridView1.Rows[0].Cells[0].Value = "Losa1";
                dataGridView1.Rows[0].Cells[1].Value = "6";
                dataGridView1.Rows[0].Cells[3].Value = "1.2";
                dataGridView1.Rows[0].Cells[4].Value = "En una dirrecion";
                dataGridView1.Rows[0].Cells[5].Value = "2";
                dataGridView1.Rows[0].Cells[6].Value = "1";
                dataGridView1.Rows[0].Cells[7].Value = "1";
            }
            else
            {
                dataGridView1.Rows[0].Cells[0].Value = "";
                dataGridView1.Rows[0].Cells[1].Value = "";
                dataGridView1.Rows[0].Cells[2].Value = "";
                dataGridView1.Rows[0].Cells[3].Value = ""; 
                dataGridView1.Rows[0].Cells[4].Value = "";
                dataGridView1.Rows[0].Cells[5].Value = "";
                dataGridView1.Rows[0].Cells[6].Value = "";
                dataGridView1.Rows[0].Cells[7].Value = "";
                

            }*/
            /*MenuForm n = new MenuForm();
            n.Show();*/

            //almLosas[cmbLosas.SelectedIndex].fc = Convert.ToDouble(txtFx.Text);
            //almLosas[cmbLosas.SelectedIndex].fy = Convert.ToDouble(txtFy.Text);
            //almLosas[cmbLosas.SelectedIndex].recubrimiento = Convert.ToDouble(txtRecublimiento.Text);