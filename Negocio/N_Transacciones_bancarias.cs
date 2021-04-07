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
 public class N_Transacciones_bancarias
 {
     M_Transacciones_bancarias C_Transacciones_bancarias = new M_Transacciones_bancarias();
     ClsDatos Data = new ClsDatos();
     public bool Existe(int Cod_trans, bool CargarDatos)
     {
         DataTable DT = new DataTable();
         DT = Data.ConsultaT("SELECT * FROM transacciones_bancarias WHERE Cod_trans= " + Cod_trans);
         bool ExisteRegistro = false;
         if (DT.Rows.Count > 0)
         {
             ExisteRegistro = true;
             if (CargarDatos)
             {
                 C_Transacciones_bancarias.Cod_trans= Convert.ToInt32(DT.Rows[0]["Cod_trans"]);
                 C_Transacciones_bancarias.Nombre_trans= DT.Rows[0]["Nombre_trans"].ToString();
                 C_Transacciones_bancarias.Operador_saldo= DT.Rows[0]["Operador_saldo"].ToString();
                 C_Transacciones_bancarias.Cod_empresa= Convert.ToInt32(DT.Rows[0]["Cod_empresa"]);
             }
         }
         return ExisteRegistro;
     }
     public M_Transacciones_bancarias Consultar(int Cod_trans)
     {
         if (Existe(Cod_trans, true))
         {
             return C_Transacciones_bancarias;
         }
         else
         {
             return null;
         }
     }
     public DataTable Consultar()
     {
         return Data.ConsultaT("SELECT * FROM transacciones_bancarias");
     }
     public long Insertar(M_Transacciones_bancarias Transacciones_bancarias)
     {
         return Data.Accion("INSERT INTO transacciones_bancarias (Cod_trans,Nombre_trans,Operador_saldo,Cod_empresa) VALUES (" + Transacciones_bancarias.Cod_trans + ", '" + Transacciones_bancarias.Nombre_trans + "'" + ", '" + Transacciones_bancarias.Operador_saldo + "'" + "," + Transacciones_bancarias.Cod_empresa + ");");
      }
     public long Actualizar(M_Transacciones_bancarias Transacciones_bancarias)
     {
         return Data.Accion("UPDATE transacciones_bancarias SET Cod_trans=" + Transacciones_bancarias.Cod_trans + ",Nombre_trans='"+Transacciones_bancarias.Nombre_trans + "'" + ",Operador_saldo='"+Transacciones_bancarias.Operador_saldo + "'" + ",Cod_empresa=" + Transacciones_bancarias.Cod_empresa + " WHERE Cod_trans= " + Transacciones_bancarias.Cod_trans + ";");
      }
     public long Nuevo(M_Transacciones_bancarias Transacciones_bancarias)
     {
         Dictionary<string, object> Parametros = new Dictionary<string, object>
         {
           {"Cod_trans", Transacciones_bancarias.Cod_trans},
           {"Nombre_trans", Transacciones_bancarias.Nombre_trans},
           {"Operador_saldo", Transacciones_bancarias.Operador_saldo},
           {"Cod_empresa", Transacciones_bancarias.Cod_empresa}
         };
         return Data.EjecutarSPEscalar("{CALL sp_Nuevo_transacciones_bancarias(?, ?, ?, ?)}", Parametros);
      }
 }
}
