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
    public class N_Inmuebles : N_General
    {
        public M_Inmuebles C_Inmuebles = new M_Inmuebles();
        //ClsDatos Data = new ClsDatos();
        public bool Existe(int Cod_inmueble, bool CargarDatos)
        {
            DataTable DT = new DataTable();
            DT = Data.ConsultaT("SELECT * FROM Inmuebles WHERE Cod_inmueble= " + Cod_inmueble);
            bool ExisteRegistro = false;
            if (DT.Rows.Count > 0)
            {
                ExisteRegistro = true;
                if (CargarDatos)
                {
                    C_Inmuebles.Cod_inmueble = Convert.ToInt32(DT.Rows[0]["Cod_inmueble"]);
                    C_Inmuebles.Tipo_inmueble = Convert.ToInt32(DT.Rows[0]["Tipo_inmueble"]);
                    C_Inmuebles.Direccion = DT.Rows[0]["Direccion"].ToString();
                    C_Inmuebles.Descripcion = DT.Rows[0]["Descripcion"].ToString();
                    C_Inmuebles.Agua = Convert.ToBoolean(DT.Rows[0]["Agua"]);
                    C_Inmuebles.Luz = Convert.ToBoolean(DT.Rows[0]["Luz"]);
                    C_Inmuebles.Telefono = Convert.ToBoolean(DT.Rows[0]["Telefono"]);
                    C_Inmuebles.No_telefono = DT.Rows[0]["No_telefono"].ToString();
                    C_Inmuebles.Parabolica = Convert.ToBoolean(DT.Rows[0]["Parabolica"]);
                    C_Inmuebles.Vigilancia = Convert.ToBoolean(DT.Rows[0]["Vigilancia"]);
                    C_Inmuebles.Administracion = Convert.ToBoolean(DT.Rows[0]["Administracion"]);
                    C_Inmuebles.Estado = DT.Rows[0]["Estado"].ToString();
                    C_Inmuebles.Canonarrendar = Convert.ToDouble(DT.Rows[0]["Canonarrendar"]);
                    if (!string.IsNullOrEmpty(DT.Rows[0]["Ultimocont"].ToString()))
                    {
                        C_Inmuebles.Ultimocont = Convert.ToInt32(DT.Rows[0]["Ultimocont"]);
                    }
                    else { C_Inmuebles.Ultimocont = 0; }
                    C_Inmuebles.Cod_direccion = Convert.ToByte(DT.Rows[0]["Cod_direccion"]);
                    C_Inmuebles.No_direccion = DT.Rows[0]["No_direccion"].ToString();
                    C_Inmuebles.No_direccion_puerta = DT.Rows[0]["No_direccion_puerta"].ToString();
                    C_Inmuebles.Cod_barrio = Convert.ToInt32(DT.Rows[0]["Cod_barrio"]);
                    C_Inmuebles.Llave_ciudad = Convert.ToInt32(DT.Rows[0]["Llave_ciudad"]);
                    C_Inmuebles.Destino_inmueble = Convert.ToByte(DT.Rows[0]["Destino_inmueble"]);
                    C_Inmuebles.Valorventa = Convert.ToDouble(DT.Rows[0]["Valorventa"]);
                    C_Inmuebles.Ambito = DT.Rows[0]["Ambito"].ToString();
                    C_Inmuebles.Cod_empresa = Convert.ToInt32(DT.Rows[0]["Cod_empresa"]);
                    C_Inmuebles.Valor_admon = Convert.ToDouble(DT.Rows[0]["Valor_admon"]);
                    C_Inmuebles.Observaciones = DT.Rows[0]["Observaciones"].ToString();
                    C_Inmuebles.Gas = Convert.ToBoolean(DT.Rows[0]["Gas"]);
                    C_Inmuebles.Estrato = Convert.ToInt32(DT.Rows[0]["Estrato"]);
                    C_Inmuebles.Metraje = Convert.ToInt32(DT.Rows[0]["metraje"]);
                    C_Inmuebles.No_contratos_arren = Convert.ToInt32(DT.Rows[0]["No_contratos_arren"]);
                    C_Inmuebles.Latitud = Convert.ToDouble(DT.Rows[0]["Latitud"]);
                    C_Inmuebles.Longitud = Convert.ToDouble(DT.Rows[0]["Longitud"]);
                    C_Inmuebles.Matricula_inm = Convert.ToInt32(DT.Rows[0]["Matricula_inm"]);
                }
            }
            return ExisteRegistro;
        }
        public M_Inmuebles Consultar(int Cod_inmueble)
        {
            if (Existe(Cod_inmueble, true))
            {
                return C_Inmuebles;
            }
            else
            {
                return null;
            }
        }

        public DataTable DetalleInmueble(int Cod_inmueble)
        {
            return Data.ConsultaT("SELECT Inmuebles.cod_inmueble, Inmuebles.tipo_inmueble, Inmuebles.direccion, Inmuebles.descripcion, Inmuebles.canonarrendar, Inmuebles.destino_inmueble, Inmuebles.valorventa, Inmuebles.estrato, Inmuebles.metraje, Tipos_Inmueble.nombre_tipo, ciudades.nombre_ciudad, Barrios_ciudad.nombre_barrio" +
                " FROM ciudades INNER JOIN (Tipos_Inmueble INNER JOIN (Barrios_ciudad INNER JOIN Inmuebles ON Barrios_ciudad.cod_barrio = Inmuebles.cod_barrio) ON Tipos_Inmueble.tipo_inmueble = Inmuebles.tipo_inmueble) ON (ciudades.llave_ciudad = Barrios_ciudad.llave_ciudad) AND (ciudades.llave_ciudad = Inmuebles.llave_ciudad)" +
                " WHERE ((inmuebles.estado = 'V' OR inmuebles.estado = 'C') AND inmuebles.estado<>'I')  AND inmuebles.cod_inmueble=" + Cod_inmueble +
                " ; ");

        }

        public DataTable Inmuebles_Disponibles()
        {
            return Data.ConsultaT("SELECT Inmuebles.cod_inmueble, Inmuebles.tipo_inmueble, Inmuebles.direccion, Inmuebles.descripcion, Inmuebles.canonarrendar, Inmuebles.destino_inmueble, Inmuebles.valorventa, Inmuebles.estrato, Inmuebles.metraje, Tipos_Inmueble.nombre_tipo, ciudades.nombre_ciudad, Barrios_ciudad.nombre_barrio" +
                " FROM ciudades INNER JOIN (Tipos_Inmueble INNER JOIN (Barrios_ciudad INNER JOIN Inmuebles ON Barrios_ciudad.cod_barrio = Inmuebles.cod_barrio) ON Tipos_Inmueble.tipo_inmueble = Inmuebles.tipo_inmueble) ON (ciudades.llave_ciudad = Barrios_ciudad.llave_ciudad) AND (ciudades.llave_ciudad = Inmuebles.llave_ciudad)" +
                " WHERE (inmuebles.estado = 'V' OR inmuebles.estado = 'C') AND inmuebles.estado<>'I' " +
                " ORDER BY inmuebles.cod_inmueble; ");
        }
        public DataTable Inmuebles_Disponibles(int Destino, int TipoInmueble, int LlaveCiudad, int Barrio, double ValorDesde = 0, double ValorHasta = 0)
        {
            string SQLWhere = "";
            if (Destino != 0)
            {
                SQLWhere = " AND Inmuebles.destino_inmueble=" + Destino;
            }
            if (TipoInmueble != 0)
            {
                SQLWhere = SQLWhere + " AND Inmuebles.tipo_inmueble=" + TipoInmueble;
            }
            if (LlaveCiudad != -1)
            {
                SQLWhere = SQLWhere + " AND Inmuebles.llave_ciudad=" + LlaveCiudad;
            }
            if (Barrio != 0)
            {
                SQLWhere = SQLWhere + " AND Inmuebles.cod_barrio=" + Barrio;
            }
            if (ValorDesde > 0 && ValorHasta > 0)
            {
                SQLWhere = SQLWhere + " AND (Inmuebles.canonarrendar BETWEEN " + ValorDesde + " AND " + ValorHasta + " OR Inmuebles.valorventa BETWEEN " + ValorDesde + " AND " + ValorHasta + ")";
            }

            return Data.ConsultaT("SELECT Inmuebles.cod_inmueble, Inmuebles.tipo_inmueble, Inmuebles.direccion, Inmuebles.descripcion, Inmuebles.canonarrendar, Inmuebles.destino_inmueble, Inmuebles.valorventa, Inmuebles.estrato, Inmuebles.metraje, Tipos_Inmueble.nombre_tipo, ciudades.nombre_ciudad, Barrios_ciudad.nombre_barrio" +
                " FROM Ciudades INNER JOIN (Tipos_Inmueble INNER JOIN (Barrios_ciudad INNER JOIN Inmuebles ON Barrios_ciudad.cod_barrio = Inmuebles.cod_barrio) ON Tipos_Inmueble.tipo_inmueble = Inmuebles.tipo_inmueble) ON (ciudades.llave_ciudad = Barrios_ciudad.llave_ciudad) AND (ciudades.llave_ciudad = Inmuebles.llave_ciudad)" +
                " WHERE ((Inmuebles.estado = 'V' OR Inmuebles.estado = 'C') AND Inmuebles.estado<>'I') " + SQLWhere +
                " ORDER BY inmuebles.cod_inmueble; ");
        }

        public DataTable CantidadInmueblesXEstado(string Tipo_id, int Id, string DV)
        {
            string SQL;
            SQL = "SELECT Inmuebles.estado, Count(Inmuebles.estado) as cantidad" +
                " FROM (Inmuebles INNER JOIN Prop_Inmuebles ON Inmuebles.cod_inmueble=Prop_Inmuebles.cod_inmueble) ";
            if (string.IsNullOrWhiteSpace(DV)) SQL += " WHERE Prop_Inmuebles.tipo_id = '" + Tipo_id + "' AND Prop_Inmuebles.id_propietario = " + Id;
            else SQL += " WHERE Prop_Inmuebles.tipo_id = '" + Tipo_id + "' AND Prop_Inmuebles.id_propietario = " + Id + " AND DV='" + DV + "'";
            SQL += " GROUP BY Inmuebles.estado;";
            return Data.ConsultaT(SQL);
        }

        public DataTable ListaInmueblesDireccion()
        {
            string SQL;
            SQL = "SELECT Inmuebles.cod_inmueble, inmuebles.direccion" +
                " FROM Inmuebles ";
            //if (string.IsNullOrWhiteSpace(DV)) SQL += " WHERE Prop_Inmuebles.tipo_id = '" + Tipo_id + "' AND Prop_Inmuebles.id_propietario = " + Id;
            //else SQL += " WHERE Prop_Inmuebles.tipo_id = '" + Tipo_id + "' AND Prop_Inmuebles.id_propietario = " + Id + " AND DV='" + DV + "'";
            //SQL += " GROUP BY Inmuebles.estado;";
            return Data.ConsultaT(SQL);
        }

        public DataTable ConsultaXPropietarioConContratoMostrar(string Tipo_id, int Id, string DV)
        {
            string SQL;
            SQL = "SELECT Inmuebles.cod_inmueble, inmuebles.direccion, estados_inmueble.nombre_estado_inmueble, contrato_arren.canon, contrato_arren.fecha_vencimiento, Contrato_Arren.no_contrato, contrato_arren.sujeto_iva_prop " +
                " FROM (((contrato_arren INNER JOIN inmuebles ON contrato_arren.cod_inmueble = inmuebles.cod_inmueble) " +
                    " INNER JOIN estados_inmueble ON inmuebles.estado = estados_inmueble.estado_inmueble)" +
                    " INNER JOIN prop_inmuebles ON prop_inmuebles.cod_inmueble = inmuebles.cod_inmueble) ";
            if (string.IsNullOrWhiteSpace(DV)) SQL += " WHERE prop_inmuebles.tipo_id = '" + Tipo_id + "' AND prop_inmuebles.id_propietario = " + Id;
            else SQL += " WHERE prop_inmuebles.tipo_id = '" + Tipo_id + "' AND prop_inmuebles.id_propietario = " + Id + " AND DV='" + DV + "'";
            SQL += " AND contrato_arren.fecha_vencimiento>contrato_arren.pago_hasta_prop";
            SQL += " ORDER BY inmuebles.cod_inmueble;";
            return Data.ConsultaT(SQL);
        }
        public DataTable ConsultaXPropietarioConContrato(string Tipo_id, int Id, string DV)
        {
            string SQL;
            SQL = "SELECT Inmuebles.*, Contrato_Arren.no_contrato, estados_inmueble.nombre_estado_inmueble " +
                " FROM (((contrato_arren INNER JOIN inmuebles ON contrato_arren.cod_inmueble = inmuebles.cod_inmueble) "+
                    " INNER JOIN estados_inmueble ON inmuebles.estado = estados_inmueble.estado_inmueble)" +
                    " INNER JOIN prop_inmuebles ON prop_inmuebles.cod_inmueble = inmuebles.cod_inmueble) ";
            if (string.IsNullOrWhiteSpace(DV)) SQL += " WHERE prop_inmuebles.tipo_id = '" +Tipo_id + "' AND prop_inmuebles.id_propietario = " + Id ;
            else SQL += " WHERE prop_inmuebles.tipo_id = '" + Tipo_id + "' AND prop_inmuebles.id_propietario = " + Id + " AND DV='" + DV + "'";
            SQL += " AND contrato_arren.fecha_vencimiento>contrato_arren.pago_hasta_prop";
            SQL += " ORDER BY inmuebles.cod_inmueble;";
            return Data.ConsultaT(SQL);
        }
        public DataTable Consultar()
        {
            return Data.ConsultaT("SELECT * FROM Inmuebles");
        }
        public long Insertar(M_Inmuebles Inmuebles)
        {
            return Data.Accion("INSERT INTO Inmuebles (Cod_inmueble,Tipo_inmueble,Direccion,Descripcion,Agua,Luz,Telefono,No_telefono,Parabolica,Vigilancia,Administracion,Estado,Canonarrendar,Ultimocont,Cod_direccion,No_direccion,No_direccion_puerta,Cod_barrio,Llave_ciudad,Destino_inmueble,Valorventa,Ambito,Cod_empresa,Valor_admon,Observaciones,Gas,Estrato,Metraje,No_contratos_arren, Latitud, Longitud, Matricula_inm)" +
                " VALUES (" + Inmuebles.Cod_inmueble + "," + Inmuebles.Tipo_inmueble + ", '" + Inmuebles.Direccion + "'" + ", '" + Inmuebles.Descripcion + "'" + "," + Inmuebles.Agua + "," + Inmuebles.Luz + "," + Inmuebles.Telefono + ", '" + Inmuebles.No_telefono + "'" + "," + Inmuebles.Parabolica + "," + Inmuebles.Vigilancia + "," + Inmuebles.Administracion + ", '" + Inmuebles.Estado + "'" + "," + Inmuebles.Canonarrendar + "," + Inmuebles.Ultimocont + "," + Inmuebles.Cod_direccion + ", '" + Inmuebles.No_direccion + "'" + ", '" + Inmuebles.No_direccion_puerta + "'" + "," + Inmuebles.Cod_barrio + "," + Inmuebles.Llave_ciudad + "," + Inmuebles.Destino_inmueble + "," + Inmuebles.Valorventa + ", '" + Inmuebles.Ambito + "'" + "," + Inmuebles.Cod_empresa + "," + Inmuebles.Valor_admon + ", '" + Inmuebles.Observaciones + "'" + "," + Inmuebles.Gas + "," + Inmuebles.Estrato + "," + Inmuebles.Metraje + "," + Inmuebles.No_contratos_arren + "," + Inmuebles.Latitud + "," + Inmuebles.Longitud + "," + Inmuebles.Matricula_inm + ");");
        }
        public long Actualizar(M_Inmuebles Inmuebles)
        {
            return Data.Accion("UPDATE Inmuebles SET Cod_inmueble=" + Inmuebles.Cod_inmueble + ",Tipo_inmueble=" + Inmuebles.Tipo_inmueble + ",Direccion='" + Inmuebles.Direccion + "'" + ",Descripcion='" + Inmuebles.Descripcion + "'" + ",Agua=" + Inmuebles.Agua + ",Luz=" + Inmuebles.Luz + ",Telefono=" + Inmuebles.Telefono + ",No_telefono='" + Inmuebles.No_telefono + "'" + ",Parabolica=" + Inmuebles.Parabolica + ",Vigilancia=" + Inmuebles.Vigilancia + ",Administracion=" + Inmuebles.Administracion + ",Estado='" + Inmuebles.Estado + "'" + ",Canonarrendar=" + Inmuebles.Canonarrendar + ",Ultimocont=" + Inmuebles.Ultimocont + ",Cod_direccion=" + Inmuebles.Cod_direccion + ",No_direccion='" + Inmuebles.No_direccion + "'" + ",No_direccion_puerta='" + Inmuebles.No_direccion_puerta + "'" + ",Cod_barrio=" + Inmuebles.Cod_barrio + ",Llave_ciudad=" + Inmuebles.Llave_ciudad + ",Destino_inmueble=" + Inmuebles.Destino_inmueble + ",Valorventa=" + Inmuebles.Valorventa + ",Ambito='" + Inmuebles.Ambito + "'" + ",Cod_empresa=" + Inmuebles.Cod_empresa + ",Valor_admon=" + Inmuebles.Valor_admon + ",Observaciones='" + Inmuebles.Observaciones + "'" + ",Gas=" + Inmuebles.Gas + ",Estrato=" + Inmuebles.Estrato + ",Metraje=" + Inmuebles.Metraje + ",No_contratos_arren=" + Inmuebles.No_contratos_arren + ",Latitud=" + Inmuebles.Latitud + ",Longitud=" + Inmuebles.Longitud + ",Matricula_inm=" + Inmuebles.Matricula_inm +
                " WHERE Cod_inmueble= " + Inmuebles.Cod_inmueble + ";");
        }
        public long Nuevo(M_Inmuebles Inmuebles)
        {
            Dictionary<string, object> Parametros = new Dictionary<string, object>
         {
           {"Cod_inmueble", Inmuebles.Cod_inmueble},
           {"Tipo_inmueble", Inmuebles.Tipo_inmueble},
           {"Direccion", Inmuebles.Direccion},
           {"Descripcion", Inmuebles.Descripcion},
           {"Agua", Inmuebles.Agua},
           {"Luz", Inmuebles.Luz},
           {"Telefono", Inmuebles.Telefono},
           {"No_telefono", Inmuebles.No_telefono},
           {"Parabolica", Inmuebles.Parabolica},
           {"Vigilancia", Inmuebles.Vigilancia},
           {"Administracion", Inmuebles.Administracion},
           {"Estado", Inmuebles.Estado},
           {"Canonarrendar", Inmuebles.Canonarrendar},
           {"Ultimocont", Inmuebles.Ultimocont},
           {"Cod_direccion", Inmuebles.Cod_direccion},
           {"No_direccion", Inmuebles.No_direccion},
           {"No_direccion_puerta", Inmuebles.No_direccion_puerta},
           {"Cod_barrio", Inmuebles.Cod_barrio},
           {"Llave_ciudad", Inmuebles.Llave_ciudad},
           {"Destino_inmueble", Inmuebles.Destino_inmueble},
           {"Valorventa", Inmuebles.Valorventa},
           {"Ambito", Inmuebles.Ambito},
           {"Cod_empresa", Inmuebles.Cod_empresa},
           {"Valor_admon", Inmuebles.Valor_admon},
           {"Observaciones", Inmuebles.Observaciones},
           {"Gas", Inmuebles.Gas},
           {"Estrato", Inmuebles.Estrato},
           {"Metraje", Inmuebles.Metraje},
           {"No_contratos_arren", Inmuebles.No_contratos_arren},
           {"Latitud", Inmuebles.Latitud},
           {"Longitud", Inmuebles.Longitud},
           {"Matricula_inm", Inmuebles.Matricula_inm}
         };
            return Data.EjecutarSPEscalar("{CALL sp_Nuevo_Inmuebles(?,?,?,?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)}", Parametros);
        }
    }
}
