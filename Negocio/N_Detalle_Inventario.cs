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
    public class N_Detalle_Inventario : N_General
    {
        public M_Detalle_Inventario C_Detalle_Inventario = new M_Detalle_Inventario();
        //ClsDatos Data = new ClsDatos();
        public bool Existe(int Cod_inmueble, int Cod_inv, int Numero_cod, bool CargarDatos)
        {
            DataTable DT = new DataTable();
            DT = Data.ConsultaT("SELECT * FROM Detalle_Inventario WHERE Cod_inmueble= " + Cod_inmueble + " and Cod_inv=" + Cod_inv + " and Numero_cod=" + Numero_cod);
            bool ExisteRegistro = false;
            if (DT.Rows.Count > 0)
            {
                ExisteRegistro = true;
                if (CargarDatos)
                {
                    C_Detalle_Inventario.Cod_inmueble = Convert.ToInt32(DT.Rows[0]["Cod_inmueble"]);
                    C_Detalle_Inventario.Cod_inv = Convert.ToInt32(DT.Rows[0]["Cod_inv"]);
                    C_Detalle_Inventario.Numero_cod = Convert.ToInt32(DT.Rows[0]["Numero_cod"]);
                    C_Detalle_Inventario.Descripcion = DT.Rows[0]["Descripcion"].ToString();
                    C_Detalle_Inventario.Nombre_imagen = DT.Rows[0]["Nombre_imagen"].ToString();
                    C_Detalle_Inventario.Orden_ver = Convert.ToInt32(DT.Rows[0]["Orden_ver"]);
                }
            }
            return ExisteRegistro;
        }
        public M_Detalle_Inventario Consultar(int Cod_inmueble, int Cod_inv, int Numero_cod)
        {
            if (Existe(Cod_inmueble, Cod_inv, Numero_cod, true))
            {
                return C_Detalle_Inventario;
            }
            else
            {
                return null;
            }
        }
        public DataTable Consultar()
        {
            return Data.ConsultaT("SELECT * FROM Detalle_Inventario");
        }
        public DataTable Consultar(int Cod_inmueble)
        {
            return Data.ConsultaT("SELECT * FROM Detalle_Inventario WHERE cod_inmueble=" + Cod_inmueble);
        }

        public DataTable ConsultarTotalesInventario (int Cod_inmueble)
        {
            return Data.ConsultaT("SELECT Detalle_Inventario.cod_inv, Cod_Inventario.descripcion_cod, Count(Detalle_Inventario.cod_inv) AS Cantidad" +
                " FROM Cod_Inventario INNER JOIN Detalle_Inventario ON Cod_Inventario.cod_inventario = Detalle_Inventario.cod_inv" +
                " WHERE Detalle_Inventario.cod_inmueble = " + Cod_inmueble +
                " GROUP BY Detalle_Inventario.cod_inv, Cod_Inventario.descripcion_cod;");
        }
        public long Insertar(M_Detalle_Inventario Detalle_Inventario)
        {
            return Data.Accion("INSERT INTO Detalle_Inventario (Cod_inmueble,Cod_inv,Numero_cod,Descripcion,Nombre_imagen,Orden_ver) VALUES (" + Detalle_Inventario.Cod_inmueble + "," + Detalle_Inventario.Cod_inv + "," + Detalle_Inventario.Numero_cod + ", '" + Detalle_Inventario.Descripcion + "'" + ", '" + Detalle_Inventario.Nombre_imagen + "'" + "," + Detalle_Inventario.Orden_ver + ");");
        }
        public long Actualizar(M_Detalle_Inventario Detalle_Inventario)
        {
            return Data.Accion("UPDATE Detalle_Inventario SET Cod_inmueble=" + Detalle_Inventario.Cod_inmueble + ",Cod_inv=" + Detalle_Inventario.Cod_inv + ",Numero_cod=" + Detalle_Inventario.Numero_cod + ",Descripcion='" + Detalle_Inventario.Descripcion + "'" + ",Nombre_imagen='" + Detalle_Inventario.Nombre_imagen + "'" + ",Orden_ver=" + Detalle_Inventario.Orden_ver + " WHERE Cod_inmueble= " + Detalle_Inventario.Cod_inmueble + " and Cod_inv=" + Detalle_Inventario.Cod_inv + " and Numero_cod=" + Detalle_Inventario.Numero_cod + ";");
        }
        public long Nuevo(M_Detalle_Inventario Detalle_Inventario)
        {
            Dictionary<string, object> Parametros = new Dictionary<string, object>
         {
           {"Cod_inmueble", Detalle_Inventario.Cod_inmueble},
           {"Cod_inv", Detalle_Inventario.Cod_inv},
           {"Numero_cod", Detalle_Inventario.Numero_cod},
           {"Descripcion", Detalle_Inventario.Descripcion},
           {"Nombre_imagen", Detalle_Inventario.Nombre_imagen},
           {"Orden_ver", Detalle_Inventario.Orden_ver}
         };
            return Data.EjecutarSPEscalar("{CALL sp_Nuevo_Detalle_Inventario(?, ?, ?, ?, ?, ?)}", Parametros);
        }
        public string GrabarDatosGrid(DataTable DT)
        {
            string resultado = "OK";
            //string Cadena = "";

            if (DT.Rows.Count > 0)
            {
                foreach (DataRow Fila in DT.Rows)
                {
                    C_Detalle_Inventario.Cod_inmueble = Convert.ToInt32(Fila["Cod_inmueble"]);
                    C_Detalle_Inventario.Cod_inv = Convert.ToInt32(Fila["Cod_inv"]);
                    C_Detalle_Inventario.Numero_cod = Convert.ToInt32(Fila["Numero_cod"]);
                    C_Detalle_Inventario.Descripcion = Fila["Descripcion"].ToString();
                    //Cadena=Fila["Descripcion"].ToString().Replace("\\","/");
                    C_Detalle_Inventario.Nombre_imagen = Fila["Nombre_imagen"].ToString().Replace("\\", "/");
                    C_Detalle_Inventario.Orden_ver = Convert.ToInt32(Fila["Orden_ver"]);

                    if (Existe(C_Detalle_Inventario.Cod_inmueble, C_Detalle_Inventario.Cod_inv, C_Detalle_Inventario.Numero_cod, false))
                    {
                        if (Actualizar(C_Detalle_Inventario) == 0) resultado = "Error al actualizar el registro";
                    }
                    else
                    {
                        if (Insertar(C_Detalle_Inventario) == 0) resultado = "Error al insertar el registro";
                    }
                }
            }
            return resultado;
        }

    }
}
