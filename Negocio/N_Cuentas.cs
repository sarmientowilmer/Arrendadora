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
 public class N_Cuentas
 {
     M_Cuentas C_Cuentas = new M_Cuentas();
     ClsDatos Data = new ClsDatos();
     public bool Existe(string Cuenta, bool CargarDatos)
     {
         DataTable DT = new DataTable();
         DT = Data.ConsultaT("SELECT * FROM Cuentas WHERE Cuenta='" + Cuenta + "'");
         bool ExisteRegistro = false;
         if (DT.Rows.Count > 0)
         {
             ExisteRegistro = true;
             if (CargarDatos)
             {
                 C_Cuentas.Cuenta= DT.Rows[0]["Cuenta"].ToString();
                 C_Cuentas.Nombre_cuenta= DT.Rows[0]["Nombre_cuenta"].ToString();
                 C_Cuentas.Saldo_negativo= Convert.ToBoolean(DT.Rows[0]["Saldo_negativo"]);
                 C_Cuentas.Cuenta_nominal= Convert.ToBoolean(DT.Rows[0]["Cuenta_nominal"]);
                 C_Cuentas.Tipo_saldo= DT.Rows[0]["Tipo_saldo"].ToString();
                 C_Cuentas.Desglose= Convert.ToBoolean(DT.Rows[0]["Desglose"]);
                 C_Cuentas.Auxiliar= Convert.ToBoolean(DT.Rows[0]["Auxiliar"]);
                 C_Cuentas.Cod_empresa= Convert.ToInt32(DT.Rows[0]["Cod_empresa"]);
                 C_Cuentas.Usu_cap= Convert.ToInt32(DT.Rows[0]["Usu_cap"]);
                 C_Cuentas.Fecha_creacion= Convert.ToDateTime(DT.Rows[0]["Fecha_creacion"]);
             }
         }
         return ExisteRegistro;
     }
     public M_Cuentas Consultar(string Cuenta)
     {
         if (Existe(Cuenta, true))
         {
             return C_Cuentas;
         }
         else
         {
             return null;
         }
     }
     public DataTable Consultar()
     {
         return Data.ConsultaT("SELECT * FROM Cuentas");
     }
     public long Insertar(M_Cuentas Cuentas)
     {
         return Data.Accion("INSERT INTO Cuentas (Cuenta,Nombre_cuenta,Saldo_negativo,Cuenta_nominal,Tipo_saldo,Desglose,Auxiliar,Cod_empresa,Usu_cap,Fecha_creacion) VALUES (" + "'" + Cuentas.Cuenta+"'" + ", '" + Cuentas.Nombre_cuenta + "'" + "," + Cuentas.Saldo_negativo + "," + Cuentas.Cuenta_nominal + ", '" + Cuentas.Tipo_saldo + "'" + "," + Cuentas.Desglose + "," + Cuentas.Auxiliar + "," + Cuentas.Cod_empresa + "," + Cuentas.Usu_cap + "," + Cuentas.Fecha_creacion + ");");
      }
     public long Actualizar(M_Cuentas Cuentas)
     {
         return Data.Accion("UPDATE Cuentas SET Cuenta='" + Cuentas.Cuenta + "'" + ",Nombre_cuenta='"+Cuentas.Nombre_cuenta + "'" + ",Saldo_negativo=" + Cuentas.Saldo_negativo + ",Cuenta_nominal=" + Cuentas.Cuenta_nominal + ",Tipo_saldo='"+Cuentas.Tipo_saldo + "'" + ",Desglose=" + Cuentas.Desglose + ",Auxiliar=" + Cuentas.Auxiliar + ",Cod_empresa=" + Cuentas.Cod_empresa + ",Usu_cap=" + Cuentas.Usu_cap + ",Fecha_creacion=" + Cuentas.Fecha_creacion + " WHERE Cuenta='" + Cuentas.Cuenta + "'" + ";");
      }
     public long Nuevo(M_Cuentas Cuentas)
     {
         Dictionary<string, object> Parametros = new Dictionary<string, object>
         {
           {"Cuenta", Cuentas.Cuenta},
           {"Nombre_cuenta", Cuentas.Nombre_cuenta},
           {"Saldo_negativo", Cuentas.Saldo_negativo},
           {"Cuenta_nominal", Cuentas.Cuenta_nominal},
           {"Tipo_saldo", Cuentas.Tipo_saldo},
           {"Desglose", Cuentas.Desglose},
           {"Auxiliar", Cuentas.Auxiliar},
           {"Cod_empresa", Cuentas.Cod_empresa},
           {"Usu_cap", Cuentas.Usu_cap},
           {"Fecha_creacion", Cuentas.Fecha_creacion}
         };
         return Data.EjecutarSPEscalar("{CALL sp_Nuevo_Cuentas(?, ?, ?, ?, ?, ?, ?, ?, ?, ?)}", Parametros);
      }
 }
}
