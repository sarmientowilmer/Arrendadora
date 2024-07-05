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
    public class N_Auxiliares : N_General
    {
        public M_Auxiliares C_Auxiliares = new M_Auxiliares();
        // ClsDatos Data = new ClsDatos();

        public string NombreTercero (string Tipo_aux, int Id_aux)
        {
            if (Existe(Tipo_aux, Id_aux, true))
            {
                return C_Auxiliares.Nombre + ' ' + C_Auxiliares.Apellido1 + ' ' + C_Auxiliares.Apellido2;
            }
            else
            {
                return "";
            }
        }
        public bool Existe(string Tipo_aux, int Id_aux, bool CargarDatos)
        {
            DataTable DT = new DataTable();
            DT = Data.ConsultaT("SELECT * FROM Auxiliares WHERE Tipo_aux='" + Tipo_aux + "'" + " and Id_aux=" + Id_aux);
            bool ExisteRegistro = false;
            if (DT.Rows.Count > 0)
            {
                ExisteRegistro = true;
                if (CargarDatos)
                {
                    C_Auxiliares.Tipo_aux = DT.Rows[0]["Tipo_aux"].ToString();
                    C_Auxiliares.Id_aux = Convert.ToInt32(DT.Rows[0]["Id_aux"]);
                    C_Auxiliares.Dv = DT.Rows[0]["Dv"].ToString();
                    C_Auxiliares.Expedido = DT.Rows[0]["Expedido"].ToString();
                    C_Auxiliares.Apellido1 = DT.Rows[0]["Apellido1"].ToString();
                    C_Auxiliares.Apellido2 = DT.Rows[0]["Apellido2"].ToString();
                    C_Auxiliares.Nombre = DT.Rows[0]["Nombre"].ToString();
                    C_Auxiliares.Direccion = DT.Rows[0]["Direccion"].ToString();
                    C_Auxiliares.Telefono = DT.Rows[0]["Telefono"].ToString();
                    C_Auxiliares.Retencion = Convert.ToBoolean(DT.Rows[0]["Retencion"]);
                    C_Auxiliares.Correo_electronico = DT.Rows[0]["Correo_electronico"].ToString();
                    C_Auxiliares.Ciudad = Convert.ToInt32(DT.Rows[0]["Ciudad"]);
                    C_Auxiliares.Regimen = Convert.ToInt32(DT.Rows[0]["Regimen"]);
                    C_Auxiliares.Clase = Convert.ToInt32(DT.Rows[0]["Clase"]);
                    C_Auxiliares.Tipo = Convert.ToInt32(DT.Rows[0]["Tipo"]);
                    C_Auxiliares.Reteica = Convert.ToBoolean(DT.Rows[0]["Reteica"]);
                    C_Auxiliares.Reteiva = Convert.ToBoolean(DT.Rows[0]["Reteiva"]);
                    C_Auxiliares.Empleado = Convert.ToBoolean(DT.Rows[0]["Empleado"]);
                    C_Auxiliares.Proveedor = Convert.ToBoolean(DT.Rows[0]["Proveedor"]);
                    C_Auxiliares.Cliente = Convert.ToBoolean(DT.Rows[0]["Cliente"]);
                    C_Auxiliares.Empresa = DT.Rows[0]["Empresa"].ToString();
                    C_Auxiliares.Tel_empresa = DT.Rows[0]["Tel_empresa"].ToString();
                    C_Auxiliares.Salario = Convert.ToDouble(DT.Rows[0]["Salario"]);
                    C_Auxiliares.Nosaplica_retencion = Convert.ToBoolean(DT.Rows[0]["Nosaplica_retencion"]);
                    C_Auxiliares.Propietario = Convert.ToBoolean(DT.Rows[0]["Propietario"]);
                    C_Auxiliares.Cod_empresa = Convert.ToInt32(DT.Rows[0]["Cod_empresa"]);
                    C_Auxiliares.EC = Convert.ToInt32(DT.Rows[0]["EC"]);
                    C_Auxiliares.Tiene_credito = Convert.ToBoolean(DT.Rows[0]["Tiene_credito"]);
                    C_Auxiliares.Fi = Convert.ToByte(DT.Rows[0]["Fi"]);
                }
            }
            return ExisteRegistro;
        }
        public string AplicaRetencion(string Tipo_aux, int Id_aux)
        {
            DataTable DT = new DataTable();
            DT = Data.ConsultaT("SELECT nosaplica_retencion FROM Auxiliares WHERE Tipo_aux='" + Tipo_aux + "'" + " and Id_aux=" + Id_aux);
            if (DT.Rows.Count > 0) return DT.Rows[0]["Nosaplica_retencion"].ToString();
            else return "No Existe";
        }
        public M_Auxiliares Consultar(string Tipo_aux, int Id_aux)
        {
            if (Existe(Tipo_aux, Id_aux, true))
            {
                return C_Auxiliares;
            }
            else
            {
                return null;
            }
        }
        public DataTable Consultar()
        {
            return Data.ConsultaT("SELECT * FROM Auxiliares");
        }

        public DataTable ConsultarTerceros(string apellido1, string apellido2, string nombres, bool EsPropietario = false, bool EsInquilino = false)
        {
            string consulta;

            if (Data.ConectaA != null && Data.ConectaA != "Access") consulta= "select tipo_aux, id_aux, dv, CONCAT_WS(' ',nombre, apellido1, apellido2) as nombre_aux from auxiliares";
            else consulta = "select tipo_aux, id_aux, dv, (nombre + ' ' + apellido1+ ' '+ apellido2) as nombre_aux from auxiliares";
            string criterio = "";
            if (apellido1 != "")
            {
                if (criterio == "")
                {
                    criterio = " where apellido1 like '" + apellido1 + "%'";
                }
                else
                {
                    criterio = criterio + " and apellido1 like '" + apellido1 + "%'";
                }
            }
            if (apellido2 != "")
            {
                if (criterio == "")
                {
                    criterio = " where apellido2 like '" + apellido2 + "%'";
                }
                else
                {
                    criterio = criterio + " and apellido2 like '" + apellido2 + "%'";
                }
            }
            if (nombres != "")
            {
                if (criterio == "")
                {
                    criterio = " where nombre like '" + nombres + "%'";
                }
                else
                {
                    criterio = criterio + " and nombre like '" + nombres + "%'";
                }
            }
            if (EsInquilino)
            {
                if (criterio == "") criterio = " WHERE cliente=true";
                else criterio += " AND cliente=true";
            }
            if (EsPropietario)
            {
                if (criterio == "") criterio = " WHERE propietario=true";
                else criterio += " AND propietario=true";
            }

            return Data.ConsultaT(consulta + criterio + " order by tipo_aux, id_aux");
        }


        public long Insertar(M_Auxiliares Auxiliares)
        {
            return Data.Accion("INSERT INTO Auxiliares (Tipo_aux,Id_aux,Dv,Expedido,Apellido1,Apellido2,Nombre,Direccion,Telefono,Retencion,Correo_electronico,Ciudad,Regimen,Clase,Tipo,Reteica,Reteiva,Empleado,Proveedor,Cliente,Empresa,Tel_empresa,Salario,Nosaplica_retencion,Propietario,Cod_empresa,EC,Tiene_credito,Fi) VALUES (" + "'" + Auxiliares.Tipo_aux + "'" + "," + Auxiliares.Id_aux + ", '" + Auxiliares.Dv + "'" + ", '" + Auxiliares.Expedido + "'" + ", '" + Auxiliares.Apellido1 + "'" + ", '" + Auxiliares.Apellido2 + "'" + ", '" + Auxiliares.Nombre + "'" + ", '" + Auxiliares.Direccion + "'" + ", '" + Auxiliares.Telefono + "'" + "," + Auxiliares.Retencion + ", '" + Auxiliares.Correo_electronico + "'" + "," + Auxiliares.Ciudad + "," + Auxiliares.Regimen + "," + Auxiliares.Clase + "," + Auxiliares.Tipo + "," + Auxiliares.Reteica + "," + Auxiliares.Reteiva + "," + Auxiliares.Empleado + "," + Auxiliares.Proveedor + "," + Auxiliares.Cliente + ", '" + Auxiliares.Empresa + "'" + ", '" + Auxiliares.Tel_empresa + "'" + "," + Auxiliares.Salario + "," + Auxiliares.Nosaplica_retencion + "," + Auxiliares.Propietario + "," + Auxiliares.Cod_empresa + "," + Auxiliares.EC + "," + Auxiliares.Tiene_credito + "," + Auxiliares.Fi + ");");
        }
        public long Actualizar(M_Auxiliares Auxiliares)
        {
            return Data.Accion("UPDATE Auxiliares SET Tipo_aux='" + Auxiliares.Tipo_aux + "'" + ",Id_aux=" + Auxiliares.Id_aux + ",Dv='" + Auxiliares.Dv + "'" + ",Expedido='" + Auxiliares.Expedido + "'" + ",Apellido1='" + Auxiliares.Apellido1 + "'" + ",Apellido2='" + Auxiliares.Apellido2 + "'" + ",Nombre='" + Auxiliares.Nombre + "'" + ",Direccion='" + Auxiliares.Direccion + "'" + ",Telefono='" + Auxiliares.Telefono + "'" + ",Retencion=" + Auxiliares.Retencion + ",Correo_electronico='" + Auxiliares.Correo_electronico + "'" + ",Ciudad=" + Auxiliares.Ciudad + ",Regimen=" + Auxiliares.Regimen + ",Clase=" + Auxiliares.Clase + ",Tipo=" + Auxiliares.Tipo + ",Reteica=" + Auxiliares.Reteica + ",Reteiva=" + Auxiliares.Reteiva + ",Empleado=" + Auxiliares.Empleado + ",Proveedor=" + Auxiliares.Proveedor + ",Cliente=" + Auxiliares.Cliente + ",Empresa='" + Auxiliares.Empresa + "'" + ",Tel_empresa='" + Auxiliares.Tel_empresa + "'" + ",Salario=" + Auxiliares.Salario + ",Nosaplica_retencion=" + Auxiliares.Nosaplica_retencion + ",Propietario=" + Auxiliares.Propietario + ",Cod_empresa=" + Auxiliares.Cod_empresa + ",EC=" + Auxiliares.EC + ",Tiene_credito=" + Auxiliares.Tiene_credito + ",Fi=" + Auxiliares.Fi + " WHERE Tipo_aux='" + Auxiliares.Tipo_aux + "'" + " and Id_aux=" + Auxiliares.Id_aux + ";");
        }
        public long Nuevo(M_Auxiliares Auxiliares)
        {
            Dictionary<string, object> Parametros = new Dictionary<string, object>
         {
           {"Tipo_aux", Auxiliares.Tipo_aux},
           {"Id_aux", Auxiliares.Id_aux},
           {"Dv", Auxiliares.Dv},
           {"Expedido", Auxiliares.Expedido},
           {"Apellido1", Auxiliares.Apellido1},
           {"Apellido2", Auxiliares.Apellido2},
           {"Nombre", Auxiliares.Nombre},
           {"Direccion", Auxiliares.Direccion},
           {"Telefono", Auxiliares.Telefono},
           {"Retencion", Auxiliares.Retencion},
           {"Correo_electronico", Auxiliares.Correo_electronico},
           {"Ciudad", Auxiliares.Ciudad},
           {"Regimen", Auxiliares.Regimen},
           {"Clase", Auxiliares.Clase},
           {"Tipo", Auxiliares.Tipo},
           {"Reteica", Auxiliares.Reteica},
           {"Reteiva", Auxiliares.Reteiva},
           {"Empleado", Auxiliares.Empleado},
           {"Proveedor", Auxiliares.Proveedor},
           {"Cliente", Auxiliares.Cliente},
           {"Empresa", Auxiliares.Empresa},
           {"Tel_empresa", Auxiliares.Tel_empresa},
           {"Salario", Auxiliares.Salario},
           {"Nosaplica_retencion", Auxiliares.Nosaplica_retencion},
           {"Propietario", Auxiliares.Propietario},
           {"Cod_empresa", Auxiliares.Cod_empresa},
           {"EC", Auxiliares.EC},
           {"Tiene_credito", Auxiliares.Tiene_credito},
           {"Fi", Auxiliares.Fi}
         };
            return Data.EjecutarSPEscalar("{CALL sp_Nuevo_Auxiliares(?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)}", Parametros);
        }
    }
}
