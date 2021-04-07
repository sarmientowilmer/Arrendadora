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
 public class N_Contrato_Admon
 {
     M_Contrato_Admon C_Contrato_Admon = new M_Contrato_Admon();
     ClsDatos Data = new ClsDatos();
     public bool Existe(int No_contrato, bool CargarDatos)
     {
         DataTable DT = new DataTable();
         DT = Data.ConsultaT("SELECT * FROM Contrato_Admon WHERE No_contrato= " + No_contrato);
         bool ExisteRegistro = false;
         if (DT.Rows.Count > 0)
         {
             ExisteRegistro = true;
             if (CargarDatos)
             {
                 C_Contrato_Admon.No_contrato= Convert.ToInt32(DT.Rows[0]["No_contrato"]);
                 C_Contrato_Admon.Cod_inmueble= Convert.ToInt32(DT.Rows[0]["Cod_inmueble"]);
                 C_Contrato_Admon.Fecha_inicio= Convert.ToDateTime(DT.Rows[0]["Fecha_inicio"]);
                 C_Contrato_Admon.Fecha_vencimiento= Convert.ToDateTime(DT.Rows[0]["Fecha_vencimiento"]);
                 C_Contrato_Admon.Tasa_admon= Convert.ToDouble(DT.Rows[0]["Tasa_admon"]);
                 C_Contrato_Admon.Forma_pago= Convert.ToInt32(DT.Rows[0]["Forma_pago"]);
                 C_Contrato_Admon.No_cuenta= DT.Rows[0]["No_cuenta"].ToString();
                 C_Contrato_Admon.Clase_cuenta= DT.Rows[0]["Clase_cuenta"].ToString();
                 C_Contrato_Admon.Entidad= DT.Rows[0]["Entidad"].ToString();
                 C_Contrato_Admon.Fecha_pago= Convert.ToDateTime(DT.Rows[0]["Fecha_pago"]);
                 C_Contrato_Admon.Pago_hasta= Convert.ToDateTime(DT.Rows[0]["Pago_hasta"]);
                 C_Contrato_Admon.Estado= DT.Rows[0]["Estado"].ToString();
                 C_Contrato_Admon.Periodo= Convert.ToInt32(DT.Rows[0]["Periodo"]);
                 C_Contrato_Admon.Prorrogas= Convert.ToInt32(DT.Rows[0]["Prorrogas"]);
                 C_Contrato_Admon.Sujeto_iva= Convert.ToBoolean(DT.Rows[0]["Sujeto_iva"]);
                 C_Contrato_Admon.Cod_empresa= Convert.ToInt32(DT.Rows[0]["Cod_empresa"]);
             }
         }
         return ExisteRegistro;
     }
     public M_Contrato_Admon Consultar(int No_contrato)
     {
         if (Existe(No_contrato, true))
         {
             return C_Contrato_Admon;
         }
         else
         {
             return null;
         }
     }
     public DataTable Consultar()
     {
         return Data.ConsultaT("SELECT * FROM Contrato_Admon");
     }
     public long Insertar(M_Contrato_Admon Contrato_Admon)
     {
         return Data.Accion("INSERT INTO Contrato_Admon (No_contrato,Cod_inmueble,Fecha_inicio,Fecha_vencimiento,Tasa_admon,Forma_pago,No_cuenta,Clase_cuenta,Entidad,Fecha_pago,Pago_hasta,Estado,Periodo,Prorrogas,Sujeto_iva,Cod_empresa) VALUES (" + Contrato_Admon.No_contrato + "," + Contrato_Admon.Cod_inmueble + "," + Contrato_Admon.Fecha_inicio + "," + Contrato_Admon.Fecha_vencimiento + "," + Contrato_Admon.Tasa_admon + "," + Contrato_Admon.Forma_pago + ", '" + Contrato_Admon.No_cuenta + "'" + ", '" + Contrato_Admon.Clase_cuenta + "'" + ", '" + Contrato_Admon.Entidad + "'" + "," + Contrato_Admon.Fecha_pago + "," + Contrato_Admon.Pago_hasta + ", '" + Contrato_Admon.Estado + "'" + "," + Contrato_Admon.Periodo + "," + Contrato_Admon.Prorrogas + "," + Contrato_Admon.Sujeto_iva + "," + Contrato_Admon.Cod_empresa + ");");
      }
     public long Actualizar(M_Contrato_Admon Contrato_Admon)
     {
         return Data.Accion("UPDATE Contrato_Admon SET No_contrato=" + Contrato_Admon.No_contrato + ",Cod_inmueble=" + Contrato_Admon.Cod_inmueble + ",Fecha_inicio=" + Contrato_Admon.Fecha_inicio + ",Fecha_vencimiento=" + Contrato_Admon.Fecha_vencimiento + ",Tasa_admon=" + Contrato_Admon.Tasa_admon + ",Forma_pago=" + Contrato_Admon.Forma_pago + ",No_cuenta='"+Contrato_Admon.No_cuenta + "'" + ",Clase_cuenta='"+Contrato_Admon.Clase_cuenta + "'" + ",Entidad='"+Contrato_Admon.Entidad + "'" + ",Fecha_pago=" + Contrato_Admon.Fecha_pago + ",Pago_hasta=" + Contrato_Admon.Pago_hasta + ",Estado='"+Contrato_Admon.Estado + "'" + ",Periodo=" + Contrato_Admon.Periodo + ",Prorrogas=" + Contrato_Admon.Prorrogas + ",Sujeto_iva=" + Contrato_Admon.Sujeto_iva + ",Cod_empresa=" + Contrato_Admon.Cod_empresa + " WHERE No_contrato= " + Contrato_Admon.No_contrato + ";");
      }
     public long Nuevo(M_Contrato_Admon Contrato_Admon)
     {
         Dictionary<string, object> Parametros = new Dictionary<string, object>
         {
           {"No_contrato", Contrato_Admon.No_contrato},
           {"Cod_inmueble", Contrato_Admon.Cod_inmueble},
           {"Fecha_inicio", Contrato_Admon.Fecha_inicio},
           {"Fecha_vencimiento", Contrato_Admon.Fecha_vencimiento},
           {"Tasa_admon", Contrato_Admon.Tasa_admon},
           {"Forma_pago", Contrato_Admon.Forma_pago},
           {"No_cuenta", Contrato_Admon.No_cuenta},
           {"Clase_cuenta", Contrato_Admon.Clase_cuenta},
           {"Entidad", Contrato_Admon.Entidad},
           {"Fecha_pago", Contrato_Admon.Fecha_pago},
           {"Pago_hasta", Contrato_Admon.Pago_hasta},
           {"Estado", Contrato_Admon.Estado},
           {"Periodo", Contrato_Admon.Periodo},
           {"Prorrogas", Contrato_Admon.Prorrogas},
           {"Sujeto_iva", Contrato_Admon.Sujeto_iva},
           {"Cod_empresa", Contrato_Admon.Cod_empresa}
         };
         return Data.EjecutarSPEscalar("{CALL sp_Nuevo_Contrato_Admon(?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)}", Parametros);
      }
 }
}
