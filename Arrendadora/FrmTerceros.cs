using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;

namespace Arrendadora
{
    public partial class FrmTerceros : Form
    {
        Funciones Func = new Funciones();
        N_Auxiliares Terceros = new N_Auxiliares();
        int Sw;

        public FrmTerceros()
        {
            InitializeComponent();
            Sw = 1;
            BotonEdit();
            //Terceros.Cadena(Program.GsPathData, Program.gsServidor);
        }

        public void BotonEdit()
        {
            if (Sw == 0) //Mostrar con datos
            {
                TSBtnAdicionar.Enabled = true;
                TSBtnGuardar.Enabled = false;
                TSBtnAnular.Enabled = true;
                TSBtnLimpiar.Enabled = true;
                TSBtnSalir.Enabled = true;
                TSBtnImprimir.Enabled = true;

                CboTipoId.Enabled = false;
                TxtID.Enabled = false;


            }
            if (Sw == 1) //Adicionar
            {
                TSBtnAdicionar.Enabled = false;
                TSBtnGuardar.Enabled = true;
                TSBtnAnular.Enabled = false;
                TSBtnLimpiar.Enabled = true;
                TSBtnImprimir.Enabled = false;

                //CboTipoId.Enabled = true;
                //TxtID.Enabled = false;

            }
            if (Sw == 2) //Editar
            {
                TSBtnAdicionar.Enabled = false;
                TSBtnGuardar.Enabled = true;
                TSBtnAnular.Enabled = false;

                TSBtnLimpiar.Enabled = true;
                TSBtnImprimir.Enabled = false;

                CboTipoId.Enabled = false;
                TxtID.ReadOnly = true;
            }

            if (Sw == 4) //Mostrar sin datos
            {
                TSBtnAdicionar.Enabled = true;
                TSBtnGuardar.Enabled = false;
                TSBtnAnular.Enabled = false;

                TSBtnLimpiar.Enabled = true;
                TSBtnImprimir.Enabled = false;

                CboTipoId.Enabled = true;
                TxtID.ReadOnly = false;
            }

        }

        public void LimpiarCampos()
        {
            string ID = TxtID.Text;
            TxtID.Enabled = true;
            //this.Controls.OfType<TextBox>().ToList().ForEach(o => o.Text = "");
            foreach (Control C in this.Controls.OfType<TextBox>())
            {
                if (C.Name != "TxtID") { C.Text = ""; }
            }
            this.Controls.OfType<CheckBox>().ToList().ForEach(o => o.Checked = false);
            this.groupBox1.Controls.OfType<TextBox>().ToList().ForEach(o => o.Text = "");
            this.groupBox1.Controls.OfType<CheckBox>().ToList().ForEach(o => o.Checked = false);
            this.groupBox2.Controls.OfType<TextBox>().ToList().ForEach(o => o.Text = "");
            this.groupBox2.Controls.OfType<CheckBox>().ToList().ForEach(o => o.Checked = false);
            this.groupBox3.Controls.OfType<TextBox>().ToList().ForEach(o => o.Text = "");
            this.groupBox3.Controls.OfType<CheckBox>().ToList().ForEach(o => o.Checked = false);
            CboCiudad.SelectedValue = 0;
            CboRegimen.SelectedValue = 0;
            CboTipoPersona.SelectedValue = 0;
            CboClaseCont.SelectedValue = 0;
            TxtSalario.Text = "0";
        }

        public void BloquearControles(bool Bloquea)
        {
            foreach (Control C in this.Controls)
            {
                if (C.GetType().Name == "TextBox") { ((TextBox)C).Enabled = Bloquea; }
                if (C.GetType().Name == "ComboBox") { ((ComboBox)C).Enabled = Bloquea; }
                if (C.GetType().Name == "DateTimePicker") { ((DateTimePicker)C).Enabled = Bloquea; }
                if (C is CheckBox) { ((CheckBox)C).Enabled = false; }
            }
        }

        private void MostrarDatos(string Tipo_Aux, int Id_Aux)
        {
            if (Terceros.Existe(Tipo_Aux, Id_Aux, true))
            {
                TxtSalario.Text = "0";
                CboTipoId.Enabled = false;
                TxtID.Enabled = false;
                TxtDV.Text = Terceros.C_Auxiliares.Dv;
                TxtExpedida.Text = Terceros.C_Auxiliares.Expedido;
                TxtApellido1.Text = Terceros.C_Auxiliares.Apellido1;
                TxtApellido2.Text = Terceros.C_Auxiliares.Apellido2;
                TxtNombres.Text = Terceros.C_Auxiliares.Nombre;
                TxtDireccion.Text = Terceros.C_Auxiliares.Direccion;
                CboCiudad.SelectedValue = Terceros.C_Auxiliares.Ciudad;
                TxtMail.Text = Terceros.C_Auxiliares.Correo_electronico;
                TxtTelefono.Text = Terceros.C_Auxiliares.Telefono;
                CboTipoPersona.SelectedValue = Terceros.C_Auxiliares.Tipo;
                CboRegimen.SelectedValue = Terceros.C_Auxiliares.Regimen;
                CboClaseCont.SelectedValue = Terceros.C_Auxiliares.Clase;
                TxtEmpresa.Text = Terceros.C_Auxiliares.Empresa;
                TxtTelEmpresa.Text = Terceros.C_Auxiliares.Tel_empresa;
                TxtSalario.Text = Terceros.C_Auxiliares.Salario.ToString("N2");
                ChkCliente.Checked = Convert.ToBoolean(Terceros.C_Auxiliares.Cliente);
                ChkNosAplicaRetencion.Checked = Convert.ToBoolean(Terceros.C_Auxiliares.Nosaplica_retencion);
                ChkPropietario.Checked = Convert.ToBoolean(Terceros.C_Auxiliares.Propietario);
                ChkProveedor.Checked = Convert.ToBoolean(Terceros.C_Auxiliares.Proveedor);
                ChkReteICA.Checked = Convert.ToBoolean(Terceros.C_Auxiliares.Reteica);
                ChkReteIVA.Checked = Convert.ToBoolean(Terceros.C_Auxiliares.Reteiva);
                ChkRetencion.Checked = Convert.ToBoolean(Terceros.C_Auxiliares.Retencion);
                ChkEmpleado.Checked = Convert.ToBoolean(Terceros.C_Auxiliares.Empleado);
                CargarTelefonos(Terceros.C_Auxiliares.Tipo_aux, Terceros.C_Auxiliares.Id_aux);
                Sw = 2;
                BotonEdit();
            }
        }

        private void GrabarDatos()
        {
            //MessageBox.Show(this.ValidateChildren().ToString());
            if (this.ValidateChildren(ValidationConstraints.Visible))
            {
                int Errores = 0;
                foreach (Control C in this.Controls)
                {
                    if (ErrorPTerceros.GetError(C)!="") { Errores++; }
                }
                if (Errores==0)
                {
                    Terceros.C_Auxiliares.Tipo_aux = CboTipoId.SelectedValue.ToString();
                    Terceros.C_Auxiliares.Id_aux = Convert.ToInt32(Func.SinSeparadorMiles(TxtID.Text));
                    Terceros.C_Auxiliares.Dv = TxtDV.Text;
                    Terceros.C_Auxiliares.Expedido = TxtExpedida.Text;
                    Terceros.C_Auxiliares.Apellido1 = TxtApellido1.Text;
                    Terceros.C_Auxiliares.Apellido2 = TxtApellido2.Text;
                    Terceros.C_Auxiliares.Nombre = TxtNombres.Text;
                    Terceros.C_Auxiliares.Direccion = TxtDireccion.Text;
                    Terceros.C_Auxiliares.Telefono = TxtTelefono.Text;
                    Terceros.C_Auxiliares.Empresa = TxtEmpresa.Text;
                    Terceros.C_Auxiliares.Tel_empresa = TxtTelEmpresa.Text;
                    Terceros.C_Auxiliares.Salario = Convert.ToDouble((TxtSalario.Text));
                    Terceros.C_Auxiliares.Ciudad = Convert.ToInt32(CboCiudad.SelectedValue.ToString());
                    Terceros.C_Auxiliares.Regimen = Convert.ToInt32(CboRegimen.SelectedValue.ToString());
                    Terceros.C_Auxiliares.Clase = Convert.ToInt32(CboClaseCont.SelectedValue.ToString());
                    Terceros.C_Auxiliares.Tipo = Convert.ToInt32(CboTipoPersona.SelectedValue.ToString());
                    Terceros.C_Auxiliares.Nosaplica_retencion = ChkNosAplicaRetencion.Checked;
                    Terceros.C_Auxiliares.Propietario = ChkPropietario.Checked;
                    Terceros.C_Auxiliares.Empleado = ChkEmpleado.Checked;
                    Terceros.C_Auxiliares.Cliente = ChkCliente.Checked;
                    Terceros.C_Auxiliares.Reteica = ChkReteICA.Checked;
                    Terceros.C_Auxiliares.Reteiva = ChkReteIVA.Checked;
                    Terceros.C_Auxiliares.Retencion = ChkRetencion.Checked;
                    if (Terceros.Existe(Terceros.C_Auxiliares.Tipo_aux, Terceros.C_Auxiliares.Id_aux, false))
                    {
                        if (Terceros.Actualizar(Terceros.C_Auxiliares) == -1)
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
                        if (Terceros.Insertar(Terceros.C_Auxiliares) == -1)
                        {
                            MessageBox.Show("Hubo un problema insertando el registro");
                        }
                        else
                        {
                            MessageBox.Show("Registro guardado exitosamente");
                            Sw = 0;
                            BotonEdit();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Hace falta ingresar información en uno o varios campos", "Error de Validación de Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Hace falta ingresar información en uno o varios campos", "Error de Validación de Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarTelefonos(string Tipo_aux, int Id_aux)
        {
            N_Telefonos_auxiliar TelefonosAuxiliar = new N_Telefonos_auxiliar();
            //TelefonosAuxiliar.Cadena(Program.GsPathData, Program.gsServidor);
            DGVTelefono.DataSource = TelefonosAuxiliar.ConsultarTelefonos(Tipo_aux, Id_aux);
        }

        private void FrmTerceros_Load(object sender, EventArgs e)
        {
            CargarCombos();
        }

        private void CargarCombos()
        {
            N_Tipos_Id TiposId = new N_Tipos_Id();
            //TiposId.Cadena(Program.GsPathData, Program.gsServidor);
            Func.CargarCombo(ref CboTipoId, TiposId.Consultar(), "nombre_id", "tipo_id");

            N_Ciudades Ciudades = new N_Ciudades();
            //Ciudades.Cadena(Program.GsPathData, Program.gsServidor);
            Func.CargarCombo(ref CboCiudad, Ciudades.Consultar(), "nombre_ciudad", "llave_ciudad");

            N_Clases_contribuyente ClaseContribuyentes = new N_Clases_contribuyente();
            //ClaseContribuyentes.Cadena(Program.GsPathData, Program.gsServidor);
            Func.CargarCombo(ref CboClaseCont, ClaseContribuyentes.Consultar(), "descripcion_clase", "clase");

            N_Regimenes Regimenes = new N_Regimenes();
            //Regimenes.Cadena(Program.GsPathData, Program.gsServidor);
            Func.CargarCombo(ref CboRegimen, Regimenes.Consultar(), "descripcion_regimen", "regimen");

            N_Tipos_tercero TiposTerceros = new N_Tipos_tercero();
            //TiposTerceros.Cadena(Program.GsPathData, Program.gsServidor);
            Func.CargarCombo(ref CboTipoPersona, TiposTerceros.Consultar(), "descripcion_tipo", "tipo");

        }

        private void CboTipoId_Validating(object sender, CancelEventArgs e)
        {
            Func.ValidarControles(ref sender, ref e, ref ErrorPTerceros, "string", 0, true);
        }

        private void CboTipoId_Validated(object sender, EventArgs e)
        {
            Func.ControlValidado(sender, e, ref ErrorPTerceros, "string");
        }

        private void CboTipoId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) { TxtID.Focus(); }
        }

        private void TxtID_Validating(object sender, CancelEventArgs e)
        {
            Func.ValidarControles(ref sender, ref e, ref ErrorPTerceros, "int32", 0, true);
        }

        private void TxtID_Validated(object sender, EventArgs e)
        {
            Func.ControlValidado(sender, e, ref ErrorPTerceros, "int32", 0, true);
        }

        private void TxtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (TxtDV.Visible) { TxtDV.Focus(); }
                else { TxtExpedida.Focus(); }
            }
        }

        private void TxtApellido1_Validating(object sender, CancelEventArgs e)
        {
            Func.ValidarControles(ref sender, ref e, ref ErrorPTerceros, "string", 0, true);
        }

        private void TxtApellido1_Validated(object sender, EventArgs e)
        {
            Func.ControlValidado(sender, e, ref ErrorPTerceros, "string");
        }

        private void TxtApellido1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) { TxtApellido2.Focus(); }
        }

        private void TxtApellido2_Validating(object sender, CancelEventArgs e)
        {
            Func.ValidarControles(ref sender, ref e, ref ErrorPTerceros, "string", 0, true);
        }

        private void TxtApellido2_Validated(object sender, EventArgs e)
        {
            Func.ControlValidado(sender, e, ref ErrorPTerceros, "string");
        }

        private void TxtApellido2_MouseEnter(object sender, EventArgs e)
        {

        }

        private void TxtApellido2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) { TxtNombres.Focus(); }
        }

        private void TxtNombres_Validating(object sender, CancelEventArgs e)
        {
            Func.ValidarControles(ref sender, ref e, ref ErrorPTerceros, "string", 0, true);
        }

        private void TxtNombres_Validated(object sender, EventArgs e)
        {
            Func.ControlValidado(sender, e, ref ErrorPTerceros, "string");
        }

        private void TxtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) { TxtDireccion.Focus(); }
        }

        private void TxtDireccion_Validating(object sender, CancelEventArgs e)
        {
            Func.ValidarControles(ref sender, ref e, ref ErrorPTerceros, "string", 0, true);
        }

        private void TxtDireccion_Validated(object sender, EventArgs e)
        {
            Func.ControlValidado(sender, e, ref ErrorPTerceros, "string");
        }

        private void TxtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) { CboCiudad.Focus(); }
        }

        private void CboCiudad_Validating(object sender, CancelEventArgs e)
        {
            Func.ValidarControles(ref sender, ref e, ref ErrorPTerceros, "int32", 0, true);
        }

        private void CboCiudad_Validated(object sender, EventArgs e)
        {
            Func.ControlValidado(sender, e, ref ErrorPTerceros, "int32", 0, false);
        }

        private void CboCiudad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) { TxtTelefono.Focus(); }
        }

        private void TxtMail_Validating(object sender, CancelEventArgs e)
        {
            Func.ValidarControles(ref sender, ref e, ref ErrorPTerceros, "string", 0, false);
        }

        private void TxtMail_Validated(object sender, EventArgs e)
        {
            Func.ControlValidado(sender, e, ref ErrorPTerceros, "string");
        }

        private void TxtMail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) { CboTipoPersona.Focus(); }
        }

        private void CboTipoPersona_Validating(object sender, CancelEventArgs e)
        {
            Func.ValidarControles(ref sender, ref e, ref ErrorPTerceros, "int32", 0, true);
        }

        private void CboTipoPersona_Validated(object sender, EventArgs e)
        {
            Func.ControlValidado(sender, e, ref ErrorPTerceros, "int32", 0);
        }

        private void CboTipoPersona_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) { CboRegimen.Focus(); }
        }

        private void CboRegimen_Validating(object sender, CancelEventArgs e)
        {
            Func.ValidarControles(ref sender, ref e, ref ErrorPTerceros, "int32", 0, true);
        }

        private void CboRegimen_Validated(object sender, EventArgs e)
        {
            Func.ControlValidado(sender, e, ref ErrorPTerceros, "int32", 0);
        }

        private void CboRegimen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) { CboClaseCont.Focus(); }
        }

        private void CboClaseCont_Validating(object sender, CancelEventArgs e)
        {
            Func.ValidarControles(ref sender, ref e, ref ErrorPTerceros, "int32", 0, true);
        }

        private void CboClaseCont_Validated(object sender, EventArgs e)
        {
            Func.ControlValidado(sender, e, ref ErrorPTerceros, "int32", 0);
        }

        private void CboClaseCont_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) { ChkRetencion.Focus(); }
        }

        private void ChkNosAplicaRetencion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) { TxtEmpresa.Focus(); }
        }

        private void TxtEmpresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) { TxtTelEmpresa.Focus(); }
        }

        private void TxtTelEmpresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) { TxtSalario.Focus(); }
        }

        private void TxtSalario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) { ChkEmpleado.Focus(); }
        }

        private void CboTipoId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboTipoId.SelectedValue.ToString() == "N")
            {
                label3.Visible = true;
                TxtDV.Visible = true;
                label4.Visible = false;
                TxtApellido2.Visible = false;
                label5.Visible = false;
                TxtNombres.Visible = false;
                TxtApellido1.Width = 509;
                TxtApellido1.Height = 40;
                TxtApellido1.Multiline = true;
                lblApellido1.Text = "Razón Social";
            }
            else
            {
                label3.Visible = false;
                TxtDV.Visible = false;
                label4.Visible = true;
                TxtApellido2.Visible = true;
                label5.Visible = true;
                TxtNombres.Visible = true;
                TxtApellido1.Width = 210;
                TxtApellido1.Height = 20;
                TxtApellido1.Multiline = false;
                lblApellido1.Text = "Primer Apellido";
            }

        }

        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) { TxtMail.Focus(); }
        }

        private void TSBtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TSBtnAdicionar_Click(object sender, EventArgs e)
        {
            Sw = 1;
            BotonEdit();
            LimpiarCampos();
            TxtID.Text = "";
            TxtID.Enabled = true;
        }

        private void TSBtnGuardar_Click(object sender, EventArgs e)
        {
            GrabarDatos();
        }

        private void TxtDV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) { TxtExpedida.Focus(); }
        }

        private void TxtDV_Validating(object sender, CancelEventArgs e)
        {
            Func.ValidarControles(ref sender, ref e, ref ErrorPTerceros, "int32", 0, true);
        }

        private void TxtDV_Validated(object sender, EventArgs e)
        {
            Func.ControlValidado(sender, e, ref ErrorPTerceros, "int32", 0);
        }

        private void TxtExpedida_Validating(object sender, CancelEventArgs e)
        {
            Func.ValidarControles(ref sender, ref e, ref ErrorPTerceros, "string", 0, true);
        }

        private void TxtExpedida_Validated(object sender, EventArgs e)
        {
            Func.ControlValidado(sender, e, ref ErrorPTerceros, "string");
        }

        private void TxtExpedida_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) { TxtApellido1.Focus(); }
        }

        private void TSBtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void TxtTelEmpresa_Validating(object sender, CancelEventArgs e)
        {
            Func.ValidarControles(ref sender, ref e, ref ErrorPTerceros, "string", 0, false);
        }

        private void TxtTelEmpresa_Validated(object sender, EventArgs e)
        {
            Func.ControlValidado(sender, e, ref ErrorPTerceros, "string", 0, true);
        }

        private void TxtSalario_Validating(object sender, CancelEventArgs e)
        {
            Func.ValidarControles(ref sender, ref e, ref ErrorPTerceros, "double", 2, true);
        }

        private void TxtSalario_Validated(object sender, EventArgs e)
        {
            Func.ControlValidado(sender, e, ref ErrorPTerceros, "double", 2, true);
        }

        private void TxtID_Leave(object sender, EventArgs e)
        {
            if (CboTipoId.SelectedValue != null && !string.IsNullOrWhiteSpace(TxtID.Text))
            {
                if (Terceros.Existe(CboTipoId.SelectedValue.ToString(), Convert.ToInt32(Func.SinSeparadorMiles(TxtID.Text)), true))
                {
                    MostrarDatos(CboTipoId.SelectedValue.ToString(), Convert.ToInt32(Func.SinSeparadorMiles(TxtID.Text)));
                }
                else
                {
                    if (MessageBox.Show("El tercero no existe, desea crearlo", "Terceros", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {

                        LimpiarCampos();
                    }
                }
            }

        }

        private void TxtTelefono_Validating(object sender, CancelEventArgs e)
        {
            Func.ValidarControles(ref sender, ref e, ref ErrorPTerceros, "string", 0, true);
        }

        private void TxtTelefono_Validated(object sender, EventArgs e)
        {
            Func.ControlValidado(sender, e, ref ErrorPTerceros, "string", 0);
        }

        private void ChkRetencion_Validating(object sender, CancelEventArgs e)
        {
            if (!ChkRetencion.Checked && !ChkNosAplicaRetencion.Checked)
            {
                ErrorPTerceros.SetError(ChkRetencion, "Verifique si el tercero está sujeto a retención");
            }
        }

        private void ChkReteICA_Validating(object sender, CancelEventArgs e)
        {
            ErrorPTerceros.SetError(ChkReteICA, string.Empty);
        }

        private void ChkReteICA_Validated(object sender, EventArgs e)
        {
            ErrorPTerceros.SetError(ChkReteIVA, string.Empty);
        }

        private void ChkReteIVA_Validated(object sender, EventArgs e)
        {
            ErrorPTerceros.SetError(ChkReteIVA, string.Empty);
        }

        private void ChkNosAplicaRetencion_Validated(object sender, EventArgs e)
        {
            if (ChkRetencion.Checked || ChkNosAplicaRetencion.Checked)
            {
                ErrorPTerceros.SetError(ChkNosAplicaRetencion, string.Empty);
            }
        }

        private void ChkEmpleado_Validating(object sender, CancelEventArgs e)
        {
            if (!ChkCliente.Checked && !ChkEmpleado.Checked && !ChkPropietario.Checked && !ChkProveedor.Checked)
            {
                ErrorPTerceros.SetError(ChkEmpleado, "Debe seleccionar por lo menos una de las opciones");
            }
        }

        private void ChkProveedor_Validating(object sender, CancelEventArgs e)
        {
            if (!ChkCliente.Checked && !ChkEmpleado.Checked && !ChkPropietario.Checked && !ChkProveedor.Checked)
            {
                ErrorPTerceros.SetError(ChkProveedor, "Debe seleccionar por lo menos una de las opciones");
            }

        }

        private void ChkCliente_Validating(object sender, CancelEventArgs e)
        {
            if (!ChkCliente.Checked && !ChkEmpleado.Checked && !ChkPropietario.Checked && !ChkProveedor.Checked)
            {
                ErrorPTerceros.SetError(ChkCliente, "Debe seleccionar por lo menos una de las opciones");
            }

        }

        private void ChkPropietario_Validating(object sender, CancelEventArgs e)
        {
            if (!ChkCliente.Checked && !ChkEmpleado.Checked && !ChkPropietario.Checked && !ChkProveedor.Checked)
            {
                ErrorPTerceros.SetError(ChkPropietario, "Debe seleccionar por lo menos una de las opciones");
            }

        }

        private void ChkEmpleado_Validated(object sender, EventArgs e)
        {
            if (ChkCliente.Checked || ChkEmpleado.Checked || ChkPropietario.Checked || ChkProveedor.Checked)
            {
                ErrorPTerceros.SetError(ChkEmpleado, string.Empty);
            }
        }

        private void ChkProveedor_Validated(object sender, EventArgs e)
        {
            if (ChkCliente.Checked || ChkEmpleado.Checked || ChkPropietario.Checked || ChkProveedor.Checked)
            {
                ErrorPTerceros.SetError(ChkProveedor, string.Empty);
            }

        }

        private void ChkCliente_Validated(object sender, EventArgs e)
        {
            if (ChkCliente.Checked || ChkEmpleado.Checked || ChkPropietario.Checked || ChkProveedor.Checked)
            {
                ErrorPTerceros.SetError(ChkCliente, string.Empty);
            }
        }

        private void ChkPropietario_Validated(object sender, EventArgs e)
        {
            if (ChkCliente.Checked || ChkEmpleado.Checked || ChkPropietario.Checked || ChkProveedor.Checked)
            {
                ErrorPTerceros.SetError(ChkPropietario, string.Empty);
            }
        }

        private void TxtEmpresa_Validating(object sender, CancelEventArgs e)
        {
            Func.ValidarControles(ref sender, ref e, ref ErrorPTerceros, "string", 0, false);
        }

        private void TxtEmpresa_Validated(object sender, EventArgs e)
        {
            Func.ControlValidado(sender, e, ref ErrorPTerceros, "string");
        }

        private void ChkReteIVA_Validating(object sender, CancelEventArgs e)
        {
            ErrorPTerceros.SetError(ChkReteICA, string.Empty);
        }

        private void ChkNosAplicaRetencion_Validating(object sender, CancelEventArgs e)
        {
            if (!ChkRetencion.Checked && !ChkNosAplicaRetencion.Checked)
            {
                ErrorPTerceros.SetError(ChkNosAplicaRetencion, "Verifique si el tercero está sujeto a retención");
            }
        }

        private void ChkRetencion_Validated(object sender, EventArgs e)
        {
            if (ChkRetencion.Checked || ChkNosAplicaRetencion.Checked)
            {
                ErrorPTerceros.SetError(ChkRetencion, string.Empty);
            }
        }

        private void DGVTelefono_Validating(object sender, CancelEventArgs e)
        {
            ErrorPTerceros.SetError(DGVTelefono, string.Empty);
        }

        private void DGVTelefono_Validated(object sender, EventArgs e)
        {
            ErrorPTerceros.SetError(DGVTelefono, string.Empty);
        }
    }
}
