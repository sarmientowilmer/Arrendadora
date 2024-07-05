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
 public class N_Conceptos
 {
     M_Conceptos C_Conceptos = new M_Conceptos();
     ClsDatos Data = new ClsDatos();
     public bool Existe(int Cod_concepto, bool CargarDatos)
     {
         DataTable DT = new DataTable();
         DT = Data.ConsultaT("SELECT * FROM Conceptos WHERE Cod_concepto= " + Cod_concepto);
         bool ExisteRegistro = false;
         if (DT.Rows.Count > 0)
         {
             ExisteRegistro = true;
             if (CargarDatos)
             {
                 C_Conceptos.Cod_concepto= Convert.ToInt32(DT.Rows[0]["Cod_concepto"]);
                 C_Conceptos.Descripcion_concepto= DT.Rows[0]["Descripcion_concepto"].ToString();
                 C_Conceptos.Cod_empresa= Convert.ToInt32(DT.Rows[0]["Cod_empresa"]);
                 C_Conceptos.Cuenta= DT.Rows[0]["Cuenta"].ToString();
                 C_Conceptos.Auxiliar= Convert.ToBoolean(DT.Rows[0]["Auxiliar"]);
                 C_Conceptos.Empresa= Convert.ToBoolean(DT.Rows[0]["Empresa"]);
                 C_Conceptos.Tipo_mov= DT.Rows[0]["Tipo_mov"].ToString();
                 C_Conceptos.Permite= Convert.ToByte(DT.Rows[0]["Permite"]);
             }
         }
         return ExisteRegistro;
     }
     public M_Conceptos Consultar(int Cod_concepto)
     {
         if (Existe(Cod_concepto, true))
         {
             return C_Conceptos;
         }
         else
         {
             return null;
         }
     }
     public DataTable Consultar()
     {
         return Data.ConsultaT("SELECT * FROM Conceptos");
     }
     public long Insertar(M_Conceptos Conceptos)
     {
         return Data.Accion("INSERT INTO Conceptos (Cod_concepto,Descripcion_concepto,Cod_empresa,Cuenta,Auxiliar,Empresa,Tipo_mov,Permite) VALUES (" + Conceptos.Cod_concepto + ", '" + Conceptos.Descripcion_concepto + "'" + "," + Conceptos.Cod_empresa + ", '" + Conceptos.Cuenta + "'" + "," + Conceptos.Auxiliar + "," + Conceptos.Empresa + ", '" + Conceptos.Tipo_mov + "'" + "," + Conceptos.Permite + ");");
      }
     public long Actualizar(M_Conceptos Conceptos)
     {
         return Data.Accion("UPDATE Conceptos SET Cod_concepto=" + Conceptos.Cod_concepto + ",Descripcion_concepto='"+Conceptos.Descripcion_concepto + "'" + ",Cod_empresa=" + Conceptos.Cod_empresa + ",Cuenta='"+Conceptos.Cuenta + "'" + ",Auxiliar=" + Conceptos.Auxiliar + ",Empresa=" + Conceptos.Empresa + ",Tipo_mov='"+Conceptos.Tipo_mov + "'" + ",Permite=" + Conceptos.Permite + " WHERE Cod_concepto= " + Conceptos.Cod_concepto + ";");
      }
     public long Nuevo(M_Conceptos Conceptos)
     {
         Dictionary<string, object> Parametros = new Dictionary<string, object>
         {
           {"Cod_concepto", Conceptos.Cod_concepto},
           {"Descripcion_concepto", Conceptos.Descripcion_concepto},
           {"Cod_empresa", Conceptos.Cod_empresa},
           {"Cuenta", Conceptos.Cuenta},
           {"Auxiliar", Conceptos.Auxiliar},
           {"Empresa", Conceptos.Empresa},
           {"Tipo_mov", Conceptos.Tipo_mov},
           {"Permite", Conceptos.Permite}
         };
         return Data.EjecutarSPEscalar("{CALL sp_Nuevo_Conceptos(?, ?, ?, ?, ?, ?, ?, ?)}", Parametros);
      }
 }
}
