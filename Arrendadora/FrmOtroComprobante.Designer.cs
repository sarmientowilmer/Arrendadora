namespace Arrendadora
{
    partial class FrmOtroComprobante
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOtroComprobante));
            this.CboTipoComp = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNumComp = new System.Windows.Forms.TextBox();
            this.CboTipoID = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtNumID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtDV = new System.Windows.Forms.TextBox();
            this.TxtNombreTercero = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtValor = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.DTPFecha = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.CboEstado = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TSBtnAdicionar = new System.Windows.Forms.ToolStripButton();
            this.TSBtnGuardar = new System.Windows.Forms.ToolStripButton();
            this.TSBtnAnular = new System.Windows.Forms.ToolStripButton();
            this.TSBtnLimpiar = new System.Windows.Forms.ToolStripButton();
            this.TSBtnImprimir = new System.Windows.Forms.ToolStripButton();
            this.TSBtnSalir = new System.Windows.Forms.ToolStripButton();
            this.ErrorPOtroComp = new System.Windows.Forms.ErrorProvider(this.components);
            this.BtnTerceros = new System.Windows.Forms.Button();
            this.CboFormaPago = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorPOtroComp)).BeginInit();
            this.SuspendLayout();
            // 
            // CboTipoComp
            // 
            this.CboTipoComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboTipoComp.FormattingEnabled = true;
            this.CboTipoComp.Location = new System.Drawing.Point(130, 100);
            this.CboTipoComp.Name = "CboTipoComp";
            this.CboTipoComp.Size = new System.Drawing.Size(207, 24);
            this.CboTipoComp.TabIndex = 3;
            this.CboTipoComp.Tag = "Tipo de Comprobante";
            this.CboTipoComp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CboTipoComp_KeyPress);
            this.CboTipoComp.Validating += new System.ComponentModel.CancelEventHandler(this.CboTipoComp_Validating);
            this.CboTipoComp.Validated += new System.EventHandler(this.CboTipoComp_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tipo Comp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(362, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Núm. Comp";
            // 
            // TxtNumComp
            // 
            this.TxtNumComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumComp.Location = new System.Drawing.Point(447, 99);
            this.TxtNumComp.Name = "TxtNumComp";
            this.TxtNumComp.Size = new System.Drawing.Size(207, 22);
            this.TxtNumComp.TabIndex = 5;
            this.TxtNumComp.Tag = "Número de Comprobante";
            this.TxtNumComp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtNumComp.Validating += new System.ComponentModel.CancelEventHandler(this.TxtNumComp_Validating);
            this.TxtNumComp.Validated += new System.EventHandler(this.TxtNumComp_Validated);
            // 
            // CboTipoID
            // 
            this.CboTipoID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CboTipoID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.CboTipoID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboTipoID.FormattingEnabled = true;
            this.CboTipoID.Location = new System.Drawing.Point(130, 127);
            this.CboTipoID.Name = "CboTipoID";
            this.CboTipoID.Size = new System.Drawing.Size(207, 24);
            this.CboTipoID.TabIndex = 7;
            this.CboTipoID.Tag = "Tipo de Identificación";
            this.CboTipoID.SelectedValueChanged += new System.EventHandler(this.CboTipoID_SelectedValueChanged);
            this.CboTipoID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CboTipoID_KeyPress);
            this.CboTipoID.Validating += new System.ComponentModel.CancelEventHandler(this.CboTipoID_Validating);
            this.CboTipoID.Validated += new System.EventHandler(this.CboTipoID_Validated);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tipo ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(362, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Núm. ID";
            // 
            // TxtNumID
            // 
            this.TxtNumID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumID.Location = new System.Drawing.Point(447, 126);
            this.TxtNumID.MaxLength = 11;
            this.TxtNumID.Name = "TxtNumID";
            this.TxtNumID.Size = new System.Drawing.Size(207, 22);
            this.TxtNumID.TabIndex = 9;
            this.TxtNumID.Tag = "Número de Identificación";
            this.TxtNumID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtNumID.Enter += new System.EventHandler(this.TxtNumID_Enter);
            this.TxtNumID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumID_KeyPress);
            this.TxtNumID.Leave += new System.EventHandler(this.TxtNumID_Leave);
            this.TxtNumID.Validating += new System.ComponentModel.CancelEventHandler(this.TxtNumID_Validating);
            this.TxtNumID.Validated += new System.EventHandler(this.TxtNumID_Validated);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(678, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "DV";
            // 
            // TxtDV
            // 
            this.TxtDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDV.Location = new System.Drawing.Point(711, 127);
            this.TxtDV.MaxLength = 1;
            this.TxtDV.Name = "TxtDV";
            this.TxtDV.Size = new System.Drawing.Size(26, 22);
            this.TxtDV.TabIndex = 11;
            this.TxtDV.Tag = "Dígito de Verificación si es NIT";
            this.TxtDV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDV_KeyPress);
            this.TxtDV.Validating += new System.ComponentModel.CancelEventHandler(this.TxtDV_Validating);
            this.TxtDV.Validated += new System.EventHandler(this.TxtDV_Validated);
            // 
            // TxtNombreTercero
            // 
            this.TxtNombreTercero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNombreTercero.Enabled = false;
            this.TxtNombreTercero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombreTercero.Location = new System.Drawing.Point(130, 154);
            this.TxtNombreTercero.Multiline = true;
            this.TxtNombreTercero.Name = "TxtNombreTercero";
            this.TxtNombreTercero.Size = new System.Drawing.Size(607, 38);
            this.TxtNombreTercero.TabIndex = 13;
            this.TxtNombreTercero.Tag = "Nombre del Tercero";
            this.TxtNombreTercero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombreTercero_KeyPress);
            this.TxtNombreTercero.Validating += new System.ComponentModel.CancelEventHandler(this.TxtNombreTercero_Validating);
            this.TxtNombreTercero.Validated += new System.EventHandler(this.TxtNombreTercero_Validated);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Nombre";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Descripción";
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDescripcion.Location = new System.Drawing.Point(130, 198);
            this.TxtDescripcion.MaxLength = 255;
            this.TxtDescripcion.Multiline = true;
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(607, 38);
            this.TxtDescripcion.TabIndex = 15;
            this.TxtDescripcion.Tag = "Descripción del Comprobante";
            this.TxtDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDescripcion_KeyPress);
            this.TxtDescripcion.Validating += new System.ComponentModel.CancelEventHandler(this.TxtDescripcion_Validating);
            this.TxtDescripcion.Validated += new System.EventHandler(this.TxtDescripcion_Validated);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(28, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Valor";
            // 
            // TxtValor
            // 
            this.TxtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtValor.Location = new System.Drawing.Point(130, 242);
            this.TxtValor.Name = "TxtValor";
            this.TxtValor.Size = new System.Drawing.Size(207, 22);
            this.TxtValor.TabIndex = 17;
            this.TxtValor.Tag = "Valor del Comprobante";
            this.TxtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtValor.Enter += new System.EventHandler(this.TxtValor_Enter);
            this.TxtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtValor_KeyPress);
            this.TxtValor.Validating += new System.ComponentModel.CancelEventHandler(this.TxtValor_Validating);
            this.TxtValor.Validated += new System.EventHandler(this.TxtValor_Validated);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(28, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Fecha";
            // 
            // DTPFecha
            // 
            this.DTPFecha.CustomFormat = "dd-MMM-yyyy";
            this.DTPFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPFecha.Location = new System.Drawing.Point(130, 71);
            this.DTPFecha.Name = "DTPFecha";
            this.DTPFecha.Size = new System.Drawing.Size(177, 22);
            this.DTPFecha.TabIndex = 1;
            this.DTPFecha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DTPFecha_KeyPress);
            this.DTPFecha.Validating += new System.ComponentModel.CancelEventHandler(this.DTPFecha_Validating);
            this.DTPFecha.Validated += new System.EventHandler(this.DTPFecha_Validated);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(28, 300);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 16);
            this.label10.TabIndex = 18;
            this.label10.Text = "Usuario";
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsuario.Location = new System.Drawing.Point(130, 298);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(207, 22);
            this.TxtUsuario.TabIndex = 19;
            this.TxtUsuario.Tag = "Usuario que registra el comprobante";
            this.TxtUsuario.Validating += new System.ComponentModel.CancelEventHandler(this.TxtUsuario_Validating);
            this.TxtUsuario.Validated += new System.EventHandler(this.TxtUsuario_Validated);
            // 
            // CboEstado
            // 
            this.CboEstado.Enabled = false;
            this.CboEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboEstado.FormattingEnabled = true;
            this.CboEstado.Location = new System.Drawing.Point(507, 296);
            this.CboEstado.Name = "CboEstado";
            this.CboEstado.Size = new System.Drawing.Size(230, 24);
            this.CboEstado.TabIndex = 21;
            this.CboEstado.Tag = "Estado del Comprobante";
            this.CboEstado.Validating += new System.ComponentModel.CancelEventHandler(this.CboEstado_Validating);
            this.CboEstado.Validated += new System.EventHandler(this.CboEstado_Validated);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(421, 299);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 16);
            this.label11.TabIndex = 20;
            this.label11.Text = "Estado";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSBtnAdicionar,
            this.TSBtnGuardar,
            this.TSBtnAnular,
            this.TSBtnLimpiar,
            this.TSBtnImprimir,
            this.TSBtnSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(816, 55);
            this.toolStrip1.TabIndex = 22;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TSBtnAdicionar
            // 
            this.TSBtnAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("TSBtnAdicionar.Image")));
            this.TSBtnAdicionar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBtnAdicionar.Name = "TSBtnAdicionar";
            this.TSBtnAdicionar.Size = new System.Drawing.Size(52, 67);
            this.TSBtnAdicionar.Text = "Nuevo";
            this.TSBtnAdicionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TSBtnAdicionar.Visible = false;
            this.TSBtnAdicionar.Click += new System.EventHandler(this.TSBtnAdicionar_Click);
            // 
            // TSBtnGuardar
            // 
            this.TSBtnGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBtnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("TSBtnGuardar.Image")));
            this.TSBtnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBtnGuardar.Name = "TSBtnGuardar";
            this.TSBtnGuardar.Size = new System.Drawing.Size(52, 52);
            this.TSBtnGuardar.Text = "Guardar";
            this.TSBtnGuardar.Click += new System.EventHandler(this.TSBtnGuardar_Click);
            // 
            // TSBtnAnular
            // 
            this.TSBtnAnular.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBtnAnular.Image = ((System.Drawing.Image)(resources.GetObject("TSBtnAnular.Image")));
            this.TSBtnAnular.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBtnAnular.Name = "TSBtnAnular";
            this.TSBtnAnular.Size = new System.Drawing.Size(52, 52);
            this.TSBtnAnular.Text = "Anular";
            this.TSBtnAnular.Click += new System.EventHandler(this.TSBtnAnular_Click);
            // 
            // TSBtnLimpiar
            // 
            this.TSBtnLimpiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBtnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("TSBtnLimpiar.Image")));
            this.TSBtnLimpiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBtnLimpiar.Name = "TSBtnLimpiar";
            this.TSBtnLimpiar.Size = new System.Drawing.Size(52, 52);
            this.TSBtnLimpiar.Text = "Limpiar";
            this.TSBtnLimpiar.Click += new System.EventHandler(this.TSBtnLimpiar_Click);
            // 
            // TSBtnImprimir
            // 
            this.TSBtnImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBtnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("TSBtnImprimir.Image")));
            this.TSBtnImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBtnImprimir.Name = "TSBtnImprimir";
            this.TSBtnImprimir.Size = new System.Drawing.Size(52, 52);
            this.TSBtnImprimir.Text = "Imprimir";
            this.TSBtnImprimir.Click += new System.EventHandler(this.TSBtnImprimir_Click);
            // 
            // TSBtnSalir
            // 
            this.TSBtnSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBtnSalir.Image = ((System.Drawing.Image)(resources.GetObject("TSBtnSalir.Image")));
            this.TSBtnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBtnSalir.Name = "TSBtnSalir";
            this.TSBtnSalir.Size = new System.Drawing.Size(52, 52);
            this.TSBtnSalir.Text = "Salir";
            this.TSBtnSalir.Click += new System.EventHandler(this.TSBtnSalir_Click);
            // 
            // ErrorPOtroComp
            // 
            this.ErrorPOtroComp.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ErrorPOtroComp.ContainerControl = this;
            // 
            // BtnTerceros
            // 
            this.BtnTerceros.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnTerceros.BackgroundImage")));
            this.BtnTerceros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnTerceros.Location = new System.Drawing.Point(743, 121);
            this.BtnTerceros.Name = "BtnTerceros";
            this.BtnTerceros.Size = new System.Drawing.Size(48, 30);
            this.BtnTerceros.TabIndex = 23;
            this.BtnTerceros.UseVisualStyleBackColor = true;
            this.BtnTerceros.Click += new System.EventHandler(this.BtnTerceros_Click);
            // 
            // CboFormaPago
            // 
            this.CboFormaPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboFormaPago.FormattingEnabled = true;
            this.CboFormaPago.Location = new System.Drawing.Point(130, 270);
            this.CboFormaPago.Name = "CboFormaPago";
            this.CboFormaPago.Size = new System.Drawing.Size(273, 24);
            this.CboFormaPago.TabIndex = 25;
            this.CboFormaPago.Tag = "Estado del Comprobante";
            this.CboFormaPago.Enter += new System.EventHandler(this.CboFormaPago_Enter);
            this.CboFormaPago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CboFormaPago_KeyPress);
            this.CboFormaPago.Validating += new System.ComponentModel.CancelEventHandler(this.CboFormaPago_Validating);
            this.CboFormaPago.Validated += new System.EventHandler(this.CboFormaPago_Validated);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(28, 273);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 16);
            this.label12.TabIndex = 24;
            this.label12.Text = "Forma de Pago";
            // 
            // FrmOtroComprobante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 337);
            this.Controls.Add(this.CboFormaPago);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.BtnTerceros);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.CboEstado);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.DTPFecha);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtValor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtDescripcion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtNombreTercero);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtDV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtNumID);
            this.Controls.Add(this.CboTipoID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtNumComp);
            this.Controls.Add(this.CboTipoComp);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmOtroComprobante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Otros Comprobantes";
            this.Load += new System.EventHandler(this.FrmOtroComprobante_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorPOtroComp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CboTipoID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtNumID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtDV;
        private System.Windows.Forms.TextBox TxtNombreTercero;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtValor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker DTPFecha;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.ComboBox CboEstado;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ErrorProvider ErrorPOtroComp;
        private System.Windows.Forms.ToolStripButton TSBtnAdicionar;
        private System.Windows.Forms.ToolStripButton TSBtnGuardar;
        private System.Windows.Forms.ToolStripButton TSBtnAnular;
        private System.Windows.Forms.ToolStripButton TSBtnLimpiar;
        private System.Windows.Forms.ToolStripButton TSBtnSalir;
        private System.Windows.Forms.ToolStripButton TSBtnImprimir;
        private System.Windows.Forms.Button BtnTerceros;
        public System.Windows.Forms.ComboBox CboTipoComp;
        public System.Windows.Forms.TextBox TxtNumComp;
        private System.Windows.Forms.ComboBox CboFormaPago;
        private System.Windows.Forms.Label label12;
    }
}