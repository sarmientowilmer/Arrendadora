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
 public class N_Detalle_IngServicios
 {
     M_Detalle_IngServicios C_Detalle_IngServicios = new M_Detalle_IngServicios();
     ClsDatos Data = new ClsDatos();
     public bool Existe(string Tipo_comp, int No_comp, int Rec_ing, int Item, bool CargarDatos)
     {
         DataTable DT = new DataTable();
         DT = Data.ConsultaT("SELECT * FROM Detalle_IngServicios WHERE Tipo_comp='" + Tipo_comp + "'" + " and No_comp=" + No_comp + " and Rec_ing=" + Rec_ing + " and Item=" + Item);
         bool ExisteRegistro = false;
         if (DT.Rows.Count > 0)
         {
             ExisteRegistro = true;
             if (CargarDatos)
             {
                 C_Detalle_IngServicios.Tipo_comp= DT.Rows[0]["Tipo_comp"].ToString();
                 C_Detalle_IngServicios.No_comp= Convert.ToInt32(DT.Rows[0]["No_comp"]);
                 C_Detalle_IngServicios.Rec_ing= Convert.ToInt32(DT.Rows[0]["Rec_ing"]);
                 C_Detalle_IngServicios.Item= Convert.ToInt32(DT.Rows[0]["Item"]);
                 C_Detalle_IngServicios.Tipo_id= DT.Rows[0]["Tipo_id"].ToString();
                 C_Detalle_IngServicios.Id= Convert.ToInt32(DT.Rows[0]["Id"]);
                 C_Detalle_IngServicios.Servicio= Convert.ToInt32(DT.Rows[0]["Servicio"]);
                 C_Detalle_IngServicios.Recibo= Convert.ToInt32(DT.Rows[0]["Recibo"]);
                 C_Detalle_IngServicios.Descripcion= DT.Rows[0]["Descripcion"].ToString();
                 C_Detalle_IngServicios.Valor= Convert.ToDouble(DT.Rows[0]["Valor"]);
                 C_Detalle_IngServicios.No_operacion= Convert.ToDouble(DT.Rows[0]["No_operacion"]);
                 C_Detalle_IngServicios.Dv= DT.Rows[0]["Dv"].ToString();
                 C_Detalle_IngServicios.Aplicadosaldo= Convert.ToBoolean(DT.Rows[0]["Aplicadosaldo"]);
             }
         }
         return ExisteRegistro;
     }
     public M_Detalle_IngServicios Consultar(string Tipo_comp, int No_comp, int Rec_ing, int Item)
     {
         if (Existe(Tipo_comp, No_comp, Rec_ing, Item, true))
         {
             return C_Detalle_IngServicios;
         }
         else
         {
             return null;
         }
     }
     public DataTable Consultar()
     {
         return Data.ConsultaT("SELECT * FROM Detalle_IngServicios");
     }
     public long Insertar(M_Detalle_IngServicios Detalle_IngServicios)
     {
         return Data.Accion("INSERT INTO Detalle_IngServicios (Tipo_comp,No_comp,Rec_ing,Item,Tipo_id,Id,Servicio,Recibo,Descripcion,Valor,No_operacion,Dv,Aplicadosaldo) VALUES (" + "'" + Detalle_IngServicios.Tipo_comp+"'" + "," + Detalle_IngServicios.No_comp + "," + Detalle_IngServicios.Rec_ing + "," + Detalle_IngServicios.Item + ", '" + Detalle_IngServicios.Tipo_id + "'" + "," + Detalle_IngServicios.Id + "," + Detalle_IngServicios.Servicio + "," + Detalle_IngServicios.Recibo + ", '" + Detalle_IngServicios.Descripcion + "'" + "," + Detalle_IngServicios.Valor + "," + Detalle_IngServicios.No_operacion + ", '" + Detalle_IngServicios.Dv + "'" + "," + Detalle_IngServicios.Aplicadosaldo + ");");
      }
     public long Actualizar(M_Detalle_IngServicios Detalle_IngServicios)
     {
         return Data.Accion("UPDATE Detalle_IngServicios SET Tipo_comp='" + Detalle_IngServicios.Tipo_comp + "'" + ",No_comp=" + Detalle_IngServicios.No_comp + ",Rec_ing=" + Detalle_IngServicios.Rec_ing + ",Item=" + Detalle_IngServicios.Item + ",Tipo_id='"+Detalle_IngServicios.Tipo_id + "'" + ",Id=" + Detalle_IngServicios.Id + ",Servicio=" + Detalle_IngServicios.Servicio + ",Recibo=" + Detalle_IngServicios.Recibo + ",Descripcion='"+Detalle_IngServicios.Descripcion + "'" + ",Valor=" + Detalle_IngServicios.Valor + ",No_operacion=" + Detalle_IngServicios.No_operacion + ",Dv='"+Detalle_IngServicios.Dv + "'" + ",Aplicadosaldo=" + Detalle_IngServicios.Aplicadosaldo + " WHERE Tipo_comp='" + Detalle_IngServicios.Tipo_comp + "'" + " and No_comp=" + Detalle_IngServicios.No_comp + " and Rec_ing=" + Detalle_IngServicios.Rec_ing + " and Item=" + Detalle_IngServicios.Item + ";");
      }
     public long Nuevo(M_Detalle_IngServicios Detalle_IngServicios)
     {
         Dictionary<string, object> Parametros = new Dictionary<string, object>
         {
           {"Tipo_comp", Detalle_IngServicios.Tipo_comp},
           {"No_comp", Detalle_IngServicios.No_comp},
           {"Rec_ing", Detalle_IngServicios.Rec_ing},
           {"Item", Detalle_IngServicios.Item},
           {"Tipo_id", Detalle_IngServicios.Tipo_id},
           {"Id", Detalle_IngServicios.Id},
           {"Servicio", Detalle_IngServicios.Servicio},
           {"Recibo", Detalle_IngServicios.Recibo},
           {"Descripcion", Detalle_IngServicios.Descripcion},
           {"Valor", Detalle_IngServicios.Valor},
           {"No_operacion", Detalle_IngServicios.No_operacion},
           {"Dv", Detalle_IngServicios.Dv},
           {"Aplicadosaldo", Detalle_IngServicios.Aplicadosaldo}
         };
         return Data.EjecutarSPEscalar("{CALL sp_Nuevo_Detalle_IngServicios(?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)}", Parametros);
      }
 }
}
