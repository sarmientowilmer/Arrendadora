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
 public class N_Detalle_conciliacion
 {
     M_Detalle_conciliacion C_Detalle_conciliacion = new M_Detalle_conciliacion();
     ClsDatos Data = new ClsDatos();
     public bool Existe(int No_conc, int Item, bool CargarDatos)
     {
         DataTable DT = new DataTable();
         DT = Data.ConsultaT("SELECT * FROM Detalle_conciliacion WHERE No_conc= " + No_conc + " and Item=" + Item);
         bool ExisteRegistro = false;
         if (DT.Rows.Count > 0)
         {
             ExisteRegistro = true;
             if (CargarDatos)
             {
                 C_Detalle_conciliacion.No_conc= Convert.ToInt32(DT.Rows[0]["No_conc"]);
                 C_Detalle_conciliacion.Descripcion= DT.Rows[0]["Descripcion"].ToString();
                 C_Detalle_conciliacion.Item= Convert.ToInt32(DT.Rows[0]["Item"]);
                 C_Detalle_conciliacion.Op_saldo= DT.Rows[0]["Op_saldo"].ToString();
                 C_Detalle_conciliacion.Valor_trans= Convert.ToDouble(DT.Rows[0]["Valor_trans"]);
                 C_Detalle_conciliacion.Cod_empresa= Convert.ToInt32(DT.Rows[0]["Cod_empresa"]);
             }
         }
         return ExisteRegistro;
     }
     public M_Detalle_conciliacion Consultar(int No_conc, int Item)
     {
         if (Existe(No_conc, Item, true))
         {
             return C_Detalle_conciliacion;
         }
         else
         {
             return null;
         }
     }
     public DataTable Consultar()
     {
         return Data.ConsultaT("SELECT * FROM Detalle_conciliacion");
     }
     public long Insertar(M_Detalle_conciliacion Detalle_conciliacion)
     {
         return Data.Accion("INSERT INTO Detalle_conciliacion (No_conc,Descripcion,Item,Op_saldo,Valor_trans,Cod_empresa) VALUES (" + Detalle_conciliacion.No_conc + ", '" + Detalle_conciliacion.Descripcion + "'" + "," + Detalle_conciliacion.Item + ", '" + Detalle_conciliacion.Op_saldo + "'" + "," + Detalle_conciliacion.Valor_trans + "," + Detalle_conciliacion.Cod_empresa + ");");
      }
     public long Actualizar(M_Detalle_conciliacion Detalle_conciliacion)
     {
         return Data.Accion("UPDATE Detalle_conciliacion SET No_conc=" + Detalle_conciliacion.No_conc + ",Descripcion='"+Detalle_conciliacion.Descripcion + "'" + ",Item=" + Detalle_conciliacion.Item + ",Op_saldo='"+Detalle_conciliacion.Op_saldo + "'" + ",Valor_trans=" + Detalle_conciliacion.Valor_trans + ",Cod_empresa=" + Detalle_conciliacion.Cod_empresa + " WHERE No_conc= " + Detalle_conciliacion.No_conc + " and Item=" + Detalle_conciliacion.Item + ";");
      }
     public long Nuevo(M_Detalle_conciliacion Detalle_conciliacion)
     {
         Dictionary<string, object> Parametros = new Dictionary<string, object>
         {
           {"No_conc", Detalle_conciliacion.No_conc},
           {"Descripcion", Detalle_conciliacion.Descripcion},
           {"Item", Detalle_conciliacion.Item},
           {"Op_saldo", Detalle_conciliacion.Op_saldo},
           {"Valor_trans", Detalle_conciliacion.Valor_trans},
           {"Cod_empresa", Detalle_conciliacion.Cod_empresa}
         };
         return Data.EjecutarSPEscalar("{CALL sp_Nuevo_Detalle_conciliacion(?, ?, ?, ?, ?, ?)}", Parametros);
      }
 }
}
