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
 public class N_Conciliacion_bancaria
 {
     M_Conciliacion_bancaria C_Conciliacion_bancaria = new M_Conciliacion_bancaria();
     ClsDatos Data = new ClsDatos();
     public bool Existe(int Cod_cuenta, int Año_Conc, int Mes_conc, bool CargarDatos)
     {
         DataTable DT = new DataTable();
         DT = Data.ConsultaT("SELECT * FROM Conciliacion_bancaria WHERE Cod_cuenta= " + Cod_cuenta + " and Año_Conc=" + Año_Conc + " and Mes_conc=" + Mes_conc);
         bool ExisteRegistro = false;
         if (DT.Rows.Count > 0)
         {
             ExisteRegistro = true;
             if (CargarDatos)
             {
                 C_Conciliacion_bancaria.Cod_cuenta= Convert.ToInt32(DT.Rows[0]["Cod_cuenta"]);
                 C_Conciliacion_bancaria.Año_Conc= Convert.ToInt32(DT.Rows[0]["Año_Conc"]);
                 C_Conciliacion_bancaria.Mes_conc= Convert.ToInt32(DT.Rows[0]["Mes_conc"]);
                 C_Conciliacion_bancaria.Saldo= Convert.ToDouble(DT.Rows[0]["Saldo"]);
                 C_Conciliacion_bancaria.Saldo_ext= Convert.ToDouble(DT.Rows[0]["Saldo_ext"]);
                 C_Conciliacion_bancaria.No_conc= Convert.ToInt32(DT.Rows[0]["No_conc"]);
                 C_Conciliacion_bancaria.Fecha_conc= Convert.ToDateTime(DT.Rows[0]["Fecha_conc"]);
                 C_Conciliacion_bancaria.Cod_empresa= Convert.ToInt32(DT.Rows[0]["Cod_empresa"]);
             }
         }
         return ExisteRegistro;
     }
     public M_Conciliacion_bancaria Consultar(int Cod_cuenta, int Año_Conc, int Mes_conc)
     {
         if (Existe(Cod_cuenta, Año_Conc, Mes_conc, true))
         {
             return C_Conciliacion_bancaria;
         }
         else
         {
             return null;
         }
     }
     public DataTable Consultar()
     {
         return Data.ConsultaT("SELECT * FROM Conciliacion_bancaria");
     }
     public long Insertar(M_Conciliacion_bancaria Conciliacion_bancaria)
     {
         return Data.Accion("INSERT INTO Conciliacion_bancaria (Cod_cuenta,Año_Conc,Mes_conc,Saldo,Saldo_ext,No_conc,Fecha_conc,Cod_empresa) VALUES (" + Conciliacion_bancaria.Cod_cuenta + "," + Conciliacion_bancaria.Año_Conc + "," + Conciliacion_bancaria.Mes_conc + "," + Conciliacion_bancaria.Saldo + "," + Conciliacion_bancaria.Saldo_ext + "," + Conciliacion_bancaria.No_conc + "," + Conciliacion_bancaria.Fecha_conc + "," + Conciliacion_bancaria.Cod_empresa + ");");
      }
     public long Actualizar(M_Conciliacion_bancaria Conciliacion_bancaria)
     {
         return Data.Accion("UPDATE Conciliacion_bancaria SET Cod_cuenta=" + Conciliacion_bancaria.Cod_cuenta + ",Año_Conc=" + Conciliacion_bancaria.Año_Conc + ",Mes_conc=" + Conciliacion_bancaria.Mes_conc + ",Saldo=" + Conciliacion_bancaria.Saldo + ",Saldo_ext=" + Conciliacion_bancaria.Saldo_ext + ",No_conc=" + Conciliacion_bancaria.No_conc + ",Fecha_conc=" + Conciliacion_bancaria.Fecha_conc + ",Cod_empresa=" + Conciliacion_bancaria.Cod_empresa + " WHERE Cod_cuenta= " + Conciliacion_bancaria.Cod_cuenta + " and Año_Conc=" + Conciliacion_bancaria.Año_Conc + " and Mes_conc=" + Conciliacion_bancaria.Mes_conc + ";");
      }
     public long Nuevo(M_Conciliacion_bancaria Conciliacion_bancaria)
     {
         Dictionary<string, object> Parametros = new Dictionary<string, object>
         {
           {"Cod_cuenta", Conciliacion_bancaria.Cod_cuenta},
           {"Año_Conc", Conciliacion_bancaria.Año_Conc},
           {"Mes_conc", Conciliacion_bancaria.Mes_conc},
           {"Saldo", Conciliacion_bancaria.Saldo},
           {"Saldo_ext", Conciliacion_bancaria.Saldo_ext},
           {"No_conc", Conciliacion_bancaria.No_conc},
           {"Fecha_conc", Conciliacion_bancaria.Fecha_conc},
           {"Cod_empresa", Conciliacion_bancaria.Cod_empresa}
         };
         return Data.EjecutarSPEscalar("{CALL sp_Nuevo_Conciliacion_bancaria(?, ?, ?, ?, ?, ?, ?, ?)}", Parametros);
      }
 }
}
