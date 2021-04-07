namespace Arrendadora
{
    partial class FrmTerceros
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTerceros));
            this.label9 = new System.Windows.Forms.Label();
            this.TxtMail = new System.Windows.Forms.TextBox();
            this.CboCiudad = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtNombres = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtApellido2 = new System.Windows.Forms.TextBox();
            this.lblApellido1 = new System.Windows.Forms.Label();
            this.CboTipoId = new System.Windows.Forms.ComboBox();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtApellido1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ChkPropietario = new System.Windows.Forms.CheckBox();
            this.ChkCliente = new System.Windows.Forms.CheckBox();
            this.ChkProveedor = new System.Windows.Forms.CheckBox();
            this.ChkEmpleado = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.TxtSalario = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.TxtTelEmpresa = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtEmpresa = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ChkNosAplicaRetencion = new System.Windows.Forms.CheckBox();
            this.ChkReteIVA = new System.Windows.Forms.CheckBox();
            this.ChkReteICA = new System.Windows.Forms.CheckBox();
            this.ChkRetencion = new System.Windows.Forms.CheckBox();
            this.CboClaseCont = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.CboRegimen = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.CboTipoPersona = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.DGVTelefono = new System.Windows.Forms.DataGridView();
            this.item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion_tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.no_telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ErrorPTerceros = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TSBtnAdicionar = new System.Windows.Forms.ToolStripButton();
            this.TSBtnGuardar = new System.Windows.Forms.ToolStripButton();
            this.TSBtnAnular = new System.Windows.Forms.ToolStripButton();
            this.TSBtnLimpiar = new System.Windows.Forms.ToolStripButton();
            this.TSBtnImprimir = new System.Windows.Forms.ToolStripButton();
            this.TSBtnSalir = new System.Windows.Forms.ToolStripButton();
            this.TxtDV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtExpedida = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTelefono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorPTerceros)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(53, 274);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Mail";
            // 
            // TxtMail
            // 
            this.TxtMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMail.Location = new System.Drawing.Point(178, 270);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(306, 22);
            this.TxtMail.TabIndex = 17;
            this.TxtMail.Tag = "Correo electrónico del tercero";
            this.TxtMail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtMail_KeyPress);
            this.TxtMail.Validating += new System.ComponentModel.CancelEventHandler(this.TxtMail_Validating);
            this.TxtMail.Validated += new System.EventHandler(this.TxtMail_Validated);
            // 
            // CboCiudad
            // 
            this.CboCiudad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CboCiudad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CboCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboCiudad.FormattingEnabled = true;
            this.CboCiudad.Location = new System.Drawing.Point(178, 243);
            this.CboCiudad.Name = "CboCiudad";
            this.CboCiudad.Size = new System.Drawing.Size(306, 24);
            this.CboCiudad.TabIndex = 13;
            this.CboCiudad.Tag = "Ciudad de residencia del tercero";
            this.CboCiudad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CboCiudad_KeyPress);
            this.CboCiudad.Validating += new System.ComponentModel.CancelEventHandler(this.CboCiudad_Validating);
            this.CboCiudad.Validated += new System.EventHandler(this.CboCiudad_Validated);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(53, 248);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Ciudad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(506, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Teléfono";
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTelefono.Location = new System.Drawing.Point(584, 245);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(147, 22);
            this.TxtTelefono.TabIndex = 15;
            this.TxtTelefono.Tag = "Número de teléfono del tercero";
            this.TxtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTelefono_KeyPress);
            this.TxtTelefono.Validating += new System.ComponentModel.CancelEventHandler(this.TxtTelefono_Validating);
            this.TxtTelefono.Validated += new System.EventHandler(this.TxtTelefono_Validated);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(53, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Dirección";
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDireccion.Location = new System.Drawing.Point(178, 218);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(553, 22);
            this.TxtDireccion.TabIndex = 11;
            this.TxtDireccion.Tag = "Dirección del tercero";
            this.TxtDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDireccion_KeyPress);
            this.TxtDireccion.Validating += new System.ComponentModel.CancelEventHandler(this.TxtDireccion_Validating);
            this.TxtDireccion.Validated += new System.EventHandler(this.TxtDireccion_Validated);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(53, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nombres";
            // 
            // TxtNombres
            // 
            this.TxtNombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombres.Location = new System.Drawing.Point(178, 192);
            this.TxtNombres.Name = "TxtNombres";
            this.TxtNombres.Size = new System.Drawing.Size(210, 22);
            this.TxtNombres.TabIndex = 9;
            this.TxtNombres.Tag = "Nombres";
            this.TxtNombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombres_KeyPress);
            this.TxtNombres.Validating += new System.ComponentModel.CancelEventHandler(this.TxtNombres_Validating);
            this.TxtNombres.Validated += new System.EventHandler(this.TxtNombres_Validated);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(427, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Segundo Apellido";
            // 
            // TxtApellido2
            // 
            this.TxtApellido2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtApellido2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtApellido2.Location = new System.Drawing.Point(551, 170);
            this.TxtApellido2.Name = "TxtApellido2";
            this.TxtApellido2.Size = new System.Drawing.Size(180, 22);
            this.TxtApellido2.TabIndex = 7;
            this.TxtApellido2.Tag = "Segundo Apellido";
            this.TxtApellido2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtApellido2_KeyPress);
            this.TxtApellido2.Validating += new System.ComponentModel.CancelEventHandler(this.TxtApellido2_Validating);
            this.TxtApellido2.Validated += new System.EventHandler(this.TxtApellido2_Validated);
            // 
            // lblApellido1
            // 
            this.lblApellido1.AutoSize = true;
            this.lblApellido1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido1.Location = new System.Drawing.Point(53, 170);
            this.lblApellido1.Name = "lblApellido1";
            this.lblApellido1.Size = new System.Drawing.Size(100, 16);
            this.lblApellido1.TabIndex = 4;
            this.lblApellido1.Text = "Primer Apellido";
            // 
            // CboTipoId
            // 
            this.CboTipoId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboTipoId.FormattingEnabled = true;
            this.CboTipoId.Location = new System.Drawing.Point(178, 109);
            this.CboTipoId.Name = "CboTipoId";
            this.CboTipoId.Size = new System.Drawing.Size(210, 24);
            this.CboTipoId.TabIndex = 1;
            this.CboTipoId.Tag = "Tipo de Identificación";
            this.CboTipoId.SelectedIndexChanged += new System.EventHandler(this.CboTipoId_SelectedIndexChanged);
            this.CboTipoId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CboTipoId_KeyPress);
            this.CboTipoId.Validating += new System.ComponentModel.CancelEventHandler(this.CboTipoId_Validating);
            this.CboTipoId.Validated += new System.EventHandler(this.CboTipoId_Validated);
            // 
            // TxtID
            // 
            this.TxtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtID.Location = new System.Drawing.Point(551, 111);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(180, 22);
            this.TxtID.TabIndex = 3;
            this.TxtID.Tag = "Número de Identificación";
            this.TxtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtID_KeyPress);
            this.TxtID.Leave += new System.EventHandler(this.TxtID_Leave);
            this.TxtID.Validating += new System.ComponentModel.CancelEventHandler(this.TxtID_Validating);
            this.TxtID.Validated += new System.EventHandler(this.TxtID_Validated);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(427, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Número de ID";
            // 
            // TxtApellido1
            // 
            this.TxtApellido1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtApellido1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtApellido1.Location = new System.Drawing.Point(178, 166);
            this.TxtApellido1.Name = "TxtApellido1";
            this.TxtApellido1.Size = new System.Drawing.Size(210, 22);
            this.TxtApellido1.TabIndex = 5;
            this.TxtApellido1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtApellido1_KeyPress);
            this.TxtApellido1.Validating += new System.ComponentModel.CancelEventHandler(this.TxtApellido1_Validating);
            this.TxtApellido1.Validated += new System.EventHandler(this.TxtApellido1_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de ID";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ChkPropietario);
            this.groupBox3.Controls.Add(this.ChkCliente);
            this.groupBox3.Controls.Add(this.ChkProveedor);
            this.groupBox3.Controls.Add(this.ChkEmpleado);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(555, 459);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(240, 111);
            this.groupBox3.TabIndex = 39;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Clasificación";
            // 
            // ChkPropietario
            // 
            this.ChkPropietario.AutoSize = true;
            this.ChkPropietario.Location = new System.Drawing.Point(19, 84);
            this.ChkPropietario.Name = "ChkPropietario";
            this.ChkPropietario.Size = new System.Drawing.Size(93, 20);
            this.ChkPropietario.TabIndex = 37;
            this.ChkPropietario.Text = "Propietario";
            this.ChkPropietario.UseVisualStyleBackColor = true;
            this.ChkPropietario.Validating += new System.ComponentModel.CancelEventHandler(this.ChkPropietario_Validating);
            this.ChkPropietario.Validated += new System.EventHandler(this.ChkPropietario_Validated);
            // 
            // ChkCliente
            // 
            this.ChkCliente.AutoSize = true;
            this.ChkCliente.Location = new System.Drawing.Point(19, 63);
            this.ChkCliente.Name = "ChkCliente";
            this.ChkCliente.Size = new System.Drawing.Size(68, 20);
            this.ChkCliente.TabIndex = 36;
            this.ChkCliente.Text = "Cliente";
            this.ChkCliente.UseVisualStyleBackColor = true;
            this.ChkCliente.Validating += new System.ComponentModel.CancelEventHandler(this.ChkCliente_Validating);
            this.ChkCliente.Validated += new System.EventHandler(this.ChkCliente_Validated);
            // 
            // ChkProveedor
            // 
            this.ChkProveedor.AutoSize = true;
            this.ChkProveedor.Location = new System.Drawing.Point(19, 40);
            this.ChkProveedor.Name = "ChkProveedor";
            this.ChkProveedor.Size = new System.Drawing.Size(91, 20);
            this.ChkProveedor.TabIndex = 35;
            this.ChkProveedor.Text = "Proveedor";
            this.ChkProveedor.UseVisualStyleBackColor = true;
            this.ChkProveedor.Validating += new System.ComponentModel.CancelEventHandler(this.ChkProveedor_Validating);
            this.ChkProveedor.Validated += new System.EventHandler(this.ChkProveedor_Validated);
            // 
            // ChkEmpleado
            // 
            this.ChkEmpleado.AutoSize = true;
            this.ChkEmpleado.Location = new System.Drawing.Point(19, 17);
            this.ChkEmpleado.Name = "ChkEmpleado";
            this.ChkEmpleado.Size = new System.Drawing.Size(90, 20);
            this.ChkEmpleado.TabIndex = 34;
            this.ChkEmpleado.Text = "Empleado";
            this.ChkEmpleado.UseVisualStyleBackColor = true;
            this.ChkEmpleado.Validating += new System.ComponentModel.CancelEventHandler(this.ChkEmpleado_Validating);
            this.ChkEmpleado.Validated += new System.EventHandler(this.ChkEmpleado_Validated);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.TxtSalario);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.TxtTelEmpresa);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.TxtEmpresa);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(47, 459);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(463, 101);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Información Laboral";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(26, 74);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 16);
            this.label15.TabIndex = 32;
            this.label15.Text = "Salario";
            // 
            // TxtSalario
            // 
            this.TxtSalario.Location = new System.Drawing.Point(115, 71);
            this.TxtSalario.Name = "TxtSalario";
            this.TxtSalario.Size = new System.Drawing.Size(306, 22);
            this.TxtSalario.TabIndex = 3;
            this.TxtSalario.Tag = "Salario";
            this.TxtSalario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtSalario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSalario_KeyPress);
            this.TxtSalario.Validating += new System.ComponentModel.CancelEventHandler(this.TxtSalario_Validating);
            this.TxtSalario.Validated += new System.EventHandler(this.TxtSalario_Validated);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(26, 48);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 16);
            this.label14.TabIndex = 30;
            this.label14.Text = "Teléfono";
            // 
            // TxtTelEmpresa
            // 
            this.TxtTelEmpresa.Location = new System.Drawing.Point(115, 45);
            this.TxtTelEmpresa.Name = "TxtTelEmpresa";
            this.TxtTelEmpresa.Size = new System.Drawing.Size(306, 22);
            this.TxtTelEmpresa.TabIndex = 31;
            this.TxtTelEmpresa.Tag = "Número de telefono de la empresa donde labora el tercero";
            this.TxtTelEmpresa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTelEmpresa_KeyPress);
            this.TxtTelEmpresa.Validating += new System.ComponentModel.CancelEventHandler(this.TxtTelEmpresa_Validating);
            this.TxtTelEmpresa.Validated += new System.EventHandler(this.TxtTelEmpresa_Validated);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(26, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 16);
            this.label13.TabIndex = 28;
            this.label13.Text = "Empresa";
            // 
            // TxtEmpresa
            // 
            this.TxtEmpresa.Location = new System.Drawing.Point(115, 19);
            this.TxtEmpresa.Name = "TxtEmpresa";
            this.TxtEmpresa.Size = new System.Drawing.Size(306, 22);
            this.TxtEmpresa.TabIndex = 29;
            this.TxtEmpresa.Tag = "Nombre de la empresa donde labora el tercero";
            this.TxtEmpresa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtEmpresa_KeyPress);
            this.TxtEmpresa.Validating += new System.ComponentModel.CancelEventHandler(this.TxtEmpresa_Validating);
            this.TxtEmpresa.Validated += new System.EventHandler(this.TxtEmpresa_Validated);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ChkNosAplicaRetencion);
            this.groupBox1.Controls.Add(this.ChkReteIVA);
            this.groupBox1.Controls.Add(this.ChkReteICA);
            this.groupBox1.Controls.Add(this.ChkRetencion);
            this.groupBox1.Controls.Add(this.CboClaseCont);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.CboRegimen);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.CboTipoPersona);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(47, 328);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(700, 109);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información Financiera";
            // 
            // ChkNosAplicaRetencion
            // 
            this.ChkNosAplicaRetencion.AutoSize = true;
            this.ChkNosAplicaRetencion.Location = new System.Drawing.Point(487, 84);
            this.ChkNosAplicaRetencion.Name = "ChkNosAplicaRetencion";
            this.ChkNosAplicaRetencion.Size = new System.Drawing.Size(157, 20);
            this.ChkNosAplicaRetencion.TabIndex = 27;
            this.ChkNosAplicaRetencion.Text = "Nos Aplica Retención";
            this.ChkNosAplicaRetencion.UseVisualStyleBackColor = true;
            this.ChkNosAplicaRetencion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ChkNosAplicaRetencion_KeyPress);
            this.ChkNosAplicaRetencion.Validating += new System.ComponentModel.CancelEventHandler(this.ChkNosAplicaRetencion_Validating);
            this.ChkNosAplicaRetencion.Validated += new System.EventHandler(this.ChkNosAplicaRetencion_Validated);
            // 
            // ChkReteIVA
            // 
            this.ChkReteIVA.AutoSize = true;
            this.ChkReteIVA.Location = new System.Drawing.Point(487, 61);
            this.ChkReteIVA.Name = "ChkReteIVA";
            this.ChkReteIVA.Size = new System.Drawing.Size(129, 20);
            this.ChkReteIVA.TabIndex = 26;
            this.ChkReteIVA.Text = "Sujeto a ReteIVA";
            this.ChkReteIVA.UseVisualStyleBackColor = true;
            this.ChkReteIVA.Validating += new System.ComponentModel.CancelEventHandler(this.ChkReteIVA_Validating);
            this.ChkReteIVA.Validated += new System.EventHandler(this.ChkReteIVA_Validated);
            // 
            // ChkReteICA
            // 
            this.ChkReteICA.AutoSize = true;
            this.ChkReteICA.Location = new System.Drawing.Point(487, 38);
            this.ChkReteICA.Name = "ChkReteICA";
            this.ChkReteICA.Size = new System.Drawing.Size(129, 20);
            this.ChkReteICA.TabIndex = 25;
            this.ChkReteICA.Text = "Sujeto a ReteICA";
            this.ChkReteICA.UseVisualStyleBackColor = true;
            this.ChkReteICA.Validating += new System.ComponentModel.CancelEventHandler(this.ChkReteICA_Validating);
            this.ChkReteICA.Validated += new System.EventHandler(this.ChkReteICA_Validated);
            // 
            // ChkRetencion
            // 
            this.ChkRetencion.AutoSize = true;
            this.ChkRetencion.Location = new System.Drawing.Point(487, 17);
            this.ChkRetencion.Name = "ChkRetencion";
            this.ChkRetencion.Size = new System.Drawing.Size(140, 20);
            this.ChkRetencion.TabIndex = 24;
            this.ChkRetencion.Text = "Sujeto a Retención";
            this.ChkRetencion.UseVisualStyleBackColor = true;
            this.ChkRetencion.Validating += new System.ComponentModel.CancelEventHandler(this.ChkRetencion_Validating);
            this.ChkRetencion.Validated += new System.EventHandler(this.ChkRetencion_Validated);
            // 
            // CboClaseCont
            // 
            this.CboClaseCont.FormattingEnabled = true;
            this.CboClaseCont.Location = new System.Drawing.Point(160, 77);
            this.CboClaseCont.Name = "CboClaseCont";
            this.CboClaseCont.Size = new System.Drawing.Size(261, 24);
            this.CboClaseCont.TabIndex = 23;
            this.CboClaseCont.Tag = "Clase de contribuyente del tercero";
            this.CboClaseCont.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CboClaseCont_KeyPress);
            this.CboClaseCont.Validating += new System.ComponentModel.CancelEventHandler(this.CboClaseCont_Validating);
            this.CboClaseCont.Validated += new System.EventHandler(this.CboClaseCont_Validated);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 80);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(135, 16);
            this.label12.TabIndex = 22;
            this.label12.Text = "Clase Constribuyente";
            // 
            // CboRegimen
            // 
            this.CboRegimen.FormattingEnabled = true;
            this.CboRegimen.Location = new System.Drawing.Point(160, 50);
            this.CboRegimen.Name = "CboRegimen";
            this.CboRegimen.Size = new System.Drawing.Size(261, 24);
            this.CboRegimen.TabIndex = 21;
            this.CboRegimen.Tag = "Regimen fiscal del tercero";
            this.CboRegimen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CboRegimen_KeyPress);
            this.CboRegimen.Validating += new System.ComponentModel.CancelEventHandler(this.CboRegimen_Validating);
            this.CboRegimen.Validated += new System.EventHandler(this.CboRegimen_Validated);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 53);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 16);
            this.label11.TabIndex = 20;
            this.label11.Text = "Régimen Fiscal";
            // 
            // CboTipoPersona
            // 
            this.CboTipoPersona.FormattingEnabled = true;
            this.CboTipoPersona.Location = new System.Drawing.Point(160, 23);
            this.CboTipoPersona.Name = "CboTipoPersona";
            this.CboTipoPersona.Size = new System.Drawing.Size(261, 24);
            this.CboTipoPersona.TabIndex = 19;
            this.CboTipoPersona.Tag = "Tipo de persona (Natural o Jurídica) del tercero";
            this.CboTipoPersona.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CboTipoPersona_KeyPress);
            this.CboTipoPersona.Validating += new System.ComponentModel.CancelEventHandler(this.CboTipoPersona_Validating);
            this.CboTipoPersona.Validated += new System.EventHandler(this.CboTipoPersona_Validated);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 16);
            this.label10.TabIndex = 18;
            this.label10.Text = "Tipo de Persona";
            // 
            // DGVTelefono
            // 
            this.DGVTelefono.AllowUserToAddRows = false;
            this.DGVTelefono.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Moccasin;
            this.DGVTelefono.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVTelefono.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVTelefono.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVTelefono.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.item,
            this.tipo_telefono,
            this.descripcion_tipo,
            this.no_telefono});
            this.DGVTelefono.Location = new System.Drawing.Point(859, 109);
            this.DGVTelefono.Name = "DGVTelefono";
            this.DGVTelefono.Size = new System.Drawing.Size(461, 145);
            this.DGVTelefono.TabIndex = 38;
            this.DGVTelefono.Validating += new System.ComponentModel.CancelEventHandler(this.DGVTelefono_Validating);
            this.DGVTelefono.Validated += new System.EventHandler(this.DGVTelefono_Validated);
            // 
            // item
            // 
            this.item.DataPropertyName = "item";
            this.item.HeaderText = "Item";
            this.item.Name = "item";
            this.item.Width = 60;
            // 
            // tipo_telefono
            // 
            this.tipo_telefono.DataPropertyName = "tipo_telefono";
            this.tipo_telefono.HeaderText = "Tipo";
            this.tipo_telefono.Name = "tipo_telefono";
            this.tipo_telefono.Width = 60;
            // 
            // descripcion_tipo
            // 
            this.descripcion_tipo.DataPropertyName = "descripcion_tipo";
            this.descripcion_tipo.HeaderText = "Descripción";
            this.descripcion_tipo.Name = "descripcion_tipo";
            this.descripcion_tipo.Width = 150;
            // 
            // no_telefono
            // 
            this.no_telefono.DataPropertyName = "no_telefono";
            this.no_telefono.HeaderText = "Número";
            this.no_telefono.Name = "no_telefono";
            this.no_telefono.Width = 120;
            // 
            // ErrorPTerceros
            // 
            this.ErrorPTerceros.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ErrorPTerceros.ContainerControl = this;
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
            this.toolStrip1.Size = new System.Drawing.Size(1250, 70);
            this.toolStrip1.TabIndex = 40;
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
            this.TSBtnAdicionar.Click += new System.EventHandler(this.TSBtnAdicionar_Click);
            // 
            // TSBtnGuardar
            // 
            this.TSBtnGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBtnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("TSBtnGuardar.Image")));
            this.TSBtnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBtnGuardar.Name = "TSBtnGuardar";
            this.TSBtnGuardar.Size = new System.Drawing.Size(52, 67);
            this.TSBtnGuardar.Text = "Guardar";
            this.TSBtnGuardar.Click += new System.EventHandler(this.TSBtnGuardar_Click);
            // 
            // TSBtnAnular
            // 
            this.TSBtnAnular.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBtnAnular.Image = ((System.Drawing.Image)(resources.GetObject("TSBtnAnular.Image")));
            this.TSBtnAnular.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBtnAnular.Name = "TSBtnAnular";
            this.TSBtnAnular.Size = new System.Drawing.Size(52, 67);
            this.TSBtnAnular.Text = "Anular";
            this.TSBtnAnular.Visible = false;
            // 
            // TSBtnLimpiar
            // 
            this.TSBtnLimpiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBtnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("TSBtnLimpiar.Image")));
            this.TSBtnLimpiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBtnLimpiar.Name = "TSBtnLimpiar";
            this.TSBtnLimpiar.Size = new System.Drawing.Size(52, 67);
            this.TSBtnLimpiar.Text = "Limpiar";
            this.TSBtnLimpiar.Click += new System.EventHandler(this.TSBtnLimpiar_Click);
            // 
            // TSBtnImprimir
            // 
            this.TSBtnImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBtnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("TSBtnImprimir.Image")));
            this.TSBtnImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBtnImprimir.Name = "TSBtnImprimir";
            this.TSBtnImprimir.Size = new System.Drawing.Size(52, 67);
            this.TSBtnImprimir.Text = "Imprimir";
            this.TSBtnImprimir.Visible = false;
            // 
            // TSBtnSalir
            // 
            this.TSBtnSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBtnSalir.Image = ((System.Drawing.Image)(resources.GetObject("TSBtnSalir.Image")));
            this.TSBtnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBtnSalir.Name = "TSBtnSalir";
            this.TSBtnSalir.Size = new System.Drawing.Size(52, 67);
            this.TSBtnSalir.Text = "Salir";
            this.TSBtnSalir.Click += new System.EventHandler(this.TSBtnSalir_Click);
            // 
            // TxtDV
            // 
            this.TxtDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDV.Location = new System.Drawing.Point(786, 112);
            this.TxtDV.Name = "TxtDV";
            this.TxtDV.Size = new System.Drawing.Size(29, 22);
            this.TxtDV.TabIndex = 42;
            this.TxtDV.Tag = "Dígito de Verificación";
            this.TxtDV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtDV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDV_KeyPress);
            this.TxtDV.Validating += new System.ComponentModel.CancelEventHandler(this.TxtDV_Validating);
            this.TxtDV.Validated += new System.EventHandler(this.TxtDV_Validated);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(753, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 16);
            this.label3.TabIndex = 41;
            this.label3.Text = "DV";
            // 
            // TxtExpedida
            // 
            this.TxtExpedida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtExpedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtExpedida.Location = new System.Drawing.Point(178, 139);
            this.TxtExpedida.Name = "TxtExpedida";
            this.TxtExpedida.Size = new System.Drawing.Size(210, 22);
            this.TxtExpedida.TabIndex = 44;
            this.TxtExpedida.Tag = "Lugar de expedición de Documento de Identidad";
            this.TxtExpedida.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtExpedida_KeyPress);
            this.TxtExpedida.Validating += new System.ComponentModel.CancelEventHandler(this.TxtExpedida_Validating);
            this.TxtExpedida.Validated += new System.EventHandler(this.TxtExpedida_Validated);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(54, 140);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(84, 16);
            this.label16.TabIndex = 43;
            this.label16.Text = "Expedida en";
            // 
            // FrmTerceros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 572);
            this.Controls.Add(this.TxtExpedida);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.TxtDV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.DGVTelefono);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TxtMail);
            this.Controls.Add(this.CboCiudad);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtTelefono);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtDireccion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtNombres);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtApellido2);
            this.Controls.Add(this.lblApellido1);
            this.Controls.Add(this.CboTipoId);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtApellido1);
            this.Controls.Add(this.label1);
            this.Name = "FrmTerceros";
            this.Tag = "Primer Apellido";
            this.Text = "Terceros";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmTerceros_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTelefono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorPTerceros)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtMail;
        private System.Windows.Forms.ComboBox CboCiudad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtNombres;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtApellido2;
        private System.Windows.Forms.Label lblApellido1;
        private System.Windows.Forms.ComboBox CboTipoId;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtApellido1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox ChkPropietario;
        private System.Windows.Forms.CheckBox ChkCliente;
        private System.Windows.Forms.CheckBox ChkProveedor;
        private System.Windows.Forms.CheckBox ChkEmpleado;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TxtSalario;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TxtTelEmpresa;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TxtEmpresa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ChkNosAplicaRetencion;
        private System.Windows.Forms.CheckBox ChkReteIVA;
        private System.Windows.Forms.CheckBox ChkReteICA;
        private System.Windows.Forms.CheckBox ChkRetencion;
        private System.Windows.Forms.ComboBox CboClaseCont;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox CboRegimen;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox CboTipoPersona;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView DGVTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn item;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion_tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn no_telefono;
        private System.Windows.Forms.ErrorProvider ErrorPTerceros;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TSBtnAdicionar;
        private System.Windows.Forms.ToolStripButton TSBtnGuardar;
        private System.Windows.Forms.ToolStripButton TSBtnAnular;
        private System.Windows.Forms.ToolStripButton TSBtnLimpiar;
        private System.Windows.Forms.ToolStripButton TSBtnImprimir;
        private System.Windows.Forms.ToolStripButton TSBtnSalir;
        private System.Windows.Forms.TextBox TxtExpedida;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox TxtDV;
        private System.Windows.Forms.Label label3;
    }
}