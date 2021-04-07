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
    public class N_Tipos_Comp:N_General
    {
        public M_Tipos_Comp C_Tipos_Comp = new M_Tipos_Comp();
        //ClsDatos Data = new ClsDatos();

        public bool Existe(string Tipo_comp, bool CargarDatos)
        {
            DataTable DT = new DataTable();
            DT = Data.ConsultaT("SELECT * FROM Tipos_Comp WHERE Tipo_comp='" + Tipo_comp + "'");
            bool ExisteRegistro = false;
            if (DT.Rows.Count > 0)
            {
                ExisteRegistro = true;
                if (CargarDatos)
                {
                    C_Tipos_Comp.Tipo_comp = DT.Rows[0]["Tipo_comp"].ToString();
                    C_Tipos_Comp.Nombre_comp = DT.Rows[0]["Nombre_comp"].ToString();
                    C_Tipos_Comp.Afecta = Convert.ToInt32(DT.Rows[0]["Afecta"]);
                    C_Tipos_Comp.Cod_empresa = Convert.ToInt32(DT.Rows[0]["Cod_empresa"]);
                    C_Tipos_Comp.Cod_concepto = Convert.ToInt32(DT.Rows[0]["Cod_concepto"]);
                    C_Tipos_Comp.Consecutivo = Convert.ToInt32(DT.Rows[0]["Consecutivo"]);
                }
            }
            return ExisteRegistro;
        }
        public M_Tipos_Comp Consultar(string Tipo_comp)
        {
            if (Existe(Tipo_comp, true))
            {
                return C_Tipos_Comp;
            }
            else
            {
                return null;
            }
        }
        public DataTable ConsultarXAfecta(string Cadena)
        {
            if (string.IsNullOrWhiteSpace(Cadena))
            {
                return Data.ConsultaT("SELECT * FROM Tipos_Comp");
            }
            else
            {
                return Data.ConsultaT("SELECT * FROM Tipos_Comp WHERE afecta=" +Cadena);
            }
            
        }
        public long Insertar(M_Tipos_Comp Tipos_Comp)
        {
            return Data.Accion("INSERT INTO Tipos_Comp (Tipo_comp,Nombre_comp,Afecta,Cod_empresa,Cod_concepto,Consecutivo) VALUES (" + "'" + Tipos_Comp.Tipo_comp + "'" + ", '" + Tipos_Comp.Nombre_comp + "'" + "," + Tipos_Comp.Afecta + "," + Tipos_Comp.Cod_empresa + "," + Tipos_Comp.Cod_concepto + "," + Tipos_Comp.Consecutivo + ");");
        }
        public long Actualizar(M_Tipos_Comp Tipos_Comp)
        {
            return Data.Accion("UPDATE Tipos_Comp SET Tipo_comp='" + Tipos_Comp.Tipo_comp + "'" + ",Nombre_comp='" + Tipos_Comp.Nombre_comp + "'" + ",Afecta=" + Tipos_Comp.Afecta + ",Cod_empresa=" + Tipos_Comp.Cod_empresa + ",Cod_concepto=" + Tipos_Comp.Cod_concepto + ",Consecutivo=" + Tipos_Comp.Consecutivo + " WHERE Tipo_comp='" + Tipos_Comp.Tipo_comp + "'" + ";");
        }
        public long Nuevo(M_Tipos_Comp Tipos_Comp)
        {
            Dictionary<string, object> Parametros = new Dictionary<string, object>
         {
           {"Tipo_comp", Tipos_Comp.Tipo_comp},
           {"Nombre_comp", Tipos_Comp.Nombre_comp},
           {"Afecta", Tipos_Comp.Afecta},
           {"Cod_empresa", Tipos_Comp.Cod_empresa},
           {"Cod_concepto", Tipos_Comp.Cod_concepto},
           {"Consecutivo", Tipos_Comp.Consecutivo}
         };
            return Data.EjecutarSPEscalar("{CALL sp_Nuevo_Tipos_Comp(?, ?, ?, ?, ?, ?)}", Parametros);
        }
    }
}
