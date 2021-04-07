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
    public class N_Ciudades : N_General
    {
        M_Ciudades C_Ciudades = new M_Ciudades();
        //ClsDatos Data = new ClsDatos();
        public bool Existe(int Llave_ciudad, bool CargarDatos)
        {
            DataTable DT = new DataTable();
            DT = Data.ConsultaT("SELECT * FROM ciudades WHERE Llave_ciudad= " + Llave_ciudad);
            bool ExisteRegistro = false;
            if (DT.Rows.Count > 0)
            {
                ExisteRegistro = true;
                if (CargarDatos)
                {
                    C_Ciudades.Llave_ciudad = Convert.ToInt32(DT.Rows[0]["Llave_ciudad"]);
                    C_Ciudades.Cod_ciudad = Convert.ToInt32(DT.Rows[0]["Cod_ciudad"]);
                    C_Ciudades.Nombre_ciudad = DT.Rows[0]["Nombre_ciudad"].ToString();
                    C_Ciudades.Cod_departamento = Convert.ToInt32(DT.Rows[0]["Cod_departamento"]);
                }
            }
            return ExisteRegistro;
        }
        public M_Ciudades Consultar(int Llave_ciudad)
        {
            if (Existe(Llave_ciudad, true))
            {
                return C_Ciudades;
            }
            else
            {
                return null;
            }
        }
        public DataTable Consultar()
        {
            return Data.ConsultaT("SELECT * FROM ciudades");
        }
        public DataTable CiudadesInmueblesDisponibles()
        {
            return Data.ConsultaT("SELECT ciudades.llave_ciudad, ciudades.nombre_ciudad" +
                " FROM ciudades INNER JOIN Inmuebles ON ciudades.llave_ciudad = Inmuebles.llave_ciudad" +
                " WHERE(((Inmuebles.estado) = 'V' Or(Inmuebles.estado) = 'C') and inmuebles.estado <> 'I')" +
                " GROUP BY ciudades.llave_ciudad, ciudades.nombre_ciudad" +
                " ORDER BY ciudades.llave_ciudad" +
                " ; ");
        }
        public long Insertar(M_Ciudades Ciudades)
        {
            return Data.Accion("INSERT INTO ciudades (Llave_ciudad,Cod_ciudad,Nombre_ciudad,Cod_departamento) VALUES (" + Ciudades.Llave_ciudad + "," + Ciudades.Cod_ciudad + ", '" + Ciudades.Nombre_ciudad + "'" + "," + Ciudades.Cod_departamento + ");");
        }
        public long Actualizar(M_Ciudades Ciudades)
        {
            return Data.Accion("UPDATE ciudades SET Llave_ciudad=" + Ciudades.Llave_ciudad + ",Cod_ciudad=" + Ciudades.Cod_ciudad + ",Nombre_ciudad='" + Ciudades.Nombre_ciudad + "'" + ",Cod_departamento=" + Ciudades.Cod_departamento + " WHERE Llave_ciudad= " + Ciudades.Llave_ciudad + ";");
        }
        public long Nuevo(M_Ciudades Ciudades)
        {
            Dictionary<string, object> Parametros = new Dictionary<string, object>
            {
                {"Llave_ciudad", Ciudades.Llave_ciudad},
                {"Cod_ciudad", Ciudades.Cod_ciudad},
                {"Nombre_ciudad", Ciudades.Nombre_ciudad},
                {"Cod_departamento", Ciudades.Cod_departamento}
            };
            return Data.EjecutarSPEscalar("{CALL sp_Nuevo_ciudades(?, ?, ?, ?)}", Parametros);
        }
    }
}
