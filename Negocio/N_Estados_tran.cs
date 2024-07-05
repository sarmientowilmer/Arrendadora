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
 public class N_Estados_tran
 {
     M_Estados_tran C_Estados_tran = new M_Estados_tran();
     ClsDatos Data = new ClsDatos();
     public bool Existe(string Cod_estado, bool CargarDatos)
     {
         DataTable DT = new DataTable();
         DT = Data.ConsultaT("SELECT * FROM Estados_tran WHERE Cod_estado='" + Cod_estado + "'");
         bool ExisteRegistro = false;
         if (DT.Rows.Count > 0)
         {
             ExisteRegistro = true;
             if (CargarDatos)
             {
                 C_Estados_tran.Cod_estado= DT.Rows[0]["Cod_estado"].ToString();
                 C_Estados_tran.Descripcion_estado= DT.Rows[0]["Descripcion_estado"].ToString();
                 C_Estados_tran.Cod_empresa= Convert.ToInt32(DT.Rows[0]["Cod_empresa"]);
             }
         }
         return ExisteRegistro;
     }
     public M_Estados_tran Consultar(string Cod_estado)
     {
         if (Existe(Cod_estado, true))
         {
             return C_Estados_tran;
         }
         else
         {
             return null;
         }
     }
     public DataTable Consultar()
     {
         return Data.ConsultaT("SELECT * FROM Estados_tran");
     }
     public long Insertar(M_Estados_tran Estados_tran)
     {
         return Data.Accion("INSERT INTO Estados_tran (Cod_estado,Descripcion_estado,Cod_empresa) VALUES (" + "'" + Estados_tran.Cod_estado+"'" + ", '" + Estados_tran.Descripcion_estado + "'" + "," + Estados_tran.Cod_empresa + ");");
      }
     public long Actualizar(M_Estados_tran Estados_tran)
     {
         return Data.Accion("UPDATE Estados_tran SET Cod_estado='" + Estados_tran.Cod_estado + "'" + ",Descripcion_estado='"+Estados_tran.Descripcion_estado + "'" + ",Cod_empresa=" + Estados_tran.Cod_empresa + " WHERE Cod_estado='" + Estados_tran.Cod_estado + "'" + ";");
      }
     public long Nuevo(M_Estados_tran Estados_tran)
     {
         Dictionary<string, object> Parametros = new Dictionary<string, object>
         {
           {"Cod_estado", Estados_tran.Cod_estado},
           {"Descripcion_estado", Estados_tran.Descripcion_estado},
           {"Cod_empresa", Estados_tran.Cod_empresa}
         };
         return Data.EjecutarSPEscalar("{CALL sp_Nuevo_Estados_tran(?, ?, ?)}", Parametros);
      }
 }
}
