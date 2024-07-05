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
 public class N_Cuadre_diario
 {
     M_Cuadre_diario C_Cuadre_diario = new M_Cuadre_diario();
     ClsDatos Data = new ClsDatos();
     public bool Existe(DateTime Fecha_cuadre, int Item, bool CargarDatos)
     {
         DataTable DT = new DataTable();
         DT = Data.ConsultaT("SELECT * FROM Cuadre_diario WHERE Fecha_cuadre= " + Fecha_cuadre + " and Item=" + Item);
         bool ExisteRegistro = false;
         if (DT.Rows.Count > 0)
         {
             ExisteRegistro = true;
             if (CargarDatos)
             {
                 C_Cuadre_diario.Fecha_cuadre= Convert.ToDateTime(DT.Rows[0]["Fecha_cuadre"]);
                 C_Cuadre_diario.Item= Convert.ToInt32(DT.Rows[0]["Item"]);
                 C_Cuadre_diario.Concepto= DT.Rows[0]["Concepto"].ToString();
                 C_Cuadre_diario.Valor1= Convert.ToDouble(DT.Rows[0]["Valor1"]);
                 C_Cuadre_diario.Valor2= Convert.ToDouble(DT.Rows[0]["Valor2"]);
                 C_Cuadre_diario.Valor3= Convert.ToDouble(DT.Rows[0]["Valor3"]);
                 C_Cuadre_diario.Valor4= Convert.ToDouble(DT.Rows[0]["Valor4"]);
                 C_Cuadre_diario.Empresa= Convert.ToInt32(DT.Rows[0]["Empresa"]);
                 C_Cuadre_diario.Valor5= Convert.ToDouble(DT.Rows[0]["Valor5"]);
             }
         }
         return ExisteRegistro;
     }
     public M_Cuadre_diario Consultar(DateTime Fecha_cuadre, int Item)
     {
         if (Existe(Fecha_cuadre, Item, true))
         {
             return C_Cuadre_diario;
         }
         else
         {
             return null;
         }
     }
     public DataTable Consultar()
     {
         return Data.ConsultaT("SELECT * FROM Cuadre_diario");
     }
     public long Insertar(M_Cuadre_diario Cuadre_diario)
     {
         return Data.Accion("INSERT INTO Cuadre_diario (Fecha_cuadre,Item,Concepto,Valor1,Valor2,Valor3,Valor4,Empresa,Valor5) VALUES (" + Cuadre_diario.Fecha_cuadre + "," + Cuadre_diario.Item + ", '" + Cuadre_diario.Concepto + "'" + "," + Cuadre_diario.Valor1 + "," + Cuadre_diario.Valor2 + "," + Cuadre_diario.Valor3 + "," + Cuadre_diario.Valor4 + "," + Cuadre_diario.Empresa + "," + Cuadre_diario.Valor5 + ");");
      }
     public long Actualizar(M_Cuadre_diario Cuadre_diario)
     {
         return Data.Accion("UPDATE Cuadre_diario SET Fecha_cuadre=" + Cuadre_diario.Fecha_cuadre + ",Item=" + Cuadre_diario.Item + ",Concepto='"+Cuadre_diario.Concepto + "'" + ",Valor1=" + Cuadre_diario.Valor1 + ",Valor2=" + Cuadre_diario.Valor2 + ",Valor3=" + Cuadre_diario.Valor3 + ",Valor4=" + Cuadre_diario.Valor4 + ",Empresa=" + Cuadre_diario.Empresa + ",Valor5=" + Cuadre_diario.Valor5 + " WHERE Fecha_cuadre= " + Cuadre_diario.Fecha_cuadre + " and Item=" + Cuadre_diario.Item + ";");
      }
     public long Nuevo(M_Cuadre_diario Cuadre_diario)
     {
         Dictionary<string, object> Parametros = new Dictionary<string, object>
         {
           {"Fecha_cuadre", Cuadre_diario.Fecha_cuadre},
           {"Item", Cuadre_diario.Item},
           {"Concepto", Cuadre_diario.Concepto},
           {"Valor1", Cuadre_diario.Valor1},
           {"Valor2", Cuadre_diario.Valor2},
           {"Valor3", Cuadre_diario.Valor3},
           {"Valor4", Cuadre_diario.Valor4},
           {"Empresa", Cuadre_diario.Empresa},
           {"Valor5", Cuadre_diario.Valor5}
         };
         return Data.EjecutarSPEscalar("{CALL sp_Nuevo_Cuadre_diario(?, ?, ?, ?, ?, ?, ?, ?, ?)}", Parametros);
      }
 }
}
