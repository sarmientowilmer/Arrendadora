using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using AccesoDatos;
using Modelo;

namespace Logica
{
    public class N_Estados_inmueble : N_General
    {
        M_Estados_inmueble C_Estados_inmueble = new M_Estados_inmueble();
        //ClsDatos Data = new ClsDatos();
        public bool Existe(string Estado_inmueble, bool CargarDatos)
        {
            DataTable DT = new DataTable();
            DT = Data.ConsultaT("SELECT * FROM estados_inmueble WHERE Estado= " + Estado_inmueble);
            bool ExisteRegistro = false;
            if (DT.Rows.Count > 0)
            {
                ExisteRegistro = true;
                if (CargarDatos)
                {
                    C_Estados_inmueble.Estado_inmueble = DT.Rows[0]["Estado_inmueble"].ToString();
                    C_Estados_inmueble.Nombre_estado_inmueble = DT.Rows[0]["Nombre_estado_inmueble"].ToString();
                }
            }
            return ExisteRegistro;
        }
        public M_Estados_inmueble Consultar(string Estado_inmueble)
        {
            if (Existe(Estado_inmueble, true))
            {
                return C_Estados_inmueble;
            }
            else
            {
                return null;
            }
        }
        public DataTable Consultar()
        {
            return Data.ConsultaT("SELECT * FROM estados_inmueble");
        }
        public long Insertar(M_Estados_inmueble Estados_inmueble)
        {
            return Data.Accion("INSERT INTO estados_inmueble (Estado_inmueble,Nombre_estado_inmueble) VALUES (" + "'" + Estados_inmueble.Estado_inmueble + "'" + ", '" + Estados_inmueble.Nombre_estado_inmueble + "'" + ");");
        }
        public long Actualizar(M_Estados_inmueble Estados_inmueble)
        {
            return Data.Accion("UPDATE estados_inmueble SET Estado_inmueble='" + Estados_inmueble.Estado_inmueble + "'" + ",Nombre_estado_inmueble='" + Estados_inmueble.Nombre_estado_inmueble + "'" + " WHERE Estado_inmueble= " + Estados_inmueble.Estado_inmueble + ";");
        }
        public long Nuevo(M_Estados_inmueble Estados_inmueble)
        {
            Dictionary<string, object> Parametros = new Dictionary<string, object>
         {
           {"Estado_inmueble", Estados_inmueble.Estado_inmueble},
           {"Nombre_estado_inmueble", Estados_inmueble.Nombre_estado_inmueble}
         };
            return Data.EjecutarSPEscalar("{CALL sp_Nuevo_estados_inmueble(?, ?)}", Parametros);
        }
    }
}
