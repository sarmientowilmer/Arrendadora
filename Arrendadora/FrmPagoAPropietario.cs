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
    public partial class FrmPagoAPropietario : Form
    {
        //N_Comprobantes Comprobantes = new N_Comprobantes();
        FuncionesGenerales Funciones = new FuncionesGenerales();
        //N_Contrato_Arren Contrato = new N_Contrato_Arren();
        //N_Descuentos_Prop DescuentosProp = new N_Descuentos_Prop();
        //N_OtrosPagos OtrosPagos = new N_OtrosPagos();
        //N_Inmuebles Inmuebles = new N_Inmuebles();
        //N_Pagos_Propietarios PagosPropietario = new N_Pagos_Propietarios();
        //N_Detalle_PagoProp DetallePagoProp = new N_Detalle_PagoProp();
        DataTable DTLiquidacion = new DataTable();
        int Sw;
        FrmPrincipal FormPrincipal = new FrmPrincipal();

        public FrmPagoAPropietario()
        {
            InitializeComponent();
        }

        public FrmPagoAPropietario(FrmPrincipal _Frm)
        {
            InitializeComponent();
            FormPrincipal = _Frm;
            FormPrincipal.MensajeEstado("Listo");
        }

        private void FrmPagoAPropietario_Load(object sender, EventArgs e)
        {
            CargarCombo();
            //Comprobantes.Cadena(Program.GsPathData, Program.gsServidorProgram.gsServidor);
            //Contrato.Cadena(Program.GsPathData, Program.gsServidorProgram.gsServidor);
            //DescuentosProp.Cadena(Program.GsPathData, Program.gsServidorProgram.gsServidor);
            //OtrosPagos.Cadena(Program.GsPathData, Program.gsServidorProgram.gsServidor);
            //Inmuebles.Cadena(Program.GsPathData, Program.gsServidorProgram.gsServidor);
            //PagosPropietario.Cadena(Program.GsPathData, Program.gsServidorProgram.gsServidor);
            //DetallePagoProp.Cadena(Program.GsPathData, Program.gsServidorProgram.gsServidor);
        }

        public void BUscarNombreTercero()
        {
            N_Auxiliares Tercero = new N_Auxiliares();
            //Tercero.Cadena(Program.GsPathData, Program.gsServidor);
            TxtNombreTercero.Text = "";
            if (CboTipoID.SelectedValue != null && TxtNumID.Text != "") TxtNombreTercero.Text = Tercero.NombreTercero(CboTipoID.SelectedValue.ToString(), Convert.ToInt32(Funciones.SinSeparadorMiles(TxtNumID.Text)));
        }

        private void CargarCombo()
        {
            FormPrincipal.MensajeEstado("Cargando datos de los catálogos");
            N_Tipos_Id TiposID = new N_Tipos_Id();
            //TiposID.ConectarA("wilmer_portatil");
            //TiposID.Cadena(Program.GsPathData, Program.gsServidor);
            //TiposID.DatosServidoryPath(Application.StartupPath);
            Funciones.CargarCombo(ref CboTipoID, TiposID.Consultar(), "nombre_id", "tipo_id");
            N_Formas_pago FormaPago = new N_Formas_pago();
            //FormaPago.ConectarA("wilmer_portatil");
            //FormaPago.Cadena(Program.GsPathData,Program.gsServidor);
            Funciones.CargarCombo(ref CboFormaPago, FormaPago.Consultar("Egresos"), "nombre_forma", "forma");
            FormPrincipal.MensajeEstado("Listo");
        }

        private void BtnTerceros_Click(object sender, EventArgs e)
        {
            FrmBuscarTercero Form = new FrmBuscarTercero();
            Form.ShowDialog();
            if (Form.DialogResult == DialogResult.OK)
            {
                CboTipoID.SelectedValue = Form._Tipo_aux;
                TxtNumID.Text = Form._Id_aux;
                TxtNombreTercero.Text = Form._Nombre_aux;
                //TxtDescripcion.Focus();
            }
        }

        private void CboTipoID_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CboTipoID.SelectedValue.ToString() != "N")
            {
                label3.Visible = false;
                TxtDV.Visible = false;
            }
            else
            {
                label3.Visible = true;
                TxtDV.Visible = true;
            }
            //BUscarNombreTercero();
            if (CboTipoID.SelectedValue != null && TxtNumID.Text != "") BUscarNombreTercero();
        }

        private void TxtNumID_Enter(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtNumID.Text)) TxtNumID.Text = Funciones.SinSeparadorMiles(TxtNumID.Text);
        }

        private void TxtNumID_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funciones.ValidaNumeros(ref e);
            if (e.KeyChar==13)
            {
                if (TxtDV.Visible) TxtDV.Focus();
                else
                {
                    //Program.MensajeEstado("Generando Liquidación propietario");
                    CargarDatos();
                    TxtDescripcion.Focus();
                }
            }
        }

        private void CargarDatos()
        {
            int NumeroRecibo = 0;
            //Revisar si el propietario tiene crédito
            FormPrincipal.MensajeEstado("Revisando si el propietario tiene crédito...");
            N_Auxiliares Tercero = new N_Auxiliares();
            //Tercero.ConectarA("wilmer_portatil");
            //Tercero.Cadena(Program.GsPathData, Program.gsServidor);
            N_Contrato_Arren Contrato = new N_Contrato_Arren();
            //Contrato.ConectarA("wilmer_portatil");
            //Contrato.Cadena(Program.GsPathData, Program.gsServidor);
            N_Descuentos_Prop DescuentosProp = new N_Descuentos_Prop();
            //DescuentosProp.ConectarA("wilmer_portatil");
            //DescuentosProp.Cadena(Program.GsPathData, Program.gsServidor);
            N_OtrosPagos OtrosPagos = new N_OtrosPagos();
            //OtrosPagos.ConectarA("wilmer_portatil");
            //OtrosPagos.Cadena(Program.GsPathData, Program.gsServidor);
            N_Inmuebles Inmuebles = new N_Inmuebles();
            //Inmuebles.ConectarA("wilmer_portatil");
            //Inmuebles.Cadena(Program.GsPathData, Program.gsServidor);
            N_Pagos_Propietarios PagosPropietario = new N_Pagos_Propietarios();
            //PagosPropietario.ConectarA("wilmer_portatil");
            //PagosPropietario.Cadena(Program.GsPathData, Program.gsServidor);
            N_Detalle_PagoProp DetallePagoProp = new N_Detalle_PagoProp();
            //DetallePagoProp.ConectarA("wilmer_portatil");
            //DetallePagoProp.Cadena(Program.GsPathData, Program.gsServidor);

            Tercero.Existe(CboTipoID.SelectedValue.ToString(), Convert.ToInt32(Funciones.SinSeparadorMiles(TxtNumID.Text)),true);
            Panel3.Visible = false;
            LblPropietarioCredito.Text = "";

            if (Tercero.C_Auxiliares.Tiene_credito)
            {
                Panel3.Visible = true;
                LblPropietarioCredito.Text = "El propietario tiene crédito, por favor revise antes de registrar el pago";
            }
            //liquidar si el número de comprobante está vacio o es cero
            if (string.IsNullOrEmpty(TxtNumComprobante.Text))
            {
                FormPrincipal.MensajeEstado("Procesando la liquidación de pagos al propietario...");
                DTLiquidacion = Contrato.LiquidarContratosPropietario(CboTipoID.SelectedValue.ToString(), Convert.ToInt32(Funciones.SinSeparadorMiles(TxtNumID.Text)), TxtDV.Text, DateTime.Today, "EG", -1, 201901, 0, DateTime.Today, true, -1);
                DGVLiquidacion.DataSource = DTLiquidacion;
            }
            else
            {
                FormPrincipal.MensajeEstado("Cargando datos para mostrar...");
                NumeroRecibo = Convert.ToInt32(TxtNumComprobante.Text);
                DGVLiquidacion.DataSource = DetallePagoProp.Consultar("EG", Convert.ToInt32(TxtNumComprobante.Text));
            }
            //cargar datos de los inmuebles
            FormPrincipal.MensajeEstado("Cargando datos de inmuebles...");
            DGVInmuebles.DataSource = Inmuebles.ConsultaXPropietarioConContratoMostrar(CboTipoID.SelectedValue.ToString(), Convert.ToInt32(Funciones.SinSeparadorMiles(TxtNumID.Text)), TxtDV.Text);
            //cargar datos de los  descuentos
            FormPrincipal.MensajeEstado("Cargando datos de descuentos...");
            DGVDescuentos.DataSource = DescuentosProp.Consultar(CboTipoID.SelectedValue.ToString(), Convert.ToInt32(Funciones.SinSeparadorMiles(TxtNumID.Text)), "EG", NumeroRecibo);
            //cargar datos de otros pagos
            FormPrincipal.MensajeEstado("Cargando otros pagos...");
            DGVOtrosPagos.DataSource = OtrosPagos.Consultar(CboTipoID.SelectedValue.ToString(), Convert.ToInt32(Funciones.SinSeparadorMiles(TxtNumID.Text)), "EG", NumeroRecibo);
            //cargar datos de pagos anteriores
            FormPrincipal.MensajeEstado("Cargando pagos anteriores...");
            DGVPagosAnteriores.DataSource = PagosPropietario.Consultar(CboTipoID.SelectedValue.ToString(), Convert.ToInt32(Funciones.SinSeparadorMiles(TxtNumID.Text)), TxtDV.Text);
            if (DGVPagosAnteriores.Rows.Count > 0)
            {
                DGVPagosAnteriores.FirstDisplayedScrollingRowIndex = DGVPagosAnteriores.Rows.Count - 1;
                DGVPagosAnteriores.CurrentCell = DGVPagosAnteriores.Rows[DGVPagosAnteriores.Rows.Count - 1].Cells[1];
                DGVPagosAnteriores.Rows[DGVPagosAnteriores.Rows.Count - 1].Selected=true;
            }
            FormPrincipal.MensajeEstado("Cargando totales...");
            //TotalesLiquidacion();
            TotalesLiq();
            TotalesDescuentos();
            TotalesOtrospagos();
            TotalesInmuebles();
            TotalLiquidacion();
            FormPrincipal.MensajeEstado("Listo");

        }

        private void CargarCuentasBancarias()
        {
            N_Cuentas_Bancarias Cuentas = new N_Cuentas_Bancarias();
            //Cuentas.Cadena(Program.GsPathData, Program.gsServidor);
            Funciones.CargarCombo(ref CboCodigoCuenta, Cuentas.Consultar(), "no_cuenta", "cod_cuenta");

        }

        private void MostrarDatos()
        {
            N_Comprobantes Comprobantes = new N_Comprobantes();
            //Comprobantes.Cadena(Program.GsPathData, Program.gsServidor);
            if (Comprobantes.Existe("EG", Convert.ToInt32(TxtNumComprobante.Text), true))
            {
                CboTipoID.SelectedValue = Comprobantes.C_Comprobantes.Tipo_id;
                TxtNumID.Text = Comprobantes.C_Comprobantes.Id.ToString("N0");
                TxtDV.Text = "";
                BUscarNombreTercero();
                TxtDescripcion.Text = Comprobantes.C_Comprobantes.Descripcion;
                DTPFecha.Value = Comprobantes.C_Comprobantes.Fecha;
                //falta buscar la fecha del ultimo pago en el contrato
                CboFormaPago.SelectedValue = Comprobantes.C_Comprobantes.Forma_pago;
                CargarCuentasBancarias();
                CboCodigoCuenta.SelectedIndex = -1;
                if (Comprobantes.C_Comprobantes.Cod_cuenta != 0)
                {
                    CboCodigoCuenta.SelectedValue = Comprobantes.C_Comprobantes.Cod_cuenta;
                }
                TxtTipoCuentaDestino.Text = "";
                if (!string.IsNullOrEmpty(Comprobantes.C_Comprobantes.Clase_cuenta)) TxtTipoCuentaDestino.Text = Comprobantes.C_Comprobantes.Clase_cuenta;
                TxtNumeroCuentaDestino.Text = "";
                if (!string.IsNullOrEmpty(Comprobantes.C_Comprobantes.Num)) TxtNumeroCuentaDestino.Text = Comprobantes.C_Comprobantes.Num;
                TxtEntidadCuentaDestino.Text = "";
                if (!string.IsNullOrEmpty(Comprobantes.C_Comprobantes.Entidad)) TxtEntidadCuentaDestino.Text = Comprobantes.C_Comprobantes.Entidad;

                if (!string.IsNullOrEmpty(Comprobantes.C_Comprobantes.Dv)) TxtDV.Text = Comprobantes.C_Comprobantes.Dv;
                if  (Comprobantes.C_Comprobantes.Estado=="D")
                {
                    MessageBox.Show("Comprobante anulado");
                }else
                {
                    CargarDatos();
                }
                
            }
            else
            {
                MessageBox.Show("El número de comprobante no existe, por favor revise");
            }
        }

        private void TxtNumID_Validated(object sender, EventArgs e)
        {
            Funciones.ControlValidado(sender, e, ref EPPagoProp, "int32", 0, true);
        }

        private void TxtNumID_Validating(object sender, CancelEventArgs e)
        {
            Funciones.ValidarControles(ref sender, ref e, ref EPPagoProp, "int32", 0, true);
            if (!e.Cancel) BUscarNombreTercero();
        }

        private void DGVLiquidacion_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //if (DGVLiquidacion.Columns[e.ColumnIndex].Name == "comision")
            //{
            //    DGVLiquidacion.Rows[e.RowIndex].Cells["comision"].Value = Math.Round(Convert.ToDouble(DGVLiquidacion.Rows[e.RowIndex].Cells["canon"].Value) * Convert.ToDouble(DGVLiquidacion.Rows[e.RowIndex].Cells["tasa_admon"].Value), 0);
            //}
            //if (DGVLiquidacion.Columns[e.ColumnIndex].Name == "iva")
            //{
            //    DGVLiquidacion.Rows[e.RowIndex].Cells["iva"].Value = Math.Round(Convert.ToDouble(DGVLiquidacion.Rows[e.RowIndex].Cells["tasa_iva"].Value) * Convert.ToDouble(DGVLiquidacion.Rows[e.RowIndex].Cells["comision"].Value), 0);
            //}

        }

        private void DGVPagosAnteriores_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            N_Detalle_PagoProp DetallePagoProp = new N_Detalle_PagoProp();
            //DetallePagoProp.ConectarA("wilmer_portatil");
            //DetallePagoProp.Cadena(Program.GsPathData, Program.gsServidor);
            if (Convert.ToInt32(DGVPagosAnteriores.Rows[e.RowIndex].Cells["pa_no_comp"].Value) > 0)
            {
                DGVDetallePago.DataSource = DetallePagoProp.ConsultaConsolidada("EG", Convert.ToInt32(DGVPagosAnteriores.Rows[e.RowIndex].Cells["pa_no_comp"].Value)); 
            }
        }

        private void TotalesLiquidacion()
        {
            TxtTotalCanon.Text = Convert.ToDouble(DTLiquidacion.Compute("SUM(canon)","")).ToString("N2");
            TxtTotalComision.Text = Convert.ToDouble(DTLiquidacion.Compute("SUM(comision)", "")).ToString("N2");
            TxtTotalIVA.Text = Convert.ToDouble(DTLiquidacion.Compute("SUM(iva)", "")).ToString("N2");

            //foreach (DataGridViewRow Fila in DGVLiquidacion.Rows)
            //{

            //}
        }

        private void TotalLiquidacion()
        {
            //Pagos
            TxtTotalArriendos.Text = TxtTotalCanon.Text;
            TxtOtrosPagos.Text = TxtTotalOtrosPagos.Text;

            //Descuentos
            TxtComision.Text = TxtTotalComision.Text;
            TxtIva.Text = TxtTotalIVA.Text;
            TxtOtrosDescuentos.Text = TxtTotalDescuentos.Text;

            //totales
            TxtTotalPagos.Text = (Convert.ToDouble(Funciones.SinSeparadorMiles(TxtTotalArriendos.Text))+ Convert.ToDouble(Funciones.SinSeparadorMiles(TxtOtrosPagos.Text))).ToString("N2");
            TxtTotalDescuentosAProp.Text = (Convert.ToDouble(Funciones.SinSeparadorMiles(TxtComision.Text)) + Convert.ToDouble(Funciones.SinSeparadorMiles(TxtIva.Text)) + Convert.ToDouble(Funciones.SinSeparadorMiles(TxtOtrosDescuentos.Text))).ToString("N2");
            TxtNetoAPagar.Text = (Convert.ToDouble(Funciones.SinSeparadorMiles(TxtTotalPagos.Text))-Convert.ToDouble(Funciones.SinSeparadorMiles(TxtTotalDescuentosAProp.Text))).ToString("N2");
        }

        private void TotalesLiq()
        {
            double SumaLiquidacion = 0;
            double SumaComision = 0;
            double SumaIva = 0;
            foreach (DataGridViewRow Fila in DGVLiquidacion.Rows)
            {
                
                SumaLiquidacion += Convert.ToDouble(Funciones.SinSeparadorMiles(Fila.Cells["canon"].Value.ToString()));
                SumaComision += Convert.ToDouble(Funciones.SinSeparadorMiles(Fila.Cells["comision"].Value.ToString()));
                SumaIva += Convert.ToDouble(Funciones.SinSeparadorMiles(Fila.Cells["iva"].Value.ToString()));
            }
            TxtTotalCanon.Text = SumaLiquidacion.ToString("N2");
            TxtTotalComision.Text = SumaComision.ToString("N2");
            TxtTotalIVA.Text = SumaIva.ToString("N2");

            
        }
        private void TotalesDescuentos()
        {
            double Total = 0;
            foreach (DataGridViewRow Fila in DGVDescuentos.Rows)
            {
                Total += Convert.ToDouble(Funciones.SinSeparadorMiles(Fila.Cells["vr_desprop"].Value.ToString()));
            }
            TxtTotalDescuentos.Text = Total.ToString("N2");
        }
        private void TotalesOtrospagos()
        {
            double TotalOtros = 0;
            foreach (DataGridViewRow Fila in DGVOtrosPagos.Rows)
            {
                TotalOtros += Convert.ToDouble(Funciones.SinSeparadorMiles(Fila.Cells["o_valor"].Value.ToString()));
            }
            TxtTotalOtrosPagos.Text = TotalOtros.ToString("N2");
        }

        private void TotalesInmuebles()
        {
            N_Inmuebles Inmuebles = new N_Inmuebles();
            //Inmuebles.Cadena(Program.GsPathData, Program.gsServidor);
            DataTable DT = new DataTable();
            TxtA.Text = "0";
            TxtV.Text = "0";
            TxtI.Text = "0";
            DT = Inmuebles.CantidadInmueblesXEstado(CboTipoID.SelectedValue.ToString(), Convert.ToInt32(Funciones.SinSeparadorMiles(TxtNumID.Text)), TxtDV.Text);
            if (DT.Rows.Count > 0)
            {
                foreach (DataRow Fila in DT.Rows)
                {
                    switch (Fila["estado"])
                    {
                        case "A":
                            {
                                TxtA.Text = Fila["cantidad"].ToString();
                                break;
                            }
                        case "V":
                            {
                                TxtV.Text = Fila["cantidad"].ToString();
                                break;
                            }
                        case "I":
                            {
                                TxtI.Text = Fila["cantidad"].ToString();
                                break;
                            }
                    }
                    
                    //this.Controls["TxtA"].Text = Fila["cantidad"].ToString();
                }
            }
        }

        private void TxtNumComprobante_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (Convert.ToInt32(TxtNumComprobante.Text) > 0) MostrarDatos();
            }
        }

        public void PrepararComprobante()
        {

        }

        private void CboCodigoCuenta_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CboCodigoCuenta.SelectedIndex!=-1)
            {
                //MessageBox.Show(CboCodigoCuenta.SelectedItem.ToString());
                if (int.TryParse(CboCodigoCuenta.SelectedValue.ToString(), out int cuenta))
                {
                    N_Cuentas_Bancarias Cuentas = new N_Cuentas_Bancarias();
                    //Cuentas.Cadena(Program.GsPathData, Program.gsServidor);
                    N_Bancos Bancos = new N_Bancos();
                    //Bancos.Cadena(Program.GsPathData, Program.gsServidor);
                    TxtTipoCuentaOrigen.Text = "";
                    TxtNumeroCuentaOrigen.Text = "";
                    TxtEntidadCuentaOrigen.Text = "";
                    cuenta = Convert.ToInt32(CboCodigoCuenta.SelectedValue.ToString());
                    if (Cuentas.Existe(Convert.ToInt32(CboCodigoCuenta.SelectedValue.ToString()), true))
                    {
                        TxtTipoCuentaOrigen.Text = Cuentas.C_Cuentas_Bancarias.Tipo_cuenta;
                        TxtNumeroCuentaOrigen.Text = Cuentas.C_Cuentas_Bancarias.No_Cuenta;
                        if (Bancos.Existe(Cuentas.C_Cuentas_Bancarias.Cod_banco, true)) TxtEntidadCuentaOrigen.Text = Bancos.C_Bancos.Nombre_banco;
                    }
                }
            }
        }
    }
}
