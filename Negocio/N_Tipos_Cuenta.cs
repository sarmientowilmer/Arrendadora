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
 public class N_Tipos_Cuenta
 {
     M_Tipos_Cuenta C_Tipos_Cuenta = new M_Tipos_Cuenta();
     ClsDatos Data = new ClsDatos();
     public bool Existe(string Tipo_cuenta, bool CargarDatos)
     {
         DataTable DT = new DataTable();
         DT = Data.ConsultaT("SELECT * FROM Tipos_Cuenta WHERE Tipo_cuenta='" + Tipo_cuenta + "'");
         bool ExisteRegistro = false;
         if (DT.Rows.Count > 0)
         {
             ExisteRegistro = true;
             if (CargarDatos)
             {
                 C_Tipos_Cuenta.Tipo_cuenta= DT.Rows[0]["Tipo_cuenta"].ToString();
                 C_Tipos_Cuenta.Nombre_tipo= DT.Rows[0]["Nombre_tipo"].ToString();
                 C_Tipos_Cuenta.Cod_empresa= Convert.ToInt32(DT.Rows[0]["Cod_empresa"]);
             }
         }
         return ExisteRegistro;
     }
     public M_Tipos_Cuenta Consultar(string Tipo_cuenta)
     {
         if (Existe(Tipo_cuenta, true))
         {
             return C_Tipos_Cuenta;
         }
         else
         {
             return null;
         }
     }
     public DataTable Consultar()
     {
         return Data.ConsultaT("SELECT * FROM Tipos_Cuenta");
     }
     public long Insertar(M_Tipos_Cuenta Tipos_Cuenta)
     {
         return Data.Accion("INSERT INTO Tipos_Cuenta (Tipo_cuenta,Nombre_tipo,Cod_empresa) VALUES (" + "'" + Tipos_Cuenta.Tipo_cuenta+"'" + ", '" + Tipos_Cuenta.Nombre_tipo + "'" + "," + Tipos_Cuenta.Cod_empresa + ");");
      }
     public long Actualizar(M_Tipos_Cuenta Tipos_Cuenta)
     {
         return Data.Accion("UPDATE Tipos_Cuenta SET Tipo_cuenta='" + Tipos_Cuenta.Tipo_cuenta + "'" + ",Nombre_tipo='"+Tipos_Cuenta.Nombre_tipo + "'" + ",Cod_empresa=" + Tipos_Cuenta.Cod_empresa + " WHERE Tipo_cuenta='" + Tipos_Cuenta.Tipo_cuenta + "'" + ";");
      }
     public long Nuevo(M_Tipos_Cuenta Tipos_Cuenta)
     {
         Dictionary<string, object> Parametros = new Dictionary<string, object>
         {
           {"Tipo_cuenta", Tipos_Cuenta.Tipo_cuenta},
           {"Nombre_tipo", Tipos_Cuenta.Nombre_tipo},
           {"Cod_empresa", Tipos_Cuenta.Cod_empresa}
         };
         return Data.EjecutarSPEscalar("{CALL sp_Nuevo_Tipos_Cuenta(?, ?, ?)}", Parametros);
      }
 }
}
