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
 public class N_Cod_Inventario
 {
     M_Cod_Inventario C_Cod_Inventario = new M_Cod_Inventario();
     ClsDatos Data = new ClsDatos();
     public bool Existe(int Cod_inventario, bool CargarDatos)
     {
         DataTable DT = new DataTable();
         DT = Data.ConsultaT("SELECT * FROM Cod_Inventario WHERE Cod_inventario= " + Cod_inventario);
         bool ExisteRegistro = false;
         if (DT.Rows.Count > 0)
         {
             ExisteRegistro = true;
             if (CargarDatos)
             {
                 C_Cod_Inventario.Cod_inventario= Convert.ToInt32(DT.Rows[0]["Cod_inventario"]);
                 C_Cod_Inventario.Descripcion_cod= DT.Rows[0]["Descripcion_cod"].ToString();
                 C_Cod_Inventario.Cod_empresa= Convert.ToInt32(DT.Rows[0]["Cod_empresa"]);
             }
         }
         return ExisteRegistro;
     }
     public M_Cod_Inventario Consultar(int Cod_inventario)
     {
         if (Existe(Cod_inventario, true))
         {
             return C_Cod_Inventario;
         }
         else
         {
             return null;
         }
     }
     public DataTable Consultar()
     {
         return Data.ConsultaT("SELECT * FROM Cod_Inventario");
     }
     public long Insertar(M_Cod_Inventario Cod_Inventario)
     {
         return Data.Accion("INSERT INTO Cod_Inventario (Cod_inventario,Descripcion_cod,Cod_empresa) VALUES (" + Cod_Inventario.Cod_inventario + ", '" + Cod_Inventario.Descripcion_cod + "'" + "," + Cod_Inventario.Cod_empresa + ");");
      }
     public long Actualizar(M_Cod_Inventario Cod_Inventario)
     {
         return Data.Accion("UPDATE Cod_Inventario SET Cod_inventario=" + Cod_Inventario.Cod_inventario + ",Descripcion_cod='"+Cod_Inventario.Descripcion_cod + "'" + ",Cod_empresa=" + Cod_Inventario.Cod_empresa + " WHERE Cod_inventario= " + Cod_Inventario.Cod_inventario + ";");
      }
     public long Nuevo(M_Cod_Inventario Cod_Inventario)
     {
         Dictionary<string, object> Parametros = new Dictionary<string, object>
         {
           {"Cod_inventario", Cod_Inventario.Cod_inventario},
           {"Descripcion_cod", Cod_Inventario.Descripcion_cod},
           {"Cod_empresa", Cod_Inventario.Cod_empresa}
         };
         return Data.EjecutarSPEscalar("{CALL sp_Nuevo_Cod_Inventario(?, ?, ?)}", Parametros);
      }
 }
}
