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
 public class N_Periodos_contables
 {
     M_Periodos_contables C_Periodos_contables = new M_Periodos_contables();
     ClsDatos Data = new ClsDatos();
     public bool Existe(int Periodo_contable, bool CargarDatos)
     {
         DataTable DT = new DataTable();
         DT = Data.ConsultaT("SELECT * FROM Periodos_contables WHERE Periodo_contable= " + Periodo_contable);
         bool ExisteRegistro = false;
         if (DT.Rows.Count > 0)
         {
             ExisteRegistro = true;
             if (CargarDatos)
             {
                 C_Periodos_contables.Periodo_contable= Convert.ToInt32(DT.Rows[0]["Periodo_contable"]);
                 C_Periodos_contables.Descripcion_periodo= DT.Rows[0]["Descripcion_periodo"].ToString();
             }
         }
         return ExisteRegistro;
     }
     public M_Periodos_contables Consultar(int Periodo_contable)
     {
         if (Existe(Periodo_contable, true))
         {
             return C_Periodos_contables;
         }
         else
         {
             return null;
         }
     }
     public DataTable Consultar()
     {
         return Data.ConsultaT("SELECT * FROM Periodos_contables");
     }
     public long Insertar(M_Periodos_contables Periodos_contables)
     {
         return Data.Accion("INSERT INTO Periodos_contables (Periodo_contable,Descripcion_periodo) VALUES (" + Periodos_contables.Periodo_contable + ", '" + Periodos_contables.Descripcion_periodo + "'" + ");");
      }
     public long Actualizar(M_Periodos_contables Periodos_contables)
     {
         return Data.Accion("UPDATE Periodos_contables SET Periodo_contable=" + Periodos_contables.Periodo_contable + ",Descripcion_periodo='"+Periodos_contables.Descripcion_periodo + "'" + " WHERE Periodo_contable= " + Periodos_contables.Periodo_contable + ";");
      }
     public long Nuevo(M_Periodos_contables Periodos_contables)
     {
         Dictionary<string, object> Parametros = new Dictionary<string, object>
         {
           {"Periodo_contable", Periodos_contables.Periodo_contable},
           {"Descripcion_periodo", Periodos_contables.Descripcion_periodo}
         };
         return Data.EjecutarSPEscalar("{CALL sp_Nuevo_Periodos_contables(?, ?)}", Parametros);
      }
 }
}
