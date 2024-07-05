using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using AccesoDatos;
using Modelo;

namespace Negocio
{
    public class N_Destinos_inmueble:N_General
    {
        M_Destinos_inmueble C_Destinos_inmueble = new M_Destinos_inmueble();
        //ClsDatos Data = new ClsDatos();
        public bool Existe(byte Codigo_destino, bool CargarDatos)
        {
            DataTable DT = new DataTable();
            DT = Data.ConsultaT("SELECT * FROM destinos_inmueble WHERE Codigo_destino= " + Codigo_destino);
            bool ExisteRegistro = false;
            if (DT.Rows.Count > 0)
            {
                ExisteRegistro = true;
                if (CargarDatos)
                {
                    C_Destinos_inmueble.Codigo_destino = Convert.ToByte(DT.Rows[0]["Codigo_destino"]);
                    C_Destinos_inmueble.Nombre_destino = DT.Rows[0]["Nombre_destino"].ToString();
                }
            }
            return ExisteRegistro;
        }
        public M_Destinos_inmueble Consultar(byte Codigo_destino)
        {
            if (Existe(Codigo_destino, true))
            {
                return C_Destinos_inmueble;
            }
            else
            {
                return null;
            }
        }
        public DataTable Consultar()
        {
            return Data.ConsultaT("SELECT * FROM destinos_inmueble");
        }
        public long Insertar(M_Destinos_inmueble Destinos_inmueble)
        {
            return Data.Accion("INSERT INTO destinos_inmueble (Codigo_destino,Nombre_destino) VALUES (" + Destinos_inmueble.Codigo_destino + ", '" + Destinos_inmueble.Nombre_destino + "'" + ");");
        }
        public long Actualizar(M_Destinos_inmueble Destinos_inmueble)
        {
            return Data.Accion("UPDATE destinos_inmueble SET Codigo_destino=" + Destinos_inmueble.Codigo_destino + ",Nombre_destino='" + Destinos_inmueble.Nombre_destino + "'" + " WHERE Codigo_destino= " + Destinos_inmueble.Codigo_destino + ";");
        }
        public long Nuevo(M_Destinos_inmueble Destinos_inmueble)
        {
            Dictionary<string, object> Parametros = new Dictionary<string, object>
         {
           {"Codigo_destino", Destinos_inmueble.Codigo_destino},
           {"Nombre_destino", Destinos_inmueble.Nombre_destino}
         };
            return Data.EjecutarSPEscalar("{CALL sp_Nuevo_destinos_inmueble(?, ?)}", Parametros);
        }
    }
}
