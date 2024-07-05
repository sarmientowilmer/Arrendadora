using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace Arrendadora
{
    public partial class FrmPasarFotos : Form
    {
        string Servidor = "APAW10SER"; //System.Configuration.ConfigurationManager.AppSettings["Servidor"]; ;
        string PathDatos = "Arrendadora"; //System.Configuration.ConfigurationManager.AppSettings["PathDatosAccess"];

        public FrmPasarFotos()
        {
            InitializeComponent();
        }

        public bool GrabarArchivo(string NombreArchivo, string DirectorioOrigen_, string DirectorioDestino_)
        {
            //string NombreArchivo = "";
            //string CarpetaInmueble = "inm_" + Cod_inmueble.ToString();

            string DirectorioOrigen = @"\\" + Servidor + @"\" + PathDatos + @"\" + DirectorioOrigen_.Replace("/", @"\");
            string DirectorioDestino = @"\\" + Servidor + @"\" + PathDatos + @"\" + DirectorioDestino_.Replace("/", @"\");
            if (File.Exists(DirectorioDestino + @"\" + NombreArchivo))
            {
                FileInfo infArchivo1 = new FileInfo(DirectorioDestino + @"\" + NombreArchivo);
                FileInfo infArchivo2 = new FileInfo(DirectorioOrigen + @"\" + NombreArchivo);
                try
                {
                    if (infArchivo1.Length != infArchivo2.Length)
                    {
                        File.Delete(DirectorioDestino + @"\" + NombreArchivo);
                        File.Copy(DirectorioOrigen + @"\" + NombreArchivo, DirectorioDestino + @"\" + NombreArchivo);
                    }
                }
                catch (Exception Ex)
                {
                    Console.Write(Ex.Message);
                    return false;
                }
            }
            else
            {
                try
                {
                    File.Copy(DirectorioOrigen + @"\" + NombreArchivo, DirectorioDestino + @"\" + NombreArchivo);
                }
                catch (Exception Ex)
                {
                    Console.WriteLine(Ex.Message);
                }
            }
            //FormPrincipal_.MostrarMensaje("Comprimiendo imagen....");
            //CambiarTamañoImagen(DirectorioDestino + @"\" + NombreArchivo, DirectorioDestino);
            //FormPrincipal_.MostrarMensaje("Listo");
            // Nombre_archivo = @"Fotos\Fotos inms\" + CarpetaInmueble + @"\" + NombreArchivo;

            return true;
        }

        public void CrearDirectorio(string DirectorioDestino)
        {
            if (!Directory.Exists(@"\\" + Servidor + @"\" + PathDatos + @"\" + DirectorioDestino))
            {
                try
                {
                    Directory.CreateDirectory(@"\\" + Servidor + @"\" + PathDatos + @"\" + DirectorioDestino);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void ExtraerDatos(string NombreImagenDI, ref string NombreArchivo, ref string DirectorioOrigen)
        {
            if (NombreImagenDI != "")
            {
                string Tem = NombreImagenDI;
                do
                {
                    if (Tem.Contains("/"))
                    {
                        Tem = Tem.Substring(Tem.IndexOf("/") + 1);
                    }
                    if (Tem.Contains(@"\"))
                    {
                        Tem = Tem.Substring(Tem.IndexOf(@"\") + 1);
                    }
                }
                while (Tem.Contains("/") || Tem.Contains(@"\"));
                NombreArchivo = Tem;
                DirectorioOrigen = NombreImagenDI.Substring(0, NombreImagenDI.IndexOf(Tem) - 1);
            }
        }

        private void BtnDetalleInv_Click(object sender, EventArgs e)
        {
            N_Detalle_Inventario DI = new N_Detalle_Inventario();
            N_Imagenes_Detalle_Inventario IDI = new N_Imagenes_Detalle_Inventario();

            //DI.Cadena(Program.GsPathData);
            //IDI.Cadena(Program.GsPathData);


            DataTable Tabla = DI.Consultar();
            string NombreImagenDI;
            string DirectorioDestino = "";
            string NombreArchivo = "";
            string DirectorioOrigen = "";
            PBar.Minimum = 1;
            PBar.Maximum = Tabla.Rows.Count - 1;
            foreach (DataRow Fila in Tabla.Rows)
            {
                //PBar.Value++;
                Application.DoEvents();
                DirectorioDestino = @"Fotos\fotos_inm\inm_" + Fila["Cod_inmueble"];
                NombreImagenDI = Fila["Nombre_imagen"].ToString();
                if (NombreImagenDI != "") ExtraerDatos(NombreImagenDI, ref NombreArchivo, ref DirectorioOrigen);
                DGVDetalle.Rows.Add(NombreArchivo, DirectorioOrigen, DirectorioDestino);
                DirectorioOrigen.Replace("/", @"\");
                DirectorioDestino.Replace("/", @"\");
                CrearDirectorio(DirectorioDestino);
                GrabarArchivo(NombreArchivo, DirectorioOrigen, DirectorioDestino);
                //Pasar las imagenes del detalle
                DataTable DTImagenes = IDI.ImagenesInmueble(Convert.ToInt32(Fila["Cod_inmueble"]));
                foreach (DataRow Item in DTImagenes.Rows)
                {
                    NombreImagenDI = Item["Nombre_imagen"].ToString();
                    if (NombreImagenDI != "") ExtraerDatos(NombreImagenDI, ref NombreArchivo, ref DirectorioOrigen);
                    DGVDetalle.Rows.Add(NombreArchivo, DirectorioOrigen, DirectorioDestino);
                    GrabarArchivo(NombreArchivo, DirectorioOrigen, DirectorioDestino);

                }
            }
            MessageBox.Show("Terminó el proceso");
        }
    }
}
