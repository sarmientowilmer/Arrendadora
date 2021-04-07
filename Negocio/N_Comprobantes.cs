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
 public class N_Comprobantes:N_General
 {
     public M_Comprobantes C_Comprobantes = new M_Comprobantes();
     //ClsDatos Data = new ClsDatos();
     public bool Existe(string Tipo_comp, int No_comp, bool CargarDatos)
     {
         DataTable DT = new DataTable();
         DT = Data.ConsultaT("SELECT * FROM Comprobantes WHERE Tipo_comp='" + Tipo_comp + "'" + " and No_comp=" + No_comp);
         bool ExisteRegistro = false;
         if (DT.Rows.Count > 0)
         {
             ExisteRegistro = true;
             if (CargarDatos)
             {
                 C_Comprobantes.Fecha= Convert.ToDateTime(DT.Rows[0]["Fecha"]);
                 C_Comprobantes.Tipo_comp= DT.Rows[0]["Tipo_comp"].ToString();
                 C_Comprobantes.No_comp= Convert.ToInt32(DT.Rows[0]["No_comp"]);
                 C_Comprobantes.Tipo_id= DT.Rows[0]["Tipo_id"].ToString();
                 C_Comprobantes.Id= Convert.ToInt32(DT.Rows[0]["Id"]);
                 C_Comprobantes.Dv= DT.Rows[0]["Dv"].ToString();
                 C_Comprobantes.Descripcion= DT.Rows[0]["Descripcion"].ToString();
                 C_Comprobantes.Valor= Convert.ToDouble(DT.Rows[0]["Valor"]);
                 C_Comprobantes.Forma_pago= Convert.ToInt32(DT.Rows[0]["Forma_pago"]);
                 C_Comprobantes.Cod_cuenta= Convert.ToInt32(DT.Rows[0]["Cod_cuenta"]);
                 C_Comprobantes.Clase_cuenta= DT.Rows[0]["Clase_cuenta"].ToString();
                 C_Comprobantes.Num= DT.Rows[0]["Num"].ToString();
                 C_Comprobantes.Entidad= DT.Rows[0]["Entidad"].ToString();
                 C_Comprobantes.Estado= DT.Rows[0]["Estado"].ToString();
                 C_Comprobantes.FechaAplic= Convert.ToDateTime(DT.Rows[0]["FechaAplic"]);
                 C_Comprobantes.Usu_cap= Convert.ToInt32(DT.Rows[0]["Usu_cap"]);
                 C_Comprobantes.Fecha_vence= Convert.ToDateTime(DT.Rows[0]["Fecha_vence"]);
                 C_Comprobantes.Cod_empresa= Convert.ToInt32(DT.Rows[0]["Cod_empresa"]);
                 C_Comprobantes.No_operacion= Convert.ToDouble(DT.Rows[0]["No_operacion"]);
                 C_Comprobantes.Cod_concepto= Convert.ToInt32(DT.Rows[0]["Cod_concepto"]);
                 C_Comprobantes.Valor_base= Convert.ToDouble(DT.Rows[0]["Valor_base"]);
                 C_Comprobantes.Usu_aprueba= Convert.ToInt32(DT.Rows[0]["Usu_aprueba"]);
                 C_Comprobantes.Estado_contab= Convert.ToInt32(DT.Rows[0]["Estado_contab"]);
                 C_Comprobantes.Centro_costo= Convert.ToInt32(DT.Rows[0]["Centro_costo"]);
                 C_Comprobantes.Seccion= Convert.ToInt32(DT.Rows[0]["Seccion"]);
             }
         }
         return ExisteRegistro;
     }
     public M_Comprobantes Consultar(string Tipo_comp, int No_comp)
     {
         if (Existe(Tipo_comp, No_comp, true))
         {
             return C_Comprobantes;
         }
         else
         {
             return null;
         }
     }
     public DataTable Consultar()
     {
         return Data.ConsultaT("SELECT * FROM Comprobantes");
     }
     public long Insertar(M_Comprobantes Comprobantes)
     {
         return Data.Accion("INSERT INTO Comprobantes (Fecha,Tipo_comp,No_comp,Tipo_id,Id,Dv,Descripcion,Valor,Forma_pago,Cod_cuenta,Clase_cuenta,Num,Entidad,Estado,FechaAplic,Usu_cap,Fecha_vence,Cod_empresa,No_operacion,Cod_concepto,Valor_base,Usu_aprueba,Estado_contab,Centro_costo,Seccion) VALUES (" + Comprobantes.Fecha + ", '" + Comprobantes.Tipo_comp + "'" + "," + Comprobantes.No_comp + ", '" + Comprobantes.Tipo_id + "'" + "," + Comprobantes.Id + ", '" + Comprobantes.Dv + "'" + ", '" + Comprobantes.Descripcion + "'" + "," + Comprobantes.Valor + "," + Comprobantes.Forma_pago + "," + Comprobantes.Cod_cuenta + ", '" + Comprobantes.Clase_cuenta + "'" + ", '" + Comprobantes.Num + "'" + ", '" + Comprobantes.Entidad + "'" + ", '" + Comprobantes.Estado + "'" + "," + Comprobantes.FechaAplic + "," + Comprobantes.Usu_cap + "," + Comprobantes.Fecha_vence + "," + Comprobantes.Cod_empresa + "," + Comprobantes.No_operacion + "," + Comprobantes.Cod_concepto + "," + Comprobantes.Valor_base + "," + Comprobantes.Usu_aprueba + "," + Comprobantes.Estado_contab + "," + Comprobantes.Centro_costo + "," + Comprobantes.Seccion + ");");
      }
     public long Actualizar(M_Comprobantes Comprobantes)
     {
         return Data.Accion("UPDATE Comprobantes SET Fecha=" + Comprobantes.Fecha + ",Tipo_comp='"+Comprobantes.Tipo_comp + "'" + ",No_comp=" + Comprobantes.No_comp + ",Tipo_id='"+Comprobantes.Tipo_id + "'" + ",Id=" + Comprobantes.Id + ",Dv='"+Comprobantes.Dv + "'" + ",Descripcion='"+Comprobantes.Descripcion + "'" + ",Valor=" + Comprobantes.Valor + ",Forma_pago=" + Comprobantes.Forma_pago + ",Cod_cuenta=" + Comprobantes.Cod_cuenta + ",Clase_cuenta='"+Comprobantes.Clase_cuenta + "'" + ",Num='"+Comprobantes.Num + "'" + ",Entidad='"+Comprobantes.Entidad + "'" + ",Estado='"+Comprobantes.Estado + "'" + ",FechaAplic=" + Comprobantes.FechaAplic + ",Usu_cap=" + Comprobantes.Usu_cap + ",Fecha_vence=" + Comprobantes.Fecha_vence + ",Cod_empresa=" + Comprobantes.Cod_empresa + ",No_operacion=" + Comprobantes.No_operacion + ",Cod_concepto=" + Comprobantes.Cod_concepto + ",Valor_base=" + Comprobantes.Valor_base + ",Usu_aprueba=" + Comprobantes.Usu_aprueba + ",Estado_contab=" + Comprobantes.Estado_contab + ",Centro_costo=" + Comprobantes.Centro_costo + ",Seccion=" + Comprobantes.Seccion + " WHERE Tipo_comp='" + Comprobantes.Tipo_comp + "'" + " and No_comp=" + Comprobantes.No_comp + ";");
      }
     public long Nuevo(M_Comprobantes Comprobantes)
     {
         Dictionary<string, object> Parametros = new Dictionary<string, object>
         {
           {"Fecha", Comprobantes.Fecha},
           {"Tipo_comp", Comprobantes.Tipo_comp},
           {"No_comp", Comprobantes.No_comp},
           {"Tipo_id", Comprobantes.Tipo_id},
           {"Id", Comprobantes.Id},
           {"Dv", Comprobantes.Dv},
           {"Descripcion", Comprobantes.Descripcion},
           {"Valor", Comprobantes.Valor},
           {"Forma_pago", Comprobantes.Forma_pago},
           {"Cod_cuenta", Comprobantes.Cod_cuenta},
           {"Clase_cuenta", Comprobantes.Clase_cuenta},
           {"Num", Comprobantes.Num},
           {"Entidad", Comprobantes.Entidad},
           {"Estado", Comprobantes.Estado},
           {"FechaAplic", Comprobantes.FechaAplic},
           {"Usu_cap", Comprobantes.Usu_cap},
           {"Fecha_vence", Comprobantes.Fecha_vence},
           {"Cod_empresa", Comprobantes.Cod_empresa},
           {"No_operacion", Comprobantes.No_operacion},
           {"Cod_concepto", Comprobantes.Cod_concepto},
           {"Valor_base", Comprobantes.Valor_base},
           {"Usu_aprueba", Comprobantes.Usu_aprueba},
           {"Estado_contab", Comprobantes.Estado_contab},
           {"Centro_costo", Comprobantes.Centro_costo},
           {"Seccion", Comprobantes.Seccion}
         };
         return Data.EjecutarSPEscalar("{CALL sp_Nuevo_Comprobantes(?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)}", Parametros);
      }
 }
}
