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
    public class N_Estados_comp : N_General
    {
        M_Estados_comp C_Estados_comp = new M_Estados_comp();
        //ClsDatos Data = new ClsDatos();
        public bool Existe(string Estado, bool CargarDatos)
        {
            DataTable DT = new DataTable();
            DT = Data.ConsultaT("SELECT * FROM Estados_comp WHERE Estado='" + Estado + "'");
            bool ExisteRegistro = false;
            if (DT.Rows.Count > 0)
            {
                ExisteRegistro = true;
                if (CargarDatos)
                {
                    C_Estados_comp.Estado = DT.Rows[0]["Estado"].ToString();
                    C_Estados_comp.Descripcion_estado = DT.Rows[0]["Descripcion_estado"].ToString();
                    C_Estados_comp.Cod_empresa = Convert.ToInt32(DT.Rows[0]["Cod_empresa"]);
                }
            }
            return ExisteRegistro;
        }
        public M_Estados_comp Consultar(string Estado)
        {
            if (Existe(Estado, true))
            {
                return C_Estados_comp;
            }
            else
            {
                return null;
            }
        }
        public DataTable Consultar()
        {
            return Data.ConsultaT("SELECT * FROM Estados_comp");
        }
        public long Insertar(M_Estados_comp Estados_comp)
        {
            return Data.Accion("INSERT INTO Estados_comp (Estado,Descripcion_estado,Cod_empresa) VALUES (" + "'" + Estados_comp.Estado + "'" + ", '" + Estados_comp.Descripcion_estado + "'" + "," + Estados_comp.Cod_empresa + ");");
        }
        public long Actualizar(M_Estados_comp Estados_comp)
        {
            return Data.Accion("UPDATE Estados_comp SET Estado='" + Estados_comp.Estado + "'" + ",Descripcion_estado='" + Estados_comp.Descripcion_estado + "'" + ",Cod_empresa=" + Estados_comp.Cod_empresa + " WHERE Estado='" + Estados_comp.Estado + "'" + ";");
        }
        public long Nuevo(M_Estados_comp Estados_comp)
        {
            Dictionary<string, object> Parametros = new Dictionary<string, object>
         {
           {"Estado", Estados_comp.Estado},
           {"Descripcion_estado", Estados_comp.Descripcion_estado},
           {"Cod_empresa", Estados_comp.Cod_empresa}
         };
            return Data.EjecutarSPEscalar("{CALL sp_Nuevo_Estados_comp(?, ?, ?)}", Parametros);
        }
    }
}
