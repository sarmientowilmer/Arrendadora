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
    public class N_Papeleria : N_General
    {
        M_Papeleria C_Papeleria = new M_Papeleria();
        //ClsDatos Data = new ClsDatos();
        public bool Existe(string Tipo_comp, bool CargarDatos)
        {
            DataTable DT = new DataTable();
            DT = Data.ConsultaT("SELECT * FROM Papeleria WHERE Tipo_comp='" + Tipo_comp + "'");
            bool ExisteRegistro = false;
            if (DT.Rows.Count > 0)
            {
                ExisteRegistro = true;
                if (CargarDatos)
                {
                    C_Papeleria.Tipo_comp = DT.Rows[0]["Tipo_comp"].ToString();
                    C_Papeleria.Consecutivo = Convert.ToInt32(DT.Rows[0]["Consecutivo"]);
                    C_Papeleria.Cod_empresa = Convert.ToInt32(DT.Rows[0]["Cod_empresa"]);
                }
            }
            return ExisteRegistro;
        }
        public M_Papeleria Consultar(string Tipo_comp)
        {
            if (Existe(Tipo_comp, true))
            {
                return C_Papeleria;
            }
            else
            {
                return null;
            }
        }
        public DataTable Consultar()
        {
            return Data.ConsultaT("SELECT * FROM Papeleria");
        }
        public long Insertar(M_Papeleria Papeleria)
        {
            return Data.Accion("INSERT INTO Papeleria (Tipo_comp,Consecutivo,Cod_empresa) VALUES (" + "'" + Papeleria.Tipo_comp + "'" + "," + Papeleria.Consecutivo + "," + Papeleria.Cod_empresa + ");");
        }
        public long Actualizar(M_Papeleria Papeleria)
        {
            return Data.Accion("UPDATE Papeleria SET Tipo_comp='" + Papeleria.Tipo_comp + "'" + ",Consecutivo=" + Papeleria.Consecutivo + ",Cod_empresa=" + Papeleria.Cod_empresa + " WHERE Tipo_comp='" + Papeleria.Tipo_comp + "'" + ";");
        }

        public int AsignarConsecutivo(string Tipo_comp)
        {
            int Consec = 0;
            do
            {
                if (Existe(Tipo_comp, true))
                {
                    Consec = C_Papeleria.Consecutivo + 1;
                }
                else
                {
                    break;
                }
            } while ((Data.Accion("UPDATE papeleria SET consecutivo=" + Consec + " WHERE tipo_comp='" + Tipo_comp + "';") == -1));
            return Consec;
        }

        public long Nuevo(M_Papeleria Papeleria)
        {
            Dictionary<string, object> Parametros = new Dictionary<string, object>
         {
           {"Tipo_comp", Papeleria.Tipo_comp},
           {"Consecutivo", Papeleria.Consecutivo},
           {"Cod_empresa", Papeleria.Cod_empresa}
         };
            return Data.EjecutarSPEscalar("{CALL sp_Nuevo_Papeleria(?, ?, ?)}", Parametros);
        }
    }
}
