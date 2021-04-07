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
 public class N_Detalle_EgServicios
 {
     M_Detalle_EgServicios C_Detalle_EgServicios = new M_Detalle_EgServicios();
     ClsDatos Data = new ClsDatos();
     public bool Existe(string Tipo_comp, int No_comp, int Item, bool CargarDatos)
     {
         DataTable DT = new DataTable();
         DT = Data.ConsultaT("SELECT * FROM Detalle_EgServicios WHERE Tipo_comp='" + Tipo_comp + "'" + " and No_comp=" + No_comp + " and Item=" + Item);
         bool ExisteRegistro = false;
         if (DT.Rows.Count > 0)
         {
             ExisteRegistro = true;
             if (CargarDatos)
             {
                 C_Detalle_EgServicios.Tipo_comp= DT.Rows[0]["Tipo_comp"].ToString();
                 C_Detalle_EgServicios.No_comp= Convert.ToInt32(DT.Rows[0]["No_comp"]);
                 C_Detalle_EgServicios.Item= Convert.ToInt32(DT.Rows[0]["Item"]);
                 C_Detalle_EgServicios.Tipo_id= DT.Rows[0]["Tipo_id"].ToString();
                 C_Detalle_EgServicios.Id= Convert.ToInt32(DT.Rows[0]["Id"]);
                 C_Detalle_EgServicios.Servicio= Convert.ToInt32(DT.Rows[0]["Servicio"]);
                 C_Detalle_EgServicios.Descripcion= DT.Rows[0]["Descripcion"].ToString();
                 C_Detalle_EgServicios.Valor= Convert.ToDouble(DT.Rows[0]["Valor"]);
                 C_Detalle_EgServicios.Recibo= Convert.ToInt32(DT.Rows[0]["Recibo"]);
                 C_Detalle_EgServicios.CanceladoE= Convert.ToBoolean(DT.Rows[0]["CanceladoE"]);
                 C_Detalle_EgServicios.Modo= Convert.ToInt32(DT.Rows[0]["Modo"]);
                 C_Detalle_EgServicios.CanceladoR= Convert.ToBoolean(DT.Rows[0]["CanceladoR"]);
                 C_Detalle_EgServicios.ItemGrav= Convert.ToInt32(DT.Rows[0]["ItemGrav"]);
                 C_Detalle_EgServicios.No_operacion= Convert.ToDouble(DT.Rows[0]["No_operacion"]);
                 C_Detalle_EgServicios.Dv= DT.Rows[0]["Dv"].ToString();
                 C_Detalle_EgServicios.Cod_inmueble= Convert.ToInt32(DT.Rows[0]["Cod_inmueble"]);
                 C_Detalle_EgServicios.Aplicadosaldo= Convert.ToBoolean(DT.Rows[0]["Aplicadosaldo"]);
             }
         }
         return ExisteRegistro;
     }
     public M_Detalle_EgServicios Consultar(string Tipo_comp, int No_comp, int Item)
     {
         if (Existe(Tipo_comp, No_comp, Item, true))
         {
             return C_Detalle_EgServicios;
         }
         else
         {
             return null;
         }
     }
     public DataTable Consultar()
     {
         return Data.ConsultaT("SELECT * FROM Detalle_EgServicios");
     }
     public long Insertar(M_Detalle_EgServicios Detalle_EgServicios)
     {
         return Data.Accion("INSERT INTO Detalle_EgServicios (Tipo_comp,No_comp,Item,Tipo_id,Id,Servicio,Descripcion,Valor,Recibo,CanceladoE,Modo,CanceladoR,ItemGrav,No_operacion,Dv,Cod_inmueble,Aplicadosaldo) VALUES (" + "'" + Detalle_EgServicios.Tipo_comp+"'" + "," + Detalle_EgServicios.No_comp + "," + Detalle_EgServicios.Item + ", '" + Detalle_EgServicios.Tipo_id + "'" + "," + Detalle_EgServicios.Id + "," + Detalle_EgServicios.Servicio + ", '" + Detalle_EgServicios.Descripcion + "'" + "," + Detalle_EgServicios.Valor + "," + Detalle_EgServicios.Recibo + "," + Detalle_EgServicios.CanceladoE + "," + Detalle_EgServicios.Modo + "," + Detalle_EgServicios.CanceladoR + "," + Detalle_EgServicios.ItemGrav + "," + Detalle_EgServicios.No_operacion + ", '" + Detalle_EgServicios.Dv + "'" + "," + Detalle_EgServicios.Cod_inmueble + "," + Detalle_EgServicios.Aplicadosaldo + ");");
      }
     public long Actualizar(M_Detalle_EgServicios Detalle_EgServicios)
     {
         return Data.Accion("UPDATE Detalle_EgServicios SET Tipo_comp='" + Detalle_EgServicios.Tipo_comp + "'" + ",No_comp=" + Detalle_EgServicios.No_comp + ",Item=" + Detalle_EgServicios.Item + ",Tipo_id='"+Detalle_EgServicios.Tipo_id + "'" + ",Id=" + Detalle_EgServicios.Id + ",Servicio=" + Detalle_EgServicios.Servicio + ",Descripcion='"+Detalle_EgServicios.Descripcion + "'" + ",Valor=" + Detalle_EgServicios.Valor + ",Recibo=" + Detalle_EgServicios.Recibo + ",CanceladoE=" + Detalle_EgServicios.CanceladoE + ",Modo=" + Detalle_EgServicios.Modo + ",CanceladoR=" + Detalle_EgServicios.CanceladoR + ",ItemGrav=" + Detalle_EgServicios.ItemGrav + ",No_operacion=" + Detalle_EgServicios.No_operacion + ",Dv='"+Detalle_EgServicios.Dv + "'" + ",Cod_inmueble=" + Detalle_EgServicios.Cod_inmueble + ",Aplicadosaldo=" + Detalle_EgServicios.Aplicadosaldo + " WHERE Tipo_comp='" + Detalle_EgServicios.Tipo_comp + "'" + " and No_comp=" + Detalle_EgServicios.No_comp + " and Item=" + Detalle_EgServicios.Item + ";");
      }
     public long Nuevo(M_Detalle_EgServicios Detalle_EgServicios)
     {
         Dictionary<string, object> Parametros = new Dictionary<string, object>
         {
           {"Tipo_comp", Detalle_EgServicios.Tipo_comp},
           {"No_comp", Detalle_EgServicios.No_comp},
           {"Item", Detalle_EgServicios.Item},
           {"Tipo_id", Detalle_EgServicios.Tipo_id},
           {"Id", Detalle_EgServicios.Id},
           {"Servicio", Detalle_EgServicios.Servicio},
           {"Descripcion", Detalle_EgServicios.Descripcion},
           {"Valor", Detalle_EgServicios.Valor},
           {"Recibo", Detalle_EgServicios.Recibo},
           {"CanceladoE", Detalle_EgServicios.CanceladoE},
           {"Modo", Detalle_EgServicios.Modo},
           {"CanceladoR", Detalle_EgServicios.CanceladoR},
           {"ItemGrav", Detalle_EgServicios.ItemGrav},
           {"No_operacion", Detalle_EgServicios.No_operacion},
           {"Dv", Detalle_EgServicios.Dv},
           {"Cod_inmueble", Detalle_EgServicios.Cod_inmueble},
           {"Aplicadosaldo", Detalle_EgServicios.Aplicadosaldo}
         };
         return Data.EjecutarSPEscalar("{CALL sp_Nuevo_Detalle_EgServicios(?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)}", Parametros);
      }
 }
}
