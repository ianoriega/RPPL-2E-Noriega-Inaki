
namespace Primer_Parcial_Labo2
{
    partial class Frm_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Menu));
            this.lbl_Bienvenida = new System.Windows.Forms.Label();
            this.lbl_Nivel = new System.Windows.Forms.Label();
            this.lbl_PetShop = new System.Windows.Forms.Label();
            this.btn_Venta = new System.Windows.Forms.Button();
            this.btn_Stock = new System.Windows.Forms.Button();
            this.btn_Empleados = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAdministrarVentas = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblUsuarioContra = new System.Windows.Forms.Label();
            this.btnLogear = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnLoguearVendedor = new System.Windows.Forms.Button();
            this.btnDarkMode = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Bienvenida
            // 
            this.lbl_Bienvenida.AutoSize = true;
            this.lbl_Bienvenida.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Bienvenida.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Bienvenida.ForeColor = System.Drawing.Color.Black;
            this.lbl_Bienvenida.Location = new System.Drawing.Point(39, 9);
            this.lbl_Bienvenida.Name = "lbl_Bienvenida";
            this.lbl_Bienvenida.Size = new System.Drawing.Size(218, 21);
            this.lbl_Bienvenida.TabIndex = 0;
            this.lbl_Bienvenida.Text = "Bienvenido al sistema Usuario";
            // 
            // lbl_Nivel
            // 
            this.lbl_Nivel.AutoSize = true;
            this.lbl_Nivel.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Nivel.ForeColor = System.Drawing.Color.Black;
            this.lbl_Nivel.Location = new System.Drawing.Point(39, 62);
            this.lbl_Nivel.Name = "lbl_Nivel";
            this.lbl_Nivel.Size = new System.Drawing.Size(122, 15);
            this.lbl_Nivel.TabIndex = 1;
            this.lbl_Nivel.Text = "Nivel de acceso: Nivel";
            // 
            // lbl_PetShop
            // 
            this.lbl_PetShop.AutoSize = true;
            this.lbl_PetShop.BackColor = System.Drawing.Color.Transparent;
            this.lbl_PetShop.Font = new System.Drawing.Font("Segoe Script", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_PetShop.ForeColor = System.Drawing.Color.Black;
            this.lbl_PetShop.Location = new System.Drawing.Point(21, 76);
            this.lbl_PetShop.Name = "lbl_PetShop";
            this.lbl_PetShop.Size = new System.Drawing.Size(236, 67);
            this.lbl_PetShop.TabIndex = 2;
            this.lbl_PetShop.Text = "Pet Shop ";
            // 
            // btn_Venta
            // 
            this.btn_Venta.Location = new System.Drawing.Point(40, 279);
            this.btn_Venta.Name = "btn_Venta";
            this.btn_Venta.Size = new System.Drawing.Size(200, 23);
            this.btn_Venta.TabIndex = 3;
            this.btn_Venta.Text = "Vender";
            this.btn_Venta.UseVisualStyleBackColor = true;
            this.btn_Venta.Visible = false;
            this.btn_Venta.Click += new System.EventHandler(this.btn_Venta_Click);
            // 
            // btn_Stock
            // 
            this.btn_Stock.Location = new System.Drawing.Point(40, 308);
            this.btn_Stock.Name = "btn_Stock";
            this.btn_Stock.Size = new System.Drawing.Size(200, 23);
            this.btn_Stock.TabIndex = 4;
            this.btn_Stock.Text = "Administrar stock";
            this.btn_Stock.UseVisualStyleBackColor = true;
            this.btn_Stock.Visible = false;
            this.btn_Stock.Click += new System.EventHandler(this.btn_Stock_Click);
            // 
            // btn_Empleados
            // 
            this.btn_Empleados.Location = new System.Drawing.Point(40, 337);
            this.btn_Empleados.Name = "btn_Empleados";
            this.btn_Empleados.Size = new System.Drawing.Size(200, 23);
            this.btn_Empleados.TabIndex = 5;
            this.btn_Empleados.Text = "Administrar empleados";
            this.btn_Empleados.UseVisualStyleBackColor = true;
            this.btn_Empleados.Visible = false;
            this.btn_Empleados.Click += new System.EventHandler(this.btn_Empleados_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(150, 450);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(90, 30);
            this.btn_Salir.TabIndex = 6;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Primer_Parcial_Labo2.Properties.Resources.pngegg_ico;
            this.pictureBox1.Location = new System.Drawing.Point(40, 437);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnAdministrarVentas
            // 
            this.btnAdministrarVentas.Location = new System.Drawing.Point(39, 366);
            this.btnAdministrarVentas.Name = "btnAdministrarVentas";
            this.btnAdministrarVentas.Size = new System.Drawing.Size(200, 23);
            this.btnAdministrarVentas.TabIndex = 8;
            this.btnAdministrarVentas.Text = "Administar Ventas";
            this.btnAdministrarVentas.UseVisualStyleBackColor = true;
            this.btnAdministrarVentas.Visible = false;
            this.btnAdministrarVentas.Click += new System.EventHandler(this.btnAdministrarVentas_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(40, 146);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(200, 23);
            this.txtUsuario.TabIndex = 9;
            this.txtUsuario.Text = "Ingrese Usuario";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(40, 175);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(200, 23);
            this.txtPassword.TabIndex = 10;
            this.txtPassword.Text = "Ingrese Password";
            // 
            // lblUsuarioContra
            // 
            this.lblUsuarioContra.AutoSize = true;
            this.lblUsuarioContra.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuarioContra.ForeColor = System.Drawing.Color.Black;
            this.lblUsuarioContra.Location = new System.Drawing.Point(40, 201);
            this.lblUsuarioContra.Name = "lblUsuarioContra";
            this.lblUsuarioContra.Size = new System.Drawing.Size(172, 15);
            this.lblUsuarioContra.TabIndex = 11;
            this.lblUsuarioContra.Text = "Usuario o password Incorrectos";
            this.lblUsuarioContra.Visible = false;
            // 
            // btnLogear
            // 
            this.btnLogear.Location = new System.Drawing.Point(40, 219);
            this.btnLogear.Name = "btnLogear";
            this.btnLogear.Size = new System.Drawing.Size(75, 23);
            this.btnLogear.TabIndex = 12;
            this.btnLogear.Text = "Ingresar";
            this.btnLogear.UseVisualStyleBackColor = true;
            this.btnLogear.Click += new System.EventHandler(this.btnLogear_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(165, 219);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(75, 23);
            this.btnAdmin.TabIndex = 13;
            this.btnAdmin.Text = "log Admin";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnLoguearVendedor
            // 
            this.btnLoguearVendedor.Location = new System.Drawing.Point(165, 250);
            this.btnLoguearVendedor.Name = "btnLoguearVendedor";
            this.btnLoguearVendedor.Size = new System.Drawing.Size(75, 23);
            this.btnLoguearVendedor.TabIndex = 14;
            this.btnLoguearVendedor.Text = "log Vend";
            this.btnLoguearVendedor.UseVisualStyleBackColor = true;
            this.btnLoguearVendedor.Click += new System.EventHandler(this.btnLoguearVendedor_Click);
            // 
            // btnDarkMode
            // 
            this.btnDarkMode.BackColor = System.Drawing.SystemColors.InfoText;
            this.btnDarkMode.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDarkMode.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDarkMode.Location = new System.Drawing.Point(88, 395);
            this.btnDarkMode.Name = "btnDarkMode";
            this.btnDarkMode.Size = new System.Drawing.Size(98, 23);
            this.btnDarkMode.TabIndex = 15;
            this.btnDarkMode.Text = "Modo Oscuro";
            this.btnDarkMode.UseVisualStyleBackColor = false;
            this.btnDarkMode.Click += new System.EventHandler(this.btnDarkMode_Click);
            // 
            // Frm_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(276, 511);
            this.Controls.Add(this.btnDarkMode);
            this.Controls.Add(this.btnLoguearVendedor);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnLogear);
            this.Controls.Add(this.lblUsuarioContra);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.btnAdministrarVentas);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Empleados);
            this.Controls.Add(this.btn_Stock);
            this.Controls.Add(this.btn_Venta);
            this.Controls.Add(this.lbl_PetShop);
            this.Controls.Add(this.lbl_Nivel);
            this.Controls.Add(this.lbl_Bienvenida);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pet Shop - Menu";
            this.Load += new System.EventHandler(this.Frm_Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Bienvenida;
        private System.Windows.Forms.Label lbl_Nivel;
        private System.Windows.Forms.Label lbl_PetShop;
        private System.Windows.Forms.Button btn_Venta;
        private System.Windows.Forms.Button btn_Stock;
        private System.Windows.Forms.Button btn_Empleados;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAdministrarVentas;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblUsuarioContra;
        private System.Windows.Forms.Button btnLogear;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnLoguearVendedor;
        private System.Windows.Forms.Button btnDarkMode;
    }
}