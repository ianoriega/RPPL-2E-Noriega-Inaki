
namespace Primer_Parcial_Labo2
{
    partial class FrmEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmpleados));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_PetShop = new System.Windows.Forms.Label();
            this.lblSeleccione = new System.Windows.Forms.Label();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.btnModificacion = new System.Windows.Forms.Button();
            this.btnBaja = new System.Windows.Forms.Button();
            this.btnAlta = new System.Windows.Forms.Button();
            this.cmbEmpleados = new System.Windows.Forms.ComboBox();
            this.lblSeleccionarEmpleado = new System.Windows.Forms.Label();
            this.lblInfoEmpleado = new System.Windows.Forms.Label();
            this.lblAccion = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.txtEmpleadoNombre = new System.Windows.Forms.TextBox();
            this.txtEmpleadoApellido = new System.Windows.Forms.TextBox();
            this.txtEmpleadoDni = new System.Windows.Forms.TextBox();
            this.txtEmpleadoUsuario = new System.Windows.Forms.TextBox();
            this.txtEmpleadoPassword = new System.Windows.Forms.TextBox();
            this.btnCrearAdmin = new System.Windows.Forms.Button();
            this.btnCrearVendedor = new System.Windows.Forms.Button();
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
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_PetShop
            // 
            this.lbl_PetShop.AutoSize = true;
            this.lbl_PetShop.Font = new System.Drawing.Font("Segoe Script", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_PetShop.Location = new System.Drawing.Point(12, 9);
            this.lbl_PetShop.Name = "lbl_PetShop";
            this.lbl_PetShop.Size = new System.Drawing.Size(236, 67);
            this.lbl_PetShop.TabIndex = 10;
            this.lbl_PetShop.Text = "Pet Shop ";
            // 
            // lblSeleccione
            // 
            this.lblSeleccione.AutoSize = true;
            this.lblSeleccione.Location = new System.Drawing.Point(20, 105);
            this.lblSeleccione.Name = "lblSeleccione";
            this.lblSeleccione.Size = new System.Drawing.Size(129, 15);
            this.lblSeleccione.TabIndex = 31;
            this.lblSeleccione.Text = "Seleccione una opcion:";
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Location = new System.Drawing.Point(20, 72);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(108, 15);
            this.lblBienvenida.TabIndex = 30;
            this.lblBienvenida.Text = "Bienvenido usuario";
            // 
            // btnModificacion
            // 
            this.btnModificacion.Location = new System.Drawing.Point(193, 123);
            this.btnModificacion.Name = "btnModificacion";
            this.btnModificacion.Size = new System.Drawing.Size(70, 23);
            this.btnModificacion.TabIndex = 29;
            this.btnModificacion.Text = "Modificar";
            this.btnModificacion.UseVisualStyleBackColor = true;
            this.btnModificacion.Click += new System.EventHandler(this.btnModificacion_Click);
            // 
            // btnBaja
            // 
            this.btnBaja.Location = new System.Drawing.Point(106, 123);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(70, 23);
            this.btnBaja.TabIndex = 28;
            this.btnBaja.Text = "Baja";
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(20, 123);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(70, 23);
            this.btnAlta.TabIndex = 27;
            this.btnAlta.Text = "Alta";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // cmbEmpleados
            // 
            this.cmbEmpleados.FormattingEnabled = true;
            this.cmbEmpleados.Location = new System.Drawing.Point(20, 191);
            this.cmbEmpleados.Name = "cmbEmpleados";
            this.cmbEmpleados.Size = new System.Drawing.Size(121, 23);
            this.cmbEmpleados.TabIndex = 32;
            this.cmbEmpleados.Visible = false;
            this.cmbEmpleados.SelectedIndexChanged += new System.EventHandler(this.cmbEmpleados_SelectedIndexChanged);
            // 
            // lblSeleccionarEmpleado
            // 
            this.lblSeleccionarEmpleado.AutoSize = true;
            this.lblSeleccionarEmpleado.Location = new System.Drawing.Point(17, 165);
            this.lblSeleccionarEmpleado.Name = "lblSeleccionarEmpleado";
            this.lblSeleccionarEmpleado.Size = new System.Drawing.Size(122, 15);
            this.lblSeleccionarEmpleado.TabIndex = 33;
            this.lblSeleccionarEmpleado.Text = "Seleccione empleado:";
            this.lblSeleccionarEmpleado.Visible = false;
            // 
            // lblInfoEmpleado
            // 
            this.lblInfoEmpleado.AutoSize = true;
            this.lblInfoEmpleado.Location = new System.Drawing.Point(20, 226);
            this.lblInfoEmpleado.Name = "lblInfoEmpleado";
            this.lblInfoEmpleado.Size = new System.Drawing.Size(28, 15);
            this.lblInfoEmpleado.TabIndex = 35;
            this.lblInfoEmpleado.Text = "Info";
            this.lblInfoEmpleado.Visible = false;
            // 
            // lblAccion
            // 
            this.lblAccion.AutoSize = true;
            this.lblAccion.Location = new System.Drawing.Point(12, 525);
            this.lblAccion.Name = "lblAccion";
            this.lblAccion.Size = new System.Drawing.Size(44, 15);
            this.lblAccion.TabIndex = 41;
            this.lblAccion.Text = "Accion";
            this.lblAccion.Visible = false;
            this.lblAccion.Click += new System.EventHandler(this.lblAccion_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(193, 521);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 42;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Visible = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // txtEmpleadoNombre
            // 
            this.txtEmpleadoNombre.Location = new System.Drawing.Point(17, 350);
            this.txtEmpleadoNombre.Name = "txtEmpleadoNombre";
            this.txtEmpleadoNombre.Size = new System.Drawing.Size(194, 23);
            this.txtEmpleadoNombre.TabIndex = 43;
            this.txtEmpleadoNombre.Text = "Nombre";
            this.txtEmpleadoNombre.Visible = false;
            // 
            // txtEmpleadoApellido
            // 
            this.txtEmpleadoApellido.Location = new System.Drawing.Point(18, 379);
            this.txtEmpleadoApellido.Name = "txtEmpleadoApellido";
            this.txtEmpleadoApellido.Size = new System.Drawing.Size(194, 23);
            this.txtEmpleadoApellido.TabIndex = 44;
            this.txtEmpleadoApellido.Text = "Apellido";
            this.txtEmpleadoApellido.Visible = false;
            // 
            // txtEmpleadoDni
            // 
            this.txtEmpleadoDni.Location = new System.Drawing.Point(18, 408);
            this.txtEmpleadoDni.Name = "txtEmpleadoDni";
            this.txtEmpleadoDni.Size = new System.Drawing.Size(194, 23);
            this.txtEmpleadoDni.TabIndex = 45;
            this.txtEmpleadoDni.Text = "Dni";
            this.txtEmpleadoDni.Visible = false;
            // 
            // txtEmpleadoUsuario
            // 
            this.txtEmpleadoUsuario.Location = new System.Drawing.Point(18, 437);
            this.txtEmpleadoUsuario.Name = "txtEmpleadoUsuario";
            this.txtEmpleadoUsuario.Size = new System.Drawing.Size(194, 23);
            this.txtEmpleadoUsuario.TabIndex = 46;
            this.txtEmpleadoUsuario.Text = "Usuario";
            this.txtEmpleadoUsuario.Visible = false;
            // 
            // txtEmpleadoPassword
            // 
            this.txtEmpleadoPassword.Location = new System.Drawing.Point(18, 466);
            this.txtEmpleadoPassword.Name = "txtEmpleadoPassword";
            this.txtEmpleadoPassword.Size = new System.Drawing.Size(194, 23);
            this.txtEmpleadoPassword.TabIndex = 47;
            this.txtEmpleadoPassword.Text = "Password";
            this.txtEmpleadoPassword.Visible = false;
            // 
            // btnCrearAdmin
            // 
            this.btnCrearAdmin.Location = new System.Drawing.Point(18, 321);
            this.btnCrearAdmin.Name = "btnCrearAdmin";
            this.btnCrearAdmin.Size = new System.Drawing.Size(94, 23);
            this.btnCrearAdmin.TabIndex = 48;
            this.btnCrearAdmin.Text = "Administrador";
            this.btnCrearAdmin.UseVisualStyleBackColor = true;
            this.btnCrearAdmin.Visible = false;
            this.btnCrearAdmin.Click += new System.EventHandler(this.btnCrearAdmin_Click);
            // 
            // btnCrearVendedor
            // 
            this.btnCrearVendedor.Location = new System.Drawing.Point(118, 321);
            this.btnCrearVendedor.Name = "btnCrearVendedor";
            this.btnCrearVendedor.Size = new System.Drawing.Size(94, 23);
            this.btnCrearVendedor.TabIndex = 49;
            this.btnCrearVendedor.Text = "Vendedor";
            this.btnCrearVendedor.UseVisualStyleBackColor = true;
            this.btnCrearVendedor.Visible = false;
            this.btnCrearVendedor.Click += new System.EventHandler(this.btnCrearVendedor_Click);
            // 
            // FrmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(284, 561);
            this.Controls.Add(this.btnCrearVendedor);
            this.Controls.Add(this.btnCrearAdmin);
            this.Controls.Add(this.txtEmpleadoPassword);
            this.Controls.Add(this.txtEmpleadoUsuario);
            this.Controls.Add(this.txtEmpleadoDni);
            this.Controls.Add(this.txtEmpleadoApellido);
            this.Controls.Add(this.txtEmpleadoNombre);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.lblAccion);
            this.Controls.Add(this.lblInfoEmpleado);
            this.Controls.Add(this.lblSeleccionarEmpleado);
            this.Controls.Add(this.cmbEmpleados);
            this.Controls.Add(this.lblSeleccione);
            this.Controls.Add(this.lblBienvenida);
            this.Controls.Add(this.btnModificacion);
            this.Controls.Add(this.btnBaja);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_PetShop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEmpleados";
            this.Load += new System.EventHandler(this.FrmEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_PetShop;
        private System.Windows.Forms.Label lblSeleccione;
        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.Button btnModificacion;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.ComboBox cmbEmpleados;
        private System.Windows.Forms.Label lblSeleccionarEmpleado;
        private System.Windows.Forms.Label lblInfoEmpleado;
        private System.Windows.Forms.Label lblAccion;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.TextBox txtEmpleadoNombre;
        private System.Windows.Forms.TextBox txtEmpleadoApellido;
        private System.Windows.Forms.TextBox txtEmpleadoDni;
        private System.Windows.Forms.TextBox txtEmpleadoUsuario;
        private System.Windows.Forms.TextBox txtEmpleadoPassword;
        private System.Windows.Forms.Button btnCrearAdmin;
        private System.Windows.Forms.Button btnCrearVendedor;
    }
}