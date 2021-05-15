using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Data.Odbc;
using System.IO;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Configuration;

namespace AccesoDatos
{
    public class ClsDatos
    {
        public string GsPath { get; set; }
        public string sBaseDatos = "Arrendadora.mdb";
        string gsServidor;
        public string CadenaConexion { get; set; }
        public string ConectaA { get; set; }
        public string Servidor { get; set; }
        public string PathDatosAccess { get; set; }

        public ClsDatos()
        {
            Servidor = ConfigurationManager.AppSettings["Servidor"]; 
            string BD = ConfigurationManager.AppSettings["BD"];
            string BDAccess = ConfigurationManager.AppSettings["BDAccess"];
            PathDatosAccess = ConfigurationManager.AppSettings["PathDatosAccess"];
            ConectaA = ConfigurationManager.AppSettings["ConectarA"];
            switch (ConectaA)
            {
                case "Access":
                    //CadenaConexion= "driver={Microsoft Access Driver (*.mdb)};" + "dbq=" + @"\\" + Servidor + @"\" + PathDatosAccess + @"\" + BDAccess + "; uid=admin; pwd=100475wfsj";
                    CadenaConexion = "Provider = Microsoft.Jet.OLEDB.4.0; Data source = " + @"\\" + Servidor + @"\" + PathDatosAccess + @"\" + BDAccess + "; Persist Security Info = False; JET OLEDB:DATABASE PASSWORD = 100475wfsj";
                    break;
                case "MariaDB":
                    CadenaConexion = "Driver={MariaDB ODBC 3.1 Driver};tcpip=1;server=" + Servidor + ";uid=apa_user;database=" + BD + ";port=3306;charset=utf8;pwd=7ex84OzO4A8I;";
                    break;
                case "MySQL": 
                    CadenaConexion = "datasource=" + Servidor + ";port=3306;username=apa_user;password=7ex84OzO4A8I;database=" + BD + ";charset=utf8";
                    break;
                default:
                    CadenaConexion = "Provider = Microsoft.Jet.OLEDB.4.0; Data source = " + @"\\" + Servidor + @"\" + PathDatosAccess + @"\" + BDAccess + "; Persist Security Info = False; JET OLEDB:DATABASE PASSWORD = 100475wfsj";
                    break;
            }

        }

        public ClsDatos(string Path)
        {
            DatosServidoryPath(Path);
            Cadena();
        }

        public ClsDatos(string Path, string Servidor)
        {
            ConectaA = Servidor;
            if (ConectaA==null) DatosServidoryPath(Path);
            Cadena();
        }

        public void ConectarA (string ConectarA)
        {
            ConectaA = ConectarA;
        }

        public void Cadena(string path = "")
        {
            if (ConectaA == "MariaDB")
            {
                CadenaConexion = "driver={MariaDB ODBC 3.1 Driver}; Server = www.arrendamientosparadaalarcon.com.co; Port = 3306; charset = UTF8; " +
                    " Database = arrend_apaweb; User = arrend_apa; Password =W]qUdQ-ho3(H ; Option = 3;";
            }
            else if (ConectaA == "Access")
            {
                CadenaConexion = "Provider = Microsoft.Jet.OLEDB.4.0; Data source = " + path + sBaseDatos + "; Persist Security Info = False; JET OLEDB:DATABASE PASSWORD = 100475wfsj";
            }
            else if (!string.IsNullOrEmpty(ConectaA))
            {
                CadenaConexion = "driver={MariaDB ODBC 3.1 Driver}; Server = " + ConectaA + "; Port = 3306; charset = UTF8; " +
                    " Database = arrendadora; User = apa_user; Password =7ex84OzO4A8I ; Option = 3;";
            }
            else
            {
                if (path == "")
                {
                    //CadenaConexion = "Provider = Microsoft.Jet.OLEDB.4.0; Data source = " + gsPath + sBaseDatos + "; Persist Security Info = False; JET OLEDB:DATABASE PASSWORD = 100475wfsj";
                    CadenaConexion = "driver={Microsoft Access Driver (*.mdb)};" + "dbq=" + GsPath + sBaseDatos + "; uid=admin; pwd=100475wfsj";
                    //CadenaConexion = "driver={MariaDB ODBC 3.1 Driver}; Server = wilmer_portatil; Port = 3306; charset = UTF8; " +
                    //    " Database = Arrendadora; User = usu_cap; Password =123456 ; Option = 3;";
                }
                else
                {
                    //CadenaConexion = "Provider = Microsoft.Jet.OLEDB.4.0; Data source = " + gsPath + sBaseDatos + "; Persist Security Info = False; JET OLEDB:DATABASE PASSWORD = 100475wfsj";
                    CadenaConexion = "driver={Microsoft Access Driver (*.mdb)};" + "dbq=" + path + sBaseDatos + "; uid=admin; pwd=100475wfsj";
                    //CadenaConexion = "driver={MariaDB ODBC 3.1 Driver}; Server = wilmer_portatil; Port = 3306; charset = UTF8; " +
                    //    " Database = Arrendadora; User = usu_cap; Password =123456 ; Option = 3;";
                    if (GsPath == null) GsPath = path;

                }
            }
        }

        public void DatosServidoryPath(string pathprograma)
        {
            string DATO;
            if (ConectaA == null)
            {
                //string archivo = Application.StartupPath + @"\datoserv.txt";
                string archivo = pathprograma + @"\datoserv.txt";
                
                System.IO.StreamReader file =
                new System.IO.StreamReader(archivo);
                if ((DATO = file.ReadLine()) != " ")
                {

                    gsServidor = @"\\" + DATO.Trim() + @"\";
                    DATO = file.ReadLine();
                    if (DATO != " ")
                    {
                        //gsServidor = "";
                        if (!string.IsNullOrWhiteSpace(DATO))
                        {
                            GsPath = gsServidor + DATO.Trim() + @"\";
                        }
                    }
                }
                else
                {
                    if (DATO == " ")
                    {
                        //MessageBox.Show( Application.CommonAppDataPath);
                        gsServidor = pathprograma.Substring(0, 3);
                        GsPath = gsServidor + pathprograma.Substring(3, pathprograma.Length - 3) + @"\";
                    }
                }
                file.Close();
            }
        }

        public string EjecutarSPString(string CadSP, Dictionary<string, object> Parametros)
        {
            string Resultado = "";
            OdbcConnection con = new OdbcConnection(CadenaConexion);
            OdbcCommand cmd = new OdbcCommand();

            try
            {
                cmd.CommandText = CadSP;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;
                if (Parametros != null) cmd = AddParameters(cmd, Parametros);
                con.Open();
                Resultado = cmd.ExecuteNonQuery().ToString();
                con.Close();
                return Resultado;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                return ex.Message;
                //con.Close();
                throw ex;
            }
        }

        public long EjecutarSPEscalar(string CadSP, Dictionary<string, object> Parametros)
        {
            long filas = -1;
            OdbcConnection con = new OdbcConnection(CadenaConexion);
            OdbcCommand cmd = new OdbcCommand();

            try
            {
                cmd.CommandText = CadSP;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;
                if (Parametros != null) cmd = AddParameters(cmd, Parametros);
                con.Open();
                filas = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();
                return filas;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return -1;
                //con.Close();
                throw ex;
            }

        }

        private static OdbcCommand AddParameters(OdbcCommand Cmd, Dictionary<string, object> parameters)
        {
            foreach (var item in parameters)
                Cmd.Parameters.AddWithValue("_" + item.Key, item.Value);
            return Cmd;
        }
        
        public DataTable ConsultaTAccess(string Cadsql)
        {
            string Cadena = "";
            DataTable dt = new DataTable();
            //OdbcConnection con = new OdbcConnection(CadenaConexion);
            OleDbConnection con = new OleDbConnection(CadenaConexion);
            try
            {
                con.Open();
                //revisar si tiene # lo cambia por '
                //string CadSinNumeral = Cadsql.Replace("#", "'");
                if (ConectaA != null)
                {
                    Cadena = Cadsql.Replace("#", "'");
                }
                else
                {
                    Cadena = Cadsql;
                }
                //OdbcDataAdapter ad = new OdbcDataAdapter(Cadena, con);
                OleDbDataAdapter ad = new OleDbDataAdapter(Cadsql, con);
                ad.Fill(dt);
                con.Close();
                return dt;
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
                return dt;
                //con.Close();
                throw ex;
            }

        }

        public DataTable ConsultaT(string Cadsql)
        {
            string Cadena = "";
            DataTable dt = new DataTable();
            if (ConectaA == "Access")
            {
                OleDbConnection con = new OleDbConnection(CadenaConexion);
                try
                {
                    con.Open();
                    //revisar si tiene # lo cambia por '
                    //string CadSinNumeral = Cadsql.Replace("#", "'");
                    //OdbcDataAdapter ad = new OdbcDataAdapter(Cadena, con);
                    OleDbDataAdapter ad = new OleDbDataAdapter(Cadsql, con);

                    ad.Fill(dt);
                    con.Close();
                    return dt;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return dt;
                    //con.Close();
                    throw ex;
                }
            }
            else
            {
                OdbcConnection con = new OdbcConnection(CadenaConexion);
                //OleDbConnection con = new OleDbConnection(CadenaConexion);
                try
                {
                    con.Open();
                    //revisar si tiene # lo cambia por '
                    //string CadSinNumeral = Cadsql.Replace("#", "'");
                    if (ConectaA != null)
                    {
                        Cadena = Cadsql.Replace("#", "'");
                        Cadena = Cadena.Replace("IIf", "if");
                    }
                    else
                    {
                        Cadena = Cadsql;
                    }
                    OdbcDataAdapter ad = new OdbcDataAdapter(Cadena, con);
                    //OleDbDataAdapter ad = new OleDbDataAdapter(cadsql, con);
                    ad.Fill(dt);
                    con.Close();
                    return dt;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return dt;
                    //con.Close();
                    throw ex;
                }
            }

        }
        public DataSet Consulta(string cadsql, string nombre)
        {
            string Cadena="";
            DataSet ds = new DataSet();
            OdbcConnection con = new OdbcConnection(CadenaConexion);
            //OleDbConnection con = new OleDbConnection(CadenaConexion);
            try
            {
                con.Open();
                if (ConectaA != null)
                {
                    Cadena = cadsql.Replace("#", "'");
                }
                else
                {
                    Cadena = cadsql;
                }
                
                OdbcDataAdapter ad = new OdbcDataAdapter(Cadena, con);
                //OleDbDataAdapter ad = new OleDbDataAdapter(cadsql, con);
                ad.Fill(ds, nombre);
                con.Close();
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return ds;
                throw ex;
            }
        }

        public long Accion(string cadsql)
        {
            string Cadena;
            long filas = -1;
            if (ConectaA == "Access")
            {
                OleDbConnection con = new OleDbConnection(CadenaConexion);
                //OdbcCommand cmd = new OdbcCommand();
                OleDbCommand cmd = new OleDbCommand();
                try
                {
                    //string CadSinNumeral = cadsql.Replace("#", "'");
                    cmd.CommandText = cadsql;
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    con.Open();
                    filas = cmd.ExecuteNonQuery();
                    con.Close();
                    return filas;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return -1;
                    throw ex;
                }
            }
            else
            {
                OdbcConnection con = new OdbcConnection(CadenaConexion);
                OdbcCommand cmd = new OdbcCommand();

                try
                {
                    //string CadSinNumeral = cadsql.Replace("#", "'");
                    if (ConectaA != null)
                    {
                        Cadena = cadsql.Replace("#", "'");
                        Cadena = Cadena.Replace("IIf", "if");
                    }
                    else
                    {
                        Cadena = cadsql;
                    }
                    cmd.CommandText = Cadena;
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    con.Open();
                    filas = cmd.ExecuteNonQuery();
                    con.Close();
                    return filas;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return -1;
                    throw ex;
                }
            }

        }
        //Código para subir imagen a base de datosMYSQL
        //private void SubirAvatar(string filePath)
        //{
        //    byte[] avatar = ConvertirAvatarAByte(filePath);
        //    OdbcConnection con = new OdbcConnection(CadenaConexion);
        //    OdbcCommand cmd = new OdbcCommand();
        //    cmd.Connection =con;
        //    //cmd.CommandText = "UPDATE usuarios SET Avatar = @avatar WHERE NombreUsuario = '" + UOn.getNombre() + "'";
        //    //cmd.Parameters.Add("@avatar", MySqlDbType.MediumBlob, avatar.Length).Value = avatar;
        //    cmd.ExecuteNonQuery();
        //}
        //public static byte[] ConvertirAvatarAByte(string filePath)
        //{
        //    FileStream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
        //    BinaryReader reader = new BinaryReader(stream);

        //    byte[] avatar = reader.ReadBytes((int)stream.Length);

        //    reader.Close();
        //    stream.Close();

        //    return avatar;
        //}
        //termina el código para subir imagen

        //Código para recuperar imagen desde base de datos Mysql
        //byte[] avatarByte = cargarAvatardesdeMYSQL();
        //Imagen.Image = byteArrayToImage(avatarByte);

        //private byte[] CargarAvatardesdeMYSQL()
        //{
        //    OdbcConnection con = new OdbcConnection(CadenaConexion);
        //    OdbcCommand cmd = new OdbcCommand();
        //    cmd.Connection = con;
        //    //cmd.CommandText = "SELECT avatar FROM usuarios WHERE NombreUsuario = '" + UOn.getNombre() + "'";
        //    OdbcDataReader consultar = cmd.ExecuteReader();
        //    if (consultar.Read())
        //    {
        //        byte[] avatarByte = (byte[])consultar["avatar"];
        //        return avatarByte;
        //    }
        //    return null;
        //}
        //public Image byteArrayToImage(byte[] byteAvatar)
        //{
        //    MemoryStream ms = new MemoryStream(byteAvatar);
        //    Image devolverImagen = Image.FromStream(ms);
        //    return devolverImagen;
        //}
        //termina el código para recuperar imagen desde base de datos Mysql


        public int DiasGracia()
        {
            DataTable Control = new DataTable();
            try
            {
                Control = ConsultaT("select diasgracia from control where cod_empresa=1");
                if (Control.Rows.Count > 0)
                {
                    return Convert.ToInt32(Control.Rows[0]["diasgracia"]);
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                return -1;
                throw e;
            }
        }

        public bool ContabCausacion()
        {
            DataTable Control = new DataTable();
            try
            {
                Control = ConsultaT("select contab_causacion from empresas where cod_empresa=1");
                if (Control.Rows.Count > 0)
                {
                    return Convert.ToBoolean(Control.Rows[0]["contab_causacion"]);
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                return false;
                throw e;
            }

        }

        public double TasaMora()
        {
            DataTable Control = new DataTable();
            try
            {
                Control = ConsultaT("select tasamora from control where cod_empresa=1");
                if (Control.Rows.Count > 0)
                {
                    return Convert.ToDouble(Control.Rows[0]["tasamora"]);
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                return -1;
                throw e;
            }
        }

        public string ClaveCorrecta(long Id, string clave)
        {
            DataSet Usuario = new DataSet();
            try
            {
                Usuario = Consulta("select id from usuarios where id=" + Id + " and clave='" + clave + "'", "consula");
                if (Usuario.Tables[0].Rows.Count > 0)
                {
                    return "OK";
                }
                else { return "NoOK"; }
            }
            catch (Exception ex)
            {
                return "ha ocurrido el error " + ex.Message;
            }
        }

    }
}
