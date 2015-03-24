using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;

namespace DatabaseLosa
{
    public class Broker
    {

        OleDbConnection connection;
        OleDbCommand command;
        private void ConnectTo()
        {
            connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=complementos\DatabaseLosas.accdb;Persist Security Info=False");//C:\Users\Willson Acevedo\Documents\Anteproyecto\Anteproyecto\DiseñoCalcLosa\complementos\
            command = connection.CreateCommand();
        }
        public Broker()
        {
            ConnectTo();
        }
        

        public void InsertProyecto(Proyecto p)
        {
            
            try
            {
                command.CommandText = "INSERT INTO PROYECTO (ID_PROYECTO, NOMBRE, TIPO_DE_LOSAS, TERMINACION, PESO_CONCRETO, USUARIO, FC, FY, RECUBRIMIENTO, PANDERETA, ESTADO, FECHA,TIPO_EDIFICIO) VALUES(" + Convert.ToString(p.Id) + ",'" + p.Nombre + "', '" + p.Tipo_losa + "', " + Convert.ToString(p.Terminacion) + ", " + Convert.ToString(p.Peso_concreto) + ", '" + p.Usuario + "', " + Convert.ToString(p.Fc) + ", " + Convert.ToString(p.Fy) + ", " + Convert.ToString(p.Recubrimiento) + ", " + Convert.ToString(p.Pandereta) + ", '" + p.Estado + "', '" + p.Fecha + "', '" + p.Tipo_edificio + "')";
                //command.CommandText = "INSERT INTO PROYECTO * VALUES('" + p.Nombre + "', '" + p.Tipo_losa + "', " + Convert.ToString(p.Terminacion) + ", " + Convert.ToString(p.Peso_concreto) + ", '" + p.Usuario + "', " + Convert.ToString(p.Fc) + ", " + Convert.ToString(p.Fy) + ", " + Convert.ToString(p.Recubrimiento) + ", " + Convert.ToString(p.Pandereta) + ", '" + p.Estado + "', '" + p.Fecha + "')";
                command.CommandType = CommandType.Text;

                connection.Open();

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }//final insert

        public void InsertLosa(Losa l)
        {

            try
            {
                command.CommandText = "INSERT INTO LOSA (NOMBRE, LX, LY, BORDESX, BORDESY, ID_PROYECTO) VALUES('" + l.Nombre + "', " + Convert.ToString(l.Lx) + ", " + Convert.ToString(l.Ly) + ", " + Convert.ToString(l.Bordesx) + ", " + Convert.ToString(l.BordesY) + ", " + Convert.ToString(l.Idproyecto) + ")";
                command.CommandType = CommandType.Text;

                connection.Open();

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }//final insert

        public void InsertCarga(Carga c)
        {

            try
            {
                command.CommandText = "INSERT INTO CARGA (HINCLINACION, CARGA_ADICIONAL, XY, CARGA_VIVA, ID_LOSA) VALUES(" + Convert.ToString(c.Hinclinacion) + ","+Convert.ToString(c.Carga_adicional)+",'"+c.Xy+"',"+Convert.ToString(c.Carga_viva)+","+Convert.ToString(c.Id_losa)+")";
                
                command.CommandType = CommandType.Text;

                connection.Open();

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }//final insert

        //Update Estado Proyecto
        public void UpdateEstadoProyecto(Proyecto p)
        {

            try
            {
                command.CommandText = "UPDATE PROYECTO SET ESTADO = '" + p.Estado + "' WHERE ID_PROYECTO=" + Convert.ToString(p.Id); 
                
                command.CommandType = CommandType.Text;

                connection.Open();

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }//final insert

        //proyectos recientes
        public List<Proyecto> selectProyectosRecientes()
        {
            List<Proyecto> ListaPro = new List<Proyecto>();
            try
            {
                var hoy = DateTime.Now;
                var hoymenossemana = hoy.AddDays(-30);
                string haceunasemana = hoymenossemana.ToString();
                command.CommandText = "SELECT * FROM PROYECTO WHERE CDATE(FECHA) >= CDATE('"+haceunasemana+"')";
                command.CommandType = CommandType.Text;
                connection.Open();

                OleDbDataReader reader = command.ExecuteReader();
                int x = 1;
                while (reader.Read())
                {

                    Proyecto p = new Proyecto();
                    p.Id = Convert.ToInt64(reader["ID_PROYECTO"].ToString());
                    p.Usuario = reader["USUARIO"].ToString();
                    p.Peso_concreto = Convert.ToDouble(reader["PESO_CONCRETO"].ToString());
                    p.Terminacion = Convert.ToDouble(reader["TERMINACION"].ToString());
                    p.Fc = Convert.ToDouble(reader["FC"].ToString());
                    p.Fy = Convert.ToDouble(reader["FY"].ToString());
                    p.Recubrimiento = Convert.ToDouble(reader["RECUBRIMIENTO"].ToString());
                    p.Tipo_losa = reader["TIPO_DE_LOSAS"].ToString();
                    p.Pandereta = Convert.ToDouble(reader["PANDERETA"].ToString());
                    p.Nombre = reader["NOMBRE"].ToString();
                    p.Estado = reader["ESTADO"].ToString();
                    p.Fecha = reader["FECHA"].ToString();
                    p.Tipo_edificio = reader["TIPO_EDIFICIO"].ToString();//TIPO_EDIFICIO
                    /*p.Cedula = reader["CEDULA"].ToString();
                    p.Sexo = reader["SEXO"].ToString();
                    p.Fechanac = reader["FECHA_NAC"].ToString();
                    p.Direccion = reader["DIRECCION"].ToString();
                    p.Peso = Convert.ToInt32(reader["PESO"].ToString());*/
                    ListaPro.Add(p);
                    x++;
                }
                return ListaPro;

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }//final proyectos recientes

        //proyectos # recientes
        public List<Proyecto> selectUltimosProyectos(int numero)
        {
            List<Proyecto> ListaPro = new List<Proyecto>();
            try
            {

                command.CommandText = "SELECT TOP " + Convert.ToString(numero) + " * FROM PROYECTO ORDER BY (CDATE(FECHA)) DESC";
                command.CommandType = CommandType.Text;
                connection.Open();

                OleDbDataReader reader = command.ExecuteReader();
                int x = 1;
                while (reader.Read())
                {

                    Proyecto p = new Proyecto();
                    p.Id = Convert.ToInt64(reader["ID_PROYECTO"].ToString());
                    p.Usuario = reader["USUARIO"].ToString();
                    p.Peso_concreto = Convert.ToDouble(reader["PESO_CONCRETO"].ToString());
                    p.Terminacion = Convert.ToDouble(reader["TERMINACION"].ToString());
                    p.Fc = Convert.ToDouble(reader["FC"].ToString());
                    p.Fy = Convert.ToDouble(reader["FY"].ToString());
                    p.Recubrimiento = Convert.ToDouble(reader["RECUBRIMIENTO"].ToString());
                    p.Tipo_losa = reader["TIPO_DE_LOSAS"].ToString();
                    p.Pandereta = Convert.ToDouble(reader["PANDERETA"].ToString());
                    p.Nombre = reader["NOMBRE"].ToString();
                    p.Estado = reader["ESTADO"].ToString();
                    p.Fecha = reader["FECHA"].ToString();
                    p.Tipo_edificio = reader["TIPO_EDIFICIO"].ToString();

                    ListaPro.Add(p);
                    x++;
                }
                return ListaPro;

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }//final proyectos recientes

        //select todos los proyectos
        public List<Proyecto> selectProyectos()
        {
            List<Proyecto> ListaPro = new List<Proyecto>();
            try
            {
                
                command.CommandText = "SELECT * FROM PROYECTO";
                command.CommandType = CommandType.Text;
                connection.Open();

                OleDbDataReader reader = command.ExecuteReader();
                int x = 1;
                while (reader.Read())
                {

                    Proyecto p = new Proyecto();
                    p.Id = Convert.ToInt64(reader["ID_PROYECTO"].ToString());
                    p.Usuario = reader["USUARIO"].ToString();
                    p.Peso_concreto = Convert.ToDouble(reader["PESO_CONCRETO"].ToString());
                    p.Terminacion = Convert.ToDouble(reader["TERMINACION"].ToString());
                    p.Fc = Convert.ToDouble(reader["FC"].ToString());
                    p.Fy = Convert.ToDouble(reader["FY"].ToString());
                    p.Recubrimiento = Convert.ToDouble(reader["RECUBRIMIENTO"].ToString());
                    p.Tipo_losa = reader["TIPO_DE_LOSAS"].ToString();
                    p.Pandereta = Convert.ToDouble(reader["PANDERETA"].ToString());
                    p.Nombre = reader["NOMBRE"].ToString();
                    p.Estado = reader["ESTADO"].ToString();
                    p.Fecha = reader["FECHA"].ToString();
                    p.Tipo_edificio = reader["TIPO_EDIFICIO"].ToString();
                    
                    ListaPro.Add(p);
                    x++;
                }
                return ListaPro;

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }//final todos los proyectos 

        //select un proyectos
        public Proyecto selectProyecto(long id)
        {
            
            try
            {

                command.CommandText = "SELECT * FROM PROYECTO WHERE ID_PROYECTO="+ Convert.ToString(id);
                command.CommandType = CommandType.Text;
                connection.Open();

                OleDbDataReader reader = command.ExecuteReader();
                Proyecto p = new Proyecto();

                if (reader.Read())
                {
                    
                    p.Id = Convert.ToInt64(reader["ID_PROYECTO"].ToString());
                    p.Usuario = reader["USUARIO"].ToString();
                    p.Peso_concreto = Convert.ToDouble(reader["PESO_CONCRETO"].ToString());
                    p.Terminacion = Convert.ToDouble(reader["TERMINACION"].ToString());
                    p.Fc = Convert.ToDouble(reader["FC"].ToString());
                    p.Fy = Convert.ToDouble(reader["FY"].ToString());
                    p.Recubrimiento = Convert.ToDouble(reader["RECUBRIMIENTO"].ToString());
                    p.Tipo_losa = reader["TIPO_DE_LOSAS"].ToString();
                    p.Pandereta = Convert.ToDouble(reader["PANDERETA"].ToString());
                    p.Nombre = reader["NOMBRE"].ToString();
                    p.Estado = reader["ESTADO"].ToString();
                    p.Fecha = reader["FECHA"].ToString();
                    p.Tipo_edificio = reader["TIPO_EDIFICIO"].ToString();

                }
                return p;

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }//final un proyectos 

        //select lista de losas
        public List<Losa> selectLosas(long idProyecto)
        {
            List<Losa> Listalosa = new List<Losa>();
            try
            {

                command.CommandText = "SELECT * FROM LOSA WHERE ID_PROYECTO=" + Convert.ToString(idProyecto);
                command.CommandType = CommandType.Text;
                connection.Open();

                OleDbDataReader reader = command.ExecuteReader();
                
                while (reader.Read())
                {

                    Losa p = new Losa();
                    p.Id = Convert.ToInt32(reader["ID_LOSA"].ToString());
                    p.Nombre = reader["NOMBRE"].ToString();
                    p.Lx = Convert.ToDouble(reader["LX"].ToString());
                    p.Ly = Convert.ToDouble(reader["LY"].ToString());
                    p.Bordesx = Convert.ToInt32(reader["BORDESX"].ToString());
                    p.BordesY = Convert.ToInt32(reader["BORDESY"].ToString());
                    p.Idproyecto = Convert.ToInt64(reader["ID_PROYECTO"].ToString());
                    
                    Listalosa.Add(p);
                  
                }
                return Listalosa;

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }//final las losas de proyectos

        //select lista de CARGAS
        public List<Carga> selectCargas(long idProyecto)
        {
            List<Carga> ListaCargas = new List<Carga>();
            try
            {

                command.CommandText = "SELECT CARGA.ID_LOSA, CARGA.ID_CARGA, CARGA.XY, CARGA.HINCLINACION, CARGA.CARGA_ADICIONAL, CARGA.CARGA_VIVA  FROM CARGA, LOSA WHERE LOSA.ID_LOSA = CARGA.ID_LOSA AND LOSA.ID_PROYECTO=" + Convert.ToString(idProyecto);
                command.CommandType = CommandType.Text;
                connection.Open();

                OleDbDataReader reader = command.ExecuteReader();
                
                while (reader.Read())
                {

                    Carga p = new Carga();
                    p.Id_losa = Convert.ToInt32(reader["ID_LOSA"].ToString());
                    p.Xy = reader["XY"].ToString();
                    p.Id_carga = Convert.ToInt32(reader["ID_CARGA"].ToString());
                    p.Hinclinacion = Convert.ToDouble(reader["HINCLINACION"].ToString());
                    p.Carga_viva=Convert.ToDouble(reader["CARGA_ADICIONAL"].ToString());
                    p.Carga_adicional = Convert.ToDouble(reader["CARGA_VIVA"].ToString());

                    ListaCargas.Add(p);

                }
                return ListaCargas;

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }//final las losas de proyectos
    }
}
