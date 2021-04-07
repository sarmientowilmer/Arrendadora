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
    public class N_Clases_contribuyente : N_General
    {
        M_Clases_contribuyente C_Clases_contribuyente = new M_Clases_contribuyente();
        //ClsDatos Data = new ClsDatos();
        public bool Existe(int Clase, bool CargarDatos)
        {
            DataTable DT = new DataTable();
            DT = Data.ConsultaT("SELECT * FROM Clases_contribuyente WHERE Clase= " + Clase);
            bool ExisteRegistro = false;
            if (DT.Rows.Count > 0)
            {
                ExisteRegistro = true;
                if (CargarDatos)
                {
                    C_Clases_contribuyente.Clase = Convert.ToInt32(DT.Rows[0]["Clase"]);
                    C_Clases_contribuyente.Descripcion_clase = DT.Rows[0]["Descripcion_clase"].ToString();
                    C_Clases_contribuyente.Cod_empresa = Convert.ToInt32(DT.Rows[0]["Cod_empresa"]);
                }
            }
            return ExisteRegistro;
        }
        public M_Clases_contribuyente Consultar(int Clase)
        {
            if (Existe(Clase, true))
            {
                return C_Clases_contribuyente;
            }
            else
            {
                return null;
            }
        }
        public DataTable Consultar()
        {
            return Data.ConsultaT("SELECT * FROM Clases_contribuyente");
        }
        public long Insertar(M_Clases_contribuyente Clases_contribuyente)
        {
            return Data.Accion("INSERT INTO Clases_contribuyente (Clase,Descripcion_clase,Cod_empresa) VALUES (" + Clases_contribuyente.Clase + ", '" + Clases_contribuyente.Descripcion_clase + "'" + "," + Clases_contribuyente.Cod_empresa + ");");
        }
        public long Actualizar(M_Clases_contribuyente Clases_contribuyente)
        {
            return Data.Accion("UPDATE Clases_contribuyente SET Clase=" + Clases_contribuyente.Clase + ",Descripcion_clase='" + Clases_contribuyente.Descripcion_clase + "'" + ",Cod_empresa=" + Clases_contribuyente.Cod_empresa + " WHERE Clase= " + Clases_contribuyente.Clase + ";");
        }
        public long Nuevo(M_Clases_contribuyente Clases_contribuyente)
        {
            Dictionary<string, object> Parametros = new Dictionary<string, object>
         {
           {"Clase", Clases_contribuyente.Clase},
           {"Descripcion_clase", Clases_contribuyente.Descripcion_clase},
           {"Cod_empresa", Clases_contribuyente.Cod_empresa}
         };
            return Data.EjecutarSPEscalar("{CALL sp_Nuevo_Clases_contribuyente(?, ?, ?)}", Parametros);
        }
    }
}
