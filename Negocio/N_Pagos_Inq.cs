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
 public class N_Pagos_Inq
 {
     M_Pagos_Inq C_Pagos_Inq = new M_Pagos_Inq();
     ClsDatos Data = new ClsDatos();
     public bool Existe(string Tipo_comp, int No_comp, int No_contrato, bool CargarDatos)
     {
         DataTable DT = new DataTable();
         DT = Data.ConsultaT("SELECT * FROM Pagos_Inq WHERE Tipo_comp='" + Tipo_comp + "'" + " and No_comp=" + No_comp + " and No_contrato=" + No_contrato);
         bool ExisteRegistro = false;
         if (DT.Rows.Count > 0)
         {
             ExisteRegistro = true;
             if (CargarDatos)
             {
                 C_Pagos_Inq.Tipo_comp= DT.Rows[0]["Tipo_comp"].ToString();
                 C_Pagos_Inq.No_comp= Convert.ToInt32(DT.Rows[0]["No_comp"]);
                 C_Pagos_Inq.No_contrato= Convert.ToInt32(DT.Rows[0]["No_contrato"]);
                 C_Pagos_Inq.Valor_pagado= Convert.ToDouble(DT.Rows[0]["Valor_pagado"]);
                 C_Pagos_Inq.Intrs_pagado= Convert.ToDouble(DT.Rows[0]["Intrs_pagado"]);
                 C_Pagos_Inq.Retencion= Convert.ToDouble(DT.Rows[0]["Retencion"]);
                 C_Pagos_Inq.Pago_hasta= Convert.ToDateTime(DT.Rows[0]["Pago_hasta"]);
                 C_Pagos_Inq.Tasa_mora= Convert.ToDouble(DT.Rows[0]["Tasa_mora"]);
                 C_Pagos_Inq.Usu_cap= Convert.ToInt32(DT.Rows[0]["Usu_cap"]);
                 C_Pagos_Inq.Admon= Convert.ToDouble(DT.Rows[0]["Admon"]);
                 C_Pagos_Inq.Tasa_iva= Convert.ToDouble(DT.Rows[0]["Tasa_iva"]);
                 C_Pagos_Inq.Cod_empresa= Convert.ToInt32(DT.Rows[0]["Cod_empresa"]);
                 C_Pagos_Inq.No_operacion= Convert.ToDouble(DT.Rows[0]["No_operacion"]);
                 C_Pagos_Inq.No_factura= Convert.ToInt32(DT.Rows[0]["No_factura"]);
             }
         }
         return ExisteRegistro;
     }
     public M_Pagos_Inq Consultar(string Tipo_comp, int No_comp, int No_contrato)
     {
         if (Existe(Tipo_comp, No_comp, No_contrato, true))
         {
             return C_Pagos_Inq;
         }
         else
         {
             return null;
         }
     }
     public DataTable Consultar()
     {
         return Data.ConsultaT("SELECT * FROM Pagos_Inq");
     }
     public long Insertar(M_Pagos_Inq Pagos_Inq)
     {
         return Data.Accion("INSERT INTO Pagos_Inq (Tipo_comp,No_comp,No_contrato,Valor_pagado,Intrs_pagado,Retencion,Pago_hasta,Tasa_mora,Usu_cap,Admon,Tasa_iva,Cod_empresa,No_operacion,No_factura) VALUES (" + "'" + Pagos_Inq.Tipo_comp+"'" + "," + Pagos_Inq.No_comp + "," + Pagos_Inq.No_contrato + "," + Pagos_Inq.Valor_pagado + "," + Pagos_Inq.Intrs_pagado + "," + Pagos_Inq.Retencion + "," + Pagos_Inq.Pago_hasta + "," + Pagos_Inq.Tasa_mora + "," + Pagos_Inq.Usu_cap + "," + Pagos_Inq.Admon + "," + Pagos_Inq.Tasa_iva + "," + Pagos_Inq.Cod_empresa + "," + Pagos_Inq.No_operacion + "," + Pagos_Inq.No_factura + ");");
      }
     public long Actualizar(M_Pagos_Inq Pagos_Inq)
     {
         return Data.Accion("UPDATE Pagos_Inq SET Tipo_comp='" + Pagos_Inq.Tipo_comp + "'" + ",No_comp=" + Pagos_Inq.No_comp + ",No_contrato=" + Pagos_Inq.No_contrato + ",Valor_pagado=" + Pagos_Inq.Valor_pagado + ",Intrs_pagado=" + Pagos_Inq.Intrs_pagado + ",Retencion=" + Pagos_Inq.Retencion + ",Pago_hasta=" + Pagos_Inq.Pago_hasta + ",Tasa_mora=" + Pagos_Inq.Tasa_mora + ",Usu_cap=" + Pagos_Inq.Usu_cap + ",Admon=" + Pagos_Inq.Admon + ",Tasa_iva=" + Pagos_Inq.Tasa_iva + ",Cod_empresa=" + Pagos_Inq.Cod_empresa + ",No_operacion=" + Pagos_Inq.No_operacion + ",No_factura=" + Pagos_Inq.No_factura + " WHERE Tipo_comp='" + Pagos_Inq.Tipo_comp + "'" + " and No_comp=" + Pagos_Inq.No_comp + " and No_contrato=" + Pagos_Inq.No_contrato + ";");
      }
     public long Nuevo(M_Pagos_Inq Pagos_Inq)
     {
         Dictionary<string, object> Parametros = new Dictionary<string, object>
         {
           {"Tipo_comp", Pagos_Inq.Tipo_comp},
           {"No_comp", Pagos_Inq.No_comp},
           {"No_contrato", Pagos_Inq.No_contrato},
           {"Valor_pagado", Pagos_Inq.Valor_pagado},
           {"Intrs_pagado", Pagos_Inq.Intrs_pagado},
           {"Retencion", Pagos_Inq.Retencion},
           {"Pago_hasta", Pagos_Inq.Pago_hasta},
           {"Tasa_mora", Pagos_Inq.Tasa_mora},
           {"Usu_cap", Pagos_Inq.Usu_cap},
           {"Admon", Pagos_Inq.Admon},
           {"Tasa_iva", Pagos_Inq.Tasa_iva},
           {"Cod_empresa", Pagos_Inq.Cod_empresa},
           {"No_operacion", Pagos_Inq.No_operacion},
           {"No_factura", Pagos_Inq.No_factura}
         };
         return Data.EjecutarSPEscalar("{CALL sp_Nuevo_Pagos_Inq(?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)}", Parametros);
      }
 }
}
