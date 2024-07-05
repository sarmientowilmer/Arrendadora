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
 public class N_Codeudores
 {
     M_Codeudores C_Codeudores = new M_Codeudores();
     ClsDatos Data = new ClsDatos();
     public bool Existe(int No_contrato, string Tipo_id, int Id_codeudor, bool CargarDatos)
     {
         DataTable DT = new DataTable();
         DT = Data.ConsultaT("SELECT * FROM Codeudores WHERE No_contrato= " + No_contrato + " and Tipo_id='" + Tipo_id + "'" + " and Id_codeudor=" + Id_codeudor);
         bool ExisteRegistro = false;
         if (DT.Rows.Count > 0)
         {
             ExisteRegistro = true;
             if (CargarDatos)
             {
                 C_Codeudores.No_contrato= Convert.ToInt32(DT.Rows[0]["No_contrato"]);
                 C_Codeudores.Tipo_id= DT.Rows[0]["Tipo_id"].ToString();
                 C_Codeudores.Id_codeudor= Convert.ToInt32(DT.Rows[0]["Id_codeudor"]);
             }
         }
         return ExisteRegistro;
     }
     public M_Codeudores Consultar(int No_contrato, string Tipo_id, int Id_codeudor)
     {
         if (Existe(No_contrato, Tipo_id, Id_codeudor, true))
         {
             return C_Codeudores;
         }
         else
         {
             return null;
         }
     }
     public DataTable Consultar()
     {
         return Data.ConsultaT("SELECT * FROM Codeudores");
     }
     public long Insertar(M_Codeudores Codeudores)
     {
         return Data.Accion("INSERT INTO Codeudores (No_contrato,Tipo_id,Id_codeudor) VALUES (" + Codeudores.No_contrato + ", '" + Codeudores.Tipo_id + "'" + "," + Codeudores.Id_codeudor + ");");
      }
     public long Actualizar(M_Codeudores Codeudores)
     {
         return Data.Accion("UPDATE Codeudores SET No_contrato=" + Codeudores.No_contrato + ",Tipo_id='"+Codeudores.Tipo_id + "'" + ",Id_codeudor=" + Codeudores.Id_codeudor + " WHERE No_contrato= " + Codeudores.No_contrato + " and Tipo_id='" + Codeudores.Tipo_id + "'" + " and Id_codeudor=" + Codeudores.Id_codeudor + ";");
      }
     public long Nuevo(M_Codeudores Codeudores)
     {
         Dictionary<string, object> Parametros = new Dictionary<string, object>
         {
           {"No_contrato", Codeudores.No_contrato},
           {"Tipo_id", Codeudores.Tipo_id},
           {"Id_codeudor", Codeudores.Id_codeudor}
         };
         return Data.EjecutarSPEscalar("{CALL sp_Nuevo_Codeudores(?, ?, ?)}", Parametros);
      }
 }
}
