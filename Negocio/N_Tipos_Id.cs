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
    public class N_Tipos_Id : N_General
    {
        M_Tipos_Id C_Tipos_Id = new M_Tipos_Id();
        //ClsDatos Data = new ClsDatos();

        //public void Cadena(string path)
        //{
        //    Data.Cadena(path);
        //}

        //public void DatosServidoryPath(string pathprograma)
        //{

        //    Data.DatosServidoryPath(pathprograma);
        //    Data.Cadena();
        //    GsPath = Data.GsPath;
        //}

        public bool Existe(string Tipo_id, bool CargarDatos)
        {
            DataTable DT = new DataTable();
            DT = Data.ConsultaT("SELECT * FROM Tipos_Id WHERE Tipo_id='" + Tipo_id + "'");
            bool ExisteRegistro = false;
            if (DT.Rows.Count > 0)
            {
                ExisteRegistro = true;
                if (CargarDatos)
                {
                    C_Tipos_Id.Tipo_id = DT.Rows[0]["Tipo_id"].ToString();
                    C_Tipos_Id.Nombre_id = DT.Rows[0]["Nombre_id"].ToString();
                    C_Tipos_Id.Cod_empresa = Convert.ToInt32(DT.Rows[0]["Cod_empresa"]);
                }
            }
            return ExisteRegistro;
        }
        public M_Tipos_Id Consultar(string Tipo_id)
        {
            if (Existe(Tipo_id, true))
            {
                return C_Tipos_Id;
            }
            else
            {
                return null;
            }
        }
        public DataTable Consultar()
        {
            return Data.ConsultaT("SELECT * FROM Tipos_Id");
        }
        public long Insertar(M_Tipos_Id Tipos_Id)
        {
            return Data.Accion("INSERT INTO Tipos_Id (Tipo_id,Nombre_id,Cod_empresa) VALUES (" + "'" + Tipos_Id.Tipo_id + "'" + ", '" + Tipos_Id.Nombre_id + "'" + "," + Tipos_Id.Cod_empresa + ");");
        }
        public long Actualizar(M_Tipos_Id Tipos_Id)
        {
            return Data.Accion("UPDATE Tipos_Id SET Tipo_id='" + Tipos_Id.Tipo_id + "'" + ",Nombre_id='" + Tipos_Id.Nombre_id + "'" + ",Cod_empresa=" + Tipos_Id.Cod_empresa + " WHERE Tipo_id='" + Tipos_Id.Tipo_id + "'" + ";");
        }
        public long Nuevo(M_Tipos_Id Tipos_Id)
        {
            Dictionary<string, object> Parametros = new Dictionary<string, object>
         {
           {"Tipo_id", Tipos_Id.Tipo_id},
           {"Nombre_id", Tipos_Id.Nombre_id},
           {"Cod_empresa", Tipos_Id.Cod_empresa}
         };
            return Data.EjecutarSPEscalar("{CALL sp_Nuevo_Tipos_Id(?, ?, ?)}", Parametros);
        }
    }
}
