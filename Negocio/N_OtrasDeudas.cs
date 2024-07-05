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
 public class N_OtrasDeudas
 {
     M_OtrasDeudas C_OtrasDeudas = new M_OtrasDeudas();
     ClsDatos Data = new ClsDatos();
     public bool Existe(int Item, string Tipo_id, int Id, bool CargarDatos)
     {
         DataTable DT = new DataTable();
         DT = Data.ConsultaT("SELECT * FROM OtrasDeudas WHERE Item= " + Item + " and Tipo_id='" + Tipo_id + "'" + " and Id=" + Id);
         bool ExisteRegistro = false;
         if (DT.Rows.Count > 0)
         {
             ExisteRegistro = true;
             if (CargarDatos)
             {
                 C_OtrasDeudas.Item= Convert.ToInt32(DT.Rows[0]["Item"]);
                 C_OtrasDeudas.Tipo_id= DT.Rows[0]["Tipo_id"].ToString();
                 C_OtrasDeudas.Id= Convert.ToInt32(DT.Rows[0]["Id"]);
                 C_OtrasDeudas.Dv= DT.Rows[0]["Dv"].ToString();
                 C_OtrasDeudas.Fecha= Convert.ToDateTime(DT.Rows[0]["Fecha"]);
                 C_OtrasDeudas.Inmueble= Convert.ToInt32(DT.Rows[0]["Inmueble"]);
                 C_OtrasDeudas.Descripcion= DT.Rows[0]["Descripcion"].ToString();
                 C_OtrasDeudas.Valor= Convert.ToDouble(DT.Rows[0]["Valor"]);
                 C_OtrasDeudas.Tipo_compRe= DT.Rows[0]["Tipo_compRe"].ToString();
                 C_OtrasDeudas.No_compRe= Convert.ToInt32(DT.Rows[0]["No_compRe"]);
                 C_OtrasDeudas.Tipo_compPa= DT.Rows[0]["Tipo_compPa"].ToString();
                 C_OtrasDeudas.No_compPa= Convert.ToInt32(DT.Rows[0]["No_compPa"]);
             }
         }
         return ExisteRegistro;
     }
     public M_OtrasDeudas Consultar(int Item, string Tipo_id, int Id)
     {
         if (Existe(Item, Tipo_id, Id, true))
         {
             return C_OtrasDeudas;
         }
         else
         {
             return null;
         }
     }
     public DataTable Consultar()
     {
         return Data.ConsultaT("SELECT * FROM OtrasDeudas");
     }
     public long Insertar(M_OtrasDeudas OtrasDeudas)
     {
         return Data.Accion("INSERT INTO OtrasDeudas (Item,Tipo_id,Id,Dv,Fecha,Inmueble,Descripcion,Valor,Tipo_compRe,No_compRe,Tipo_compPa,No_compPa) VALUES (" + OtrasDeudas.Item + ", '" + OtrasDeudas.Tipo_id + "'" + "," + OtrasDeudas.Id + ", '" + OtrasDeudas.Dv + "'" + "," + OtrasDeudas.Fecha + "," + OtrasDeudas.Inmueble + ", '" + OtrasDeudas.Descripcion + "'" + "," + OtrasDeudas.Valor + ", '" + OtrasDeudas.Tipo_compRe + "'" + "," + OtrasDeudas.No_compRe + ", '" + OtrasDeudas.Tipo_compPa + "'" + "," + OtrasDeudas.No_compPa + ");");
      }
     public long Actualizar(M_OtrasDeudas OtrasDeudas)
     {
         return Data.Accion("UPDATE OtrasDeudas SET Item=" + OtrasDeudas.Item + ",Tipo_id='"+OtrasDeudas.Tipo_id + "'" + ",Id=" + OtrasDeudas.Id + ",Dv='"+OtrasDeudas.Dv + "'" + ",Fecha=" + OtrasDeudas.Fecha + ",Inmueble=" + OtrasDeudas.Inmueble + ",Descripcion='"+OtrasDeudas.Descripcion + "'" + ",Valor=" + OtrasDeudas.Valor + ",Tipo_compRe='"+OtrasDeudas.Tipo_compRe + "'" + ",No_compRe=" + OtrasDeudas.No_compRe + ",Tipo_compPa='"+OtrasDeudas.Tipo_compPa + "'" + ",No_compPa=" + OtrasDeudas.No_compPa + " WHERE Item= " + OtrasDeudas.Item + " and Tipo_id='" + OtrasDeudas.Tipo_id + "'" + " and Id=" + OtrasDeudas.Id + ";");
      }
     public long Nuevo(M_OtrasDeudas OtrasDeudas)
     {
         Dictionary<string, object> Parametros = new Dictionary<string, object>
         {
           {"Item", OtrasDeudas.Item},
           {"Tipo_id", OtrasDeudas.Tipo_id},
           {"Id", OtrasDeudas.Id},
           {"Dv", OtrasDeudas.Dv},
           {"Fecha", OtrasDeudas.Fecha},
           {"Inmueble", OtrasDeudas.Inmueble},
           {"Descripcion", OtrasDeudas.Descripcion},
           {"Valor", OtrasDeudas.Valor},
           {"Tipo_compRe", OtrasDeudas.Tipo_compRe},
           {"No_compRe", OtrasDeudas.No_compRe},
           {"Tipo_compPa", OtrasDeudas.Tipo_compPa},
           {"No_compPa", OtrasDeudas.No_compPa}
         };
         return Data.EjecutarSPEscalar("{CALL sp_Nuevo_OtrasDeudas(?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)}", Parametros);
      }
 }
}
