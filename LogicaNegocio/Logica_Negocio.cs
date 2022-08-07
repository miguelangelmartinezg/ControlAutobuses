using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Entities;

namespace LogicaNegocio
{
    
    public class Logica_Negocio
    {
        //Chofer oChofer = new Chofer();
        //Ruta oRuta = new Ruta();
        //Autobus oAutobus = new Autobus();
        Acceso_Datos oAcceDatos = new Acceso_Datos();

        public DataTable CargarChoferes(int nId)
        {
            return oAcceDatos.ListChoferes(nId);
        }
        public void InsertarChofer(Chofer oChofer)
        {
            oAcceDatos.AddChofer(oChofer);
        }
        public void ActualizarChofer(Chofer oChofer)
        {
            oAcceDatos.EditChofer(oChofer);
        }
        public void BorrarChofer(int nId)
        {
            oAcceDatos.DeletChofer(nId);
        }

        public DataTable CargarAutobus(int nId)
        {
            return oAcceDatos.ListarAutobuses(nId);
        }
        public void InsertarAutobus(Autobus oBus)
        {
            oAcceDatos.AddAutobus(oBus);
        }
        public void ActualizarBus(Autobus oBus)
        {
            oAcceDatos.ActualizarAutobus(oBus);
        }
        public void BorrarBus(int nId)
        {
            oAcceDatos.DeletAutobus(nId);
        }


        public DataTable CargarRutas(int nId)
        {
            return oAcceDatos.ListarRutas(nId);
        }
        public void InsertarRuta(Ruta oRuta)
        {
            oAcceDatos.AddRuta(oRuta);
        }
        public void ActualizarRuta(Ruta oRuta)
        {
            oAcceDatos.ActualizarRuta(oRuta);
        }
        public void BorrarRuta(int nId)
        {
            oAcceDatos.DeletAutobus(nId);
        }
        public DataTable DatosGeneral(string tabla)
        {
            DataTable dt = oAcceDatos.DatosGeneral(tabla);
            return dt;
        }
        public DataTable DatosGeneralConsulta(string cConsulta)
        {
            DataTable dt = oAcceDatos.DatosGeneralConsulta(cConsulta);
            return dt;
        }

        public void Asignar(Asignacion oAsignacion)
        {
            oAcceDatos.Asignar(oAsignacion);
        }
        public void DesAsignar(Asignacion oAsignacion)
        {
            oAcceDatos.DesAsignar(oAsignacion);
        }
        public DataTable ListarAsignaciones(int nId)
        {
            return oAcceDatos.ListarAsignaciones(nId);
        }
    }

}
