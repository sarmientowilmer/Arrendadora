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
 public class N_Procesos_facturacion
 {
     M_Procesos_facturacion C_Procesos_facturacion = new M_Procesos_facturacion();
     ClsDatos Data = new ClsDatos();
     public bool Existe( bool CargarDatos)
     {
         DataTable DT = new DataTable();
         DT = Data.ConsultaT("SELECT * FROM procesos_facturacion " );
         bool ExisteRegistro = false;
         if (DT.Rows.Count > 0)
         {
             ExisteRegistro = true;
             if (CargarDatos)
             {
                 C_Procesos_facturacion.Fecha_proceso= Convert.ToDateTime(DT.Rows[0]["Fecha_proceso"]);
                 C_Procesos_facturacion.No_proceso= Convert.ToInt32(DT.Rows[0]["No_proceso"]);
                 C_Procesos_facturacion.Tipo_id_desde= DT.Rows[0]["Tipo_id_desde"].ToString();
                 C_Procesos_facturacion.Id_desde= Convert.ToInt32(DT.Rows[0]["Id_desde"]);
                 C_Procesos_facturacion.Dv_desde= DT.Rows[0]["Dv_desde"].ToString();
                 C_Procesos_facturacion.Tipo_id_hasta= DT.Rows[0]["Tipo_id_hasta"].ToString();
                 C_Procesos_facturacion.Id_hasta= Convert.ToInt32(DT.Rows[0]["Id_hasta"]);
                 C_Procesos_facturacion.Dv_hasta= DT.Rows[0]["Dv_hasta"].ToString();
                 C_Procesos_facturacion.Dia_venc_desde= Convert.ToInt32(DT.Rows[0]["Dia_venc_desde"]);
                 C_Procesos_facturacion.Dia_venc_hasta= Convert.ToInt32(DT.Rows[0]["Dia_venc_hasta"]);
                 C_Procesos_facturacion.No_factura_inicial= Convert.ToInt32(DT.Rows[0]["No_factura_inicial"]);
                 C_Procesos_facturacion.No_operacion= Convert.ToDouble(DT.Rows[0]["No_operacion"]);
                 C_Procesos_facturacion.Cod_empresa= Convert.ToInt32(DT.Rows[0]["Cod_empresa"]);
                 C_Procesos_facturacion.No_factura_final= Convert.ToInt32(DT.Rows[0]["No_factura_final"]);
                 C_Procesos_facturacion.Portesycorreo= Convert.ToDouble(DT.Rows[0]["Portesycorreo"]);
             }
         }
         return ExisteRegistro;
     }
     //public M_Procesos_facturacion Consultar()
     //{
     //    if (Existe(Periodo_contable, true))
     //    {
     //        return C_Procesos_facturacion;
     //    }
     //    else
     //    {
     //        return null;
     //    }
     //}
     public DataTable Consultar()
     {
         return Data.ConsultaT("SELECT * FROM procesos_facturacion");
     }
     public long Insertar(M_Procesos_facturacion Procesos_facturacion)
     {
         return Data.Accion("INSERT INTO procesos_facturacion (Fecha_proceso,No_proceso,Tipo_id_desde,Id_desde,Dv_desde,Tipo_id_hasta,Id_hasta,Dv_hasta,Dia_venc_desde,Dia_venc_hasta,No_factura_inicial,No_operacion,Cod_empresa,No_factura_final,Portesycorreo) VALUES (" + Procesos_facturacion.Fecha_proceso + "," + Procesos_facturacion.No_proceso + ", '" + Procesos_facturacion.Tipo_id_desde + "'" + "," + Procesos_facturacion.Id_desde + ", '" + Procesos_facturacion.Dv_desde + "'" + ", '" + Procesos_facturacion.Tipo_id_hasta + "'" + "," + Procesos_facturacion.Id_hasta + ", '" + Procesos_facturacion.Dv_hasta + "'" + "," + Procesos_facturacion.Dia_venc_desde + "," + Procesos_facturacion.Dia_venc_hasta + "," + Procesos_facturacion.No_factura_inicial + "," + Procesos_facturacion.No_operacion + "," + Procesos_facturacion.Cod_empresa + "," + Procesos_facturacion.No_factura_final + "," + Procesos_facturacion.Portesycorreo + ");");
      }
     public long Actualizar(M_Procesos_facturacion Procesos_facturacion)
     {
         return Data.Accion("UPDATE procesos_facturacion SET Fecha_proceso=" + Procesos_facturacion.Fecha_proceso + ",No_proceso=" + Procesos_facturacion.No_proceso + ",Tipo_id_desde='"+Procesos_facturacion.Tipo_id_desde + "'" + ",Id_desde=" + Procesos_facturacion.Id_desde + ",Dv_desde='"+Procesos_facturacion.Dv_desde + "'" + ",Tipo_id_hasta='"+Procesos_facturacion.Tipo_id_hasta + "'" + ",Id_hasta=" + Procesos_facturacion.Id_hasta + ",Dv_hasta='"+Procesos_facturacion.Dv_hasta + "'" + ",Dia_venc_desde=" + Procesos_facturacion.Dia_venc_desde + ",Dia_venc_hasta=" + Procesos_facturacion.Dia_venc_hasta + ",No_factura_inicial=" + Procesos_facturacion.No_factura_inicial + ",No_operacion=" + Procesos_facturacion.No_operacion + ",Cod_empresa=" + Procesos_facturacion.Cod_empresa + ",No_factura_final=" + Procesos_facturacion.No_factura_final + ",Portesycorreo=" + Procesos_facturacion.Portesycorreo + ";");
      }
     public long Nuevo(M_Procesos_facturacion Procesos_facturacion)
     {
         Dictionary<string, object> Parametros = new Dictionary<string, object>
         {
           {"Fecha_proceso", Procesos_facturacion.Fecha_proceso},
           {"No_proceso", Procesos_facturacion.No_proceso},
           {"Tipo_id_desde", Procesos_facturacion.Tipo_id_desde},
           {"Id_desde", Procesos_facturacion.Id_desde},
           {"Dv_desde", Procesos_facturacion.Dv_desde},
           {"Tipo_id_hasta", Procesos_facturacion.Tipo_id_hasta},
           {"Id_hasta", Procesos_facturacion.Id_hasta},
           {"Dv_hasta", Procesos_facturacion.Dv_hasta},
           {"Dia_venc_desde", Procesos_facturacion.Dia_venc_desde},
           {"Dia_venc_hasta", Procesos_facturacion.Dia_venc_hasta},
           {"No_factura_inicial", Procesos_facturacion.No_factura_inicial},
           {"No_operacion", Procesos_facturacion.No_operacion},
           {"Cod_empresa", Procesos_facturacion.Cod_empresa},
           {"No_factura_final", Procesos_facturacion.No_factura_final},
           {"Portesycorreo", Procesos_facturacion.Portesycorreo}
         };
         return Data.EjecutarSPEscalar("{CALL sp_Nuevo_procesos_facturacion(?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)}", Parametros);
      }
 }
}
