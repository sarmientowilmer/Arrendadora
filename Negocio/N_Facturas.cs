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
 public class N_Facturas
 {
     M_Facturas C_Facturas = new M_Facturas();
     ClsDatos Data = new ClsDatos();
     public bool Existe( bool CargarDatos)
     {
         DataTable DT = new DataTable();
         DT = Data.ConsultaT("SELECT * FROM facturas " );
         bool ExisteRegistro = false;
         if (DT.Rows.Count > 0)
         {
             ExisteRegistro = true;
             if (CargarDatos)
             {
                 C_Facturas.Tipo_comp= DT.Rows[0]["Tipo_comp"].ToString();
                 C_Facturas.No_comp= Convert.ToInt32(DT.Rows[0]["No_comp"]);
                 C_Facturas.Saldo_anterior= Convert.ToDouble(DT.Rows[0]["Saldo_anterior"]);
                 C_Facturas.Recargo_mora= Convert.ToDouble(DT.Rows[0]["Recargo_mora"]);
                 C_Facturas.Cargo_mes= Convert.ToDouble(DT.Rows[0]["Cargo_mes"]);
                 C_Facturas.Iva_arriendo= Convert.ToDouble(DT.Rows[0]["Iva_arriendo"]);
                 C_Facturas.Retension= Convert.ToDouble(DT.Rows[0]["Retension"]);
                 C_Facturas.Administracion= Convert.ToDouble(DT.Rows[0]["Administracion"]);
                 C_Facturas.Portesycorreo= Convert.ToDouble(DT.Rows[0]["Portesycorreo"]);
                 C_Facturas.Otros_descripcion= DT.Rows[0]["Otros_descripcion"].ToString();
                 C_Facturas.Otros_valor= Convert.ToDouble(DT.Rows[0]["Otros_valor"]);
                 C_Facturas.Pago_desde= Convert.ToDateTime(DT.Rows[0]["Pago_desde"]);
                 C_Facturas.Dias= Convert.ToInt32(DT.Rows[0]["Dias"]);
                 C_Facturas.Fecha_vencimiento= Convert.ToDateTime(DT.Rows[0]["Fecha_vencimiento"]);
                 C_Facturas.Notas= DT.Rows[0]["Notas"].ToString();
                 C_Facturas.Estado_factura= Convert.ToByte(DT.Rows[0]["Estado_factura"]);
                 C_Facturas.No_operacion= Convert.ToDouble(DT.Rows[0]["No_operacion"]);
                 C_Facturas.Cod_empresa= Convert.ToInt32(DT.Rows[0]["Cod_empresa"]);
                 C_Facturas.Estado_impresion= Convert.ToByte(DT.Rows[0]["Estado_impresion"]);
                 C_Facturas.No_proceso= Convert.ToInt32(DT.Rows[0]["No_proceso"]);
                 C_Facturas.No_contrato= Convert.ToInt32(DT.Rows[0]["No_contrato"]);
                 C_Facturas.Refacturada= Convert.ToBoolean(DT.Rows[0]["Refacturada"]);
                 C_Facturas.Fra_ant= Convert.ToInt32(DT.Rows[0]["Fra_ant"]);
             }
         }
         return ExisteRegistro;
     }
     //public M_Facturas Consultar()
     //{
     //    if (Existe(Cod_estado, true))
     //    {
     //        return C_Facturas;
     //    }
     //    else
     //    {
     //        return null;
     //    }
     //}
     public DataTable Consultar()
     {
         return Data.ConsultaT("SELECT * FROM facturas");
     }
     public long Insertar(M_Facturas Facturas)
     {
         return Data.Accion("INSERT INTO facturas (Tipo_comp,No_comp,Saldo_anterior,Recargo_mora,Cargo_mes,Iva_arriendo,Retension,Administracion,Portesycorreo,Otros_descripcion,Otros_valor,Pago_desde,Dias,Fecha_vencimiento,Notas,Estado_factura,No_operacion,Cod_empresa,Estado_impresion,No_proceso,No_contrato,Refacturada,Fra_ant) VALUES (" + "'" + Facturas.Tipo_comp+"'" + "," + Facturas.No_comp + "," + Facturas.Saldo_anterior + "," + Facturas.Recargo_mora + "," + Facturas.Cargo_mes + "," + Facturas.Iva_arriendo + "," + Facturas.Retension + "," + Facturas.Administracion + "," + Facturas.Portesycorreo + ", '" + Facturas.Otros_descripcion + "'" + "," + Facturas.Otros_valor + "," + Facturas.Pago_desde + "," + Facturas.Dias + "," + Facturas.Fecha_vencimiento + ", '" + Facturas.Notas + "'" + "," + Facturas.Estado_factura + "," + Facturas.No_operacion + "," + Facturas.Cod_empresa + "," + Facturas.Estado_impresion + "," + Facturas.No_proceso + "," + Facturas.No_contrato + "," + Facturas.Refacturada + "," + Facturas.Fra_ant + ");");
      }
     public long Actualizar(M_Facturas Facturas)
     {
         return Data.Accion("UPDATE facturas SET Tipo_comp='" + Facturas.Tipo_comp + "'" + ",No_comp=" + Facturas.No_comp + ",Saldo_anterior=" + Facturas.Saldo_anterior + ",Recargo_mora=" + Facturas.Recargo_mora + ",Cargo_mes=" + Facturas.Cargo_mes + ",Iva_arriendo=" + Facturas.Iva_arriendo + ",Retension=" + Facturas.Retension + ",Administracion=" + Facturas.Administracion + ",Portesycorreo=" + Facturas.Portesycorreo + ",Otros_descripcion='"+Facturas.Otros_descripcion + "'" + ",Otros_valor=" + Facturas.Otros_valor + ",Pago_desde=" + Facturas.Pago_desde + ",Dias=" + Facturas.Dias + ",Fecha_vencimiento=" + Facturas.Fecha_vencimiento + ",Notas='"+Facturas.Notas + "'" + ",Estado_factura=" + Facturas.Estado_factura + ",No_operacion=" + Facturas.No_operacion + ",Cod_empresa=" + Facturas.Cod_empresa + ",Estado_impresion=" + Facturas.Estado_impresion + ",No_proceso=" + Facturas.No_proceso + ",No_contrato=" + Facturas.No_contrato + ",Refacturada=" + Facturas.Refacturada + ",Fra_ant=" + Facturas.Fra_ant + ";");
      }
     public long Nuevo(M_Facturas Facturas)
     {
         Dictionary<string, object> Parametros = new Dictionary<string, object>
         {
           {"Tipo_comp", Facturas.Tipo_comp},
           {"No_comp", Facturas.No_comp},
           {"Saldo_anterior", Facturas.Saldo_anterior},
           {"Recargo_mora", Facturas.Recargo_mora},
           {"Cargo_mes", Facturas.Cargo_mes},
           {"Iva_arriendo", Facturas.Iva_arriendo},
           {"Retension", Facturas.Retension},
           {"Administracion", Facturas.Administracion},
           {"Portesycorreo", Facturas.Portesycorreo},
           {"Otros_descripcion", Facturas.Otros_descripcion},
           {"Otros_valor", Facturas.Otros_valor},
           {"Pago_desde", Facturas.Pago_desde},
           {"Dias", Facturas.Dias},
           {"Fecha_vencimiento", Facturas.Fecha_vencimiento},
           {"Notas", Facturas.Notas},
           {"Estado_factura", Facturas.Estado_factura},
           {"No_operacion", Facturas.No_operacion},
           {"Cod_empresa", Facturas.Cod_empresa},
           {"Estado_impresion", Facturas.Estado_impresion},
           {"No_proceso", Facturas.No_proceso},
           {"No_contrato", Facturas.No_contrato},
           {"Refacturada", Facturas.Refacturada},
           {"Fra_ant", Facturas.Fra_ant}
         };
         return Data.EjecutarSPEscalar("{CALL sp_Nuevo_facturas(?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)}", Parametros);
      }
 }
}
