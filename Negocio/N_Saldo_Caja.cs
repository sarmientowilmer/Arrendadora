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
 public class N_Saldo_Caja
 {
     M_Saldo_Caja C_Saldo_Caja = new M_Saldo_Caja();
     ClsDatos Data = new ClsDatos();
     public bool Existe(int Año, int Mes, string Cuenta, string Tipo_aux, double Id_auxiliar, int Cod_empresa, bool CargarDatos)
     {
         DataTable DT = new DataTable();
         DT = Data.ConsultaT("SELECT * FROM Saldo_Caja WHERE Año= " + Año + " and Mes=" + Mes + " and Cuenta='" + Cuenta + "'" + " and Tipo_aux='" + Tipo_aux + "'" + " and Id_auxiliar=" + Id_auxiliar + " and Cod_empresa=" + Cod_empresa);
         bool ExisteRegistro = false;
         if (DT.Rows.Count > 0)
         {
             ExisteRegistro = true;
             if (CargarDatos)
             {
                 C_Saldo_Caja.Año= Convert.ToInt32(DT.Rows[0]["Año"]);
                 C_Saldo_Caja.Mes= Convert.ToInt32(DT.Rows[0]["Mes"]);
                 C_Saldo_Caja.Cuenta= DT.Rows[0]["Cuenta"].ToString();
                 C_Saldo_Caja.Tipo_aux= DT.Rows[0]["Tipo_aux"].ToString();
                 C_Saldo_Caja.Id_auxiliar= Convert.ToDouble(DT.Rows[0]["Id_auxiliar"]);
                 C_Saldo_Caja.Dv= DT.Rows[0]["Dv"].ToString();
                 C_Saldo_Caja.Saldo= Convert.ToDouble(DT.Rows[0]["Saldo"]);
                 C_Saldo_Caja.Cod_empresa= Convert.ToInt32(DT.Rows[0]["Cod_empresa"]);
             }
         }
         return ExisteRegistro;
     }
     public M_Saldo_Caja Consultar(int Año, int Mes, string Cuenta, string Tipo_aux, double Id_auxiliar, int Cod_empresa)
     {
         if (Existe(Año, Mes, Cuenta, Tipo_aux, Id_auxiliar, Cod_empresa, true))
         {
             return C_Saldo_Caja;
         }
         else
         {
             return null;
         }
     }
     public DataTable Consultar()
     {
         return Data.ConsultaT("SELECT * FROM Saldo_Caja");
     }
     public long Insertar(M_Saldo_Caja Saldo_Caja)
     {
         return Data.Accion("INSERT INTO Saldo_Caja (Año,Mes,Cuenta,Tipo_aux,Id_auxiliar,Dv,Saldo,Cod_empresa) VALUES (" + Saldo_Caja.Año + "," + Saldo_Caja.Mes + ", '" + Saldo_Caja.Cuenta + "'" + ", '" + Saldo_Caja.Tipo_aux + "'" + "," + Saldo_Caja.Id_auxiliar + ", '" + Saldo_Caja.Dv + "'" + "," + Saldo_Caja.Saldo + "," + Saldo_Caja.Cod_empresa + ");");
      }
     public long Actualizar(M_Saldo_Caja Saldo_Caja)
     {
         return Data.Accion("UPDATE Saldo_Caja SET Año=" + Saldo_Caja.Año + ",Mes=" + Saldo_Caja.Mes + ",Cuenta='"+Saldo_Caja.Cuenta + "'" + ",Tipo_aux='"+Saldo_Caja.Tipo_aux + "'" + ",Id_auxiliar=" + Saldo_Caja.Id_auxiliar + ",Dv='"+Saldo_Caja.Dv + "'" + ",Saldo=" + Saldo_Caja.Saldo + ",Cod_empresa=" + Saldo_Caja.Cod_empresa + " WHERE Año= " + Saldo_Caja.Año + " and Mes=" + Saldo_Caja.Mes + " and Cuenta='" + Saldo_Caja.Cuenta + "'" + " and Tipo_aux='" + Saldo_Caja.Tipo_aux + "'" + " and Id_auxiliar=" + Saldo_Caja.Id_auxiliar + " and Cod_empresa=" + Saldo_Caja.Cod_empresa + ";");
      }
     public long Nuevo(M_Saldo_Caja Saldo_Caja)
     {
         Dictionary<string, object> Parametros = new Dictionary<string, object>
         {
           {"Año", Saldo_Caja.Año},
           {"Mes", Saldo_Caja.Mes},
           {"Cuenta", Saldo_Caja.Cuenta},
           {"Tipo_aux", Saldo_Caja.Tipo_aux},
           {"Id_auxiliar", Saldo_Caja.Id_auxiliar},
           {"Dv", Saldo_Caja.Dv},
           {"Saldo", Saldo_Caja.Saldo},
           {"Cod_empresa", Saldo_Caja.Cod_empresa}
         };
         return Data.EjecutarSPEscalar("{CALL sp_Nuevo_Saldo_Caja(?, ?, ?, ?, ?, ?, ?, ?)}", Parametros);
      }
 }
}
