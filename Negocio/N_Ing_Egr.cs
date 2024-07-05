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
 public class N_Ing_Egr
 {
     M_Ing_Egr C_Ing_Egr = new M_Ing_Egr();
     ClsDatos Data = new ClsDatos();
     public bool Existe(string Tipo_comp, int No_comp, int Item, bool CargarDatos)
     {
         DataTable DT = new DataTable();
         DT = Data.ConsultaT("SELECT * FROM Ing_Egr WHERE Tipo_comp='" + Tipo_comp + "'" + " and No_comp=" + No_comp + " and Item=" + Item);
         bool ExisteRegistro = false;
         if (DT.Rows.Count > 0)
         {
             ExisteRegistro = true;
             if (CargarDatos)
             {
                 C_Ing_Egr.Tipo_comp= DT.Rows[0]["Tipo_comp"].ToString();
                 C_Ing_Egr.No_comp= Convert.ToInt32(DT.Rows[0]["No_comp"]);
                 C_Ing_Egr.Item= Convert.ToInt32(DT.Rows[0]["Item"]);
                 C_Ing_Egr.Descripcion= DT.Rows[0]["Descripcion"].ToString();
                 C_Ing_Egr.Valor= Convert.ToDouble(DT.Rows[0]["Valor"]);
                 C_Ing_Egr.Itipo= Convert.ToInt32(DT.Rows[0]["Itipo"]);
                 C_Ing_Egr.Cod_concepto= Convert.ToInt32(DT.Rows[0]["Cod_concepto"]);
                 C_Ing_Egr.Cod_empresa= Convert.ToInt32(DT.Rows[0]["Cod_empresa"]);
                 C_Ing_Egr.No_operacion= Convert.ToDouble(DT.Rows[0]["No_operacion"]);
                 C_Ing_Egr.Tipo_id= DT.Rows[0]["Tipo_id"].ToString();
                 C_Ing_Egr.Id= Convert.ToInt32(DT.Rows[0]["Id"]);
                 C_Ing_Egr.Dv= DT.Rows[0]["Dv"].ToString();
             }
         }
         return ExisteRegistro;
     }
     public M_Ing_Egr Consultar(string Tipo_comp, int No_comp, int Item)
     {
         if (Existe(Tipo_comp, No_comp, Item, true))
         {
             return C_Ing_Egr;
         }
         else
         {
             return null;
         }
     }
     public DataTable Consultar()
     {
         return Data.ConsultaT("SELECT * FROM Ing_Egr");
     }
     public long Insertar(M_Ing_Egr Ing_Egr)
     {
         return Data.Accion("INSERT INTO Ing_Egr (Tipo_comp,No_comp,Item,Descripcion,Valor,Itipo,Cod_concepto,Cod_empresa,No_operacion,Tipo_id,Id,Dv) VALUES (" + "'" + Ing_Egr.Tipo_comp+"'" + "," + Ing_Egr.No_comp + "," + Ing_Egr.Item + ", '" + Ing_Egr.Descripcion + "'" + "," + Ing_Egr.Valor + "," + Ing_Egr.Itipo + "," + Ing_Egr.Cod_concepto + "," + Ing_Egr.Cod_empresa + "," + Ing_Egr.No_operacion + ", '" + Ing_Egr.Tipo_id + "'" + "," + Ing_Egr.Id + ", '" + Ing_Egr.Dv + "'" + ");");
      }
     public long Actualizar(M_Ing_Egr Ing_Egr)
     {
         return Data.Accion("UPDATE Ing_Egr SET Tipo_comp='" + Ing_Egr.Tipo_comp + "'" + ",No_comp=" + Ing_Egr.No_comp + ",Item=" + Ing_Egr.Item + ",Descripcion='"+Ing_Egr.Descripcion + "'" + ",Valor=" + Ing_Egr.Valor + ",Itipo=" + Ing_Egr.Itipo + ",Cod_concepto=" + Ing_Egr.Cod_concepto + ",Cod_empresa=" + Ing_Egr.Cod_empresa + ",No_operacion=" + Ing_Egr.No_operacion + ",Tipo_id='"+Ing_Egr.Tipo_id + "'" + ",Id=" + Ing_Egr.Id + ",Dv='"+Ing_Egr.Dv + "'" + " WHERE Tipo_comp='" + Ing_Egr.Tipo_comp + "'" + " and No_comp=" + Ing_Egr.No_comp + " and Item=" + Ing_Egr.Item + ";");
      }
     public long Nuevo(M_Ing_Egr Ing_Egr)
     {
         Dictionary<string, object> Parametros = new Dictionary<string, object>
         {
           {"Tipo_comp", Ing_Egr.Tipo_comp},
           {"No_comp", Ing_Egr.No_comp},
           {"Item", Ing_Egr.Item},
           {"Descripcion", Ing_Egr.Descripcion},
           {"Valor", Ing_Egr.Valor},
           {"Itipo", Ing_Egr.Itipo},
           {"Cod_concepto", Ing_Egr.Cod_concepto},
           {"Cod_empresa", Ing_Egr.Cod_empresa},
           {"No_operacion", Ing_Egr.No_operacion},
           {"Tipo_id", Ing_Egr.Tipo_id},
           {"Id", Ing_Egr.Id},
           {"Dv", Ing_Egr.Dv}
         };
         return Data.EjecutarSPEscalar("{CALL sp_Nuevo_Ing_Egr(?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)}", Parametros);
      }
 }
}
