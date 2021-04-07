namespace Arrendadora
{
    partial class FormControlCambios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormControlCambios));
            this.LblFecha = new System.Windows.Forms.Label();
            this.DTPFecha = new System.Windows.Forms.DateTimePicker();
            this.DGVDetalle = new System.Windows.Forms.DataGridView();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valornvo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autorizo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.campo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autoriza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Registro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnReporteDiario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFecha.Location = new System.Drawing.Point(60, 37);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(46, 16);
            this.LblFecha.TabIndex = 0;
            this.LblFecha.Text = "Fecha";
            // 
            // DTPFecha
            // 
            this.DTPFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPFecha.Location = new System.Drawing.Point(112, 37);
            this.DTPFecha.Name = "DTPFecha";
            this.DTPFecha.Size = new System.Drawing.Size(260, 22);
            this.DTPFecha.TabIndex = 1;
            this.DTPFecha.ValueChanged += new System.EventHandler(this.DTPFecha_ValueChanged);
            // 
            // DGVDetalle
            // 
            this.DGVDetalle.AllowUserToAddRows = false;
            this.DGVDetalle.AllowUserToDeleteRows = false;
            this.DGVDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVDetalle.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVDetalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha,
            this.Hora,
            this.valorold,
            this.valornvo,
            this.autorizo,
            this.usuario,
            this.tabla,
            this.campo,
            this.motivo,
            this.empresa,
            this.Autoriza,
            this.Registro});
            this.DGVDetalle.Location = new System.Drawing.Point(12, 80);
            this.DGVDetalle.Name = "DGVDetalle";
            this.DGVDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVDetalle.Size = new System.Drawing.Size(934, 358);
            this.DGVDetalle.TabIndex = 2;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "fecha";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.Width = 90;
            // 
            // Hora
            // 
            this.Hora.DataPropertyName = "hora";
            dataGridViewCellStyle2.Format = "T";
            dataGridViewCellStyle2.NullValue = null;
            this.Hora.DefaultCellStyle = dataGridViewCellStyle2;
            this.Hora.HeaderText = "Hora";
            this.Hora.Name = "Hora";
            this.Hora.Width = 90;
            // 
            // valorold
            // 
            this.valorold.DataPropertyName = "valorold";
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.valorold.DefaultCellStyle = dataGridViewCellStyle3;
            this.valorold.HeaderText = "Valor Anterior";
            this.valorold.MinimumWidth = 100;
            this.valorold.Name = "valorold";
            this.valorold.Width = 210;
            // 
            // valornvo
            // 
            this.valornvo.DataPropertyName = "valornvo";
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.valornvo.DefaultCellStyle = dataGridViewCellStyle4;
            this.valornvo.HeaderText = "Valor Nuevo";
            this.valornvo.MinimumWidth = 100;
            this.valornvo.Name = "valornvo";
            this.valornvo.Width = 210;
            // 
            // autorizo
            // 
            this.autorizo.DataPropertyName = "autorizo";
            this.autorizo.HeaderText = "Autorizó";
            this.autorizo.Name = "autorizo";
            this.autorizo.Visible = false;
            // 
            // usuario
            // 
            this.usuario.DataPropertyName = "usuario";
            this.usuario.HeaderText = "Usuario";
            this.usuario.Name = "usuario";
            this.usuario.Visible = false;
            // 
            // tabla
            // 
            this.tabla.DataPropertyName = "tabla";
            this.tabla.HeaderText = "Tabla o Proceso";
            this.tabla.Name = "tabla";
            // 
            // campo
            // 
            this.campo.DataPropertyName = "campo";
            this.campo.HeaderText = "Campo";
            this.campo.Name = "campo";
            // 
            // motivo
            // 
            this.motivo.DataPropertyName = "motivo";
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.motivo.DefaultCellStyle = dataGridViewCellStyle5;
            this.motivo.HeaderText = "Motivo";
            this.motivo.MinimumWidth = 100;
            this.motivo.Name = "motivo";
            this.motivo.Width = 200;
            // 
            // empresa
            // 
            this.empresa.DataPropertyName = "cod_empresa";
            this.empresa.HeaderText = "Empresa";
            this.empresa.Name = "empresa";
            this.empresa.Visible = false;
            // 
            // Autoriza
            // 
            this.Autoriza.DataPropertyName = "Autoriza";
            this.Autoriza.HeaderText = "Autoriza";
            this.Autoriza.MinimumWidth = 100;
            this.Autoriza.Name = "Autoriza";
            this.Autoriza.Width = 150;
            // 
            // Registro
            // 
            this.Registro.DataPropertyName = "Registro";
            this.Registro.HeaderText = "Registró";
            this.Registro.MinimumWidth = 100;
            this.Registro.Name = "Registro";
            this.Registro.Width = 150;
            // 
            // BtnReporteDiario
            // 
            this.BtnReporteDiario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnReporteDiario.BackgroundImage")));
            this.BtnReporteDiario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnReporteDiario.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnReporteDiario.Location = new System.Drawing.Point(403, 17);
            this.BtnReporteDiario.Name = "BtnReporteDiario";
            this.BtnReporteDiario.Size = new System.Drawing.Size(54, 57);
            this.BtnReporteDiario.TabIndex = 18;
            this.BtnReporteDiario.Text = "Imprimir";
            this.BtnReporteDiario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnReporteDiario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnReporteDiario.UseVisualStyleBackColor = true;
            this.BtnReporteDiario.Click += new System.EventHandler(this.BtnReporteDiario_Click);
            // 
            // FormControlCambios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 450);
            this.Controls.Add(this.BtnReporteDiario);
            this.Controls.Add(this.DGVDetalle);
            this.Controls.Add(this.DTPFecha);
            this.Controls.Add(this.LblFecha);
            this.Name = "FormControlCambios";
            this.Text = "Consulta de Cambios con Autorización a  BD";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormControlCambios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.DateTimePicker DTPFecha;
        private System.Windows.Forms.DataGridView DGVDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorold;
        private System.Windows.Forms.DataGridViewTextBoxColumn valornvo;
        private System.Windows.Forms.DataGridViewTextBoxColumn autorizo;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn tabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn campo;
        private System.Windows.Forms.DataGridViewTextBoxColumn motivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn empresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autoriza;
        private System.Windows.Forms.DataGridViewTextBoxColumn Registro;
        private System.Windows.Forms.Button BtnReporteDiario;
    }
}