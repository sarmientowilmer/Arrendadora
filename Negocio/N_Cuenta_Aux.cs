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
 public class N_Cuenta_Aux
 {
     M_Cuenta_Aux C_Cuenta_Aux = new M_Cuenta_Aux();
     ClsDatos Data = new ClsDatos();
     public bool Existe(string Cuenta, string Tipo_aux, bool CargarDatos)
     {
         DataTable DT = new DataTable();
         DT = Data.ConsultaT("SELECT * FROM Cuenta_Aux WHERE Cuenta='" + Cuenta + "'" + " and Tipo_aux='" + Tipo_aux + "'");
         bool ExisteRegistro = false;
         if (DT.Rows.Count > 0)
         {
             ExisteRegistro = true;
             if (CargarDatos)
             {
                 C_Cuenta_Aux.Cuenta= DT.Rows[0]["Cuenta"].ToString();
                 C_Cuenta_Aux.Tipo_aux= DT.Rows[0]["Tipo_aux"].ToString();
                 C_Cuenta_Aux.Cod_empresa= Convert.ToInt32(DT.Rows[0]["Cod_empresa"]);
             }
         }
         return ExisteRegistro;
     }
     public M_Cuenta_Aux Consultar(string Cuenta, string Tipo_aux)
     {
         if (Existe(Cuenta, Tipo_aux, true))
         {
             return C_Cuenta_Aux;
         }
         else
         {
             return null;
         }
     }
     public DataTable Consultar()
     {
         return Data.ConsultaT("SELECT * FROM Cuenta_Aux");
     }
     public long Insertar(M_Cuenta_Aux Cuenta_Aux)
     {
         return Data.Accion("INSERT INTO Cuenta_Aux (Cuenta,Tipo_aux,Cod_empresa) VALUES (" + "'" + Cuenta_Aux.Cuenta+"'" + ", '" + Cuenta_Aux.Tipo_aux + "'" + "," + Cuenta_Aux.Cod_empresa + ");");
      }
     public long Actualizar(M_Cuenta_Aux Cuenta_Aux)
     {
         return Data.Accion("UPDATE Cuenta_Aux SET Cuenta='" + Cuenta_Aux.Cuenta + "'" + ",Tipo_aux='"+Cuenta_Aux.Tipo_aux + "'" + ",Cod_empresa=" + Cuenta_Aux.Cod_empresa + " WHERE Cuenta='" + Cuenta_Aux.Cuenta + "'" + " and Tipo_aux='" + Cuenta_Aux.Tipo_aux + "'" + ";");
      }
     public long Nuevo(M_Cuenta_Aux Cuenta_Aux)
     {
         Dictionary<string, object> Parametros = new Dictionary<string, object>
         {
           {"Cuenta", Cuenta_Aux.Cuenta},
           {"Tipo_aux", Cuenta_Aux.Tipo_aux},
           {"Cod_empresa", Cuenta_Aux.Cod_empresa}
         };
         return Data.EjecutarSPEscalar("{CALL sp_Nuevo_Cuenta_Aux(?, ?, ?)}", Parametros);
      }
 }
}
