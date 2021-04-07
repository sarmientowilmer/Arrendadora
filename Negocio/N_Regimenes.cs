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
    public class N_Regimenes : N_General
    {
        M_Regimenes C_Regimenes = new M_Regimenes();
        //ClsDatos Data = new ClsDatos();
        public bool Existe(int Regimen, bool CargarDatos)
        {
            DataTable DT = new DataTable();
            DT = Data.ConsultaT("SELECT * FROM Regimenes WHERE Regimen= " + Regimen);
            bool ExisteRegistro = false;
            if (DT.Rows.Count > 0)
            {
                ExisteRegistro = true;
                if (CargarDatos)
                {
                    C_Regimenes.Regimen = Convert.ToInt32(DT.Rows[0]["Regimen"]);
                    C_Regimenes.Descripcion_regimen = DT.Rows[0]["Descripcion_regimen"].ToString();
                    C_Regimenes.Cod_empresa = Convert.ToInt32(DT.Rows[0]["Cod_empresa"]);
                }
            }
            return ExisteRegistro;
        }
        public M_Regimenes Consultar(int Regimen)
        {
            if (Existe(Regimen, true))
            {
                return C_Regimenes;
            }
            else
            {
                return null;
            }
        }
        public DataTable Consultar()
        {
            return Data.ConsultaT("SELECT * FROM Regimenes");
        }
        public long Insertar(M_Regimenes Regimenes)
        {
            return Data.Accion("INSERT INTO Regimenes (Regimen,Descripcion_regimen,Cod_empresa) VALUES (" + Regimenes.Regimen + ", '" + Regimenes.Descripcion_regimen + "'" + "," + Regimenes.Cod_empresa + ");");
        }
        public long Actualizar(M_Regimenes Regimenes)
        {
            return Data.Accion("UPDATE Regimenes SET Regimen=" + Regimenes.Regimen + ",Descripcion_regimen='" + Regimenes.Descripcion_regimen + "'" + ",Cod_empresa=" + Regimenes.Cod_empresa + " WHERE Regimen= " + Regimenes.Regimen + ";");
        }
        public long Nuevo(M_Regimenes Regimenes)
        {
            Dictionary<string, object> Parametros = new Dictionary<string, object>
         {
           {"Regimen", Regimenes.Regimen},
           {"Descripcion_regimen", Regimenes.Descripcion_regimen},
           {"Cod_empresa", Regimenes.Cod_empresa}
         };
            return Data.EjecutarSPEscalar("{CALL sp_Nuevo_Regimenes(?, ?, ?)}", Parametros);
        }
    }
}
