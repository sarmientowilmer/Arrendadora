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
    public class N_Tipos_tercero : N_General
    {
        M_Tipos_tercero C_Tipos_tercero = new M_Tipos_tercero();
        //ClsDatos Data = new ClsDatos();
        public bool Existe(int Tipo, bool CargarDatos)
        {
            DataTable DT = new DataTable();
            DT = Data.ConsultaT("SELECT * FROM tipos_tercero WHERE Tipo= " + Tipo);
            bool ExisteRegistro = false;
            if (DT.Rows.Count > 0)
            {
                ExisteRegistro = true;
                if (CargarDatos)
                {
                    C_Tipos_tercero.Tipo = Convert.ToInt32(DT.Rows[0]["Tipo"]);
                    C_Tipos_tercero.Descripcion_tipo = DT.Rows[0]["Descripcion_tipo"].ToString();
                    C_Tipos_tercero.Cod_empresa = Convert.ToInt32(DT.Rows[0]["Cod_empresa"]);
                }
            }
            return ExisteRegistro;
        }
        public M_Tipos_tercero Consultar(int Tipo)
        {
            if (Existe(Tipo, true))
            {
                return C_Tipos_tercero;
            }
            else
            {
                return null;
            }
        }
        public DataTable Consultar()
        {
            return Data.ConsultaT("SELECT * FROM tipos_tercero");
        }
        public long Insertar(M_Tipos_tercero Tipos_tercero)
        {
            return Data.Accion("INSERT INTO tipos_tercero (Tipo,Descripcion_tipo,Cod_empresa) VALUES (" + Tipos_tercero.Tipo + ", '" + Tipos_tercero.Descripcion_tipo + "'" + "," + Tipos_tercero.Cod_empresa + ");");
        }
        public long Actualizar(M_Tipos_tercero Tipos_tercero)
        {
            return Data.Accion("UPDATE tipos_tercero SET Tipo=" + Tipos_tercero.Tipo + ",Descripcion_tipo='" + Tipos_tercero.Descripcion_tipo + "'" + ",Cod_empresa=" + Tipos_tercero.Cod_empresa + " WHERE Tipo= " + Tipos_tercero.Tipo + ";");
        }
        public long Nuevo(M_Tipos_tercero Tipos_tercero)
        {
            Dictionary<string, object> Parametros = new Dictionary<string, object>
         {
           {"Tipo", Tipos_tercero.Tipo},
           {"Descripcion_tipo", Tipos_tercero.Descripcion_tipo},
           {"Cod_empresa", Tipos_tercero.Cod_empresa}
         };
            return Data.EjecutarSPEscalar("{CALL sp_Nuevo_tipos_tercero(?, ?, ?)}", Parametros);
        }
    }
}
