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
 public class N_Monedas
 {
     M_Monedas C_Monedas = new M_Monedas();
     ClsDatos Data = new ClsDatos();
     public bool Existe(int Cod_moneda, bool CargarDatos)
     {
         DataTable DT = new DataTable();
         DT = Data.ConsultaT("SELECT * FROM Monedas WHERE Cod_moneda= " + Cod_moneda);
         bool ExisteRegistro = false;
         if (DT.Rows.Count > 0)
         {
             ExisteRegistro = true;
             if (CargarDatos)
             {
                 C_Monedas.Cod_moneda= Convert.ToInt32(DT.Rows[0]["Cod_moneda"]);
                 C_Monedas.Nombre_moneda= DT.Rows[0]["Nombre_moneda"].ToString();
                 C_Monedas.Cod_empresa= Convert.ToInt32(DT.Rows[0]["Cod_empresa"]);
             }
         }
         return ExisteRegistro;
     }
     public M_Monedas Consultar(int Cod_moneda)
     {
         if (Existe(Cod_moneda, true))
         {
             return C_Monedas;
         }
         else
         {
             return null;
         }
     }
     public DataTable Consultar()
     {
         return Data.ConsultaT("SELECT * FROM Monedas");
     }
     public long Insertar(M_Monedas Monedas)
     {
         return Data.Accion("INSERT INTO Monedas (Cod_moneda,Nombre_moneda,Cod_empresa) VALUES (" + Monedas.Cod_moneda + ", '" + Monedas.Nombre_moneda + "'" + "," + Monedas.Cod_empresa + ");");
      }
     public long Actualizar(M_Monedas Monedas)
     {
         return Data.Accion("UPDATE Monedas SET Cod_moneda=" + Monedas.Cod_moneda + ",Nombre_moneda='"+Monedas.Nombre_moneda + "'" + ",Cod_empresa=" + Monedas.Cod_empresa + " WHERE Cod_moneda= " + Monedas.Cod_moneda + ";");
      }
     public long Nuevo(M_Monedas Monedas)
     {
         Dictionary<string, object> Parametros = new Dictionary<string, object>
         {
           {"Cod_moneda", Monedas.Cod_moneda},
           {"Nombre_moneda", Monedas.Nombre_moneda},
           {"Cod_empresa", Monedas.Cod_empresa}
         };
         return Data.EjecutarSPEscalar("{CALL sp_Nuevo_Monedas(?, ?, ?)}", Parametros);
      }
 }
}
