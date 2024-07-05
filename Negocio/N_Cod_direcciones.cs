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
    public class N_Cod_direcciones
    {
        M_Cod_direcciones C_Cod_direcciones = new M_Cod_direcciones();
        ClsDatos Data = new ClsDatos();
        public bool Existe(byte Cod_direccion, bool CargarDatos)
        {
            DataTable DT = new DataTable();
            DT = Data.ConsultaT("SELECT * FROM Cod_direcciones WHERE Cod_direccion= " + Cod_direccion);
            bool ExisteRegistro = false;
            if (DT.Rows.Count > 0)
            {
                ExisteRegistro = true;
                if (CargarDatos)
                {
                    C_Cod_direcciones.Cod_direccion = Convert.ToByte(DT.Rows[0]["Cod_direccion"]);
                    C_Cod_direcciones.Descripcion_cod_direccion = DT.Rows[0]["Descripcion_cod_direccion"].ToString();
                }
            }
            return ExisteRegistro;
        }
        public M_Cod_direcciones Consultar(byte Cod_direccion)
        {
            if (Existe(Cod_direccion, true))
            {
                return C_Cod_direcciones;
            }
            else
            {
                return null;
            }
        }
        public DataTable Consultar()
        {
            return Data.ConsultaT("SELECT * FROM Cod_direcciones");
        }
        public long Insertar(M_Cod_direcciones Cod_direcciones)
        {
            return Data.Accion("INSERT INTO Cod_direcciones (Cod_direccion,Descripcion_cod_direccion) VALUES (" + Cod_direcciones.Cod_direccion + ", '" + Cod_direcciones.Descripcion_cod_direccion + "'" + ");");
        }
        public long Actualizar(M_Cod_direcciones Cod_direcciones)
        {
            return Data.Accion("UPDATE Cod_direcciones SET Cod_direccion=" + Cod_direcciones.Cod_direccion + ",Descripcion_cod_direccion='" + Cod_direcciones.Descripcion_cod_direccion + "'" + " WHERE Cod_direccion= " + Cod_direcciones.Cod_direccion + ";");
        }
        public long Nuevo(M_Cod_direcciones Cod_direcciones)
        {
            Dictionary<string, object> Parametros = new Dictionary<string, object>
         {
           {"Cod_direccion", Cod_direcciones.Cod_direccion},
           {"Descripcion_cod_direccion", Cod_direcciones.Descripcion_cod_direccion}
         };
            return Data.EjecutarSPEscalar("{CALL sp_Nuevo_Cod_direcciones(?, ?)}", Parametros);
        }
    }
}
