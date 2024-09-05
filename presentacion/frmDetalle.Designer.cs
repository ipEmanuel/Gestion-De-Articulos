namespace presentacion
{
    partial class frmDetalle
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
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblTextoCodigo = new System.Windows.Forms.Label();
            this.lblTextoNombre = new System.Windows.Forms.Label();
            this.lblTextoDescripcion = new System.Windows.Forms.Label();
            this.lblTextoPrecio = new System.Windows.Forms.Label();
            this.lblTextoMarca = new System.Windows.Forms.Label();
            this.lblTextoCategoria = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pbxArticulo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(24, 54);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Codigo";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(24, 94);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(24, 134);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(24, 174);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 4;
            this.lblPrecio.Text = "Precio";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(24, 214);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 5;
            this.lblMarca.Text = "Marca";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(24, 254);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria.TabIndex = 6;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblTextoCodigo
            // 
            this.lblTextoCodigo.AutoSize = true;
            this.lblTextoCodigo.Location = new System.Drawing.Point(119, 54);
            this.lblTextoCodigo.Name = "lblTextoCodigo";
            this.lblTextoCodigo.Size = new System.Drawing.Size(0, 13);
            this.lblTextoCodigo.TabIndex = 7;
            // 
            // lblTextoNombre
            // 
            this.lblTextoNombre.AutoSize = true;
            this.lblTextoNombre.Location = new System.Drawing.Point(119, 94);
            this.lblTextoNombre.Name = "lblTextoNombre";
            this.lblTextoNombre.Size = new System.Drawing.Size(0, 13);
            this.lblTextoNombre.TabIndex = 8;
            // 
            // lblTextoDescripcion
            // 
            this.lblTextoDescripcion.AutoSize = true;
            this.lblTextoDescripcion.Location = new System.Drawing.Point(119, 134);
            this.lblTextoDescripcion.Name = "lblTextoDescripcion";
            this.lblTextoDescripcion.Size = new System.Drawing.Size(0, 13);
            this.lblTextoDescripcion.TabIndex = 9;
            // 
            // lblTextoPrecio
            // 
            this.lblTextoPrecio.AutoSize = true;
            this.lblTextoPrecio.Location = new System.Drawing.Point(119, 174);
            this.lblTextoPrecio.Name = "lblTextoPrecio";
            this.lblTextoPrecio.Size = new System.Drawing.Size(0, 13);
            this.lblTextoPrecio.TabIndex = 11;
            // 
            // lblTextoMarca
            // 
            this.lblTextoMarca.AutoSize = true;
            this.lblTextoMarca.Location = new System.Drawing.Point(119, 214);
            this.lblTextoMarca.Name = "lblTextoMarca";
            this.lblTextoMarca.Size = new System.Drawing.Size(0, 13);
            this.lblTextoMarca.TabIndex = 12;
            // 
            // lblTextoCategoria
            // 
            this.lblTextoCategoria.AutoSize = true;
            this.lblTextoCategoria.Location = new System.Drawing.Point(119, 254);
            this.lblTextoCategoria.Name = "lblTextoCategoria";
            this.lblTextoCategoria.Size = new System.Drawing.Size(0, 13);
            this.lblTextoCategoria.TabIndex = 13;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(362, 322);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 14;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pbxArticulo
            // 
            this.pbxArticulo.Location = new System.Drawing.Point(300, 12);
            this.pbxArticulo.Name = "pbxArticulo";
            this.pbxArticulo.Size = new System.Drawing.Size(206, 295);
            this.pbxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxArticulo.TabIndex = 15;
            this.pbxArticulo.TabStop = false;
            // 
            // frmDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 357);
            this.Controls.Add(this.pbxArticulo);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblTextoCategoria);
            this.Controls.Add(this.lblTextoMarca);
            this.Controls.Add(this.lblTextoPrecio);
            this.Controls.Add(this.lblTextoDescripcion);
            this.Controls.Add(this.lblTextoNombre);
            this.Controls.Add(this.lblTextoCodigo);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCodigo);
            this.Name = "frmDetalle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDetalle";
            this.Load += new System.EventHandler(this.frmDetalle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblTextoCodigo;
        private System.Windows.Forms.Label lblTextoNombre;
        private System.Windows.Forms.Label lblTextoDescripcion;
        private System.Windows.Forms.Label lblTextoPrecio;
        private System.Windows.Forms.Label lblTextoMarca;
        private System.Windows.Forms.Label lblTextoCategoria;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.PictureBox pbxArticulo;
    }
}