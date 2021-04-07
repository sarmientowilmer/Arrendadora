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
    public class N_Controlcambios : N_General
    {
        public M_Controlcambios C_Controlcambios = new M_Controlcambios();
        //ClsDatos Data = new ClsDatos();

        public bool Existe(DateTime Fecha, DateTime Hora, int Autorizo, bool CargarDatos)
        {
            DataTable DT = new DataTable();
            DT = Data.ConsultaT("SELECT * FROM controlcambios WHERE Fecha= " + Fecha + " and Hora=" + Hora + " and Autorizo=" + Autorizo);
            bool ExisteRegistro = false;
            if (DT.Rows.Count > 0)
            {
                ExisteRegistro = true;
                if (CargarDatos)
                {
                    C_Controlcambios.Fecha = Convert.ToDateTime(DT.Rows[0]["Fecha"]);
                    C_Controlcambios.Hora = Convert.ToDateTime(DT.Rows[0]["Hora"]);
                    C_Controlcambios.Valorold = DT.Rows[0]["Valorold"].ToString();
                    C_Controlcambios.Valornvo = DT.Rows[0]["Valornvo"].ToString();
                    C_Controlcambios.Autorizo = Convert.ToInt32(DT.Rows[0]["Autorizo"]);
                    C_Controlcambios.Usuario = Convert.ToInt32(DT.Rows[0]["Usuario"]);
                    C_Controlcambios.Tabla = DT.Rows[0]["Tabla"].ToString();
                    C_Controlcambios.Campo = DT.Rows[0]["Campo"].ToString();
                    C_Controlcambios.Cod_empresa = Convert.ToInt32(DT.Rows[0]["Cod_empresa"]);
                    C_Controlcambios.Motivo = DT.Rows[0]["Motivo"].ToString();
                }
            }
            return ExisteRegistro;
        }
        public M_Controlcambios Consultar(DateTime Fecha, DateTime Hora, int Autorizo)
        {
            if (Existe(Fecha, Hora, Autorizo, true))
            {
                return C_Controlcambios;
            }
            else
            {
                return null;
            }
        }
        public DataTable Consultar()
        {
            return Data.ConsultaT("SELECT * FROM controlcambios");
        }
        public DataTable Consultar(DateTime Fecha)
        {
            return Data.ConsultaT("SELECT * FROM controlcambios WHERE fecha=#" + Fecha.ToString("yyyy/MM/dd") +"#");
        }
         
        public DataTable ConsultaReporte(DateTime Fecha)
        {
            if (Data.ConectaA == "Access")
            {
                return Data.ConsultaT("SELECT controlcambios.*, usuarios.nombres & ' ' & usuarios.apellido1 & ' ' & usuarios.apellido2 AS Autoriza, usuarios_1.nombres & ' ' & usuarios_1.apellido1 & ' ' & [usuarios_1].[apellido2] AS Registro " +
                       "FROM(controlcambios INNER JOIN Usuarios ON controlcambios.autorizo = Usuarios.id) INNER JOIN Usuarios AS Usuarios_1 ON controlcambios.usuario = Usuarios_1.id " +
                       "WHERE fecha=#" + Fecha.ToString("yyyy/MM/dd") + "#");
            }
            else
            {
                return Data.ConsultaT("SELECT controlcambios.*, concat(usuarios.nombres, ' ', usuarios.apellido1, ' ', usuarios.apellido2) AS Autoriza, concat(usuarios_1.nombres, ' ', usuarios_1.apellido1, ' ', usuarios_1.apellido2) AS Registro" +
                       "FROM(controlcambios INNER JOIN Usuarios ON controlcambios.autorizo = Usuarios.id) INNER JOIN Usuarios AS Usuarios_1 ON controlcambios.usuario = Usuarios_1.id " +
                       "WHERE fecha=#" + Fecha.ToString("yyyy/MM/dd") + "#");
            }
            //return Data.ConsultaT("SELECT controlcambios.*   FROM controlcambios WHERE fecha=#" + Fecha.ToString("yyyy/MM/dd") + "#");
        }

        public long Insertar(M_Controlcambios Controlcambios)
        {
            return Data.Accion("INSERT INTO controlcambios (Fecha,Hora,Valorold,Valornvo,Autorizo,Usuario,Tabla,Campo,Cod_empresa, Motivo) VALUES (#" + Controlcambios.Fecha.ToString("yyyy/MM/dd") + "#,#" + Controlcambios.Hora.ToString ("HH:mm") + "#, '" + Controlcambios.Valorold + "'" + ", '" + Controlcambios.Valornvo + "'" + "," + Controlcambios.Autorizo + "," + Controlcambios.Usuario + ", '" + Controlcambios.Tabla + "'" + ", '" + Controlcambios.Campo + "'" + "," + Controlcambios.Cod_empresa + ",'" + Controlcambios.Motivo + "');");
        }
        public long Actualizar(M_Controlcambios Controlcambios)
        {
            return Data.Accion("UPDATE controlcambios SET Fecha=#" + Controlcambios.Fecha.ToString("yyyy/MM/dd") + "#,Hora=#" + Controlcambios.Hora.ToString("HH:mm") + "#,Valorold='" + Controlcambios.Valorold + "'" + ",Valornvo='" + Controlcambios.Valornvo + "'" + ",Autorizo=" + Controlcambios.Autorizo + ",Usuario=" + Controlcambios.Usuario + ",Tabla='" + Controlcambios.Tabla + "'" + ",Campo='" + Controlcambios.Campo + "'" + ",Cod_empresa=" + Controlcambios.Cod_empresa + " WHERE Fecha= " + Controlcambios.Fecha + " and Hora=" + Controlcambios.Hora + " and Autorizo=" + Controlcambios.Autorizo + " and Motivo='" + Controlcambios.Motivo + "'" + ";");
        }
        public long Nuevo(M_Controlcambios Controlcambios)
        {
            Dictionary<string, object> Parametros = new Dictionary<string, object>
         {
           {"Fecha", Controlcambios.Fecha},
           {"Hora", Controlcambios.Hora},
           {"Valorold", Controlcambios.Valorold},
           {"Valornvo", Controlcambios.Valornvo},
           {"Autorizo", Controlcambios.Autorizo},
           {"Usuario", Controlcambios.Usuario},
           {"Tabla", Controlcambios.Tabla},
           {"Campo", Controlcambios.Campo},
           {"Cod_empresa", Controlcambios.Cod_empresa}
         };
            return Data.EjecutarSPEscalar("{CALL sp_Nuevo_controlcambios(?, ?, ?, ?, ?, ?, ?, ?, ?)}", Parametros);
        }
    }
}
