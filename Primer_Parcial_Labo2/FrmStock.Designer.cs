
namespace Primer_Parcial_Labo2
{
    partial class FrmStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStock));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_PetShop = new System.Windows.Forms.Label();
            this.btnAlta = new System.Windows.Forms.Button();
            this.btnBaja = new System.Windows.Forms.Button();
            this.btnModificacion = new System.Windows.Forms.Button();
            this.lblProductoInfo = new System.Windows.Forms.Label();
            this.txtProductoCodigo = new System.Windows.Forms.TextBox();
            this.lblProductoIngresarCod = new System.Windows.Forms.Label();
            this.btnProductoBuscar = new System.Windows.Forms.Button();
            this.cmbProductos = new System.Windows.Forms.ComboBox();
            this.lblProductoBuscar = new System.Windows.Forms.Label();
            this.txtProductoMarca = new System.Windows.Forms.TextBox();
            this.txtProductoDescripcion = new System.Windows.Forms.TextBox();
            this.txtProductoPrecio = new System.Windows.Forms.TextBox();
            this.txtProductoCantidad = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.lblAccion = new System.Windows.Forms.Label();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.lblSeleccione = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtProductoPeso = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Primer_Parcial_Labo2.Properties.Resources.pngegg_ico;
            this.pictureBox1.Location = new System.Drawing.Point(221, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_PetShop
            // 
            this.lbl_PetShop.AutoSize = true;
            this.lbl_PetShop.Font = new System.Drawing.Font("Segoe Script", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_PetShop.Location = new System.Drawing.Point(12, 9);
            this.lbl_PetShop.Name = "lbl_PetShop";
            this.lbl_PetShop.Size = new System.Drawing.Size(236, 67);
            this.lbl_PetShop.TabIndex = 8;
            this.lbl_PetShop.Text = "Pet Shop ";
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(18, 127);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(70, 23);
            this.btnAlta.TabIndex = 10;
            this.btnAlta.Text = "Alta";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // btnBaja
            // 
            this.btnBaja.Location = new System.Drawing.Point(104, 127);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(70, 23);
            this.btnBaja.TabIndex = 11;
            this.btnBaja.Text = "Baja";
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // btnModificacion
            // 
            this.btnModificacion.Location = new System.Drawing.Point(191, 127);
            this.btnModificacion.Name = "btnModificacion";
            this.btnModificacion.Size = new System.Drawing.Size(70, 23);
            this.btnModificacion.TabIndex = 12;
            this.btnModificacion.Text = "Modificar";
            this.btnModificacion.UseVisualStyleBackColor = true;
            this.btnModificacion.Click += new System.EventHandler(this.btnModificacion_Click);
            // 
            // lblProductoInfo
            // 
            this.lblProductoInfo.AutoSize = true;
            this.lblProductoInfo.Location = new System.Drawing.Point(13, 272);
            this.lblProductoInfo.Name = "lblProductoInfo";
            this.lblProductoInfo.Size = new System.Drawing.Size(28, 15);
            this.lblProductoInfo.TabIndex = 13;
            this.lblProductoInfo.Text = "Info";
            this.lblProductoInfo.Visible = false;
            // 
            // txtProductoCodigo
            // 
            this.txtProductoCodigo.Location = new System.Drawing.Point(18, 188);
            this.txtProductoCodigo.Name = "txtProductoCodigo";
            this.txtProductoCodigo.Size = new System.Drawing.Size(91, 23);
            this.txtProductoCodigo.TabIndex = 14;
            this.txtProductoCodigo.Text = "Codigo";
            this.txtProductoCodigo.Visible = false;
            // 
            // lblProductoIngresarCod
            // 
            this.lblProductoIngresarCod.AutoSize = true;
            this.lblProductoIngresarCod.Location = new System.Drawing.Point(18, 170);
            this.lblProductoIngresarCod.Name = "lblProductoIngresarCod";
            this.lblProductoIngresarCod.Size = new System.Drawing.Size(91, 15);
            this.lblProductoIngresarCod.TabIndex = 15;
            this.lblProductoIngresarCod.Text = "Ingresar Codigo";
            this.lblProductoIngresarCod.Visible = false;
            // 
            // btnProductoBuscar
            // 
            this.btnProductoBuscar.Location = new System.Drawing.Point(185, 188);
            this.btnProductoBuscar.Name = "btnProductoBuscar";
            this.btnProductoBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnProductoBuscar.TabIndex = 16;
            this.btnProductoBuscar.Text = "Buscar";
            this.btnProductoBuscar.UseVisualStyleBackColor = true;
            this.btnProductoBuscar.Visible = false;
            this.btnProductoBuscar.Click += new System.EventHandler(this.btnProductoBuscar_Click);
            // 
            // cmbProductos
            // 
            this.cmbProductos.FormattingEnabled = true;
            this.cmbProductos.Location = new System.Drawing.Point(14, 246);
            this.cmbProductos.Name = "cmbProductos";
            this.cmbProductos.Size = new System.Drawing.Size(247, 23);
            this.cmbProductos.TabIndex = 17;
            this.cmbProductos.Visible = false;
            this.cmbProductos.SelectedIndexChanged += new System.EventHandler(this.cmbProductos_SelectedIndexChanged);
            // 
            // lblProductoBuscar
            // 
            this.lblProductoBuscar.AutoSize = true;
            this.lblProductoBuscar.Location = new System.Drawing.Point(14, 228);
            this.lblProductoBuscar.Name = "lblProductoBuscar";
            this.lblProductoBuscar.Size = new System.Drawing.Size(94, 15);
            this.lblProductoBuscar.TabIndex = 18;
            this.lblProductoBuscar.Text = "Buscar producto";
            this.lblProductoBuscar.Visible = false;
            // 
            // txtProductoMarca
            // 
            this.txtProductoMarca.Location = new System.Drawing.Point(12, 360);
            this.txtProductoMarca.Name = "txtProductoMarca";
            this.txtProductoMarca.Size = new System.Drawing.Size(248, 23);
            this.txtProductoMarca.TabIndex = 19;
            this.txtProductoMarca.Text = "Marca";
            this.txtProductoMarca.Visible = false;
            // 
            // txtProductoDescripcion
            // 
            this.txtProductoDescripcion.Location = new System.Drawing.Point(11, 389);
            this.txtProductoDescripcion.Name = "txtProductoDescripcion";
            this.txtProductoDescripcion.Size = new System.Drawing.Size(248, 23);
            this.txtProductoDescripcion.TabIndex = 20;
            this.txtProductoDescripcion.Text = "Descripcion";
            this.txtProductoDescripcion.Visible = false;
            // 
            // txtProductoPrecio
            // 
            this.txtProductoPrecio.Location = new System.Drawing.Point(12, 418);
            this.txtProductoPrecio.Name = "txtProductoPrecio";
            this.txtProductoPrecio.Size = new System.Drawing.Size(248, 23);
            this.txtProductoPrecio.TabIndex = 21;
            this.txtProductoPrecio.Text = "Precio";
            this.txtProductoPrecio.Visible = false;
            // 
            // txtProductoCantidad
            // 
            this.txtProductoCantidad.Location = new System.Drawing.Point(11, 447);
            this.txtProductoCantidad.Name = "txtProductoCantidad";
            this.txtProductoCantidad.Size = new System.Drawing.Size(120, 23);
            this.txtProductoCantidad.TabIndex = 22;
            this.txtProductoCantidad.Text = "Canidad";
            this.txtProductoCantidad.Visible = false;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(185, 493);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 23;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Visible = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // lblAccion
            // 
            this.lblAccion.AutoSize = true;
            this.lblAccion.Location = new System.Drawing.Point(13, 501);
            this.lblAccion.Name = "lblAccion";
            this.lblAccion.Size = new System.Drawing.Size(44, 15);
            this.lblAccion.TabIndex = 24;
            this.lblAccion.Text = "Accion";
            this.lblAccion.Visible = false;
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Location = new System.Drawing.Point(18, 76);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(108, 15);
            this.lblBienvenida.TabIndex = 25;
            this.lblBienvenida.Text = "Bienvenido usuario";
            // 
            // lblSeleccione
            // 
            this.lblSeleccione.AutoSize = true;
            this.lblSeleccione.Location = new System.Drawing.Point(18, 109);
            this.lblSeleccione.Name = "lblSeleccione";
            this.lblSeleccione.Size = new System.Drawing.Size(129, 15);
            this.lblSeleccione.TabIndex = 26;
            this.lblSeleccione.Text = "Seleccione una opcion:";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(186, 526);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 27;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtProductoPeso
            // 
            this.txtProductoPeso.Location = new System.Drawing.Point(141, 447);
            this.txtProductoPeso.Name = "txtProductoPeso";
            this.txtProductoPeso.Size = new System.Drawing.Size(120, 23);
            this.txtProductoPeso.TabIndex = 28;
            this.txtProductoPeso.Text = "Peso";
            this.txtProductoPeso.Visible = false;
            // 
            // FrmStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(284, 561);
            this.Controls.Add(this.txtProductoPeso);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblSeleccione);
            this.Controls.Add(this.lblBienvenida);
            this.Controls.Add(this.lblAccion);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.txtProductoCantidad);
            this.Controls.Add(this.txtProductoPrecio);
            this.Controls.Add(this.txtProductoDescripcion);
            this.Controls.Add(this.txtProductoMarca);
            this.Controls.Add(this.lblProductoBuscar);
            this.Controls.Add(this.cmbProductos);
            this.Controls.Add(this.btnProductoBuscar);
            this.Controls.Add(this.lblProductoIngresarCod);
            this.Controls.Add(this.txtProductoCodigo);
            this.Controls.Add(this.lblProductoInfo);
            this.Controls.Add(this.btnModificacion);
            this.Controls.Add(this.btnBaja);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_PetShop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmStock";
            this.Load += new System.EventHandler(this.FrmStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_PetShop;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Button btnModificacion;
        private System.Windows.Forms.Label lblProductoInfo;
        private System.Windows.Forms.TextBox txtProductoCodigo;
        private System.Windows.Forms.Label lblProductoIngresarCod;
        private System.Windows.Forms.Button btnProductoBuscar;
        private System.Windows.Forms.ComboBox cmbProductos;
        private System.Windows.Forms.Label lblProductoBuscar;
        private System.Windows.Forms.TextBox txtProductoMarca;
        private System.Windows.Forms.TextBox txtProductoDescripcion;
        private System.Windows.Forms.TextBox txtProductoPrecio;
        private System.Windows.Forms.TextBox txtProductoCantidad;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label lblAccion;
        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.Label lblSeleccione;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtProductoPeso;
    }
}