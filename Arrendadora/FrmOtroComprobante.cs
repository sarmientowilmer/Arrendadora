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

using System.Globalization;

namespace Arrendadora
{
    public partial class FrmOtroComprobante : Form
    {
        Funciones Func = new Funciones();
        N_Otroscomprobantes OtroComprobante = new N_Otroscomprobantes();
        NR_OtroComprobante Reporte = new NR_OtroComprobante();
        int Sw;
        FrmOtrosComprobantes FrmOtros = new FrmOtrosComprobantes();
        FrmPrincipal FormPrincipal = new FrmPrincipal();

        public FrmOtroComprobante(FrmPrincipal _Frm, FrmOtrosComprobantes _Form)
        {
            InitializeComponent();
            FormPrincipal = _Frm;
            FormPrincipal.MensajeEstado("Cargando formulario otro comprobante...");
            //OtroComprobante.DatosServidoryPath(Program.GsPathData);
            //OtroComprobante.Cadena(Program.GsPathData,Program.gsServidor);
            CargarCombos();
            Sw = 1;
            BotonEdit();
            TxtUsuario.Text = Program.IdUsuario.ToString();
            FrmOtros = _Form;
            FormPrincipal.MensajeEstado("Listo");
        }

        public FrmOtroComprobante(FrmPrincipal _Frm, string TipoComp, int NumComp, FrmOtrosComprobantes _Form)
        {
            InitializeComponent();
            FormPrincipal = _Frm;
            FormPrincipal.MensajeEstado("Cargando formulario Otro comprobante...");
            FrmOtros = _Form;
            //OtroComprobante.Cadena(Program.GsPathData,Program.gsServidor);
            CargarCombos();
            CboTipoComp.SelectedValue = TipoComp;
            TxtNumComp.Text = NumComp.ToString();
            //Sw = 0;
            MostrarDatos(TipoComp, NumComp);
            BotonEdit();
            FormPrincipal.MensajeEstado("Listo");
        }

        public void BotonEdit()
        {
            if (Sw == 0) //Mostrar con datos
            {
                if (CboEstado.SelectedValue.ToString() == "D")
                {
                    TSBtnAnular.Enabled = false;
                }
                else
                {
                    if (OtroComprobante.C_Otroscomprobantes.Fecha != DateTime.Today)
                    {
                        if (Program.IdUsuario == 88159430) TSBtnAnular.Enabled = true;
                        else TSBtnAnular.Enabled = false;
                    }
                    else
                    {
                        TSBtnAnular.Enabled = true;
                    }
                }
                TSBtnAdicionar.Enabled = true;
                TSBtnGuardar.Enabled = false;
                //TSBtnAnular.Enabled = true;
                TSBtnLimpiar.Enabled = false;
                TSBtnSalir.Enabled = true;
                TSBtnImprimir.Enabled = true;

                CboTipoComp.Enabled = false;
                TxtNumComp.Enabled = false;
                CboEstado.Enabled = false;
                TxtUsuario.Enabled = false;
            }
            if (Sw == 1) //Adicionar
            {
                TSBtnAdicionar.Enabled = false;
                TSBtnGuardar.Enabled = true;
                TSBtnAnular.Enabled = false;
                TSBtnLimpiar.Enabled = true;
                TSBtnImprimir.Enabled = false;

                CboTipoComp.Enabled = true;
                TxtNumComp.Enabled = false;
                CboEstado.Enabled = false;
                TxtUsuario.Enabled = false;
                //TxtNumComp.ReadOnly = false;
                //txtApellido1.ReadOnly = false;
                //txtApellido2.ReadOnly = false;
                //txtNombre1.ReadOnly = false;
                //txtNombre2.ReadOnly = false;



            }
            if (Sw == 2) //Editar
            {
                TSBtnAdicionar.Enabled = false;
                TSBtnGuardar.Enabled = true;
                TSBtnAnular.Enabled = false;

                TSBtnLimpiar.Enabled = true;
                TSBtnImprimir.Enabled = false;

                CboTipoComp.Enabled = false;
                TxtNumComp.ReadOnly = true;
                CboEstado.Enabled = false;
                TxtUsuario.Enabled = false;
                //txtApellido1.ReadOnly = false;
                //txtApellido2.ReadOnly = false;
                //txtNombre1.ReadOnly = false;
                //txtNombre2.ReadOnly = false;

            }

            if (Sw == 4) //Mostrar sin datos
            {
                TSBtnAdicionar.Enabled = true;
                TSBtnGuardar.Enabled = false;
                TSBtnAnular.Enabled = false;

                TSBtnLimpiar.Enabled = true;
                TSBtnImprimir.Enabled = false;

                CboTipoComp.Enabled = true;
                TxtNumComp.ReadOnly = false;
                //txtApellido1.ReadOnly = false;
                //txtApellido2.ReadOnly = false;
                //txtNombre1.ReadOnly = false;
                //txtNombre2.ReadOnly = false;

            }

        }


        private void GrabarDatos()
        {
            if (this.ValidateChildren(ValidationConstraints.Visible))
            {
                int Errores = 0;
                foreach (Control C in this.Controls)
                {
                    if (ErrorPOtroComp.GetError(C)!=string.Empty) { Errores++; }
                }
                if (Errores > 0)
                {
                    MessageBox.Show("hay errores que se deben corregir");
                }
                else
                {
                    TSBtnGuardar.Enabled = false;
                    OtroComprobante.C_Otroscomprobantes.Fecha = DTPFecha.Value;
                    OtroComprobante.C_Otroscomprobantes.Tipo_comp = CboTipoComp.SelectedValue.ToString();
                    OtroComprobante.C_Otroscomprobantes.Tipo_comp = CboTipoComp.SelectedValue.ToString();
                    OtroComprobante.C_Otroscomprobantes.Tipo_comp = CboTipoComp.SelectedValue.ToString();
                    if (Sw != 1)
                    {
                        OtroComprobante.C_Otroscomprobantes.No_comp = Convert.ToInt32(Func.SinSeparadorMiles(TxtNumComp.Text));
                    }
                    else
                    {
                    }
                    OtroComprobante.C_Otroscomprobantes.Tipo_id = CboTipoID.SelectedValue.ToString();
                    OtroComprobante.C_Otroscomprobantes.Id = Convert.ToInt32(Func.SinSeparadorMiles(TxtNumID.Text));
                    OtroComprobante.C_Otroscomprobantes.Dv = TxtDV.Text;
                    OtroComprobante.C_Otroscomprobantes.Descripcion = TxtDescripcion.Text;
                    OtroComprobante.C_Otroscomprobantes.Valor = Convert.ToDouble(Func.SinSeparadorMiles(TxtValor.Text));
                    OtroComprobante.C_Otroscomprobantes.Usu_cap = Convert.ToInt32(Func.SinSeparadorMiles(TxtUsuario.Text));
                    OtroComprobante.C_Otroscomprobantes.Forma_pago = Convert.ToInt32(CboFormaPago.SelectedValue);
                    OtroComprobante.C_Otroscomprobantes.Estado = CboEstado.SelectedValue.ToString();
                    if (Sw != 1)
                    {
                        if (OtroComprobante.Actualizar(OtroComprobante.C_Otroscomprobantes) == -1)
                        {
                            MessageBox.Show("No se pudo actualizar el registro");
                        }
                        else
                        {
                            MessageBox.Show("El registro se actualizó exitosamente");
                            Sw = 0;
                            BotonEdit();
                        }
                    }
                    else
                    {
                        TSBtnGuardar.Enabled = false;
                        OtroComprobante.C_Otroscomprobantes.Seccion = 1;
                        OtroComprobante.C_Otroscomprobantes.Estado = "A";
                        OtroComprobante.C_Otroscomprobantes.Centro_costo = 1;
                        OtroComprobante.C_Otroscomprobantes.Clase_cuenta = " ";
                        OtroComprobante.C_Otroscomprobantes.Num = " ";
                        OtroComprobante.C_Otroscomprobantes.Entidad = " ";
                        OtroComprobante.C_Otroscomprobantes.Estado_contab = 1;
                        if (OtroComprobante.C_Otroscomprobantes.Tipo_id != "N") { OtroComprobante.C_Otroscomprobantes.Dv = " "; }
                        N_Papeleria Papeleria = new N_Papeleria();
                        //Papeleria.Cadena(Program.GsPathData,Program.gsServidor);
                        OtroComprobante.C_Otroscomprobantes.No_comp = Papeleria.AsignarConsecutivo(OtroComprobante.C_Otroscomprobantes.Tipo_comp);
                        switch (OtroComprobante.Insertar(OtroComprobante.C_Otroscomprobantes))
                        {
                            case -1:
                                MessageBox.Show("Hubo un problema insertando el registro");
                                break;
                            case -2:
                                MessageBox.Show("El registro se insertó pero no se actualizaron los saldos diarios y generales");
                                break;
                            case -3:
                                MessageBox.Show("El registró se insertó pero no se actualizó el saldo general");
                                break;
                            default:
                                TxtNumComp.Text = OtroComprobante.C_Otroscomprobantes.No_comp.ToString();

                                FrmOtros.ActualizarDatos();
                                Application.DoEvents();
                                FrmOtros.Activate();
                                
                                MessageBox.Show("Registro guardado exitosamente");
                                Sw = 0;
                                BotonEdit();
                                break;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Hace falta ingresar información en uno o varios campos", "Error de Validación de Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void MostrarDatos(string TipoComp, int NumComp)
        {
            if (OtroComprobante.Existe(TipoComp, NumComp, true))
            {
                DTPFecha.Value = OtroComprobante.C_Otroscomprobantes.Fecha;
                CboTipoID.SelectedValue = OtroComprobante.C_Otroscomprobantes.Tipo_id;
                TxtNumID.Text = OtroComprobante.C_Otroscomprobantes.Id.ToString("N0");
                TxtDV.Text = OtroComprobante.C_Otroscomprobantes.Dv;
                TxtDescripcion.Text = OtroComprobante.C_Otroscomprobantes.Descripcion;
                TxtValor.Text = OtroComprobante.C_Otroscomprobantes.Valor.ToString("N2");
                TxtUsuario.Text = OtroComprobante.C_Otroscomprobantes.Usu_cap.ToString();
                CboEstado.SelectedValue = OtroComprobante.C_Otroscomprobantes.Estado;
                CboFormaPago.SelectedValue = OtroComprobante.C_Otroscomprobantes.Forma_pago;
                BUscarNombreTercero();
                switch (OtroComprobante.C_Otroscomprobantes.Estado)
                {
                    case "A":
                        BloquearControles(false);
                        break;
                    case "D":
                        MessageBox.Show("El comprobante se encuentra anulado");
                        BloquearControles(false);
                        TSBtnAnular.Enabled = false;
                        TSBtnImprimir.Enabled = false;
                        break;
                    case "V":
                        MessageBox.Show("El comprobante se encuentra validado");
                        BloquearControles(false);
                        break;
                }
            }
            else
            {
                MessageBox.Show("No existe el comprobante " + CboTipoComp.Text + ' ' + TxtNumComp.Text, "Error en consulta de comproante", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void BloquearControles(bool Bloquea)
        {
            foreach (Control C in this.Controls)
            {
                if (C.GetType().Name == "TextBox") { ((TextBox)C).Enabled = Bloquea; }
                if (C.GetType().Name == "ComboBox") { ((ComboBox)C).Enabled = Bloquea; }
                if (C.GetType().Name == "DateTimePicker") { ((DateTimePicker)C).Enabled = Bloquea; }
            }
            BtnTerceros.Enabled = Bloquea;
        }

        private void FrmOtroComprobante_Load(object sender, EventArgs e)
        {

        }

        private void CambiarEstado(string Estado)
        {
            OtroComprobante.Existe(CboTipoComp.SelectedValue.ToString(), Convert.ToInt32(TxtNumComp.Text), true);
            if (OtroComprobante.Anular(OtroComprobante.C_Otroscomprobantes) == -1)
            {
                MessageBox.Show("No se pudo anular el comprobante");
            }
            else
            {
                MessageBox.Show("Comprobante anulado");
                //bloquear todos los controles
                MostrarDatos(OtroComprobante.C_Otroscomprobantes.Tipo_comp, OtroComprobante.C_Otroscomprobantes.No_comp);
                FrmOtros.Activate();
            }
        }

        private void CargarCombos()
        {
            N_Tipos_Id TiposID = new N_Tipos_Id();
            N_Tipos_Comp TiposComp = new N_Tipos_Comp();
            N_Estados_comp EstadosComp = new N_Estados_comp();
            N_Formas_pago Formas_Pago_ = new N_Formas_pago();

            //TiposID.Cadena(Program.GsPathData,Program.gsServidor);
            Func.CargarCombo(ref CboTipoID, TiposID.Consultar(), "nombre_id", "tipo_id");
            CboTipoID.AutoCompleteCustomSource = CargarAutocompletar(TiposID.Consultar());
            //CboTipoID.AutoCompleteMode = AutoCompleteMode.Suggest;
            //CboTipoID.AutoCompleteSource = AutoCompleteSource.CustomSource;

            //TiposComp.Cadena(Program.GsPathData, Program.gsServidor);
            Func.CargarCombo(ref CboTipoComp, TiposComp.ConsultarXAfecta("0"), "nombre_comp", "tipo_comp");

            //EstadosComp.Cadena(Program.GsPathData, Program.gsServidor);
            Func.CargarCombo(ref CboEstado, EstadosComp.Consultar(), "descripcion_estado", "estado");

            Func.CargarCombo(ref CboFormaPago, Formas_Pago_.ConsultarParaOtrosComprobantes(), "nombre_forma", "forma");
        }

        public AutoCompleteStringCollection CargarAutocompletar(DataTable DT)
        {
            AutoCompleteStringCollection stringCol = new AutoCompleteStringCollection();

            foreach (DataRow row in DT.Rows)
            {
                stringCol.Add(Convert.ToString(row["nombre_id"]));
            }

            return stringCol;
        }

        private void TxtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            Func.ValidaNumerosDec(TxtValor.Text, ref e, 2);
            if (e.KeyChar == 13) { CboFormaPago.Focus(); }//toolStrip1.Focus(); TSBtnGuardar.Select(); }
        }

        private void TxtNumID_KeyPress(object sender, KeyPressEventArgs e)
        {
            Func.ValidaNumeros(ref e);
            if (e.KeyChar == 13)
            {
                if (TxtDV.Visible) { TxtDV.Focus(); }
                else { TxtDescripcion.Focus(); }
            }
        }

        private void TxtNumID_Leave(object sender, EventArgs e)
        {
            //TxtNumID.Text = string.Format("{0:N0}", Convert.ToInt32(TxtNumID.Text));
        }

        private void TxtNumID_Enter(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TxtNumID.Text))
            {
                TxtNumID.Text = Func.SinSeparadorMiles(TxtNumID.Text);
            }
        }

        private void TxtValor_Enter(object sender, EventArgs e)
        {
            TxtValor.Text = Func.SinSeparadorMiles(TxtValor.Text);
        }

        private void TxtValor_Leave(object sender, EventArgs e)
        {
            //TxtValor.Text = string.Format("{0:N2}", Convert.ToDouble(TxtValor.Text));
        }

        private void TxtNumID_Validating(object sender, CancelEventArgs e)
        {
            Func.ValidarControles(ref sender, ref e, ref ErrorPOtroComp, "int32", 0, true);
            if (!e.Cancel) { BUscarNombreTercero(); }
        }

        private void TxtValor_Validating(object sender, CancelEventArgs e)
        {
            Func.ValidarControles(ref sender, ref e, ref ErrorPOtroComp, "double", 2, true);
        }

        private void TSBtnGuardar_Click(object sender, EventArgs e)
        {
            GrabarDatos();
        }

        private void TSBtnAdicionar_Click(object sender, EventArgs e)
        {
            Sw = 1;
            BotonEdit();
        }

        private void TxtNumID_Validated(object sender, EventArgs e)
        {
            Func.ControlValidado(sender, e, ref ErrorPOtroComp, "int32", 0, true);
        }

        private void TxtNumComp_Validated(object sender, EventArgs e)
        {
            //Func.ControlValidado(sender, e, ref ErrorPOtroComp, "int32", 0,false);
        }

        private void CboTipoID_Validating(object sender, CancelEventArgs e)
        {
            Func.ValidarControles(ref sender, ref e, ref ErrorPOtroComp, "string", 0, true);
        }

        private void CboTipoID_Validated(object sender, EventArgs e)
        {
            Func.ControlValidado(sender, e, ref ErrorPOtroComp, "string");
        }

        private void CboTipoID_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CboTipoID.SelectedValue.ToString() != "N")
            {
                label5.Visible = false;
                TxtDV.Visible = false;
            }
            else
            {
                label5.Visible = true;
                TxtDV.Visible = true;
            }
            BUscarNombreTercero();
        }

        private void TxtNumComp_Validating(object sender, CancelEventArgs e)
        {
            //Func.ValidarControles(ref sender, ref e, ref ErrorPOtroComp, "int32", 0, false);
        }

        private void TxtDescripcion_Validating(object sender, CancelEventArgs e)
        {
            Func.ValidarControles(ref sender, ref e, ref ErrorPOtroComp, "string", 0, true);
        }

        private void TxtDescripcion_Validated(object sender, EventArgs e)
        {
            Func.ControlValidado(sender, e, ref ErrorPOtroComp, "string", 0, false);
        }

        private void TxtNombreTercero_Validating(object sender, CancelEventArgs e)
        {
            Func.ValidarControles(ref sender, ref e, ref ErrorPOtroComp, "string", 0, true);
        }
        public void BUscarNombreTercero()
        {
            N_Auxiliares Tercero = new N_Auxiliares();
            //Tercero.Cadena(Program.GsPathData,Program.gsServidor);
            TxtNombreTercero.Text = "";
            if (CboTipoID.SelectedValue != null && TxtNumID.Text != "")
            {
                TxtNombreTercero.Text = Tercero.NombreTercero(CboTipoID.SelectedValue.ToString(), Convert.ToInt32(Func.SinSeparadorMiles(TxtNumID.Text)));
            }
        }

        private void TxtNombreTercero_Validated(object sender, EventArgs e)
        {
            Func.ControlValidado(sender, e, ref ErrorPOtroComp, "string");
        }

        private void TxtUsuario_Validating(object sender, CancelEventArgs e)
        {
            Func.ValidarControles(ref sender, ref e, ref ErrorPOtroComp, "int32", 0, true);
        }

        private void TxtUsuario_Validated(object sender, EventArgs e)
        {
            Func.ControlValidado(sender, e, ref ErrorPOtroComp, "int32", 0, true);
        }

        private void TxtDV_Validating(object sender, CancelEventArgs e)
        {
            if (CboTipoID.SelectedValue.ToString() == "N")
            {
                Func.ValidarControles(ref sender, ref e, ref ErrorPOtroComp, "int32", 0, true);
            }
            else
            {
                TxtDV.Text = "";
            }
        }

        private void TxtDV_Validated(object sender, EventArgs e)
        {
            if (CboTipoID.SelectedValue.ToString() == "N")
            {
                Func.ControlValidado(sender, e, ref ErrorPOtroComp, "int32", 0, false);
            }
            else
            {
                TxtDV.Text = "";
                ErrorPOtroComp.SetError(TxtDV, string.Empty);
            }
        }

        private void TxtDV_KeyPress(object sender, KeyPressEventArgs e)
        {
            Func.ValidaNumeros(ref e);
            if (e.KeyChar == 13) { TxtNombreTercero.Focus(); }
        }

        private void TSBtnAnular_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea anular el comprobante", "Anular Comprobante", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                N_Controlcambios ControlCambios = new N_Controlcambios();
                ControlCambios.C_Controlcambios.Campo = "Comprob: " + TxtNumComp.Text;
                ControlCambios.C_Controlcambios.Valorold = CboEstado.Text;
                ControlCambios.C_Controlcambios.Usuario = Convert.ToInt32(Func.SinSeparadorMiles(TxtUsuario.Text));
                FrmAutoriza F = new FrmAutoriza(ControlCambios);
                F.ShowDialog();
                if (F.DialogResult == DialogResult.OK)
                {
                    CambiarEstado("D");
                    FrmOtros.ActualizarDatos();
                    Application.DoEvents();
                    FrmOtros.Activate();
                }
            }

        }

        private void TSBtnImprimir_Click(object sender, EventArgs e)
        {
            PrepararComprobante(CboTipoComp.SelectedValue.ToString(), Convert.ToInt32(TxtNumComp.Text));
            FrmRptOtroComprobante Form = new FrmRptOtroComprobante(Reporte);
            Form.ShowDialog();
            
        }

        private void PrepararComprobante(string TipoComp, int NumComp)
        {
            N_Formas_pago FormasPago = new N_Formas_pago();
            N_Conversion Monedas = new N_Conversion();
            N_Tipos_Comp TiposComp = new N_Tipos_Comp();
            //FormasPago.Cadena(Program.GsPathData,Program.gsServidor);
            //TiposComp.Cadena(Program.GsPathData, Program.gsServidor);
            Reporte.Fecha = OtroComprobante.C_Otroscomprobantes.Fecha;
            Reporte.Tipo_comp = OtroComprobante.C_Otroscomprobantes.Tipo_comp;
            TiposComp.C_Tipos_Comp = TiposComp.Consultar(OtroComprobante.C_Otroscomprobantes.Tipo_comp);
            Reporte.Nombre_comp = TiposComp.C_Tipos_Comp.Nombre_comp;
            Reporte.No_comp = OtroComprobante.C_Otroscomprobantes.No_comp;
            Reporte.Tipo_id = OtroComprobante.C_Otroscomprobantes.Tipo_id;
            Reporte.Id = OtroComprobante.C_Otroscomprobantes.Id;
            Reporte.Dv = OtroComprobante.C_Otroscomprobantes.Dv;
            Reporte.Nombre_tercero = TxtNombreTercero.Text;
            Reporte.Descripcion = OtroComprobante.C_Otroscomprobantes.Descripcion;
            Reporte.Valor = OtroComprobante.C_Otroscomprobantes.Valor;
            Reporte.Forma_pago = OtroComprobante.C_Otroscomprobantes.Forma_pago;
            FormasPago.C_Formas_pago = FormasPago.Consultar(OtroComprobante.C_Otroscomprobantes.Forma_pago);
            Reporte.Nombre_forma = FormasPago.C_Formas_pago.Nombre_forma;
            Reporte.Cod_cuenta = OtroComprobante.C_Otroscomprobantes.Cod_cuenta;
            Reporte.Clase_cuenta = OtroComprobante.C_Otroscomprobantes.Clase_cuenta;
            Reporte.Num = OtroComprobante.C_Otroscomprobantes.Num;
            Reporte.Entidad = OtroComprobante.C_Otroscomprobantes.Entidad;
            Reporte.Estado = OtroComprobante.C_Otroscomprobantes.Estado;
            Reporte.FechaAplic = OtroComprobante.C_Otroscomprobantes.FechaAplic;
            Reporte.Usu_cap = OtroComprobante.C_Otroscomprobantes.Usu_cap;
            Reporte.Fecha_vence = OtroComprobante.C_Otroscomprobantes.Fecha_vence;
            Reporte.Cod_empresa = OtroComprobante.C_Otroscomprobantes.Cod_empresa;
            Reporte.No_operacion = OtroComprobante.C_Otroscomprobantes.No_operacion;
            Reporte.Cod_concepto = OtroComprobante.C_Otroscomprobantes.Cod_concepto;
            Reporte.Valor_base = OtroComprobante.C_Otroscomprobantes.Valor_base;
            Reporte.Usu_aprueba = OtroComprobante.C_Otroscomprobantes.Usu_aprueba;
            Reporte.Estado_contab = OtroComprobante.C_Otroscomprobantes.Estado_contab;
            Reporte.Centro_costo = OtroComprobante.C_Otroscomprobantes.Centro_costo;
            Reporte.Seccion = OtroComprobante.C_Otroscomprobantes.Seccion;
            Reporte.Son = Monedas.Convertir(OtroComprobante.C_Otroscomprobantes.Valor.ToString(), true);

        }

        private void TSBtnSalir_Click(object sender, EventArgs e)
        {
            FrmOtros.Refresh();
            this.Close();

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
                TxtDescripcion.Focus();
            }
        }

        private void DTPFecha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) { CboTipoComp.Focus(); }
        }

        private void CboTipoComp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) { CboTipoID.Focus(); }
        }

        private void CboTipoID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) { TxtNumID.Focus(); }
        }

        private void TxtNombreTercero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) { TxtDescripcion.Focus(); }
        }

        private void TxtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) {   TxtValor.Focus();  }
        }

        private void TxtValor_Validated(object sender, EventArgs e)
        {
            Func.ControlValidado(sender, e, ref ErrorPOtroComp, "double", 2, true);
        }

        private void CboTipoComp_Validating(object sender, CancelEventArgs e)
        {
            Func.ValidarControles(ref sender, ref e, ref ErrorPOtroComp, "string", 0, true);
        }

        private void CboTipoComp_Validated(object sender, EventArgs e)
        {
            Func.ControlValidado(sender, e, ref ErrorPOtroComp, "string", 0);
        }

        private void DTPFecha_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(DTPFecha.Text))
            {
                ErrorPOtroComp.SetError(DTPFecha, "Debe ingresar una fecha");
            }
        }

        private void DTPFecha_Validated(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(DTPFecha.Text))
            {
                ErrorPOtroComp.SetError(DTPFecha, string.Empty);
            }
        }

        private void CboEstado_Validating(object sender, CancelEventArgs e)
        {
            Func.ValidarControles(ref sender, ref e, ref ErrorPOtroComp, "string", 0,true);
        }

        private void CboEstado_Validated(object sender, EventArgs e)
        {
            Func.ControlValidado(sender, e, ref ErrorPOtroComp,"string");
        }

        private void TSBtnLimpiar_Click(object sender, EventArgs e)
        {
            
        }

        private void CboFormaPago_Validated(object sender, EventArgs e)
        {
            Func.ControlValidado(sender, e, ref ErrorPOtroComp, "int32");
        }

        private void CboFormaPago_Validating(object sender, CancelEventArgs e)
        {
            Func.ValidarControles(ref sender, ref e, ref ErrorPOtroComp, "int32", 0, true);
        }

        private void CboFormaPago_Enter(object sender, EventArgs e)
        {
            
        }

        private void CboFormaPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) { toolStrip1.Focus(); TSBtnGuardar.Select(); }
        }
    }
}
