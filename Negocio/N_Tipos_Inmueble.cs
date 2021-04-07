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
    public class N_Tipos_Inmueble:N_General
    {
        public M_Tipos_Inmueble C_Tipos_Inmueble = new M_Tipos_Inmueble();
        //ClsDatos Data = new ClsDatos();
        public bool Existe(int Tipo_inmueble, bool CargarDatos)
        {
            DataTable DT = new DataTable();
            DT = Data.ConsultaT("SELECT * FROM Tipos_Inmueble WHERE Tipo_inmueble= " + Tipo_inmueble);
            bool ExisteRegistro = false;
            if (DT.Rows.Count > 0)
            {
                ExisteRegistro = true;
                if (CargarDatos)
                {
                    C_Tipos_Inmueble.Tipo_inmueble = Convert.ToInt32(DT.Rows[0]["Tipo_inmueble"]);
                    C_Tipos_Inmueble.Nombre_tipo = DT.Rows[0]["Nombre_tipo"].ToString();
                    C_Tipos_Inmueble.Cod_empresa = Convert.ToInt32(DT.Rows[0]["Cod_empresa"]);
                }
            }
            return ExisteRegistro;
        }
        public M_Tipos_Inmueble Consultar(int Tipo_inmueble)
        {
            if (Existe(Tipo_inmueble, true))
            {
                return C_Tipos_Inmueble;
            }
            else
            {
                return null;
            }
        }
        public DataTable Consultar()
        {
            return Data.ConsultaT("SELECT * FROM Tipos_Inmueble");
        }
        public long Insertar(M_Tipos_Inmueble Tipos_Inmueble)
        {
            return Data.Accion("INSERT INTO Tipos_Inmueble (Tipo_inmueble,Nombre_tipo,Cod_empresa) VALUES (" + Tipos_Inmueble.Tipo_inmueble + ", '" + Tipos_Inmueble.Nombre_tipo + "'" + "," + Tipos_Inmueble.Cod_empresa + ");");
        }
        public long Actualizar(M_Tipos_Inmueble Tipos_Inmueble)
        {
            return Data.Accion("UPDATE Tipos_Inmueble SET Tipo_inmueble=" + Tipos_Inmueble.Tipo_inmueble + ",Nombre_tipo='" + Tipos_Inmueble.Nombre_tipo + "'" + ",Cod_empresa=" + Tipos_Inmueble.Cod_empresa + " WHERE Tipo_inmueble= " + Tipos_Inmueble.Tipo_inmueble + ";");
        }
        public long Nuevo(M_Tipos_Inmueble Tipos_Inmueble)
        {
            Dictionary<string, object> Parametros = new Dictionary<string, object>
         {
           {"Tipo_inmueble", Tipos_Inmueble.Tipo_inmueble},
           {"Nombre_tipo", Tipos_Inmueble.Nombre_tipo},
           {"Cod_empresa", Tipos_Inmueble.Cod_empresa}
         };
            return Data.EjecutarSPEscalar("{CALL sp_Nuevo_Tipos_Inmueble(?, ?, ?)}", Parametros);
        }
    }
}
