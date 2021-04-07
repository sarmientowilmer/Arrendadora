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
    public class N_Imagenes_Detalle_Inventario : N_General
    {
        public M_Imagenes_Detalle_Inventario C_Imagenes_Detalle_Inventario = new M_Imagenes_Detalle_Inventario();
        //ClsDatos Data = new ClsDatos();
        public bool Existe(int Cod_inmueble, int Cod_inv, int Numero_cod, int Numero_imagen, bool CargarDatos)
        {
            DataTable DT = new DataTable();
            DT = Data.ConsultaT("SELECT * FROM Imagenes_Detalle_Inventario WHERE Cod_inmueble= " + Cod_inmueble + " and Cod_inv=" + Cod_inv + " and Numero_cod=" + Numero_cod + " and Numero_imagen=" + Numero_imagen);
            bool ExisteRegistro = false;
            if (DT.Rows.Count > 0)
            {
                ExisteRegistro = true;
                if (CargarDatos)
                {
                    C_Imagenes_Detalle_Inventario.Cod_inmueble = Convert.ToInt32(DT.Rows[0]["Cod_inmueble"]);
                    C_Imagenes_Detalle_Inventario.Cod_inv = Convert.ToInt32(DT.Rows[0]["Cod_inv"]);
                    C_Imagenes_Detalle_Inventario.Numero_cod = Convert.ToInt32(DT.Rows[0]["Numero_cod"]);
                    C_Imagenes_Detalle_Inventario.Numero_imagen = Convert.ToInt32(DT.Rows[0]["Numero_imagen"]);
                    C_Imagenes_Detalle_Inventario.Descripcion = DT.Rows[0]["Descripcion"].ToString();
                    C_Imagenes_Detalle_Inventario.Nombre_imagen = DT.Rows[0]["Nombre_imagen"].ToString();
                }
            }
            return ExisteRegistro;
        }
        public M_Imagenes_Detalle_Inventario Consultar(int Cod_inmueble, int Cod_inv, int Numero_cod, int Numero_imagen)
        {
            if (Existe(Cod_inmueble, Cod_inv, Numero_cod, Numero_imagen, true))
            {
                return C_Imagenes_Detalle_Inventario;
            }
            else
            {
                return null;
            }
        }
        public DataTable Consultar()
        {
            return Data.ConsultaT("SELECT * FROM Imagenes_Detalle_Inventario");
        }

        public DataTable Consultar(int Cod_inmueble)
        {
            return Data.ConsultaT("SELECT * FROM Imagenes_Detalle_Inventario WHERE cod_inmueble=" + Cod_inmueble);
        }

        public DataTable ImagenesInmueble(int Cod_inmueble)
        {
            return Data.ConsultaT("SELECT Detalle_Inventario.cod_inmueble, Detalle_Inventario.orden_ver, Imagenes_Detalle_Inventario.Nombre_imagen" +
                " FROM Detalle_Inventario INNER JOIN Imagenes_Detalle_Inventario ON(Detalle_Inventario.numero_cod = Imagenes_Detalle_Inventario.numero_cod) AND(Detalle_Inventario.cod_inv = Imagenes_Detalle_Inventario.cod_inv) AND(Detalle_Inventario.cod_inmueble = Imagenes_Detalle_Inventario.cod_inmueble)" +
                " WHERE Detalle_Inventario.cod_inmueble = " + Cod_inmueble +
                " ORDER BY Detalle_Inventario.orden_ver;");

        }
        public long Insertar(M_Imagenes_Detalle_Inventario Imagenes_Detalle_Inventario)
        {
            return Data.Accion("INSERT INTO Imagenes_Detalle_Inventario (Cod_inmueble,Cod_inv,Numero_cod,Numero_imagen,Descripcion,Nombre_imagen) VALUES (" + Imagenes_Detalle_Inventario.Cod_inmueble + "," + Imagenes_Detalle_Inventario.Cod_inv + "," + Imagenes_Detalle_Inventario.Numero_cod + "," + Imagenes_Detalle_Inventario.Numero_imagen + ", '" + Imagenes_Detalle_Inventario.Descripcion + "'" + ", '" + Imagenes_Detalle_Inventario.Nombre_imagen + "'" + ");");
        }
        public long Actualizar(M_Imagenes_Detalle_Inventario Imagenes_Detalle_Inventario)
        {
            return Data.Accion("UPDATE Imagenes_Detalle_Inventario SET Cod_inmueble=" + Imagenes_Detalle_Inventario.Cod_inmueble + ",Cod_inv=" + Imagenes_Detalle_Inventario.Cod_inv + ",Numero_cod=" + Imagenes_Detalle_Inventario.Numero_cod + ",Numero_imagen=" + Imagenes_Detalle_Inventario.Numero_imagen + ",Descripcion='" + Imagenes_Detalle_Inventario.Descripcion + "'" + ",Nombre_imagen='" + Imagenes_Detalle_Inventario.Nombre_imagen + "'" + " WHERE Cod_inmueble= " + Imagenes_Detalle_Inventario.Cod_inmueble + " and Cod_inv=" + Imagenes_Detalle_Inventario.Cod_inv + " and Numero_cod=" + Imagenes_Detalle_Inventario.Numero_cod + " and Numero_imagen=" + Imagenes_Detalle_Inventario.Numero_imagen + ";");
        }
        public long Nuevo(M_Imagenes_Detalle_Inventario Imagenes_Detalle_Inventario)
        {
            Dictionary<string, object> Parametros = new Dictionary<string, object>
         {
           {"Cod_inmueble", Imagenes_Detalle_Inventario.Cod_inmueble},
           {"Cod_inv", Imagenes_Detalle_Inventario.Cod_inv},
           {"Numero_cod", Imagenes_Detalle_Inventario.Numero_cod},
           {"Numero_imagen", Imagenes_Detalle_Inventario.Numero_imagen},
           {"Descripcion", Imagenes_Detalle_Inventario.Descripcion},
           {"Nombre_imagen", Imagenes_Detalle_Inventario.Nombre_imagen}
         };
            return Data.EjecutarSPEscalar("{CALL sp_Nuevo_Imagenes_Detalle_Inventario(?, ?, ?, ?, ?, ?)}", Parametros);
        }
        public string GrabarDatosGrid(DataTable DT)
        {
            string resultado = "OK";
            //string Cadena = "";

            if (DT.Rows.Count > 0)
            {
                foreach (DataRow Fila in DT.Rows)
                {
                    C_Imagenes_Detalle_Inventario.Cod_inmueble = Convert.ToInt32(Fila["Cod_inmueble"]);
                    C_Imagenes_Detalle_Inventario.Cod_inv = Convert.ToInt32(Fila["Cod_inv"]);
                    C_Imagenes_Detalle_Inventario.Numero_cod = Convert.ToInt32(Fila["Numero_cod"]);
                    C_Imagenes_Detalle_Inventario.Numero_imagen = Convert.ToInt32(Fila["Numero_imagen"]);
                    C_Imagenes_Detalle_Inventario.Descripcion = Fila["Descripcion"].ToString();
                    //Cadena=Fila["Descripcion"].ToString().Replace("\\","/");
                    //Cadena= Cadena.Replace("\\","/");
                    C_Imagenes_Detalle_Inventario.Nombre_imagen = Fila["Nombre_imagen"].ToString().Replace("\\", "/");

                    if (Existe(C_Imagenes_Detalle_Inventario.Cod_inmueble, C_Imagenes_Detalle_Inventario.Cod_inv, C_Imagenes_Detalle_Inventario.Numero_cod, C_Imagenes_Detalle_Inventario.Numero_imagen, false))
                    {
                        if (Actualizar(C_Imagenes_Detalle_Inventario) == 0) resultado = "Error al actualizar el registro";
                    }
                    else
                    {
                        if (Insertar(C_Imagenes_Detalle_Inventario) == 0) resultado = "Error al insertar el registro";
                    }
                }
            }
            return resultado;
        }

    }
}
