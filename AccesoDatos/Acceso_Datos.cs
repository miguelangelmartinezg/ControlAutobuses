using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
namespace AccesoDatos
{
    public class Acceso_Datos
    {
        SqlConnection miConexion = new SqlConnection(ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString);


        public  DataTable DatosGeneral(string tabla)
        {
            DataTable dt = new DataTable();
            try
            {
                string consulta = "SELECT * FROM " + tabla + " ";
                SqlCommand cmd = new SqlCommand(consulta, miConexion);
                miConexion.Open();
                SqlDataAdapter adap = new SqlDataAdapter(cmd);

                adap.Fill(dt);
                miConexion.Close();
                //objCon.Close();
                
            }
            catch (Exception ex)
            {
                string cMensajeError = ex.Message + ", " + ((ex.InnerException != null) ? ex.InnerException.Message.Trim() : "").ToString();
                miConexion.Close();
                
            }
            return dt;
        }
        public DataTable DatosGeneralConsulta(string cConsulta)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand(cConsulta, miConexion);
                miConexion.Open();
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                adap.Fill(dt);
                miConexion.Close();
              
            }
            catch (Exception ex)
            {
                string cMensajeError = ex.Message + ", " + ((ex.InnerException != null) ? ex.InnerException.Message.Trim() : "").ToString();
                miConexion.Close();
               
            }
            return dt;
        }

        public DataTable ListChoferes(int nId)
        {
            DataTable dtDato = new DataTable();

            SqlCommand cmd = new SqlCommand("ListarChoferes", miConexion);
            cmd.CommandType = CommandType.StoredProcedure;
            miConexion.Open();
            cmd.Parameters.AddWithValue("@IdChofer", nId);
            SqlDataAdapter oAdaptador = new SqlDataAdapter(cmd);
            oAdaptador.Fill(dtDato);
            miConexion.Close();


            return dtDato;
        }
        public void AddChofer(Chofer oChofer)
        {
            SqlCommand cmd = new SqlCommand("AgregarChofer", miConexion);
            cmd.CommandType = CommandType.StoredProcedure;
            miConexion.Open();
            cmd.Parameters.AddWithValue("@Nombre", oChofer.Nombre);
            cmd.Parameters.AddWithValue("@Apellido", oChofer.Apellido);
            cmd.Parameters.AddWithValue("@Cedula", oChofer.Cedula);
            cmd.Parameters.AddWithValue("@FechaNac", oChofer.FechaNac);
            
           
            cmd.ExecuteNonQuery();
            miConexion.Close();


        }
        public void EditChofer(Chofer oChofer)
        {
            SqlCommand cmd = new SqlCommand("ActualizarChofer", miConexion);
            cmd.CommandType = CommandType.StoredProcedure;
            miConexion.Open();
            cmd.Parameters.AddWithValue("@IdChofer", oChofer.IdChofer);
            cmd.Parameters.AddWithValue("@Nombre", oChofer.Nombre);
            cmd.Parameters.AddWithValue("@Apellido", oChofer.Apellido);
            cmd.Parameters.AddWithValue("@Cedula", oChofer.Cedula);
            cmd.Parameters.AddWithValue("@FechaNac", oChofer.FechaNac);
            cmd.ExecuteNonQuery();
            miConexion.Close();
        }
        public int DeletChofer(int nId)
        {
            miConexion.Open();
            string cQuery = "Delete from Choferes where IdChofer = " + nId;
            SqlCommand cmd = new SqlCommand(cQuery, miConexion);
            int nResultado = cmd.ExecuteNonQuery();
            miConexion.Close();
            return nResultado;
        }

        public DataTable ListarAutobuses(int nId)
        {
            DataTable dtDato = new DataTable();

            SqlCommand cmd = new SqlCommand("ListarAutobuses", miConexion);
            cmd.CommandType = CommandType.StoredProcedure;
            miConexion.Open();
            cmd.Parameters.AddWithValue("@IdBus", nId);
            SqlDataAdapter oAdaptador = new SqlDataAdapter(cmd);
            oAdaptador.Fill(dtDato);
            miConexion.Close();
            return dtDato;
        }
        public void AddAutobus(Autobus oAutobus)
        {
            SqlCommand cmd = new SqlCommand("AgregarAutobus", miConexion);
            cmd.CommandType = CommandType.StoredProcedure;
            miConexion.Open();
            cmd.Parameters.AddWithValue("@IdMarca", oAutobus.IdMarca);
            cmd.Parameters.AddWithValue("@IdModelo", oAutobus.IdModelo);
            cmd.Parameters.AddWithValue("@IdColor", oAutobus.IdColor);
            cmd.Parameters.AddWithValue("@IdAno", oAutobus.IdAno);
            cmd.Parameters.AddWithValue("@Placa", oAutobus.Placa);
            cmd.ExecuteNonQuery();
            miConexion.Close();
        }
        public void ActualizarAutobus(Autobus oAutobus)
        {
            SqlCommand cmd = new SqlCommand("ActualizarAutobus", miConexion);
            cmd.CommandType = CommandType.StoredProcedure;
            miConexion.Open();
            cmd.Parameters.AddWithValue("@IdAutobus", oAutobus.IdBus);
            cmd.Parameters.AddWithValue("@IdMarca", oAutobus.IdMarca);
            cmd.Parameters.AddWithValue("@IdModelo", oAutobus.IdModelo);
            cmd.Parameters.AddWithValue("@IdColor", oAutobus.IdColor);
            cmd.Parameters.AddWithValue("@IdAno", oAutobus.IdAno);
            cmd.Parameters.AddWithValue("@Placa", oAutobus.Placa);
            cmd.ExecuteNonQuery();
            miConexion.Close();
        }
        public int DeletAutobus(int nId)
        {
            miConexion.Open();
            string cQuery = "Delete from Autobuses where IdBus = " + nId;
            SqlCommand cmd = new SqlCommand(cQuery, miConexion);
            int nResultado = cmd.ExecuteNonQuery();
            miConexion.Close();
            return nResultado;

        }

        public DataTable ListarRutas(int nId)
        {
            DataTable dtDato = new DataTable();

            SqlCommand cmd = new SqlCommand("ListarRutas", miConexion);
            cmd.CommandType = CommandType.StoredProcedure;
            miConexion.Open();
            cmd.Parameters.AddWithValue("@IdRuta", nId);
            SqlDataAdapter oAdaptador = new SqlDataAdapter(cmd);
            oAdaptador.Fill(dtDato);
            miConexion.Close();
            return dtDato;
        }
        public void AddRuta(Ruta oRuta)
        {
            SqlCommand cmd = new SqlCommand("AgregarRuta", miConexion);
            cmd.CommandType = CommandType.StoredProcedure;
            miConexion.Open();
            cmd.Parameters.AddWithValue("@Nombre", oRuta.Nombre);
            cmd.Parameters.AddWithValue("@lOcupado", oRuta.LoCupado);
           
            cmd.ExecuteNonQuery();
            miConexion.Close();
        }
        public void ActualizarRuta(Ruta oRuta)
        {
            SqlCommand cmd = new SqlCommand("ActualizarRuta", miConexion);
            cmd.CommandType = CommandType.StoredProcedure;
            miConexion.Open();
            cmd.Parameters.AddWithValue("@IdRuta", oRuta.IdRuta);
            cmd.Parameters.AddWithValue("@Nombre", oRuta.Nombre);
            //cmd.Parameters.AddWithValue("@lOcupado", oRuta.LoCupado);
            cmd.ExecuteNonQuery();
            miConexion.Close();
        }
        public int DeletRuta(int nId)
        {
            miConexion.Open();
            string cQuery = "Delete from Rutas where IdRuta = " + nId;
            SqlCommand cmd = new SqlCommand(cQuery, miConexion);
            int nResultado = cmd.ExecuteNonQuery();
            miConexion.Close();
            return nResultado;

        }

        public void Asignar(Asignacion oAsignar)
        {
            SqlCommand cmd = new SqlCommand("Asignar", miConexion);
            cmd.CommandType = CommandType.StoredProcedure;
            miConexion.Open();
            cmd.Parameters.AddWithValue("@IdChofer", oAsignar.IdChofer);
            cmd.Parameters.AddWithValue("@IdRuta", oAsignar.IdRuta);
            cmd.Parameters.AddWithValue("@IdBus", oAsignar.IdBus);           
            cmd.ExecuteNonQuery();
            miConexion.Close();
        }
        public void DesAsignar(Asignacion oAsignar)
        {
            SqlCommand cmd = new SqlCommand("DesAsignar", miConexion);
            cmd.CommandType = CommandType.StoredProcedure;
            miConexion.Open();
            cmd.Parameters.AddWithValue("@IdAsignacion", oAsignar.IdAsignacion);
            cmd.Parameters.AddWithValue("@IdChofer", oAsignar.IdChofer);
            cmd.Parameters.AddWithValue("@IdRuta", oAsignar.IdRuta);
            cmd.Parameters.AddWithValue("@IdBus", oAsignar.IdBus);
            cmd.ExecuteNonQuery();
            miConexion.Close();
        }
        public DataTable ListarAsignaciones(int nId)
        {
            DataTable dtDato = new DataTable();

            SqlCommand cmd = new SqlCommand("ListarAsignaciones", miConexion);
            cmd.CommandType = CommandType.StoredProcedure;
            miConexion.Open();
            cmd.Parameters.AddWithValue("@IdAsignacion", nId);
            SqlDataAdapter oAdaptador = new SqlDataAdapter(cmd);
            oAdaptador.Fill(dtDato);
            miConexion.Close();
            return dtDato;
        }
    }
}
