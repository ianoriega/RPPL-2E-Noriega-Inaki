
namespace Primer_Parcial__Laboratorio_2
{
    partial class Frm_Login
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
            this.components = new System.ComponentModel.Container();
            this.txt_Usuario = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.lbl_Usuario = new System.Windows.Forms.Label();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.btn_Loguear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.Location = new System.Drawing.Point(274, 95);
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.Size = new System.Drawing.Size(159, 20);
            this.txt_Usuario.TabIndex = 0;
            this.txt_Usuario.Text = "Ingrese su usuario";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(272, 170);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.Size = new System.Drawing.Size(161, 20);
            this.txt_pass.TabIndex = 2;
            this.txt_pass.Text = "Ingrese su password";
            // 
            // lbl_Usuario
            // 
            this.lbl_Usuario.AutoSize = true;
            this.lbl_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_Usuario.Location = new System.Drawing.Point(271, 72);
            this.lbl_Usuario.Name = "lbl_Usuario";
            this.lbl_Usuario.Size = new System.Drawing.Size(68, 20);
            this.lbl_Usuario.TabIndex = 3;
            this.lbl_Usuario.Text = "Usuario:";
            this.lbl_Usuario.Click += new System.EventHandler(this.lbl_Usuario_Click);
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_pass.Location = new System.Drawing.Point(271, 147);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(92, 20);
            this.lbl_pass.TabIndex = 4;
            this.lbl_pass.Text = "Contraseña";
            // 
            // btn_Loguear
            // 
            this.btn_Loguear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_Loguear.Location = new System.Drawing.Point(272, 228);
            this.btn_Loguear.Name = "btn_Loguear";
            this.btn_Loguear.Size = new System.Drawing.Size(159, 32);
            this.btn_Loguear.TabIndex = 5;
            this.btn_Loguear.Text = "Ingresar al sistema";
            this.btn_Loguear.UseVisualStyleBackColor = true;
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 420);
            this.Controls.Add(this.btn_Loguear);
            this.Controls.Add(this.lbl_pass);
            this.Controls.Add(this.lbl_Usuario);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_Usuario);
            this.Name = "Frm_Login";
            this.Text = "Pet Shop ";
            this.Load += new System.EventHandler(this.Frm_Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Usuario;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Label lbl_Usuario;
        public System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.Button btn_Loguear;
    }
}

