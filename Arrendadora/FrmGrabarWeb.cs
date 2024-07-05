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

namespace Arrendadora
{
    public partial class FrmGrabarWeb : Form
    {
        N_Inmuebles Inmueble = new N_Inmuebles();
        N_Inmuebles InmuebleWeb = new N_Inmuebles();

        public FrmGrabarWeb()
        {
            InitializeComponent();
        }

        private void FrmGrabarWeb_Load(object sender, EventArgs e)
        {
            Inmueble.DatosServidoryPath(Application.StartupPath);
            InmuebleWeb.ConectarA("MariaDB");
            InmuebleWeb.DatosServidoryPath(Application.StartupPath);

            DGVDatos.DataSource = Inmueble.Consultar();



        }

        private void BtnTransferir_Click(object sender, EventArgs e)
        {
            if (DGVDatos.Rows.Count > 0)
            {
                for (int i=0; i< DGVDatos.Rows.Count; i++)
                {
                    DGVDatos.Rows[i].Selected=true;
                    InmuebleWeb.C_Inmuebles.Cod_inmueble = Convert.ToInt32(DGVDatos.Rows[i].Cells["cod_inmueble"].Value);
                    if (InmuebleWeb.Existe(InmuebleWeb.C_Inmuebles.Cod_inmueble, false))
                    {
                        if (InmuebleWeb.Actualizar(InmuebleWeb.C_Inmuebles) == 0)
                        {
                            MessageBox.Show("No se grabó en la web el inmueble " + InmuebleWeb.C_Inmuebles.Cod_inmueble);
                        }
                        else
                        {
                            //MessageBox.Show("Se grabó en la web el inmueble" + InmuebleWeb.C_Inmuebles.Cod_inmueble);
                            label1.Text = "Se actualizó el inmueble " + InmuebleWeb.C_Inmuebles.Cod_inmueble;
                        }
                    }
                    else
                    {
                        if (InmuebleWeb.Insertar(InmuebleWeb.C_Inmuebles) == 0)
                        {
                            MessageBox.Show("No se insertó en la web el inmueble " + InmuebleWeb.C_Inmuebles.Cod_inmueble);
                        }
                        else
                        {
                            label1.Text = "Se insertó el inmueble " + InmuebleWeb.C_Inmuebles.Cod_inmueble;
                        }
                    }
                }
            }
            MessageBox.Show("terminó el proceso");
        }

        private void BtnGrabarInmueble_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtCodInmueble.Text))
            {
                if (Inmueble.Existe(Convert.ToInt32(TxtCodInmueble.Text), true))
                {
                    InmuebleWeb.C_Inmuebles = Inmueble.C_Inmuebles;
                    if (InmuebleWeb.Existe(InmuebleWeb.C_Inmuebles.Cod_inmueble, false))
                    {
                        if (InmuebleWeb.Actualizar(InmuebleWeb.C_Inmuebles) == 0)
                        {
                            MessageBox.Show("No se grabó en la web el inmueble " + InmuebleWeb.C_Inmuebles.Cod_inmueble);
                        }
                        else
                        {
                            //MessageBox.Show("Se grabó en la web el inmueble" + InmuebleWeb.C_Inmuebles.Cod_inmueble);
                            label1.Text = "Se actualizó el inmueble " + InmuebleWeb.C_Inmuebles.Cod_inmueble;
                            GrabarDetalleInventario(InmuebleWeb.C_Inmuebles.Cod_inmueble);
                        }
                    }
                    else
                    {
                        if (InmuebleWeb.Insertar(InmuebleWeb.C_Inmuebles) == 0)
                        {
                            MessageBox.Show("No se insertó en la web el inmueble " + InmuebleWeb.C_Inmuebles.Cod_inmueble);
                        }
                        else
                        {
                            label1.Text = "Se insertó el inmueble " + InmuebleWeb.C_Inmuebles.Cod_inmueble;
                            GrabarDetalleInventario(InmuebleWeb.C_Inmuebles.Cod_inmueble);
                        }
                    }
                    
                }
            }
        }
        private void GrabarDetalleInventario(int Cod_inmueble)
        {
            //int I;
            N_Detalle_Inventario DetalleInventarioWeb = new N_Detalle_Inventario();
            N_Detalle_Inventario DetalleInventario = new N_Detalle_Inventario();
            N_Imagenes_Detalle_Inventario ImagenesWEB = new N_Imagenes_Detalle_Inventario();
            N_Imagenes_Detalle_Inventario Imagenes = new N_Imagenes_Detalle_Inventario();
            //DetalleInventario.Cadena(Program.GsPathData, Program.gsServidor);
            //DetalleInventario.DatosServidoryPath(Application.StartupPath);
            //Imagenes.Cadena(Program.GsPathData, Program.gsServidor);
            //Imagenes.DatosServidoryPath(Application.StartupPath);
            //DetalleInventarioWeb.ConectarA("MariaDB");
            //DetalleInventarioWeb.DatosServidoryPath(Application.StartupPath);
            //ImagenesWEB.ConectarA("MariaDB");
            //ImagenesWEB.DatosServidoryPath(Application.StartupPath);
            DataTable DTInventario = new DataTable();
            DataTable DTImagenes = new DataTable();
            DTInventario = DetalleInventario.Consultar(Cod_inmueble);
            DTImagenes = Imagenes.Consultar(Cod_inmueble);
            DetalleInventarioWeb.GrabarDatosGrid(DTInventario);
            ImagenesWEB.GrabarDatosGrid(DTImagenes);
        }

    }
}
