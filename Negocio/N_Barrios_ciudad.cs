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
    public class N_Barrios_ciudad : N_General
    {
        M_Barrios_ciudad C_Barrios_ciudad = new M_Barrios_ciudad();
        //ClsDatos Data = new ClsDatos();
        public bool Existe(int Cod_barrio, int Llave_ciudad, bool CargarDatos)
        {
            DataTable DT = new DataTable();
            DT = Data.ConsultaT("SELECT * FROM Barrios_ciudad WHERE Cod_barrio= " + Cod_barrio + " and Llave_ciudad=" + Llave_ciudad);
            bool ExisteRegistro = false;
            if (DT.Rows.Count > 0)
            {
                ExisteRegistro = true;
                if (CargarDatos)
                {
                    C_Barrios_ciudad.Cod_barrio = Convert.ToInt32(DT.Rows[0]["Cod_barrio"]);
                    C_Barrios_ciudad.Llave_ciudad = Convert.ToInt32(DT.Rows[0]["Llave_ciudad"]);
                    C_Barrios_ciudad.Nombre_barrio = DT.Rows[0]["Nombre_barrio"].ToString();
                    C_Barrios_ciudad.Descripcion_barrio = DT.Rows[0]["Descripcion_barrio"].ToString();
                    C_Barrios_ciudad.Cod_empresa = Convert.ToInt32(DT.Rows[0]["Cod_empresa"]);
                }
            }
            return ExisteRegistro;
        }
        public M_Barrios_ciudad Consultar(int Cod_barrio, int Llave_ciudad)
        {
            if (Existe(Cod_barrio, Llave_ciudad, true))
            {
                return C_Barrios_ciudad;
            }
            else
            {
                return null;
            }
        }
        public DataTable Consultar()
        {
            return Data.ConsultaT("SELECT * FROM Barrios_ciudad");
        }

        public DataTable BarriosXCiudad(int Llave_ciudad)
        {
            return Data.ConsultaT("SELECT * FROM barrios_ciudad WHERE llave_ciudad=" + Llave_ciudad);
        }

        public DataTable BarriosInmueblesDisponibles(int Llave_ciudad)
        {
            return Data.ConsultaT("SELECT DISTINCTROW Barrios_ciudad.nombre_barrio, Barrios_ciudad.llave_ciudad, Barrios_ciudad.cod_barrio" +
                " FROM Barrios_ciudad INNER JOIN(ciudades INNER JOIN Inmuebles ON ciudades.llave_ciudad = Inmuebles.llave_ciudad) ON(ciudades.llave_ciudad = Barrios_ciudad.llave_ciudad) AND(Barrios_ciudad.cod_barrio = Inmuebles.cod_barrio)" +
                " WHERE(((Inmuebles.estado) = 'V' Or(Inmuebles.estado) = 'C' And(Inmuebles.estado) <> 'I')) AND inmuebles.llave_ciudad=" + Llave_ciudad + ";"
            );
        }

        public long Insertar(M_Barrios_ciudad Barrios_ciudad)
        {
            return Data.Accion("INSERT INTO Barrios_ciudad (Cod_barrio,Llave_ciudad,Nombre_barrio,Descripcion_barrio,Cod_empresa) VALUES (" + Barrios_ciudad.Cod_barrio + "," + Barrios_ciudad.Llave_ciudad + ", '" + Barrios_ciudad.Nombre_barrio + "'" + ", '" + Barrios_ciudad.Descripcion_barrio + "'" + "," + Barrios_ciudad.Cod_empresa + ");");
        }
        public long Actualizar(M_Barrios_ciudad Barrios_ciudad)
        {
            return Data.Accion("UPDATE Barrios_ciudad SET Cod_barrio=" + Barrios_ciudad.Cod_barrio + ",Llave_ciudad=" + Barrios_ciudad.Llave_ciudad + ",Nombre_barrio='" + Barrios_ciudad.Nombre_barrio + "'" + ",Descripcion_barrio='" + Barrios_ciudad.Descripcion_barrio + "'" + ",Cod_empresa=" + Barrios_ciudad.Cod_empresa + " WHERE Cod_barrio= " + Barrios_ciudad.Cod_barrio + " and Llave_ciudad=" + Barrios_ciudad.Llave_ciudad + ";");
        }
        public long Nuevo(M_Barrios_ciudad Barrios_ciudad)
        {
            Dictionary<string, object> Parametros = new Dictionary<string, object>
         {
           {"Cod_barrio", Barrios_ciudad.Cod_barrio},
           {"Llave_ciudad", Barrios_ciudad.Llave_ciudad},
           {"Nombre_barrio", Barrios_ciudad.Nombre_barrio},
           {"Descripcion_barrio", Barrios_ciudad.Descripcion_barrio},
           {"Cod_empresa", Barrios_ciudad.Cod_empresa}
         };
            return Data.EjecutarSPEscalar("{CALL sp_Nuevo_Barrios_ciudad(?, ?, ?, ?, ?)}", Parametros);
        }
    }
}
