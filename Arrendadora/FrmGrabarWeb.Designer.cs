namespace Arrendadora
{
    partial class FrmGrabarWeb
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
            this.DGVDatos = new System.Windows.Forms.DataGridView();
            this.BtnTransferir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtCodInmueble = new System.Windows.Forms.TextBox();
            this.BtnGrabarInmueble = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVDatos
            // 
            this.DGVDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVDatos.Location = new System.Drawing.Point(12, 87);
            this.DGVDatos.Name = "DGVDatos";
            this.DGVDatos.Size = new System.Drawing.Size(872, 256);
            this.DGVDatos.TabIndex = 0;
            // 
            // BtnTransferir
            // 
            this.BtnTransferir.Location = new System.Drawing.Point(34, 30);
            this.BtnTransferir.Name = "BtnTransferir";
            this.BtnTransferir.Size = new System.Drawing.Size(128, 33);
            this.BtnTransferir.TabIndex = 1;
            this.BtnTransferir.Text = "Transferir Información";
            this.BtnTransferir.UseVisualStyleBackColor = true;
            this.BtnTransferir.Click += new System.EventHandler(this.BtnTransferir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // TxtCodInmueble
            // 
            this.TxtCodInmueble.Location = new System.Drawing.Point(452, 37);
            this.TxtCodInmueble.Name = "TxtCodInmueble";
            this.TxtCodInmueble.Size = new System.Drawing.Size(100, 20);
            this.TxtCodInmueble.TabIndex = 3;
            // 
            // BtnGrabarInmueble
            // 
            this.BtnGrabarInmueble.Location = new System.Drawing.Point(602, 35);
            this.BtnGrabarInmueble.Name = "BtnGrabarInmueble";
            this.BtnGrabarInmueble.Size = new System.Drawing.Size(132, 23);
            this.BtnGrabarInmueble.TabIndex = 4;
            this.BtnGrabarInmueble.Text = "Grabar Datos Inmueble";
            this.BtnGrabarInmueble.UseVisualStyleBackColor = true;
            this.BtnGrabarInmueble.Click += new System.EventHandler(this.BtnGrabarInmueble_Click);
            // 
            // FrmGrabarWeb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 355);
            this.Controls.Add(this.BtnGrabarInmueble);
            this.Controls.Add(this.TxtCodInmueble);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnTransferir);
            this.Controls.Add(this.DGVDatos);
            this.Name = "FrmGrabarWeb";
            this.Text = "Transferir información a WEB";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmGrabarWeb_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVDatos;
        private System.Windows.Forms.Button BtnTransferir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtCodInmueble;
        private System.Windows.Forms.Button BtnGrabarInmueble;
    }
}