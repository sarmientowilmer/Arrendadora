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
 public class N_Tipo_saldo_PUC
 {
     M_Tipo_saldo_PUC C_Tipo_saldo_PUC = new M_Tipo_saldo_PUC();
     ClsDatos Data = new ClsDatos();
     public bool Existe(string Tipo_saldo_PUC, bool CargarDatos)
     {
         DataTable DT = new DataTable();
         DT = Data.ConsultaT("SELECT * FROM tipo_saldo_PUC WHERE Tipo_saldo_PUC='" + Tipo_saldo_PUC + "'");
         bool ExisteRegistro = false;
         if (DT.Rows.Count > 0)
         {
             ExisteRegistro = true;
             if (CargarDatos)
             {
                 C_Tipo_saldo_PUC.Tipo_saldo_PUC= DT.Rows[0]["Tipo_saldo_PUC"].ToString();
                 C_Tipo_saldo_PUC.Descripcion_saldo= DT.Rows[0]["Descripcion_saldo"].ToString();
             }
         }
         return ExisteRegistro;
     }
     public M_Tipo_saldo_PUC Consultar(string Tipo_saldo_PUC)
     {
         if (Existe(Tipo_saldo_PUC, true))
         {
             return C_Tipo_saldo_PUC;
         }
         else
         {
             return null;
         }
     }
     public DataTable Consultar()
     {
         return Data.ConsultaT("SELECT * FROM tipo_saldo_PUC");
     }
     public long Insertar(M_Tipo_saldo_PUC Tipo_saldo_PUC)
     {
         return Data.Accion("INSERT INTO tipo_saldo_PUC (Tipo_saldo_PUC,Descripcion_saldo) VALUES (" + "'" + Tipo_saldo_PUC.Tipo_saldo_PUC+"'" + ", '" + Tipo_saldo_PUC.Descripcion_saldo + "'" + ");");
      }
     public long Actualizar(M_Tipo_saldo_PUC Tipo_saldo_PUC)
     {
         return Data.Accion("UPDATE tipo_saldo_PUC SET Tipo_saldo_PUC='" + Tipo_saldo_PUC.Tipo_saldo_PUC + "'" + ",Descripcion_saldo='"+Tipo_saldo_PUC.Descripcion_saldo + "'" + " WHERE Tipo_saldo_PUC='" + Tipo_saldo_PUC.Tipo_saldo_PUC + "'" + ";");
      }
     public long Nuevo(M_Tipo_saldo_PUC Tipo_saldo_PUC)
     {
         Dictionary<string, object> Parametros = new Dictionary<string, object>
         {
           {"Tipo_saldo_PUC", Tipo_saldo_PUC.Tipo_saldo_PUC},
           {"Descripcion_saldo", Tipo_saldo_PUC.Descripcion_saldo}
         };
         return Data.EjecutarSPEscalar("{CALL sp_Nuevo_tipo_saldo_PUC(?, ?)}", Parametros);
      }
 }
}
