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
    public class N_Prop_Inmuebles : N_General
    {
        public M_Prop_Inmuebles C_Prop_Inmuebles = new M_Prop_Inmuebles();
        //ClsDatos Data = new ClsDatos();
        public bool Existe(int Cod_inmueble, string Tipo_id, int Id_propietario, bool CargarDatos)
        {
            DataTable DT = new DataTable();
            DT = Data.ConsultaT("SELECT * FROM Prop_Inmuebles WHERE Cod_inmueble= " + Cod_inmueble + " and Tipo_id='" + Tipo_id + "'" + " and Id_propietario=" + Id_propietario);
            bool ExisteRegistro = false;
            if (DT.Rows.Count > 0)
            {
                ExisteRegistro = true;
                if (CargarDatos)
                {
                    C_Prop_Inmuebles.Cod_inmueble = Convert.ToInt32(DT.Rows[0]["Cod_inmueble"]);
                    C_Prop_Inmuebles.Tipo_id = DT.Rows[0]["Tipo_id"].ToString();
                    C_Prop_Inmuebles.Id_propietario = Convert.ToInt32(DT.Rows[0]["Id_propietario"]);
                    C_Prop_Inmuebles.Dv = DT.Rows[0]["Dv"].ToString();
                    C_Prop_Inmuebles.Estado_propietario = DT.Rows[0]["Estado_propietario"].ToString();
                    C_Prop_Inmuebles.Fecha_hasta = Convert.ToDateTime(DT.Rows[0]["Fecha_hasta"]);
                }
            }
            return ExisteRegistro;
        }
        public M_Prop_Inmuebles Consultar(int Cod_inmueble, string Tipo_id, int Id_propietario)
        {
            if (Existe(Cod_inmueble, Tipo_id, Id_propietario, true))
            {
                return C_Prop_Inmuebles;
            }
            else
            {
                return null;
            }
        }
        public DataTable Consultar(int Cod_inmueble)
        {
            return Data.ConsultaT("SELECT prop_inmuebles.*, (auxiliares.nombre & ' ' & auxiliares.apellido1 & ' ' & auxiliares.apellido2) as nombre_propietario FROM Prop_Inmuebles INNER JOIN auxiliares ON prop_inmuebles.id_propietario = auxiliares.id_aux WHERE Cod_inmueble=" + Cod_inmueble);
        }
        public long Insertar(M_Prop_Inmuebles Prop_Inmuebles)
        {
            return Data.Accion("INSERT INTO Prop_Inmuebles (Cod_inmueble,Tipo_id,Id_propietario,Dv,Estado_propietario,Fecha_hasta) VALUES (" + Prop_Inmuebles.Cod_inmueble + ", '" + Prop_Inmuebles.Tipo_id + "'" + "," + Prop_Inmuebles.Id_propietario + ", '" + Prop_Inmuebles.Dv + "'" + ", '" + Prop_Inmuebles.Estado_propietario + "'" + "," + Prop_Inmuebles.Fecha_hasta + ");");
        }
        public long Actualizar(M_Prop_Inmuebles Prop_Inmuebles)
        {
            return Data.Accion("UPDATE Prop_Inmuebles SET Cod_inmueble=" + Prop_Inmuebles.Cod_inmueble + ",Tipo_id='" + Prop_Inmuebles.Tipo_id + "'" + ",Id_propietario=" + Prop_Inmuebles.Id_propietario + ",Dv='" + Prop_Inmuebles.Dv + "'" + ",Estado_propietario='" + Prop_Inmuebles.Estado_propietario + "'" + ",Fecha_hasta=" + Prop_Inmuebles.Fecha_hasta + " WHERE Cod_inmueble= " + Prop_Inmuebles.Cod_inmueble + " and Tipo_id='" + Prop_Inmuebles.Tipo_id + "'" + " and Id_propietario=" + Prop_Inmuebles.Id_propietario + ";");
        }
        public long Nuevo(M_Prop_Inmuebles Prop_Inmuebles)
        {
            Dictionary<string, object> Parametros = new Dictionary<string, object>
         {
           {"Cod_inmueble", Prop_Inmuebles.Cod_inmueble},
           {"Tipo_id", Prop_Inmuebles.Tipo_id},
           {"Id_propietario", Prop_Inmuebles.Id_propietario},
           {"Dv", Prop_Inmuebles.Dv},
           {"Estado_propietario", Prop_Inmuebles.Estado_propietario},
           {"Fecha_hasta", Prop_Inmuebles.Fecha_hasta}
         };
            return Data.EjecutarSPEscalar("{CALL sp_Nuevo_Prop_Inmuebles(?, ?, ?, ?, ?, ?)}", Parametros);
        }
    }
}
