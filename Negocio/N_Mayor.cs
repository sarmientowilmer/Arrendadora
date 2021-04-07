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
 public class N_Mayor
 {
     M_Mayor C_Mayor = new M_Mayor();
     ClsDatos Data = new ClsDatos();
     public bool Existe(string Cuenta, string Tipo_aux, double Id_auxiliar, int Cod_empresa, bool CargarDatos)
     {
         DataTable DT = new DataTable();
         DT = Data.ConsultaT("SELECT * FROM Mayor WHERE Cuenta='" + Cuenta + "'" + " and Tipo_aux='" + Tipo_aux + "'" + " and Id_auxiliar=" + Id_auxiliar + " and Cod_empresa=" + Cod_empresa);
         bool ExisteRegistro = false;
         if (DT.Rows.Count > 0)
         {
             ExisteRegistro = true;
             if (CargarDatos)
             {
                 C_Mayor.Cuenta= DT.Rows[0]["Cuenta"].ToString();
                 C_Mayor.Tipo_aux= DT.Rows[0]["Tipo_aux"].ToString();
                 C_Mayor.Id_auxiliar= Convert.ToDouble(DT.Rows[0]["Id_auxiliar"]);
                 C_Mayor.Dv= DT.Rows[0]["Dv"].ToString();
                 C_Mayor.Saldo= Convert.ToDouble(DT.Rows[0]["Saldo"]);
                 C_Mayor.Debitos= Convert.ToDouble(DT.Rows[0]["Debitos"]);
                 C_Mayor.Creditos= Convert.ToDouble(DT.Rows[0]["Creditos"]);
                 C_Mayor.Cod_empresa= Convert.ToInt32(DT.Rows[0]["Cod_empresa"]);
                 C_Mayor.Año= Convert.ToInt32(DT.Rows[0]["Año"]);
             }
         }
         return ExisteRegistro;
     }
     public M_Mayor Consultar(string Cuenta, string Tipo_aux, double Id_auxiliar, int Cod_empresa)
     {
         if (Existe(Cuenta, Tipo_aux, Id_auxiliar, Cod_empresa, true))
         {
             return C_Mayor;
         }
         else
         {
             return null;
         }
     }
     public DataTable Consultar()
     {
         return Data.ConsultaT("SELECT * FROM Mayor");
     }
     public long Insertar(M_Mayor Mayor)
     {
         return Data.Accion("INSERT INTO Mayor (Cuenta,Tipo_aux,Id_auxiliar,Dv,Saldo,Debitos,Creditos,Cod_empresa,Año) VALUES (" + "'" + Mayor.Cuenta+"'" + ", '" + Mayor.Tipo_aux + "'" + "," + Mayor.Id_auxiliar + ", '" + Mayor.Dv + "'" + "," + Mayor.Saldo + "," + Mayor.Debitos + "," + Mayor.Creditos + "," + Mayor.Cod_empresa + "," + Mayor.Año + ");");
      }
     public long Actualizar(M_Mayor Mayor)
     {
         return Data.Accion("UPDATE Mayor SET Cuenta='" + Mayor.Cuenta + "'" + ",Tipo_aux='"+Mayor.Tipo_aux + "'" + ",Id_auxiliar=" + Mayor.Id_auxiliar + ",Dv='"+Mayor.Dv + "'" + ",Saldo=" + Mayor.Saldo + ",Debitos=" + Mayor.Debitos + ",Creditos=" + Mayor.Creditos + ",Cod_empresa=" + Mayor.Cod_empresa + ",Año=" + Mayor.Año + " WHERE Cuenta='" + Mayor.Cuenta + "'" + " and Tipo_aux='" + Mayor.Tipo_aux + "'" + " and Id_auxiliar=" + Mayor.Id_auxiliar + " and Cod_empresa=" + Mayor.Cod_empresa + ";");
      }
     public long Nuevo(M_Mayor Mayor)
     {
         Dictionary<string, object> Parametros = new Dictionary<string, object>
         {
           {"Cuenta", Mayor.Cuenta},
           {"Tipo_aux", Mayor.Tipo_aux},
           {"Id_auxiliar", Mayor.Id_auxiliar},
           {"Dv", Mayor.Dv},
           {"Saldo", Mayor.Saldo},
           {"Debitos", Mayor.Debitos},
           {"Creditos", Mayor.Creditos},
           {"Cod_empresa", Mayor.Cod_empresa},
           {"Año", Mayor.Año}
         };
         return Data.EjecutarSPEscalar("{CALL sp_Nuevo_Mayor(?, ?, ?, ?, ?, ?, ?, ?, ?)}", Parametros);
      }
 }
}
