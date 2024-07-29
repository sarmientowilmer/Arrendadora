using Modelo;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arrendadora
{
    public partial class FrmGenerarFotosRedes : Form
    {
        N_Inmuebles inmueble = new N_Inmuebles();
        N_Detalle_Inventario detalle_inventario = new N_Detalle_Inventario();
        N_Imagenes_Detalle_Inventario imagenes = new N_Imagenes_Detalle_Inventario();
        string DireccionImagenes = ConfigurationManager.AppSettings["PathDatosAccess"];
        string Servidor = ConfigurationManager.AppSettings["Servidor"];

        public FrmGenerarFotosRedes()
        {
            InitializeComponent();
        }
        private void AgregarTextoAImagen(String Directorio, String DirectorioSalida, String NombreArchivo, string NombreArchivoSalida)
        {
            string DireccionLogo = "D:\\Proyectos\\ArrendadoraVS2022d\\Arrendadora\\Arrendadora\\Resources\\";
            string NombreArchivoLogo = "NUEVO_LOGO.png";

            if (File.Exists(DirectorioSalida + NombreArchivoSalida))
            {
                File.Delete(DirectorioSalida + NombreArchivoSalida);
            }


            Image logo;
            try
            {
                //logo = Image.FromFile(DireccionLogo + NombreArchivoLogo);
                logo = Arrendadora.Properties.Resources.NUEVO_LOGO;
            }
            catch (Exception ex)
            {
                return;
            }
            Image frame;
            try
            {
                frame = Image.FromFile(Directorio + NombreArchivo);
            }
            catch (Exception ex)
            {
                return;
            }

            int width = 1200; // Set your desired width
            int height = 800; // Set your desired height

            using (frame)
            {
                using (var bitmap = new Bitmap(width, height))
                {
                    using (var canvas = Graphics.FromImage(bitmap))
                    {
                        canvas.InterpolationMode = InterpolationMode.HighQualityBicubic;
                        canvas.DrawImage(frame,
                                         new Rectangle(0,
                                                       0,
                                                       width,
                                                       height),
                                         new Rectangle(0,
                                                       0,
                                                       frame.Width,
                                                       frame.Height),
                                         GraphicsUnit.Pixel);

                        // Resize the playbutton image to 300x200
                        using (var resizedLogo = ResizeImage(logo, 300, 200))
                        {
                            // Create a semi-transparent version of the resized playbutton image
                            using (var semiTransparentLogo = MakeSemiTransparent(resizedLogo, 0.6f))
                            {
                                canvas.DrawImage(semiTransparentLogo,
                                                 (bitmap.Width / 2) - (semiTransparentLogo.Width / 2),
                                                 (bitmap.Height / 2) - (semiTransparentLogo.Height / 2));
                            }
                        }

                        //Establezco la orientación mediante coordenadas  
                        StringFormat stringformat = new StringFormat();
                        stringformat.Alignment = StringAlignment.Near;
                        stringformat.LineAlignment = StringAlignment.Near;

                        StringFormat stringformat2 = new StringFormat();
                        stringformat2.Alignment = StringAlignment.Near;
                        stringformat2.LineAlignment = StringAlignment.Near;

                        //Propiedades de la fuente  
                        //Color StringColor = System.Drawing.ColorTranslator.FromHtml("#933eea");//le damos color
                        Color StringColor = System.Drawing.Color.Black;//le damos color

                        //Color StringColor2 = System.Drawing.ColorTranslator.FromHtml("#e80c88");//le damos color
                        string Str_TextOnImageTitle = "Arrendamientos Parada Alarcón";//Your title Text On Image
                        string Str_TextOnImage = "Codigo Inmueble: " + inmueble.C_Inmuebles.Cod_inmueble;//Your Text On Image
                        string Str_TextOnImage2 = "Dirección: " + inmueble.C_Inmuebles.Direccion;//Your Text On Image
                        string str_TextOnImage3 = "Canon: " + inmueble.C_Inmuebles.Canonarrendar.ToString("N2");


                        //dibujar la imagen 
                        //

                        Color StringColor2 = System.Drawing.ColorTranslator.FromHtml("#EDECEC");//le damos color
                        canvas.FillRectangle(new SolidBrush(Color.LightGray), 20, bitmap.Height - 260, bitmap.Width - 50, 250);

                        canvas.DrawImage(ResizeImage(logo, 600, 500), bitmap.Width - 250, bitmap.Height - 220);


                        canvas.DrawString(Str_TextOnImageTitle, new Font("arial", 30,
                        FontStyle.Bold), new SolidBrush(StringColor), new Point(30, bitmap.Height - 260 + 10),
                        stringformat);

                        canvas.DrawString(Str_TextOnImage, new Font("arial", 28,
                        FontStyle.Regular), new SolidBrush(StringColor), new Point(30, bitmap.Height - 260 + 60),
                        stringformat);

                        canvas.DrawString(Str_TextOnImage2, new Font("Arial", 28,
                        FontStyle.Regular), new SolidBrush(StringColor), new Point(30, bitmap.Height - 260 + 110),
                        stringformat2); //Response.ContentType = "image/jpeg";

                        canvas.DrawString(str_TextOnImage3, new Font("Arial", 28,
                            FontStyle.Regular), new SolidBrush(StringColor), new Point(30, bitmap.Height - 260 + 160),
                                stringformat2);




                        canvas.Save();
                    }

                    try
                    {
                        string Archivo = DirectorioSalida + NombreArchivoSalida + ".jpg";
                        bitmap.Save(Archivo, ImageFormat.Jpeg);
                    }
                    catch (Exception ex) 
                    {
                        MessageBox.Show("Hubo un error...");
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            //pictureBox1.Image = Image.FromFile(Directorio + NombreArchivo);
            //pictureBox2.Image = Image.FromFile(Directorio + NombreArchivoSalida);
        }
        static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        static Bitmap MakeSemiTransparent(Image image, float opacity)
        {
            if (opacity < 0 || opacity > 1)
            {
                throw new ArgumentOutOfRangeException("opacity", "Opacity must be between 0 and 1.");
            }

            Bitmap bmp = new Bitmap(image.Width, image.Height);
            using (Graphics gfx = Graphics.FromImage(bmp))
            {
                ColorMatrix matrix = new ColorMatrix
                {
                    Matrix33 = opacity
                };

                ImageAttributes attributes = new ImageAttributes();
                attributes.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

                gfx.DrawImage(image, new Rectangle(0, 0, bmp.Width, bmp.Height),
                              0, 0, image.Width, image.Height, GraphicsUnit.Pixel, attributes);
            }

            return bmp;
        }

        private void FrmGenerarFotosRedes_Load(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void DGVInmuebles_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
       
        }

        private void DGVInmuebles_SelectionChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(TxtInmueble.Text) > 0 )
            {
                int cod_inmueble = Convert.ToInt32(TxtInmueble.Text);
                inmueble.Existe(cod_inmueble, true) ;
                DGVDetalleInv.DataSource = detalle_inventario.ListaDetalleXInmueble(Convert.ToInt32(TxtInmueble.Text));
                

            }
        }

        private void DGVDetalleInv_SelectionChanged(object sender, EventArgs e)
        {
            if (DGVDetalleInv.Rows.Count >0 && DGVDetalleInv.CurrentRow != null)
            {
                int cod_inmueble = Convert.ToInt32(DGVDetalleInv.CurrentRow.Cells["di_cod_inmueble"].Value);
                int cod_inv = Convert.ToInt32(DGVDetalleInv.CurrentRow.Cells["di_cod_inv"].Value);
                int numero_cod = Convert.ToInt32(DGVDetalleInv.CurrentRow.Cells["di_numero_cod"].Value);
                DGVImagenes.DataSource = imagenes.ImagenesInmuebleCodInv(cod_inmueble, cod_inv, numero_cod);
                
            }
        }

        private void DGVImagenes_SelectionChanged(object sender, EventArgs e)
        {
            string Archivo = "";
            PicFoto1.Image = null;
            PicFoto2.Image = null;
            if (DGVImagenes.Rows.Count>0)
            {
                TxtImagen.Text = DGVImagenes.CurrentRow.Cells["imagenes_nombre_imagen"].Value.ToString();
                if (TxtImagen.Text != "")
                {
                    Archivo = @"\\" + Servidor + "\\" + DireccionImagenes + "\\" + TxtImagen.Text;
                    PicFoto1.Image =  File.Exists(Archivo) ? Image.FromFile(Archivo) : Arrendadora.Properties.Resources.archivo_no_existe;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string DireccionOrigen = @"\\" + Servidor + @"\" + DireccionImagenes + @"\";
            string DireccionDestino = @"\\" + Servidor + @"\" + DireccionImagenes + @"\fotos\fotos_redes\";
            AgregarTextoAImagen(DireccionOrigen, DireccionDestino, TxtImagen.Text, "Inmueble_" + inmueble.C_Inmuebles.Cod_inmueble);
            MessageBox.Show("termino");
            string Archivo = DireccionDestino + "\\" + "inmueble_" + inmueble.C_Inmuebles.Cod_inmueble+".jpg";
            PicFoto2.Image = File.Exists(Archivo) ? Image.FromFile(Archivo) : Arrendadora.Properties.Resources.archivo_no_existe;

        }

        private void TxtInmueble_TextChanged(object sender, EventArgs e)
        {
            if (TxtInmueble.Text.Length > 0 && Convert.ToInt32(TxtInmueble.Text) > 0)
            {
                int cod_inmueble = Convert.ToInt32(TxtInmueble.Text);
                if (inmueble.Existe(cod_inmueble, true))
                {
                    TxtDireccion.Text = inmueble.C_Inmuebles.Direccion;
                    DGVDetalleInv.DataSource = detalle_inventario.ListaDetalleXInmueble(Convert.ToInt32(TxtInmueble.Text));
                    
                }
            }
            else
            {
                TxtInmueble.Text = "";
                DGVDetalleInv.DataSource = null;
                DGVImagenes.DataSource = null;
                PicFoto1.Image = null;
                PicFoto2.Image = null;
            }
        }
    }
}
