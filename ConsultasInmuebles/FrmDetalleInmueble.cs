using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace ConsultasInmuebles
{
    public partial class FrmDetalleInmueble : Form
    {
        N_Inmuebles Inmuebles = new N_Inmuebles();
        N_Imagenes_Detalle_Inventario Imagenes = new N_Imagenes_Detalle_Inventario();
        
        int PosicionImagen = 0;
        Image Imagen;
        FuncionesGenerales Funciones = new FuncionesGenerales();
        DataTable DTInmueble = new DataTable();

        
        DataTable DTImagenes = new DataTable();

        public FrmDetalleInmueble()
        {
            InitializeComponent();
        }

        public FrmDetalleInmueble(N_Inmuebles Inm)
        {
            InitializeComponent();
            Inmuebles = Inm;
            //Imagenes.DatosServidoryPath(Application.StartupPath);
            DTImagenes = Imagenes.ImagenesInmueble(Inmuebles.C_Inmuebles.Cod_inmueble);
            DTInmueble = Inmuebles.DetalleInmueble(Inmuebles.C_Inmuebles.Cod_inmueble);
            MostrarDatos();
            MostrarImagen("derecha");
        }

        private void CargarImagen(ref PictureBox PB, int Posicion)
        {
            string direccion = @"\\" + Imagenes.Servidor + @"\" + Imagenes.PathDatosAccess + @"\";
            //Image img = null;
            PB.Image = null;
            if (DTImagenes.Rows.Count >0 )
            { 
                //Console.Write("Archivo" + direccion + DTImagenes.Rows[0]["cod_inmueble"]);
                Console.WriteLine("Archivo: " + direccion + DTImagenes.Rows[Posicion]["nombre_imagen"]);
                //MessageBox.Show("Archivo" + direccion + DTImagenes.Rows[Posicion]["nombre_imagen"]);
                if (Funciones.ExisteArchivo(direccion + DTImagenes.Rows[Posicion]["nombre_imagen"]))
                {
                    try
                    {
                        using (var bmpTemp = new Bitmap(direccion + DTImagenes.Rows[Posicion]["nombre_imagen"]))
                        {
                            //img = new Bitmap(bmpTemp);
                            //PB.Image = img;
                            PB.Image = new Bitmap(bmpTemp);
                        }

                        //PB.Image = Image.FromFile(direccion + DTImagenes.Rows[Posicion]["nombre_imagen"]);
                        //PB.Image = img;
                    }
                    catch (Exception e)
                    {
                        //MessageBox.Show("Error al cargar la imagen : " + direccion + DTImagenes.Rows[Posicion]["nombre_imagen"] + "\n Mensaje de error: " + e.Message);
                        Console.WriteLine("Error al cargar la imagen : " + direccion + DTImagenes.Rows[Posicion]["nombre_imagen"] + "\n Mensaje de error: " + e.Message);
                        //img.Dispose();
                        //img = null;
                        GC.Collect();
                        GC.WaitForPendingFinalizers();
                        PB.Image = null;
                        using (var bmpTemp = new Bitmap(direccion + DTImagenes.Rows[Posicion]["nombre_imagen"]))
                        {
                            //img = new Bitmap(bmpTemp);
                            //PB.Image = img;
                            PB.Image = new Bitmap(bmpTemp);
                        }
                    }
                }
                else
                {
                    PB.Image = Properties.Resources.camara_de_fotos254;
                }
            }
            else
            {
                PB.Image = Properties.Resources.camara_de_fotos254;
            }
            //img.Dispose();
            //img = null;
        }

        private void MostrarImagen(string Direccion)
        {
            if (Direccion == "derecha")
            {
                if (PosicionImagen > DTImagenes.Rows.Count - 2)
                {
                    PosicionImagen = 0;
                }
                else
                {
                    PosicionImagen++;
                }
                if (PosicionImagen == DTImagenes.Rows.Count - 1)
                {
                    CargarImagen(ref PBImagen1, PosicionImagen);
                    CargarImagen(ref PBImagen2, 0);
                    CargarImagen(ref PBImagen3, 1);
                }
                else if (PosicionImagen > DTImagenes.Rows.Count - 3)
                {
                    CargarImagen(ref PBImagen1, PosicionImagen);
                    CargarImagen(ref PBImagen2, PosicionImagen+1);
                    CargarImagen(ref PBImagen3, 0);
                }
                else
                {
                    CargarImagen(ref PBImagen1, PosicionImagen);
                    CargarImagen(ref PBImagen2, PosicionImagen+1);
                    CargarImagen(ref PBImagen3, PosicionImagen+2);
                }
            }
            else
            {
                if (PosicionImagen ==0)
                {
                    PosicionImagen = DTImagenes.Rows.Count-1;
                }
                else
                {
                    PosicionImagen--;
                }
                if (PosicionImagen == 0)
                {
                    CargarImagen(ref PBImagen1, DTImagenes.Rows.Count - 1);
                    CargarImagen(ref PBImagen2, DTImagenes.Rows.Count - 2);
                    CargarImagen(ref PBImagen3, DTImagenes.Rows.Count - 3);
                }
                else if (PosicionImagen==1)
                {
                    CargarImagen(ref PBImagen1, PosicionImagen);
                    CargarImagen(ref PBImagen2, DTImagenes.Rows.Count - 1);
                    CargarImagen(ref PBImagen3, DTImagenes.Rows.Count - 2);
                }
                else if (PosicionImagen == 2)
                {
                    CargarImagen(ref PBImagen1, PosicionImagen);
                    CargarImagen(ref PBImagen2, PosicionImagen - 1);
                    CargarImagen(ref PBImagen3, DTImagenes.Rows.Count - 1);
                }
                else
                {
                    CargarImagen(ref PBImagen1, PosicionImagen);
                    CargarImagen(ref PBImagen2, PosicionImagen - 1);
                    CargarImagen(ref PBImagen3, PosicionImagen - 1);
                }

            }
            CargarImagen(ref PBImagenPrincipal, PosicionImagen);
        }

        public  void MostrarDatos()
        {
            N_Detalle_Inventario DetalleInventario = new N_Detalle_Inventario();
            DetalleInventario.DatosServidoryPath(Application.StartupPath);
            DataTable DTTotalesInventario = DetalleInventario.ConsultarTotalesInventario(Inmuebles.C_Inmuebles.Cod_inmueble);
            int Habitaciones = 0;  int BañoP = 0; int BañoA = 0; int Sala = 0; int Comedor = 0; int Garaje = 0; int Cocina = 0; int Estudio = 0; int Patio = 0;
            int Solar = 0;
            string Descripcion = "";
            if (DTTotalesInventario.Rows.Count > 0)
            {
                foreach (DataRow Fila in DTTotalesInventario.Rows)
                {
                    Descripcion=Fila["descripcion_cod"].ToString();
                    if (Descripcion.Contains("HABITAC")) { Habitaciones = Convert.ToInt32(Fila["Cantidad"]); }
                    if (Descripcion.Contains("BAÑO P")) { BañoP = Convert.ToInt32(Fila["Cantidad"]); }
                    if (Descripcion.Contains("BAÑO S")) { BañoA = Convert.ToInt32(Fila["Cantidad"]); }
                    if (Descripcion.Contains("SALA")) { Sala = Convert.ToInt32(Fila["Cantidad"]); }
                    if (Descripcion.Contains("COMEDOR")) { Comedor = Convert.ToInt32(Fila["Cantidad"]); }
                    if (Descripcion.Contains("COCINA")) { Cocina = Convert.ToInt32(Fila["Cantidad"]); }
                    if (Descripcion.Contains("PATIO")) { Patio = Convert.ToInt32(Fila["Cantidad"]); }
                    if (Descripcion.Contains("GARAJE")) { Garaje = Convert.ToInt32(Fila["Cantidad"]); }
                    if (Descripcion.Contains("ESTUDIO")) { Estudio = Convert.ToInt32(Fila["Cantidad"]); }
                    if (Descripcion.Contains("SOLAR")) { Solar = Convert.ToInt32(Fila["Cantidad"]); }
                }
            }
            LblHabitaciones.Text = Habitaciones.ToString();
            LblBañoPrincipal.Text = BañoP.ToString();
            LblBañoAuxiliar.Text = BañoA.ToString();
            LblSala.Text = Sala.ToString();
            LblComedor.Text = Comedor.ToString();
            LblCocina.Text = Cocina.ToString();
            LblPatio.Text = Patio.ToString();
            LblGaraje.Text = Garaje.ToString();
            LblEstudio.Text = Estudio.ToString();
            LblSolar.Text = Solar.ToString();
            LblEncabezado.Text = DTInmueble.Rows[0]["Nombre_tipo"].ToString() + " CÓDIGO " + DTInmueble.Rows[0]["cod_inmueble"].ToString() + " - " + DTInmueble.Rows[0]["direccion"].ToString() + " - " +  DTInmueble.Rows[0]["Nombre_barrio"].ToString() + " - " + DTInmueble.Rows[0]["nombre_ciudad"].ToString();
            LblValor.Text = string.Format("{0:N0}", Convert.ToDouble(DTInmueble.Rows[0]["canonarrendar"]));
            LblVenta.Text = string.Format("{0:N0}", Convert.ToDouble(DTInmueble.Rows[0]["valorventa"]));
            LblDescripcion.Text = Inmuebles.C_Inmuebles.Descripcion.ToString();
            LblEstrato.Text = Inmuebles.C_Inmuebles.Estrato.ToString();
            LblArea.Text = Inmuebles.C_Inmuebles.Metraje.ToString() + " mts2";
            LblValorAdmon.Text = Inmuebles.C_Inmuebles.Valor_admon.ToString("N0");
            LblEntorno.Text = Inmuebles.C_Inmuebles.Ambito;
            if (Inmuebles.C_Inmuebles.Agua) { PBAgua.Image = Properties.Resources.agua128; }
            else { PBAgua.Image = Properties.Resources.aguanegro128; }
            if (Inmuebles.C_Inmuebles.Luz) { PBEnergia.Image = Properties.Resources.energia128; }
            else { PBEnergia.Image = Properties.Resources.energianegro128; }
            if (Inmuebles.C_Inmuebles.Gas) { PBGas.Image=Properties.Resources.cocinar128; }
            else { PBGas.Image = Properties.Resources.cocinarnegro128; }
            if (Inmuebles.C_Inmuebles.Parabolica) { PBTelevision.Image = Properties.Resources.television1_128; }
            else { PBTelevision.Image = Properties.Resources.televisionnegro128; }
            if (Inmuebles.C_Inmuebles.Telefono) { PBTelefono.Image = Properties.Resources.telefono128; }
            else { PBTelefono.Image = Properties.Resources.telefononegro128; }
            if (Inmuebles.C_Inmuebles.Administracion) { PBAdministracion.Image = Properties.Resources.vigilante128; }
            else { PBAdministracion.Image = Properties.Resources.vigilantenegro128; }

        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmDetalleInmueble_Load(object sender, EventArgs e)
        {
            Timer1.Enabled = true;
        }

        private void Timer1_Tick_1(object sender, EventArgs e)
        {
            MostrarImagen("derecha");
        }

        private void PBImagen1_MouseEnter(object sender, EventArgs e)
        {
            Imagen = PBImagenPrincipal.Image;
            PBImagenPrincipal.Image=PBImagen1.Image;
            Timer1.Enabled = false;
        }

        private void PBImagen1_MouseLeave(object sender, EventArgs e)
        {
            PBImagenPrincipal.Image = Imagen;
            Timer1.Enabled = true;
        }

        private void PBImagen2_MouseEnter(object sender, EventArgs e)
        {
            Imagen = PBImagenPrincipal.Image;
            PBImagenPrincipal.Image = PBImagen2.Image;
            Timer1.Enabled = false;
        }

        private void PBImagen2_MouseLeave(object sender, EventArgs e)
        {
            PBImagenPrincipal.Image = Imagen;
            Timer1.Enabled = true;
        }

        private void PBImagen3_MouseEnter(object sender, EventArgs e)
        {
            Imagen = PBImagenPrincipal.Image;
            PBImagenPrincipal.Image = PBImagen3.Image;
            Timer1.Enabled = false;
        }

        private void PBImagen3_MouseLeave(object sender, EventArgs e)
        {
            PBImagenPrincipal.Image = Imagen;
            Timer1.Enabled = true;
        }

        private void BtnIzquierda_Click(object sender, EventArgs e)
        {
            Timer1.Enabled = false;
            MostrarImagen("izquierda");
            Timer1.Enabled = true;
        }

        private void BtnDerecha_Click(object sender, EventArgs e)
        {
            Timer1.Enabled = false;
            MostrarImagen("derecha");
            Timer1.Enabled = true;
        }

        private void Panel2_SizeChanged(object sender, EventArgs e)
        {
            panel5.Left = Panel2.Width / 2 - panel5.Width / 2 + 10;
        }
    }
}
