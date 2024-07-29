namespace Arrendadora
{
    partial class FrmGenerarFotosRedes
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
            this.label1 = new System.Windows.Forms.Label();
            this.DGVDetalleInv = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DGVImagenes = new System.Windows.Forms.DataGridView();
            this.TxtImagen = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.PicFoto2 = new System.Windows.Forms.PictureBox();
            this.PicFoto1 = new System.Windows.Forms.PictureBox();
            this.TxtInmueble = new System.Windows.Forms.TextBox();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.imagenes_cod_inmueble = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagenes_cod_inv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagenes_numero_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagenes_numero_imagen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagenes_descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagenes_Nombre_imagen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.di_cod_inmueble = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.di_cod_inv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.di_numero_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.di_descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.di_nombre_imagen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.di_orden_ver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDetalleInv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVImagenes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicFoto2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicFoto1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inmuebles";
            // 
            // DGVDetalleInv
            // 
            this.DGVDetalleInv.AllowUserToAddRows = false;
            this.DGVDetalleInv.AllowUserToDeleteRows = false;
            this.DGVDetalleInv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVDetalleInv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.di_cod_inmueble,
            this.di_cod_inv,
            this.di_numero_cod,
            this.di_descripcion,
            this.di_nombre_imagen,
            this.di_orden_ver});
            this.DGVDetalleInv.Location = new System.Drawing.Point(12, 96);
            this.DGVDetalleInv.Name = "DGVDetalleInv";
            this.DGVDetalleInv.RowHeadersVisible = false;
            this.DGVDetalleInv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVDetalleInv.Size = new System.Drawing.Size(490, 278);
            this.DGVDetalleInv.TabIndex = 2;
            this.DGVDetalleInv.SelectionChanged += new System.EventHandler(this.DGVDetalleInv_SelectionChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Detalle Inventario";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 377);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Imagenes";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // DGVImagenes
            // 
            this.DGVImagenes.AllowUserToAddRows = false;
            this.DGVImagenes.AllowUserToDeleteRows = false;
            this.DGVImagenes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DGVImagenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVImagenes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imagenes_cod_inmueble,
            this.imagenes_cod_inv,
            this.imagenes_numero_cod,
            this.imagenes_numero_imagen,
            this.imagenes_descripcion,
            this.imagenes_Nombre_imagen});
            this.DGVImagenes.Location = new System.Drawing.Point(15, 393);
            this.DGVImagenes.Name = "DGVImagenes";
            this.DGVImagenes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVImagenes.Size = new System.Drawing.Size(487, 181);
            this.DGVImagenes.TabIndex = 5;
            this.DGVImagenes.SelectionChanged += new System.EventHandler(this.DGVImagenes_SelectionChanged);
            // 
            // TxtImagen
            // 
            this.TxtImagen.Location = new System.Drawing.Point(508, 25);
            this.TxtImagen.Name = "TxtImagen";
            this.TxtImagen.Size = new System.Drawing.Size(393, 20);
            this.TxtImagen.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(917, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 35);
            this.button1.TabIndex = 9;
            this.button1.Text = "Generar Foto Redes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PicFoto2
            // 
            this.PicFoto2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PicFoto2.Location = new System.Drawing.Point(508, 317);
            this.PicFoto2.Name = "PicFoto2";
            this.PicFoto2.Size = new System.Drawing.Size(476, 257);
            this.PicFoto2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicFoto2.TabIndex = 8;
            this.PicFoto2.TabStop = false;
            // 
            // PicFoto1
            // 
            this.PicFoto1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PicFoto1.Location = new System.Drawing.Point(508, 51);
            this.PicFoto1.Name = "PicFoto1";
            this.PicFoto1.Size = new System.Drawing.Size(476, 260);
            this.PicFoto1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicFoto1.TabIndex = 7;
            this.PicFoto1.TabStop = false;
            // 
            // TxtInmueble
            // 
            this.TxtInmueble.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtInmueble.Location = new System.Drawing.Point(87, 22);
            this.TxtInmueble.Name = "TxtInmueble";
            this.TxtInmueble.Size = new System.Drawing.Size(114, 22);
            this.TxtInmueble.TabIndex = 10;
            this.TxtInmueble.TextChanged += new System.EventHandler(this.TxtInmueble_TextChanged);
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDireccion.Location = new System.Drawing.Point(87, 50);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(415, 22);
            this.TxtDireccion.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Dirección";
            // 
            // imagenes_cod_inmueble
            // 
            this.imagenes_cod_inmueble.DataPropertyName = "cod_inmueble";
            this.imagenes_cod_inmueble.HeaderText = "Inmueble";
            this.imagenes_cod_inmueble.Name = "imagenes_cod_inmueble";
            this.imagenes_cod_inmueble.Visible = false;
            // 
            // imagenes_cod_inv
            // 
            this.imagenes_cod_inv.DataPropertyName = "cod_inv";
            this.imagenes_cod_inv.HeaderText = "Cod inv";
            this.imagenes_cod_inv.Name = "imagenes_cod_inv";
            this.imagenes_cod_inv.Visible = false;
            // 
            // imagenes_numero_cod
            // 
            this.imagenes_numero_cod.DataPropertyName = "numero_cod";
            this.imagenes_numero_cod.HeaderText = "Numero";
            this.imagenes_numero_cod.Name = "imagenes_numero_cod";
            this.imagenes_numero_cod.Visible = false;
            // 
            // imagenes_numero_imagen
            // 
            this.imagenes_numero_imagen.DataPropertyName = "numero_imagen";
            this.imagenes_numero_imagen.HeaderText = "num Imagen";
            this.imagenes_numero_imagen.Name = "imagenes_numero_imagen";
            this.imagenes_numero_imagen.Visible = false;
            // 
            // imagenes_descripcion
            // 
            this.imagenes_descripcion.DataPropertyName = "descripcion";
            this.imagenes_descripcion.HeaderText = "Descripción";
            this.imagenes_descripcion.Name = "imagenes_descripcion";
            this.imagenes_descripcion.Width = 150;
            // 
            // imagenes_Nombre_imagen
            // 
            this.imagenes_Nombre_imagen.DataPropertyName = "nombre_imagen";
            this.imagenes_Nombre_imagen.HeaderText = "Dirección Imagen";
            this.imagenes_Nombre_imagen.Name = "imagenes_Nombre_imagen";
            this.imagenes_Nombre_imagen.Width = 250;
            // 
            // di_cod_inmueble
            // 
            this.di_cod_inmueble.DataPropertyName = "cod_inmueble";
            this.di_cod_inmueble.HeaderText = "Inmueble";
            this.di_cod_inmueble.Name = "di_cod_inmueble";
            this.di_cod_inmueble.Visible = false;
            // 
            // di_cod_inv
            // 
            this.di_cod_inv.DataPropertyName = "cod_inv";
            this.di_cod_inv.HeaderText = "cod_inv";
            this.di_cod_inv.Name = "di_cod_inv";
            this.di_cod_inv.Visible = false;
            // 
            // di_numero_cod
            // 
            this.di_numero_cod.DataPropertyName = "numero_cod";
            this.di_numero_cod.HeaderText = "numero";
            this.di_numero_cod.Name = "di_numero_cod";
            this.di_numero_cod.Visible = false;
            // 
            // di_descripcion
            // 
            this.di_descripcion.DataPropertyName = "descripcion_cod";
            this.di_descripcion.HeaderText = "Descripción";
            this.di_descripcion.Name = "di_descripcion";
            this.di_descripcion.Width = 250;
            // 
            // di_nombre_imagen
            // 
            this.di_nombre_imagen.DataPropertyName = "nombre_imagen";
            this.di_nombre_imagen.HeaderText = "Dirección Imagen";
            this.di_nombre_imagen.Name = "di_nombre_imagen";
            this.di_nombre_imagen.Width = 250;
            // 
            // di_orden_ver
            // 
            this.di_orden_ver.DataPropertyName = "orden_ver";
            this.di_orden_ver.HeaderText = "orden_ver";
            this.di_orden_ver.Name = "di_orden_ver";
            this.di_orden_ver.Visible = false;
            // 
            // FrmGenerarFotosRedes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 577);
            this.Controls.Add(this.TxtDireccion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtInmueble);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PicFoto2);
            this.Controls.Add(this.PicFoto1);
            this.Controls.Add(this.TxtImagen);
            this.Controls.Add(this.DGVImagenes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DGVDetalleInv);
            this.Controls.Add(this.label1);
            this.Name = "FrmGenerarFotosRedes";
            this.Text = "Generar Fotos para redes Sociales";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmGenerarFotosRedes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVDetalleInv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVImagenes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicFoto2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicFoto1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGVDetalleInv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DGVImagenes;
        private System.Windows.Forms.TextBox TxtImagen;
        private System.Windows.Forms.PictureBox PicFoto1;
        private System.Windows.Forms.PictureBox PicFoto2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TxtInmueble;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn imagenes_cod_inmueble;
        private System.Windows.Forms.DataGridViewTextBoxColumn imagenes_cod_inv;
        private System.Windows.Forms.DataGridViewTextBoxColumn imagenes_numero_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn imagenes_numero_imagen;
        private System.Windows.Forms.DataGridViewTextBoxColumn imagenes_descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn imagenes_Nombre_imagen;
        private System.Windows.Forms.DataGridViewTextBoxColumn di_cod_inmueble;
        private System.Windows.Forms.DataGridViewTextBoxColumn di_cod_inv;
        private System.Windows.Forms.DataGridViewTextBoxColumn di_numero_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn di_descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn di_nombre_imagen;
        private System.Windows.Forms.DataGridViewTextBoxColumn di_orden_ver;
    }
}