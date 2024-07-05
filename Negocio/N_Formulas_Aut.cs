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
 public class N_Formulas_Aut
 {
     M_Formulas_Aut C_Formulas_Aut = new M_Formulas_Aut();
     ClsDatos Data = new ClsDatos();
     public bool Existe(string Nombre_formula, bool CargarDatos)
     {
         DataTable DT = new DataTable();
         DT = Data.ConsultaT("SELECT * FROM Formulas_Aut WHERE Nombre_formula='" + Nombre_formula + "'");
         bool ExisteRegistro = false;
         if (DT.Rows.Count > 0)
         {
             ExisteRegistro = true;
             if (CargarDatos)
             {
                 C_Formulas_Aut.Nombre_formula= DT.Rows[0]["Nombre_formula"].ToString();
                 C_Formulas_Aut.Descripcion_formula= DT.Rows[0]["Descripcion_formula"].ToString();
             }
         }
         return ExisteRegistro;
     }
     public M_Formulas_Aut Consultar(string Nombre_formula)
     {
         if (Existe(Nombre_formula, true))
         {
             return C_Formulas_Aut;
         }
         else
         {
             return null;
         }
     }
     public DataTable Consultar()
     {
         return Data.ConsultaT("SELECT * FROM Formulas_Aut");
     }
     public long Insertar(M_Formulas_Aut Formulas_Aut)
     {
         return Data.Accion("INSERT INTO Formulas_Aut (Nombre_formula,Descripcion_formula) VALUES (" + "'" + Formulas_Aut.Nombre_formula+"'" + ", '" + Formulas_Aut.Descripcion_formula + "'" + ");");
      }
     public long Actualizar(M_Formulas_Aut Formulas_Aut)
     {
         return Data.Accion("UPDATE Formulas_Aut SET Nombre_formula='" + Formulas_Aut.Nombre_formula + "'" + ",Descripcion_formula='"+Formulas_Aut.Descripcion_formula + "'" + " WHERE Nombre_formula='" + Formulas_Aut.Nombre_formula + "'" + ";");
      }
     public long Nuevo(M_Formulas_Aut Formulas_Aut)
     {
         Dictionary<string, object> Parametros = new Dictionary<string, object>
         {
           {"Nombre_formula", Formulas_Aut.Nombre_formula},
           {"Descripcion_formula", Formulas_Aut.Descripcion_formula}
         };
         return Data.EjecutarSPEscalar("{CALL sp_Nuevo_Formulas_Aut(?, ?)}", Parametros);
      }
 }
}
