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
    public class N_Estados_contab
    {
        public M_Estados_contab C_Estados_contab = new M_Estados_contab();
        ClsDatos Data = new ClsDatos();
        public bool Existe(int Estado, bool CargarDatos)
        {
            DataTable DT = new DataTable();
            DT = Data.ConsultaT("SELECT * FROM Estados_contab WHERE Estado= " + Estado);
            bool ExisteRegistro = false;
            if (DT.Rows.Count > 0)
            {
                ExisteRegistro = true;
                if (CargarDatos)
                {
                    C_Estados_contab.Estado = Convert.ToInt32(DT.Rows[0]["Estado"]);
                    C_Estados_contab.Descripcion_estado = DT.Rows[0]["Descripcion_estado"].ToString();
                    C_Estados_contab.Cod_empresa = Convert.ToInt32(DT.Rows[0]["Cod_empresa"]);
                }
            }
            return ExisteRegistro;
        }
        public M_Estados_contab Consultar(int Estado)
        {
            if (Existe(Estado, true))
            {
                return C_Estados_contab;
            }
            else
            {
                return null;
            }
        }
        public DataTable Consultar()
        {
            return Data.ConsultaT("SELECT * FROM Estados_contab");
        }
        public long Insertar(M_Estados_contab Estados_contab)
        {
            return Data.Accion("INSERT INTO Estados_contab (Estado,Descripcion_estado,Cod_empresa) VALUES (" + Estados_contab.Estado + ", '" + Estados_contab.Descripcion_estado + "'" + "," + Estados_contab.Cod_empresa + ");");
        }
        public long Actualizar(M_Estados_contab Estados_contab)
        {
            return Data.Accion("UPDATE Estados_contab SET Estado=" + Estados_contab.Estado + ",Descripcion_estado='" + Estados_contab.Descripcion_estado + "'" + ",Cod_empresa=" + Estados_contab.Cod_empresa + " WHERE Estado= " + Estados_contab.Estado + ";");
        }
        public long Nuevo(M_Estados_contab Estados_contab)
        {
            Dictionary<string, object> Parametros = new Dictionary<string, object>
         {
           {"Estado", Estados_contab.Estado},
           {"Descripcion_estado", Estados_contab.Descripcion_estado},
           {"Cod_empresa", Estados_contab.Cod_empresa}
         };
            return Data.EjecutarSPEscalar("{CALL sp_Nuevo_Estados_contab(?, ?, ?)}", Parametros);
        }
    }
}
