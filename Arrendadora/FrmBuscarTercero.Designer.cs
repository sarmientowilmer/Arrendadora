namespace Arrendadora
{
    partial class FrmBuscarTercero
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBuscarTercero));
            this.TxtApellido1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNombres = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtApellido2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DGVDatos = new System.Windows.Forms.DataGridView();
            this.tipo_aux = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_aux = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_aux = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnSeleccionar = new System.Windows.Forms.Button();
            this.BtnCrear = new System.Windows.Forms.Button();
            this.CHKInquilino = new System.Windows.Forms.CheckBox();
            this.CHKPropietario = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtApellido1
            // 
            this.TxtApellido1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtApellido1.Location = new System.Drawing.Point(205, 42);
            this.TxtApellido1.Name = "TxtApellido1";
            this.TxtApellido1.Size = new System.Drawing.Size(586, 22);
            this.TxtApellido1.TabIndex = 3;
            this.TxtApellido1.TextChanged += new System.EventHandler(this.TxtApellido1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Primer Apellido o Razón Social";
            // 
            // TxtNombres
            // 
            this.TxtNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombres.Location = new System.Drawing.Point(514, 70);
            this.TxtNombres.Name = "TxtNombres";
            this.TxtNombres.Size = new System.Drawing.Size(277, 22);
            this.TxtNombres.TabIndex = 9;
            this.TxtNombres.TextChanged += new System.EventHandler(this.TxtNombres_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(437, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nombres";
            // 
            // TxtApellido2
            // 
            this.TxtApellido2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtApellido2.Location = new System.Drawing.Point(205, 70);
            this.TxtApellido2.Name = "TxtApellido2";
            this.TxtApellido2.Size = new System.Drawing.Size(225, 22);
            this.TxtApellido2.TabIndex = 7;
            this.TxtApellido2.TextChanged += new System.EventHandler(this.TxtApellido2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Segundo Apellido";
            // 
            // DGVDatos
            // 
            this.DGVDatos.AllowUserToAddRows = false;
            this.DGVDatos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(211)))), ((int)(((byte)(29)))));
            this.DGVDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.DGVDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.DGVDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tipo_aux,
            this.id_aux,
            this.dv,
            this.nombre_aux});
            this.DGVDatos.Location = new System.Drawing.Point(8, 98);
            this.DGVDatos.Name = "DGVDatos";
            this.DGVDatos.ReadOnly = true;
            this.DGVDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVDatos.Size = new System.Drawing.Size(826, 364);
            this.DGVDatos.TabIndex = 10;
            this.DGVDatos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVDatos_CellContentDoubleClick);
            // 
            // tipo_aux
            // 
            this.tipo_aux.DataPropertyName = "tipo_aux";
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.LightBlue;
            this.tipo_aux.DefaultCellStyle = dataGridViewCellStyle9;
            this.tipo_aux.HeaderText = "Tipo ID";
            this.tipo_aux.Name = "tipo_aux";
            this.tipo_aux.ReadOnly = true;
            // 
            // id_aux
            // 
            this.id_aux.DataPropertyName = "id_aux";
            this.id_aux.HeaderText = "Número";
            this.id_aux.Name = "id_aux";
            this.id_aux.ReadOnly = true;
            // 
            // dv
            // 
            this.dv.DataPropertyName = "dv";
            this.dv.HeaderText = "DV";
            this.dv.Name = "dv";
            this.dv.ReadOnly = true;
            this.dv.Width = 70;
            // 
            // nombre_aux
            // 
            this.nombre_aux.DataPropertyName = "nombre_aux";
            this.nombre_aux.HeaderText = "Nombre";
            this.nombre_aux.Name = "nombre_aux";
            this.nombre_aux.ReadOnly = true;
            this.nombre_aux.Width = 400;
            // 
            // BtnSeleccionar
            // 
            this.BtnSeleccionar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSeleccionar.BackgroundImage")));
            this.BtnSeleccionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnSeleccionar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnSeleccionar.Location = new System.Drawing.Point(840, 114);
            this.BtnSeleccionar.Name = "BtnSeleccionar";
            this.BtnSeleccionar.Size = new System.Drawing.Size(77, 61);
            this.BtnSeleccionar.TabIndex = 11;
            this.BtnSeleccionar.Text = "Seleccionar";
            this.BtnSeleccionar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnSeleccionar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.BtnSeleccionar.UseVisualStyleBackColor = true;
            this.BtnSeleccionar.Click += new System.EventHandler(this.BtnSeleccionar_Click);
            // 
            // BtnCrear
            // 
            this.BtnCrear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnCrear.BackgroundImage")));
            this.BtnCrear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnCrear.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnCrear.Location = new System.Drawing.Point(840, 202);
            this.BtnCrear.Name = "BtnCrear";
            this.BtnCrear.Size = new System.Drawing.Size(77, 61);
            this.BtnCrear.TabIndex = 12;
            this.BtnCrear.Text = "Crear";
            this.BtnCrear.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnCrear.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.BtnCrear.UseVisualStyleBackColor = true;
            this.BtnCrear.Click += new System.EventHandler(this.BtnCrear_Click);
            // 
            // CHKInquilino
            // 
            this.CHKInquilino.AutoSize = true;
            this.CHKInquilino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHKInquilino.Location = new System.Drawing.Point(814, 42);
            this.CHKInquilino.Name = "CHKInquilino";
            this.CHKInquilino.Size = new System.Drawing.Size(68, 20);
            this.CHKInquilino.TabIndex = 13;
            this.CHKInquilino.Text = "Cliente";
            this.CHKInquilino.UseVisualStyleBackColor = true;
            this.CHKInquilino.CheckedChanged += new System.EventHandler(this.CHKInquilino_CheckedChanged);
            // 
            // CHKPropietario
            // 
            this.CHKPropietario.AutoSize = true;
            this.CHKPropietario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHKPropietario.Location = new System.Drawing.Point(814, 68);
            this.CHKPropietario.Name = "CHKPropietario";
            this.CHKPropietario.Size = new System.Drawing.Size(93, 20);
            this.CHKPropietario.TabIndex = 14;
            this.CHKPropietario.Text = "Propietario";
            this.CHKPropietario.UseVisualStyleBackColor = true;
            this.CHKPropietario.CheckedChanged += new System.EventHandler(this.CHKPropietario_CheckedChanged);
            // 
            // FrmBuscarTercero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 474);
            this.Controls.Add(this.CHKPropietario);
            this.Controls.Add(this.CHKInquilino);
            this.Controls.Add(this.BtnCrear);
            this.Controls.Add(this.BtnSeleccionar);
            this.Controls.Add(this.DGVDatos);
            this.Controls.Add(this.TxtNombres);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtApellido2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtApellido1);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmBuscarTercero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBuscarTercero";
            this.Load += new System.EventHandler(this.FrmBuscarTercero_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtApellido1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtNombres;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtApellido2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGVDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_aux;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_aux;
        private System.Windows.Forms.DataGridViewTextBoxColumn dv;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_aux;
        private System.Windows.Forms.Button BtnSeleccionar;
        private System.Windows.Forms.Button BtnCrear;
        private System.Windows.Forms.CheckBox CHKInquilino;
        private System.Windows.Forms.CheckBox CHKPropietario;
    }
}