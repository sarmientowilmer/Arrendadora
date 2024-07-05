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
    public partial class FrmConsultaInmuebles : Form
    {
        N_Inmuebles Inmuebles = new N_Inmuebles();
        FuncionesGenerales Funciones = new FuncionesGenerales();

        public FrmConsultaInmuebles()
        {
            InitializeComponent();
            Inmuebles.DatosServidoryPath(Application.StartupPath);
        }

        private void FrmConsultaInmuebles_Load(object sender, EventArgs e)
        {
            N_Tipos_Inmueble TiposInmueble = new N_Tipos_Inmueble();
            TiposInmueble.DatosServidoryPath(Application.StartupPath);
            Funciones.CargarCombo(ref CboTipoInmueble, TiposInmueble.Consultar(), "nombre_tipo", "tipo_inmueble",true,"TODOS","0");
            
            N_Ciudades Ciudades = new N_Ciudades();
            Ciudades.DatosServidoryPath(Application.StartupPath);
            Funciones.CargarCombo(ref CboCiudad, Ciudades.CiudadesInmueblesDisponibles(), "nombre_ciudad", "llave_ciudad",true,"TODAS","-1");

            //CargarDestinos Inmuebles
            CboDestino.Items.Add("TODOS");
            CboDestino.Items.Add("ARRIENDO");
            CboDestino.Items.Add("VENTA");
            CboDestino.Items.Add("ARRIENDO O VENTA");
            CboDestino.SelectedIndex = 0;

            //Cargar Rangos de Valores

            CboValorDesde.Items.Add("TODOS");
            CboValorDesde.Items.Add("1");
            CboValorDesde.Items.Add(500001.ToString("N0"));
            CboValorDesde.Items.Add(1000001.ToString("N0"));
            CboValorDesde.Items.Add(1500001.ToString("N0"));
            CboValorDesde.Items.Add(2000001.ToString("N0"));
            CboValorDesde.Items.Add(2500001.ToString("N0"));
            CboValorDesde.Items.Add(3000001.ToString("N0"));
            CboValorDesde.SelectedIndex = 0;

            CboValorHasta.Items.Add("");
            CboValorHasta.Items.Add(500000.ToString("N0"));
            CboValorHasta.Items.Add(1000000.ToString("N0"));
            CboValorHasta.Items.Add(1500000.ToString("N0"));
            CboValorHasta.Items.Add(2000000.ToString("N0"));
            CboValorHasta.Items.Add(2500000.ToString("N0"));
            CboValorHasta.Items.Add(3000000.ToString("N0"));
            CboValorHasta.Items.Add(9999999999999.ToString("N0"));
            CboValorHasta.SelectedIndex = 0;
            CboValorHasta.Enabled = false;

            DGVDatos.DataSource = Inmuebles.Inmuebles_Disponibles();
            //DGVDatos.Columns["tipo_inmueble"].Visible = false;
            //DGVDatos.Columns["destino_inmueble"].Visible = false;
        }

        private void CargarBarriosCiudad(int Ciudad)
        {
            N_Barrios_ciudad Barrios = new N_Barrios_ciudad();
            Barrios.DatosServidoryPath(Application.StartupPath);
            Funciones.CargarCombo(ref CboBarrio, Barrios.BarriosInmueblesDisponibles(Ciudad), "nombre_barrio", "cod_barrio", true, "TODOS", "0");

        }


        private void DGVDatos_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (DGVDatos.Columns[e.ColumnIndex].Name == "tipo_inmueble")
            {
                //DGVDatos.Rows[e.RowIndex].Cells["imagen"].Value = Properties.Resources.casa16;
                //if (e.Value != null)
                //{
                //    if (Convert.ToInt32(e.Value) == 1)
                //    {
                //        DGVDatos.Rows[e.RowIndex].Cells["imagen"].Value = Properties.Resources.casa16;
                //    }
                //    if (Convert.ToInt32(e.Value) == 2)
                //    {
                //        DGVDatos.Rows[e.RowIndex].Cells["imagen"].Value = Properties.Resources.apartamento1_16;
                //    }
                //    if (Convert.ToInt32(e.Value) == 3)
                //    {
                //        DGVDatos.Rows[e.RowIndex].Cells["imagen"].Value = Properties.Resources.almacen16;
                //    }
                //    if (Convert.ToInt32(e.Value) == 4)
                //    {
                //        DGVDatos.Rows[e.RowIndex].Cells["imagen"].Value = Properties.Resources.apartamento16;
                //    }
                //    if (Convert.ToInt32(e.Value) == 6)
                //    {
                //        DGVDatos.Rows[e.RowIndex].Cells["imagen"].Value = Properties.Resources.terreno16;
                //    }

                //    if (Convert.ToInt32(e.Value) == 9)
                //    {
                //        DGVDatos.Rows[e.RowIndex].Cells["imagen"].Value = Properties.Resources.cabana16;
                //    }

                //}
            }
        }

        private void CboCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CboCiudad_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CboCiudad.SelectedIndex != 0)
            {
                CargarBarriosCiudad(Convert.ToInt32(CboCiudad.SelectedValue));
            }
            else
            {
                CboBarrio.DataSource = null;
                CboBarrio.Items.Clear();
                CboBarrio.Items.Add("TODOS");
                CboBarrio.SelectedIndex = 0;
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            int Destino = CboDestino.SelectedIndex;
            int TipoInmueble = Convert.ToInt32(CboDestino.SelectedValue);
            int LlaveCiudad = Convert.ToInt32(CboCiudad.SelectedValue);
            int Barrio = Convert.ToInt32(CboBarrio.SelectedValue);
            DGVDatos.DataSource = Inmuebles.Inmuebles_Disponibles(Destino, TipoInmueble, LlaveCiudad, Barrio);

        }

        private void PBLogo_Click(object sender, EventArgs e)
        {
            
        }

        private void PBLogo_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DGVDatos_DoubleClick(object sender, EventArgs e)
        {
            if (DGVDatos.Rows.Count > 0)
            {
                //Inmuebles.Consultar(Convert.ToInt32(DGVDatos.CurrentRow.Cells["cod_inmueble"].Value));
                if (Inmuebles.Existe(Convert.ToInt32(DGVDatos.CurrentRow.Cells["cod_inmueble"].Value),true))
                {
                    FrmDetalleInmueble F = new FrmDetalleInmueble(Inmuebles);
                    F.ShowDialog();
                }
            }
        }

        private void PanBtnBuscar_MouseEnter(object sender, EventArgs e)
        {
            PanBtnBuscar.BackColor = Color.DarkGray;
            PanBtnBuscar.BorderStyle = BorderStyle.Fixed3D;
        }

        private void PanBtnBuscar_MouseLeave(object sender, EventArgs e)
        {
            PanBtnBuscar.BackColor = Color.LightGray;
            PanBtnBuscar.BorderStyle = BorderStyle.Fixed3D;
        }

        private void BtnSlide_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 281)
            {
                MenuVertical.Width = 60;
                PanelConsulta.Left -= 221;
                PanelConsulta.Width += 221;
            }
            else
            {
                MenuVertical.Width = 281;
                PanelConsulta.Left += 221;
                PanelConsulta.Width -= 221;
            }
        }

        private void PanBtnBuscar_Click(object sender, EventArgs e)
        {
            BuscarInmuebles();
        }

        private void PictureBox5_MouseEnter(object sender, EventArgs e)
        {
            PanBtnBuscar.BackColor = Color.DarkGray;
            PanBtnBuscar.BorderStyle = BorderStyle.Fixed3D;
        }

        private void PictureBox5_MouseLeave(object sender, EventArgs e)
        {
            PanBtnBuscar.BackColor = Color.LightGray;
            PanBtnBuscar.BorderStyle = BorderStyle.FixedSingle;
        }

        private void Label10_MouseEnter(object sender, EventArgs e)
        {
            PanBtnBuscar.BackColor = Color.DarkGray;
            PanBtnBuscar.BorderStyle = BorderStyle.Fixed3D;
        }

        private void Label10_MouseLeave(object sender, EventArgs e)
        {
            PanBtnBuscar.BackColor = Color.LightGray;
            PanBtnBuscar.BorderStyle = BorderStyle.Fixed3D;
        }

        private void Label10_Click(object sender, EventArgs e)
        {
            BuscarInmuebles();
        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {
            BuscarInmuebles();
        }

        private void BuscarInmuebles()
        {
            int Destino = CboDestino.SelectedIndex;
            int TipoInmueble = Convert.ToInt32(CboTipoInmueble.SelectedValue);
            int LlaveCiudad = Convert.ToInt32(CboCiudad.SelectedValue);
            int Barrio = Convert.ToInt32(CboBarrio.SelectedValue);
            double ValorDesde = 0;
            double ValorHasta = 0;

            if (CboValorDesde.SelectedIndex > 0)
            {
                if (CboValorHasta.SelectedIndex < CboValorDesde.SelectedIndex)
                {
                    MessageBox.Show("Debe seleccionar un valor superior al de valor desde", "Error en Valor Hasta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                ValorDesde = Convert.ToDouble(Funciones.SinSeparadorMiles(CboValorDesde.Text));
                ValorHasta = Convert.ToDouble(Funciones.SinSeparadorMiles(CboValorHasta.Text));
            }
            DGVDatos.DataSource = Inmuebles.Inmuebles_Disponibles(Destino, TipoInmueble, LlaveCiudad, Barrio,ValorDesde, ValorHasta);
        }

        private void CboValorDesde_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CboValorHasta.SelectedIndex != -1)
            {
                if (Convert.ToInt32(CboValorDesde.SelectedIndex) == 0) { CboValorHasta.Enabled = false; CboValorHasta.SelectedIndex = 0; }
                else { CboValorHasta.Enabled = true; }
            }
        }

        private void CboValorHasta_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CboValorHasta.SelectedIndex < CboValorDesde.SelectedIndex && CboValorHasta.Text == "")
            {
                MessageBox.Show("Debe seleccionar un valor superior al de valor desde","Error en Valor Hasta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CboValorHasta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboValorDesde.SelectedIndex < CboValorHasta.SelectedIndex && CboValorHasta.Text=="")
            {
                MessageBox.Show("Debe seleccionar un valor superior al de valor desde", "Error en Valor Hasta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PanBtnBuscar_Paint(object sender, PaintEventArgs e)
        {
            BuscarInmuebles();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
