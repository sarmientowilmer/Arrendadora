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
 public class N_Movimiento_Bancario
 {
     M_Movimiento_Bancario C_Movimiento_Bancario = new M_Movimiento_Bancario();
     ClsDatos Data = new ClsDatos();
     public bool Existe(int Cod_cuenta, int Cod_trans, int Cod_concepto, int Consecutivo, bool CargarDatos)
     {
         DataTable DT = new DataTable();
         DT = Data.ConsultaT("SELECT * FROM Movimiento_Bancario WHERE Cod_cuenta= " + Cod_cuenta + " and Cod_trans=" + Cod_trans + " and Cod_concepto=" + Cod_concepto + " and Consecutivo=" + Consecutivo);
         bool ExisteRegistro = false;
         if (DT.Rows.Count > 0)
         {
             ExisteRegistro = true;
             if (CargarDatos)
             {
                 C_Movimiento_Bancario.Cod_cuenta= Convert.ToInt32(DT.Rows[0]["Cod_cuenta"]);
                 C_Movimiento_Bancario.Consecutivo= Convert.ToInt32(DT.Rows[0]["Consecutivo"]);
                 C_Movimiento_Bancario.Fecha_girada= Convert.ToDateTime(DT.Rows[0]["Fecha_girada"]);
                 C_Movimiento_Bancario.Fecha_captura= Convert.ToDateTime(DT.Rows[0]["Fecha_captura"]);
                 C_Movimiento_Bancario.Fecha_cobro= Convert.ToDateTime(DT.Rows[0]["Fecha_cobro"]);
                 C_Movimiento_Bancario.Tipo_id= DT.Rows[0]["Tipo_id"].ToString();
                 C_Movimiento_Bancario.No_id= Convert.ToInt32(DT.Rows[0]["No_id"]);
                 C_Movimiento_Bancario.Dv= DT.Rows[0]["Dv"].ToString();
                 C_Movimiento_Bancario.Beneficiario= DT.Rows[0]["Beneficiario"].ToString();
                 C_Movimiento_Bancario.No_documento= DT.Rows[0]["No_documento"].ToString();
                 C_Movimiento_Bancario.Descripcion= DT.Rows[0]["Descripcion"].ToString();
                 C_Movimiento_Bancario.Cod_trans= Convert.ToInt32(DT.Rows[0]["Cod_trans"]);
                 C_Movimiento_Bancario.Cod_concepto= Convert.ToInt32(DT.Rows[0]["Cod_concepto"]);
                 C_Movimiento_Bancario.Centro_costo= Convert.ToInt32(DT.Rows[0]["Centro_costo"]);
                 C_Movimiento_Bancario.Usuario_cap= Convert.ToInt32(DT.Rows[0]["Usuario_cap"]);
                 C_Movimiento_Bancario.Seccion= Convert.ToInt32(DT.Rows[0]["Seccion"]);
                 C_Movimiento_Bancario.Valor_girado= Convert.ToDouble(DT.Rows[0]["Valor_girado"]);
                 C_Movimiento_Bancario.Forma_grabacion= Convert.ToInt32(DT.Rows[0]["Forma_grabacion"]);
                 C_Movimiento_Bancario.No_comp= Convert.ToInt32(DT.Rows[0]["No_comp"]);
                 C_Movimiento_Bancario.Estado= DT.Rows[0]["Estado"].ToString();
             }
         }
         return ExisteRegistro;
     }
     public M_Movimiento_Bancario Consultar(int Cod_cuenta, int Cod_trans, int Cod_concepto, int Consecutivo)
     {
         if (Existe(Cod_cuenta, Cod_trans, Cod_concepto, Consecutivo, true))
         {
             return C_Movimiento_Bancario;
         }
         else
         {
             return null;
         }
     }
     public DataTable Consultar()
     {
         return Data.ConsultaT("SELECT * FROM Movimiento_Bancario");
     }
     public long Insertar(M_Movimiento_Bancario Movimiento_Bancario)
     {
         return Data.Accion("INSERT INTO Movimiento_Bancario (Cod_cuenta,Consecutivo,Fecha_girada,Fecha_captura,Fecha_cobro,Tipo_id,No_id,Dv,Beneficiario,No_documento,Descripcion,Cod_trans,Cod_concepto,Centro_costo,Usuario_cap,Seccion,Valor_girado,Forma_grabacion,No_comp,Estado) VALUES (" + Movimiento_Bancario.Cod_cuenta + "," + Movimiento_Bancario.Consecutivo + "," + Movimiento_Bancario.Fecha_girada + "," + Movimiento_Bancario.Fecha_captura + "," + Movimiento_Bancario.Fecha_cobro + ", '" + Movimiento_Bancario.Tipo_id + "'" + "," + Movimiento_Bancario.No_id + ", '" + Movimiento_Bancario.Dv + "'" + ", '" + Movimiento_Bancario.Beneficiario + "'" + ", '" + Movimiento_Bancario.No_documento + "'" + ", '" + Movimiento_Bancario.Descripcion + "'" + "," + Movimiento_Bancario.Cod_trans + "," + Movimiento_Bancario.Cod_concepto + "," + Movimiento_Bancario.Centro_costo + "," + Movimiento_Bancario.Usuario_cap + "," + Movimiento_Bancario.Seccion + "," + Movimiento_Bancario.Valor_girado + "," + Movimiento_Bancario.Forma_grabacion + "," + Movimiento_Bancario.No_comp + ", '" + Movimiento_Bancario.Estado + "'" + ");");
      }
     public long Actualizar(M_Movimiento_Bancario Movimiento_Bancario)
     {
         return Data.Accion("UPDATE Movimiento_Bancario SET Cod_cuenta=" + Movimiento_Bancario.Cod_cuenta + ",Consecutivo=" + Movimiento_Bancario.Consecutivo + ",Fecha_girada=" + Movimiento_Bancario.Fecha_girada + ",Fecha_captura=" + Movimiento_Bancario.Fecha_captura + ",Fecha_cobro=" + Movimiento_Bancario.Fecha_cobro + ",Tipo_id='"+Movimiento_Bancario.Tipo_id + "'" + ",No_id=" + Movimiento_Bancario.No_id + ",Dv='"+Movimiento_Bancario.Dv + "'" + ",Beneficiario='"+Movimiento_Bancario.Beneficiario + "'" + ",No_documento='"+Movimiento_Bancario.No_documento + "'" + ",Descripcion='"+Movimiento_Bancario.Descripcion + "'" + ",Cod_trans=" + Movimiento_Bancario.Cod_trans + ",Cod_concepto=" + Movimiento_Bancario.Cod_concepto + ",Centro_costo=" + Movimiento_Bancario.Centro_costo + ",Usuario_cap=" + Movimiento_Bancario.Usuario_cap + ",Seccion=" + Movimiento_Bancario.Seccion + ",Valor_girado=" + Movimiento_Bancario.Valor_girado + ",Forma_grabacion=" + Movimiento_Bancario.Forma_grabacion + ",No_comp=" + Movimiento_Bancario.No_comp + ",Estado='"+Movimiento_Bancario.Estado + "'" + " WHERE Cod_cuenta= " + Movimiento_Bancario.Cod_cuenta + " and Cod_trans=" + Movimiento_Bancario.Cod_trans + " and Cod_concepto=" + Movimiento_Bancario.Cod_concepto + " and Consecutivo=" + Movimiento_Bancario.Consecutivo + ";");
      }
     public long Nuevo(M_Movimiento_Bancario Movimiento_Bancario)
     {
         Dictionary<string, object> Parametros = new Dictionary<string, object>
         {
           {"Cod_cuenta", Movimiento_Bancario.Cod_cuenta},
           {"Consecutivo", Movimiento_Bancario.Consecutivo},
           {"Fecha_girada", Movimiento_Bancario.Fecha_girada},
           {"Fecha_captura", Movimiento_Bancario.Fecha_captura},
           {"Fecha_cobro", Movimiento_Bancario.Fecha_cobro},
           {"Tipo_id", Movimiento_Bancario.Tipo_id},
           {"No_id", Movimiento_Bancario.No_id},
           {"Dv", Movimiento_Bancario.Dv},
           {"Beneficiario", Movimiento_Bancario.Beneficiario},
           {"No_documento", Movimiento_Bancario.No_documento},
           {"Descripcion", Movimiento_Bancario.Descripcion},
           {"Cod_trans", Movimiento_Bancario.Cod_trans},
           {"Cod_concepto", Movimiento_Bancario.Cod_concepto},
           {"Centro_costo", Movimiento_Bancario.Centro_costo},
           {"Usuario_cap", Movimiento_Bancario.Usuario_cap},
           {"Seccion", Movimiento_Bancario.Seccion},
           {"Valor_girado", Movimiento_Bancario.Valor_girado},
           {"Forma_grabacion", Movimiento_Bancario.Forma_grabacion},
           {"No_comp", Movimiento_Bancario.No_comp},
           {"Estado", Movimiento_Bancario.Estado}
         };
         return Data.EjecutarSPEscalar("{CALL sp_Nuevo_Movimiento_Bancario(?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)}", Parametros);
      }
 }
}
