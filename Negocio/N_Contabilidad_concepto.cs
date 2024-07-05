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
 public class N_Contabilidad_concepto
 {
     M_Contabilidad_concepto C_Contabilidad_concepto = new M_Contabilidad_concepto();
     ClsDatos Data = new ClsDatos();
     public bool Existe(int Cod_concepto, int Item, bool CargarDatos)
     {
         DataTable DT = new DataTable();
         DT = Data.ConsultaT("SELECT * FROM Contabilidad_concepto WHERE Cod_concepto= " + Cod_concepto + " and Item=" + Item);
         bool ExisteRegistro = false;
         if (DT.Rows.Count > 0)
         {
             ExisteRegistro = true;
             if (CargarDatos)
             {
                 C_Contabilidad_concepto.Cod_concepto= Convert.ToInt32(DT.Rows[0]["Cod_concepto"]);
                 C_Contabilidad_concepto.Item= Convert.ToInt32(DT.Rows[0]["Item"]);
                 C_Contabilidad_concepto.Cuenta= DT.Rows[0]["Cuenta"].ToString();
                 C_Contabilidad_concepto.Tipo_aux= DT.Rows[0]["Tipo_aux"].ToString();
                 C_Contabilidad_concepto.Id_auxiliar= Convert.ToDouble(DT.Rows[0]["Id_auxiliar"]);
                 C_Contabilidad_concepto.Tipo_mov= DT.Rows[0]["Tipo_mov"].ToString();
                 C_Contabilidad_concepto.Valor_aplica= DT.Rows[0]["Valor_aplica"].ToString();
                 C_Contabilidad_concepto.Cod_empresa= Convert.ToInt32(DT.Rows[0]["Cod_empresa"]);
             }
         }
         return ExisteRegistro;
     }
     public M_Contabilidad_concepto Consultar(int Cod_concepto, int Item)
     {
         if (Existe(Cod_concepto, Item, true))
         {
             return C_Contabilidad_concepto;
         }
         else
         {
             return null;
         }
     }
     public DataTable Consultar()
     {
         return Data.ConsultaT("SELECT * FROM Contabilidad_concepto");
     }
     public long Insertar(M_Contabilidad_concepto Contabilidad_concepto)
     {
         return Data.Accion("INSERT INTO Contabilidad_concepto (Cod_concepto,Item,Cuenta,Tipo_aux,Id_auxiliar,Tipo_mov,Valor_aplica,Cod_empresa) VALUES (" + Contabilidad_concepto.Cod_concepto + "," + Contabilidad_concepto.Item + ", '" + Contabilidad_concepto.Cuenta + "'" + ", '" + Contabilidad_concepto.Tipo_aux + "'" + "," + Contabilidad_concepto.Id_auxiliar + ", '" + Contabilidad_concepto.Tipo_mov + "'" + ", '" + Contabilidad_concepto.Valor_aplica + "'" + "," + Contabilidad_concepto.Cod_empresa + ");");
      }
     public long Actualizar(M_Contabilidad_concepto Contabilidad_concepto)
     {
         return Data.Accion("UPDATE Contabilidad_concepto SET Cod_concepto=" + Contabilidad_concepto.Cod_concepto + ",Item=" + Contabilidad_concepto.Item + ",Cuenta='"+Contabilidad_concepto.Cuenta + "'" + ",Tipo_aux='"+Contabilidad_concepto.Tipo_aux + "'" + ",Id_auxiliar=" + Contabilidad_concepto.Id_auxiliar + ",Tipo_mov='"+Contabilidad_concepto.Tipo_mov + "'" + ",Valor_aplica='"+Contabilidad_concepto.Valor_aplica + "'" + ",Cod_empresa=" + Contabilidad_concepto.Cod_empresa + " WHERE Cod_concepto= " + Contabilidad_concepto.Cod_concepto + " and Item=" + Contabilidad_concepto.Item + ";");
      }
     public long Nuevo(M_Contabilidad_concepto Contabilidad_concepto)
     {
         Dictionary<string, object> Parametros = new Dictionary<string, object>
         {
           {"Cod_concepto", Contabilidad_concepto.Cod_concepto},
           {"Item", Contabilidad_concepto.Item},
           {"Cuenta", Contabilidad_concepto.Cuenta},
           {"Tipo_aux", Contabilidad_concepto.Tipo_aux},
           {"Id_auxiliar", Contabilidad_concepto.Id_auxiliar},
           {"Tipo_mov", Contabilidad_concepto.Tipo_mov},
           {"Valor_aplica", Contabilidad_concepto.Valor_aplica},
           {"Cod_empresa", Contabilidad_concepto.Cod_empresa}
         };
         return Data.EjecutarSPEscalar("{CALL sp_Nuevo_Contabilidad_concepto(?, ?, ?, ?, ?, ?, ?, ?)}", Parametros);
      }
 }
}
