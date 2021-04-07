namespace ConsultasInmuebles
{
    partial class FrmConsultaInmuebles
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaInmuebles));
            this.label1 = new System.Windows.Forms.Label();
            this.CboTipoInmueble = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CboValorDesde = new System.Windows.Forms.ComboBox();
            this.CboValorHasta = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CboCiudad = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CboBarrio = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CboDestino = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DGVDatos = new System.Windows.Forms.DataGridView();
            this.cod_inmueble = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_barrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.canonarrendar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorventa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estrato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metraje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destino_inmueble = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_inmueble = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.BtnSlide = new System.Windows.Forms.PictureBox();
            this.PanBtnBuscar = new System.Windows.Forms.Panel();
            this.PictureBox5 = new System.Windows.Forms.PictureBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelConsulta = new System.Windows.Forms.Panel();
            this.PBLogo = new System.Windows.Forms.PictureBox();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDatos)).BeginInit();
            this.MenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSlide)).BeginInit();
            this.PanBtnBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox5)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de Inmueble";
            // 
            // CboTipoInmueble
            // 
            this.CboTipoInmueble.BackColor = System.Drawing.Color.DarkGray;
            this.CboTipoInmueble.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboTipoInmueble.FormattingEnabled = true;
            this.CboTipoInmueble.Location = new System.Drawing.Point(58, 17);
            this.CboTipoInmueble.Name = "CboTipoInmueble";
            this.CboTipoInmueble.Size = new System.Drawing.Size(207, 24);
            this.CboTipoInmueble.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(107, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Desde";
            // 
            // CboValorDesde
            // 
            this.CboValorDesde.BackColor = System.Drawing.Color.DarkGray;
            this.CboValorDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboValorDesde.FormattingEnabled = true;
            this.CboValorDesde.Location = new System.Drawing.Point(58, 19);
            this.CboValorDesde.Name = "CboValorDesde";
            this.CboValorDesde.Size = new System.Drawing.Size(207, 24);
            this.CboValorDesde.TabIndex = 4;
            this.CboValorDesde.SelectedValueChanged += new System.EventHandler(this.CboValorDesde_SelectedValueChanged);
            // 
            // CboValorHasta
            // 
            this.CboValorHasta.BackColor = System.Drawing.Color.DarkGray;
            this.CboValorHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboValorHasta.FormattingEnabled = true;
            this.CboValorHasta.Location = new System.Drawing.Point(58, 62);
            this.CboValorHasta.Name = "CboValorHasta";
            this.CboValorHasta.Size = new System.Drawing.Size(207, 24);
            this.CboValorHasta.TabIndex = 6;
            this.CboValorHasta.SelectedIndexChanged += new System.EventHandler(this.CboValorHasta_SelectedIndexChanged);
            this.CboValorHasta.SelectedValueChanged += new System.EventHandler(this.CboValorHasta_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Hasta";
            // 
            // CboCiudad
            // 
            this.CboCiudad.BackColor = System.Drawing.Color.DarkGray;
            this.CboCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboCiudad.FormattingEnabled = true;
            this.CboCiudad.Location = new System.Drawing.Point(58, 22);
            this.CboCiudad.Name = "CboCiudad";
            this.CboCiudad.Size = new System.Drawing.Size(204, 24);
            this.CboCiudad.TabIndex = 8;
            this.CboCiudad.SelectedIndexChanged += new System.EventHandler(this.CboCiudad_SelectedIndexChanged);
            this.CboCiudad.SelectedValueChanged += new System.EventHandler(this.CboCiudad_SelectedValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(55, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ciudad";
            // 
            // CboBarrio
            // 
            this.CboBarrio.BackColor = System.Drawing.Color.DarkGray;
            this.CboBarrio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboBarrio.FormattingEnabled = true;
            this.CboBarrio.Location = new System.Drawing.Point(58, 65);
            this.CboBarrio.Name = "CboBarrio";
            this.CboBarrio.Size = new System.Drawing.Size(204, 24);
            this.CboBarrio.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(55, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Barrio";
            // 
            // CboDestino
            // 
            this.CboDestino.BackColor = System.Drawing.Color.DarkGray;
            this.CboDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboDestino.FormattingEnabled = true;
            this.CboDestino.Location = new System.Drawing.Point(58, 17);
            this.CboDestino.Name = "CboDestino";
            this.CboDestino.Size = new System.Drawing.Size(207, 24);
            this.CboDestino.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(55, -2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Destino";
            // 
            // DGVDatos
            // 
            this.DGVDatos.AllowUserToAddRows = false;
            this.DGVDatos.AllowUserToDeleteRows = false;
            this.DGVDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVDatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.DGVDatos.BackgroundColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_inmueble,
            this.nombre_tipo,
            this.direccion,
            this.descripcion,
            this.nombre_ciudad,
            this.nombre_barrio,
            this.canonarrendar,
            this.valorventa,
            this.estrato,
            this.metraje,
            this.destino_inmueble,
            this.tipo_inmueble});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVDatos.DefaultCellStyle = dataGridViewCellStyle9;
            this.DGVDatos.EnableHeadersVisualStyles = false;
            this.DGVDatos.Location = new System.Drawing.Point(7, 3);
            this.DGVDatos.Name = "DGVDatos";
            this.DGVDatos.ReadOnly = true;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVDatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.DGVDatos.RowHeadersVisible = false;
            this.DGVDatos.RowHeadersWidth = 15;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            this.DGVDatos.RowsDefaultCellStyle = dataGridViewCellStyle11;
            this.DGVDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVDatos.Size = new System.Drawing.Size(689, 632);
            this.DGVDatos.TabIndex = 15;
            this.DGVDatos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DGVDatos_CellFormatting_1);
            this.DGVDatos.DoubleClick += new System.EventHandler(this.DGVDatos_DoubleClick);
            // 
            // cod_inmueble
            // 
            this.cod_inmueble.DataPropertyName = "cod_inmueble";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cod_inmueble.DefaultCellStyle = dataGridViewCellStyle2;
            this.cod_inmueble.HeaderText = "Inmueble";
            this.cod_inmueble.Name = "cod_inmueble";
            this.cod_inmueble.ReadOnly = true;
            this.cod_inmueble.Width = 62;
            // 
            // nombre_tipo
            // 
            this.nombre_tipo.DataPropertyName = "nombre_tipo";
            this.nombre_tipo.HeaderText = "Tipo";
            this.nombre_tipo.Name = "nombre_tipo";
            this.nombre_tipo.ReadOnly = true;
            this.nombre_tipo.Width = 120;
            // 
            // direccion
            // 
            this.direccion.DataPropertyName = "direccion";
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.direccion.DefaultCellStyle = dataGridViewCellStyle3;
            this.direccion.HeaderText = "Dirección";
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            this.direccion.Width = 180;
            // 
            // descripcion
            // 
            this.descripcion.DataPropertyName = "descripcion";
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.descripcion.DefaultCellStyle = dataGridViewCellStyle4;
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Width = 280;
            // 
            // nombre_ciudad
            // 
            this.nombre_ciudad.DataPropertyName = "nombre_ciudad";
            this.nombre_ciudad.HeaderText = "Ciudad";
            this.nombre_ciudad.Name = "nombre_ciudad";
            this.nombre_ciudad.ReadOnly = true;
            this.nombre_ciudad.Width = 110;
            // 
            // nombre_barrio
            // 
            this.nombre_barrio.DataPropertyName = "nombre_barrio";
            this.nombre_barrio.HeaderText = "Barrio";
            this.nombre_barrio.Name = "nombre_barrio";
            this.nombre_barrio.ReadOnly = true;
            // 
            // canonarrendar
            // 
            this.canonarrendar.DataPropertyName = "canonarrendar";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N0";
            this.canonarrendar.DefaultCellStyle = dataGridViewCellStyle5;
            this.canonarrendar.HeaderText = "Valor";
            this.canonarrendar.Name = "canonarrendar";
            this.canonarrendar.ReadOnly = true;
            // 
            // valorventa
            // 
            this.valorventa.DataPropertyName = "valorventa";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N0";
            this.valorventa.DefaultCellStyle = dataGridViewCellStyle6;
            this.valorventa.HeaderText = "Valor Venta";
            this.valorventa.Name = "valorventa";
            this.valorventa.ReadOnly = true;
            // 
            // estrato
            // 
            this.estrato.DataPropertyName = "estrato";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.estrato.DefaultCellStyle = dataGridViewCellStyle7;
            this.estrato.HeaderText = "Estrato";
            this.estrato.Name = "estrato";
            this.estrato.ReadOnly = true;
            this.estrato.Width = 62;
            // 
            // metraje
            // 
            this.metraje.DataPropertyName = "metraje";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.metraje.DefaultCellStyle = dataGridViewCellStyle8;
            this.metraje.HeaderText = "Área";
            this.metraje.Name = "metraje";
            this.metraje.ReadOnly = true;
            this.metraje.Width = 55;
            // 
            // destino_inmueble
            // 
            this.destino_inmueble.DataPropertyName = "destino_inmueble";
            this.destino_inmueble.HeaderText = "destino_inmueble";
            this.destino_inmueble.Name = "destino_inmueble";
            this.destino_inmueble.ReadOnly = true;
            this.destino_inmueble.Visible = false;
            // 
            // tipo_inmueble
            // 
            this.tipo_inmueble.DataPropertyName = "tipo_inmueble";
            this.tipo_inmueble.HeaderText = "tipo_inmueble";
            this.tipo_inmueble.Name = "tipo_inmueble";
            this.tipo_inmueble.ReadOnly = true;
            this.tipo_inmueble.Visible = false;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.Font = new System.Drawing.Font("Bernard MT Condensed", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(966, 48);
            this.label8.TabIndex = 17;
            this.label8.Text = "ARRENDAMIENTOS PARADA ALARCÓN";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.Font = new System.Drawing.Font("Bernard MT Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(22, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(966, 22);
            this.label9.TabIndex = 18;
            this.label9.Text = "Consulta de Inmuebles Disponibles";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MenuVertical
            // 
            this.MenuVertical.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.MenuVertical.BackColor = System.Drawing.Color.Gray;
            this.MenuVertical.Controls.Add(this.BtnSlide);
            this.MenuVertical.Controls.Add(this.PanBtnBuscar);
            this.MenuVertical.Controls.Add(this.panel5);
            this.MenuVertical.Controls.Add(this.panel4);
            this.MenuVertical.Controls.Add(this.panel3);
            this.MenuVertical.Controls.Add(this.panel2);
            this.MenuVertical.Location = new System.Drawing.Point(12, 103);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(281, 638);
            this.MenuVertical.TabIndex = 19;
            // 
            // BtnSlide
            // 
            this.BtnSlide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSlide.Image = global::ConsultasInmuebles.Properties.Resources.menunegro256;
            this.BtnSlide.Location = new System.Drawing.Point(242, 3);
            this.BtnSlide.Name = "BtnSlide";
            this.BtnSlide.Size = new System.Drawing.Size(32, 26);
            this.BtnSlide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnSlide.TabIndex = 16;
            this.BtnSlide.TabStop = false;
            this.BtnSlide.Click += new System.EventHandler(this.BtnSlide_Click);
            // 
            // PanBtnBuscar
            // 
            this.PanBtnBuscar.BackColor = System.Drawing.Color.DarkGray;
            this.PanBtnBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanBtnBuscar.Controls.Add(this.PictureBox5);
            this.PanBtnBuscar.Controls.Add(this.Label10);
            this.PanBtnBuscar.Location = new System.Drawing.Point(6, 387);
            this.PanBtnBuscar.Name = "PanBtnBuscar";
            this.PanBtnBuscar.Size = new System.Drawing.Size(268, 66);
            this.PanBtnBuscar.TabIndex = 19;
            this.PanBtnBuscar.Click += new System.EventHandler(this.PanBtnBuscar_Click);
            this.PanBtnBuscar.Paint += new System.Windows.Forms.PaintEventHandler(this.PanBtnBuscar_Paint);
            this.PanBtnBuscar.MouseEnter += new System.EventHandler(this.PanBtnBuscar_MouseEnter);
            this.PanBtnBuscar.MouseLeave += new System.EventHandler(this.PanBtnBuscar_MouseLeave);
            // 
            // PictureBox5
            // 
            this.PictureBox5.Image = global::ConsultasInmuebles.Properties.Resources.buscar_casanegro128;
            this.PictureBox5.Location = new System.Drawing.Point(3, 3);
            this.PictureBox5.Name = "PictureBox5";
            this.PictureBox5.Size = new System.Drawing.Size(46, 56);
            this.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox5.TabIndex = 15;
            this.PictureBox5.TabStop = false;
            this.PictureBox5.Click += new System.EventHandler(this.PictureBox5_Click);
            this.PictureBox5.MouseEnter += new System.EventHandler(this.PictureBox5_MouseEnter);
            this.PictureBox5.MouseLeave += new System.EventHandler(this.PictureBox5_MouseLeave);
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.Location = new System.Drawing.Point(113, 22);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(61, 18);
            this.Label10.TabIndex = 7;
            this.Label10.Text = "Buscar";
            this.Label10.Click += new System.EventHandler(this.Label10_Click);
            this.Label10.MouseEnter += new System.EventHandler(this.Label10_MouseEnter);
            this.Label10.MouseLeave += new System.EventHandler(this.Label10_MouseLeave);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkGray;
            this.panel5.Controls.Add(this.pictureBox4);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.CboCiudad);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.CboBarrio);
            this.panel5.Location = new System.Drawing.Point(3, 261);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(268, 94);
            this.panel5.TabIndex = 18;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::ConsultasInmuebles.Properties.Resources.mapabarrionegro128;
            this.pictureBox4.Location = new System.Drawing.Point(6, 22);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(46, 56);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkGray;
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.CboValorHasta);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.CboValorDesde);
            this.panel4.Location = new System.Drawing.Point(3, 161);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(268, 94);
            this.panel4.TabIndex = 17;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ConsultasInmuebles.Properties.Resources.precio_casanegro128;
            this.pictureBox3.Location = new System.Drawing.Point(3, 29);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(46, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.CboTipoInmueble);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(3, 107);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(268, 48);
            this.panel3.TabIndex = 16;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ConsultasInmuebles.Properties.Resources.parametrosbusquedanegro128;
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.CboDestino);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(3, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(268, 48);
            this.panel2.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ConsultasInmuebles.Properties.Resources.lista_verificacionnegra128;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // PanelConsulta
            // 
            this.PanelConsulta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelConsulta.BackColor = System.Drawing.Color.LightGray;
            this.PanelConsulta.Controls.Add(this.DGVDatos);
            this.PanelConsulta.Location = new System.Drawing.Point(292, 103);
            this.PanelConsulta.Name = "PanelConsulta";
            this.PanelConsulta.Size = new System.Drawing.Size(699, 638);
            this.PanelConsulta.TabIndex = 20;
            // 
            // PBLogo
            // 
            this.PBLogo.Image = global::ConsultasInmuebles.Properties.Resources.NUEVO_LOGO;
            this.PBLogo.Location = new System.Drawing.Point(12, 3);
            this.PBLogo.Name = "PBLogo";
            this.PBLogo.Size = new System.Drawing.Size(158, 81);
            this.PBLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBLogo.TabIndex = 16;
            this.PBLogo.TabStop = false;
            this.PBLogo.Click += new System.EventHandler(this.PBLogo_Click);
            this.PBLogo.DoubleClick += new System.EventHandler(this.PBLogo_DoubleClick);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::ConsultasInmuebles.Properties.Resources.no_disponible16;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 40;
            // 
            // FrmConsultaInmuebles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 753);
            this.ControlBox = false;
            this.Controls.Add(this.PanelConsulta);
            this.Controls.Add(this.MenuVertical);
            this.Controls.Add(this.PBLogo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmConsultaInmuebles";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmConsultaInmuebles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVDatos)).EndInit();
            this.MenuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnSlide)).EndInit();
            this.PanBtnBuscar.ResumeLayout(false);
            this.PanBtnBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox5)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelConsulta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PBLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CboTipoInmueble;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CboValorDesde;
        private System.Windows.Forms.ComboBox CboValorHasta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CboCiudad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CboBarrio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CboDestino;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridView DGVDatos;
        private System.Windows.Forms.PictureBox PBLogo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel PanBtnBuscar;
        private System.Windows.Forms.PictureBox PictureBox5;
        private System.Windows.Forms.Label Label10;
        private System.Windows.Forms.PictureBox BtnSlide;
        private System.Windows.Forms.Panel PanelConsulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_inmueble;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_ciudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_barrio;
        private System.Windows.Forms.DataGridViewTextBoxColumn canonarrendar;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorventa;
        private System.Windows.Forms.DataGridViewTextBoxColumn estrato;
        private System.Windows.Forms.DataGridViewTextBoxColumn metraje;
        private System.Windows.Forms.DataGridViewTextBoxColumn destino_inmueble;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_inmueble;
    }
}

