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
    public class N_Telefonos_auxiliar : N_General
    {
        M_Telefonos_auxiliar C_Telefonos_auxiliar = new M_Telefonos_auxiliar();
        //ClsDatos Data = new ClsDatos();
        public bool Existe(string Tipo_aux, int Id_aux, int Item, bool CargarDatos)
        {
            DataTable DT = new DataTable();
            DT = Data.ConsultaT("SELECT * FROM telefonos_auxiliar WHERE Tipo_aux='" + Tipo_aux + "'" + " and Id_aux=" + Id_aux + " and Item=" + Item);
            bool ExisteRegistro = false;
            if (DT.Rows.Count > 0)
            {
                ExisteRegistro = true;
                if (CargarDatos)
                {
                    C_Telefonos_auxiliar.Tipo_aux = DT.Rows[0]["Tipo_aux"].ToString();
                    C_Telefonos_auxiliar.Id_aux = Convert.ToInt32(DT.Rows[0]["Id_aux"]);
                    C_Telefonos_auxiliar.Item = Convert.ToInt32(DT.Rows[0]["Item"]);
                    C_Telefonos_auxiliar.Tipo_telefono = Convert.ToInt32(DT.Rows[0]["Tipo_telefono"]);
                    C_Telefonos_auxiliar.No_telefono = DT.Rows[0]["No_telefono"].ToString();
                }
            }
            return ExisteRegistro;
        }
        public M_Telefonos_auxiliar Consultar(string Tipo_aux, int Id_aux, int Item)
        {
            if (Existe(Tipo_aux, Id_aux, Item, true))
            {
                return C_Telefonos_auxiliar;
            }
            else
            {
                return null;
            }
        }
        public DataTable Consultar()
        {
            return Data.ConsultaT("SELECT * FROM telefonos_auxiliar");
        }

        public DataTable ConsultarTelefonos(string Tipo_aux, int Id_aux)
        {
            return Data.ConsultaT("SELECT * FROM telefonos_auxiliar WHERE tipo_aux='" + Tipo_aux + "' AND id_aux=" + Id_aux +";");
        }

        public long Insertar(M_Telefonos_auxiliar Telefonos_auxiliar)
        {
            return Data.Accion("INSERT INTO telefonos_auxiliar (Tipo_aux,Id_aux,Item,Tipo_telefono,No_telefono) VALUES (" + "'" + Telefonos_auxiliar.Tipo_aux + "'" + "," + Telefonos_auxiliar.Id_aux + "," + Telefonos_auxiliar.Item + "," + Telefonos_auxiliar.Tipo_telefono + ", '" + Telefonos_auxiliar.No_telefono + "'" + ");");
        }
        public long Actualizar(M_Telefonos_auxiliar Telefonos_auxiliar)
        {
            return Data.Accion("UPDATE telefonos_auxiliar SET Tipo_aux='" + Telefonos_auxiliar.Tipo_aux + "'" + ",Id_aux=" + Telefonos_auxiliar.Id_aux + ",Item=" + Telefonos_auxiliar.Item + ",Tipo_telefono=" + Telefonos_auxiliar.Tipo_telefono + ",No_telefono='" + Telefonos_auxiliar.No_telefono + "'" + " WHERE Tipo_aux='" + Telefonos_auxiliar.Tipo_aux + "'" + " and Id_aux=" + Telefonos_auxiliar.Id_aux + " and Item=" + Telefonos_auxiliar.Item + ";");
        }
        public long Nuevo(M_Telefonos_auxiliar Telefonos_auxiliar)
        {
            Dictionary<string, object> Parametros = new Dictionary<string, object>
         {
           {"Tipo_aux", Telefonos_auxiliar.Tipo_aux},
           {"Id_aux", Telefonos_auxiliar.Id_aux},
           {"Item", Telefonos_auxiliar.Item},
           {"Tipo_telefono", Telefonos_auxiliar.Tipo_telefono},
           {"No_telefono", Telefonos_auxiliar.No_telefono}
         };
            return Data.EjecutarSPEscalar("{CALL sp_Nuevo_telefonos_auxiliar(?, ?, ?, ?, ?)}", Parametros);
        }
    }
}
