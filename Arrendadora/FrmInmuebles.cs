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
    public partial class FrmInmuebles : Form
    {
        N_Inmuebles Inmueble = new N_Inmuebles();
        N_Inmuebles InmuebleWeb = new N_Inmuebles();
        N_Prop_Inmuebles Propietarios = new N_Prop_Inmuebles();
        FuncionesGenerales Funciones = new FuncionesGenerales();

        public FrmInmuebles()
        {
            InitializeComponent();
            
        }

        private void FrmInmuebles_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.Prop_Inmuebles' Puede moverla o quitarla según sea necesario.
            //Propietarios.Cadena(Program.GsPathData, Program.gsServidor);
            //Inmueble.Cadena(Program.GsPathData, Program.gsServidor);
            //InmuebleWeb.ConectarA("MariaDB");
            //InmuebleWeb.DatosServidoryPath(Application.StartupPath);

            N_Tipos_Inmueble TiposInmueble = new N_Tipos_Inmueble();
            //TiposInmueble.Cadena(Program.GsPathData, Program.gsServidor);
            Funciones.CargarCombo(ref CboTipoInmueble,TiposInmueble.Consultar(), "nombre_tipo", "tipo_inmueble");

            N_Ciudades Ciudades = new N_Ciudades();
            //Ciudades.Cadena(Program.GsPathData, Program.gsServidor);
            Funciones.CargarCombo(ref CboCiudad, Ciudades.Consultar(), "nombre_ciudad", "llave_ciudad");

            N_Estados_inmueble EstadosInmueble = new N_Estados_inmueble();
            //EstadosInmueble.Cadena(Program.GsPathData, Program.gsServidor);
            Funciones.CargarCombo(ref CboEstado, EstadosInmueble.Consultar(), "nombre_estado_inmueble", "estado_inmueble");

            N_Destinos_inmueble DestinosInmueble = new N_Destinos_inmueble();
            //DestinosInmueble.Cadena(Program.GsPathData, Program.gsServidor);
            Funciones.CargarCombo(ref CboDestino, DestinosInmueble.Consultar(), "nombre_destino", "codigo_destino");

        }

        private void CargarBarrios(int LLave_ciudad)
        {
            N_Barrios_ciudad Barrios = new N_Barrios_ciudad();
            //Barrios.Cadena(Program.GsPathData, Program.gsServidor);
            Funciones.CargarCombo(ref CboBarrio, Barrios.BarriosXCiudad(LLave_ciudad), "nombre_barrio", "cod_barrio");
        }

        private void TxtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (Inmueble.Existe(Convert.ToInt32(TxtCodigo.Text), true))
                {
                    MostrarDatos();
                    MostrarPropietarios();
                }
                else
                {
                    MessageBox.Show("No existe el inmueble");
                }
            }
        }

        private void MostrarPropietarios()
        {
            DGVPropietarios.DataSource = Propietarios.Consultar(Convert.ToInt32(TxtCodigo.Text));
        }

        private void MostrarDatos()
        {
            TxtDireccion.Text = Inmueble.C_Inmuebles.Direccion;
            TxtDescripcion.Text = Inmueble.C_Inmuebles.Descripcion;
            TxtEntorno.Text = Inmueble.C_Inmuebles.Ambito;
            TxtObservaciones.Text = Inmueble.C_Inmuebles.Observaciones;
            ChkAgua.Checked = Inmueble.C_Inmuebles.Agua;
            ChkEnergia.Checked = Inmueble.C_Inmuebles.Luz;
            ChkGas.Checked = Inmueble.C_Inmuebles.Gas;
            ChKTelevision.Checked = Inmueble.C_Inmuebles.Parabolica;
            ChkVigilancia.Checked = Inmueble.C_Inmuebles.Vigilancia;
            ChkTelefono.Checked = Inmueble.C_Inmuebles.Telefono;
            TxtNTelefono.Text = Inmueble.C_Inmuebles.No_telefono;
            ChkAdministracion.Checked = Inmueble.C_Inmuebles.Administracion;
            TxtValorAdmon.Text = Inmueble.C_Inmuebles.Valor_admon.ToString("N0");
            CboTipoInmueble.SelectedValue = Inmueble.C_Inmuebles.Tipo_inmueble;
            CboEstado.SelectedValue = Inmueble.C_Inmuebles.Estado;
            CboCiudad.SelectedValue = Inmueble.C_Inmuebles.Llave_ciudad;
            CboBarrio.SelectedValue = Inmueble.C_Inmuebles.Cod_barrio;
            CboDestino.SelectedValue = Inmueble.C_Inmuebles.Destino_inmueble;
            TxtCanonArrendar.Text = Inmueble.C_Inmuebles.Canonarrendar.ToString("N0");
            TxtValorVenta.Text = Inmueble.C_Inmuebles.Valorventa.ToString("N0");
            TxtCantContratos.Text = Inmueble.C_Inmuebles.No_contratos_arren.ToString();
            TxtMatriculaInmobiliaria.Text = Inmueble.C_Inmuebles.Matricula_inm.ToString();
            TxtLatitud.Text = Inmueble.C_Inmuebles.Latitud.ToString();
            TxtLongitud.Text = Inmueble.C_Inmuebles.Longitud.ToString();
            TxtArea.Text = Inmueble.C_Inmuebles.Metraje.ToString();
            TxtEstrato.Text = Inmueble.C_Inmuebles.Estrato.ToString();
            TxtUltimoContrato.Text = Inmueble.C_Inmuebles.Ultimocont.ToString();
        }

        private void GrabarDatos()
        {
            Inmueble.C_Inmuebles.Direccion = TxtDireccion.Text;
            Inmueble.C_Inmuebles.Descripcion = TxtDescripcion.Text;
            Inmueble.C_Inmuebles.Ambito = TxtEntorno.Text;
            Inmueble.C_Inmuebles.Observaciones = TxtObservaciones.Text;
            Inmueble.C_Inmuebles.Agua = ChkAgua.Checked;
            Inmueble.C_Inmuebles.Luz = ChkEnergia.Checked;
            Inmueble.C_Inmuebles.Gas = ChkGas.Checked;
            Inmueble.C_Inmuebles.Parabolica = ChKTelevision.Checked;
            Inmueble.C_Inmuebles.Vigilancia = ChkVigilancia.Checked;
            Inmueble.C_Inmuebles.Telefono = ChkTelefono.Checked;
            Inmueble.C_Inmuebles.No_telefono = TxtNTelefono.Text;
            Inmueble.C_Inmuebles.Administracion = ChkAdministracion.Checked;
            Inmueble.C_Inmuebles.Valor_admon = Convert.ToDouble(Funciones.SinSeparadorMiles(TxtValorAdmon.Text));
            Inmueble.C_Inmuebles.Tipo_inmueble = Convert.ToInt32(CboTipoInmueble.SelectedValue);
            Inmueble.C_Inmuebles.Estado = CboEstado.SelectedValue.ToString();
            Inmueble.C_Inmuebles.Llave_ciudad = Convert.ToInt32(CboCiudad.SelectedValue);
            Inmueble.C_Inmuebles.Cod_barrio = Convert.ToInt32(CboBarrio.SelectedValue);
            Inmueble.C_Inmuebles.Destino_inmueble = Convert.ToByte(CboDestino.SelectedValue);
            Inmueble.C_Inmuebles.Canonarrendar = Convert.ToDouble(Funciones.SinSeparadorMiles(TxtCanonArrendar.Text));
            Inmueble.C_Inmuebles.Valorventa = Convert.ToDouble(Funciones.SinSeparadorMiles(TxtValorVenta.Text));
            Inmueble.C_Inmuebles.No_contratos_arren = Convert.ToInt32(TxtCantContratos.Text);
            Inmueble.C_Inmuebles.Matricula_inm = Convert.ToInt32(TxtMatriculaInmobiliaria.Text);
            Inmueble.C_Inmuebles.Latitud = Convert.ToDouble(TxtLatitud.Text);
            Inmueble.C_Inmuebles.Longitud = Convert.ToDouble(TxtLongitud.Text);
            Inmueble.C_Inmuebles.Metraje = Convert.ToInt32(TxtArea.Text);
            Inmueble.C_Inmuebles.Estrato = Convert.ToInt32(TxtEstrato.Text);
            Inmueble.C_Inmuebles.Ultimocont = Convert.ToInt32(TxtUltimoContrato.Text);
            InmuebleWeb.C_Inmuebles = Inmueble.C_Inmuebles;
            if (Inmueble.Actualizar(Inmueble.C_Inmuebles)==0)
            {
                MessageBox.Show("No se grabó el inmueble");
            }
            else
            {
                MessageBox.Show("Se grabó el inmueble");
            }

            if (InmuebleWeb.Existe(InmuebleWeb.C_Inmuebles.Cod_inmueble, false))
            {
                if (InmuebleWeb.Actualizar(InmuebleWeb.C_Inmuebles) == 0)
                {
                    MessageBox.Show("No se grabó en la web");
                }
                else
                {
                    MessageBox.Show("Se grabó en la web");
                }
                
            }
            else
            {
                InmuebleWeb.Insertar(InmuebleWeb.C_Inmuebles);
            }
        }

        private void TSBGrabar_Click(object sender, EventArgs e)
        {
            GrabarDatos();
        }

        private void CboCiudad_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CboCiudad.SelectedIndex != 0)
            {
                CargarBarrios(Convert.ToInt32(CboCiudad.SelectedValue));
            }
            
        }

        private void TabPagGenerales_Click(object sender, EventArgs e)
        {

        }
    }
}
