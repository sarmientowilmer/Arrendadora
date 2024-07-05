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
 public class N_Descuentos
 {
     M_Descuentos C_Descuentos = new M_Descuentos();
     ClsDatos Data = new ClsDatos();
     public bool Existe(int Cod_descuento, bool CargarDatos)
     {
         DataTable DT = new DataTable();
         DT = Data.ConsultaT("SELECT * FROM Descuentos WHERE Cod_descuento= " + Cod_descuento);
         bool ExisteRegistro = false;
         if (DT.Rows.Count > 0)
         {
             ExisteRegistro = true;
             if (CargarDatos)
             {
                 C_Descuentos.Cod_descuento= Convert.ToInt32(DT.Rows[0]["Cod_descuento"]);
                 C_Descuentos.Nombre_desc= DT.Rows[0]["Nombre_desc"].ToString();
                 C_Descuentos.Afecta= Convert.ToInt32(DT.Rows[0]["Afecta"]);
                 C_Descuentos.Saldo= Convert.ToBoolean(DT.Rows[0]["Saldo"]);
                 C_Descuentos.Cod_empresa= Convert.ToInt32(DT.Rows[0]["Cod_empresa"]);
             }
         }
         return ExisteRegistro;
     }
     public M_Descuentos Consultar(int Cod_descuento)
     {
         if (Existe(Cod_descuento, true))
         {
             return C_Descuentos;
         }
         else
         {
             return null;
         }
     }
     public DataTable Consultar()
     {
         return Data.ConsultaT("SELECT * FROM Descuentos");
     }
     public long Insertar(M_Descuentos Descuentos)
     {
         return Data.Accion("INSERT INTO Descuentos (Cod_descuento,Nombre_desc,Afecta,Saldo,Cod_empresa) VALUES (" + Descuentos.Cod_descuento + ", '" + Descuentos.Nombre_desc + "'" + "," + Descuentos.Afecta + "," + Descuentos.Saldo + "," + Descuentos.Cod_empresa + ");");
      }
     public long Actualizar(M_Descuentos Descuentos)
     {
         return Data.Accion("UPDATE Descuentos SET Cod_descuento=" + Descuentos.Cod_descuento + ",Nombre_desc='"+Descuentos.Nombre_desc + "'" + ",Afecta=" + Descuentos.Afecta + ",Saldo=" + Descuentos.Saldo + ",Cod_empresa=" + Descuentos.Cod_empresa + " WHERE Cod_descuento= " + Descuentos.Cod_descuento + ";");
      }
     public long Nuevo(M_Descuentos Descuentos)
     {
         Dictionary<string, object> Parametros = new Dictionary<string, object>
         {
           {"Cod_descuento", Descuentos.Cod_descuento},
           {"Nombre_desc", Descuentos.Nombre_desc},
           {"Afecta", Descuentos.Afecta},
           {"Saldo", Descuentos.Saldo},
           {"Cod_empresa", Descuentos.Cod_empresa}
         };
         return Data.EjecutarSPEscalar("{CALL sp_Nuevo_Descuentos(?, ?, ?, ?, ?)}", Parametros);
      }
 }
}
