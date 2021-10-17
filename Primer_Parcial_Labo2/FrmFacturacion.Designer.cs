
namespace Primer_Parcial_Labo2
{
    partial class FrmFacturacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFacturacion));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_PetShop = new System.Windows.Forms.Label();
            this.rtbFacturacion = new System.Windows.Forms.RichTextBox();
            this.btnClienteMejor = new System.Windows.Forms.Button();
            this.btnVendedorMejor = new System.Windows.Forms.Button();
            this.lblMejor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Primer_Parcial_Labo2.Properties.Resources.pngegg_ico;
            this.pictureBox1.Location = new System.Drawing.Point(223, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_PetShop
            // 
            this.lbl_PetShop.AutoSize = true;
            this.lbl_PetShop.BackColor = System.Drawing.Color.Transparent;
            this.lbl_PetShop.Font = new System.Drawing.Font("Segoe Script", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_PetShop.Location = new System.Drawing.Point(12, 27);
            this.lbl_PetShop.Name = "lbl_PetShop";
            this.lbl_PetShop.Size = new System.Drawing.Size(236, 67);
            this.lbl_PetShop.TabIndex = 8;
            this.lbl_PetShop.Text = "Pet Shop ";
            // 
            // rtbFacturacion
            // 
            this.rtbFacturacion.Location = new System.Drawing.Point(12, 121);
            this.rtbFacturacion.Name = "rtbFacturacion";
            this.rtbFacturacion.ReadOnly = true;
            this.rtbFacturacion.Size = new System.Drawing.Size(260, 183);
            this.rtbFacturacion.TabIndex = 10;
            this.rtbFacturacion.Text = "";
            // 
            // btnClienteMejor
            // 
            this.btnClienteMejor.Location = new System.Drawing.Point(12, 330);
            this.btnClienteMejor.Name = "btnClienteMejor";
            this.btnClienteMejor.Size = new System.Drawing.Size(120, 23);
            this.btnClienteMejor.TabIndex = 11;
            this.btnClienteMejor.Text = "Mejor cliente";
            this.btnClienteMejor.UseVisualStyleBackColor = true;
            this.btnClienteMejor.Click += new System.EventHandler(this.btnClienteMejor_Click);
            // 
            // btnVendedorMejor
            // 
            this.btnVendedorMejor.Location = new System.Drawing.Point(154, 330);
            this.btnVendedorMejor.Name = "btnVendedorMejor";
            this.btnVendedorMejor.Size = new System.Drawing.Size(120, 23);
            this.btnVendedorMejor.TabIndex = 12;
            this.btnVendedorMejor.Text = "Mejor vendedor";
            this.btnVendedorMejor.UseVisualStyleBackColor = true;
            this.btnVendedorMejor.Click += new System.EventHandler(this.btnVendedorMejor_Click);
            // 
            // lblMejor
            // 
            this.lblMejor.AutoSize = true;
            this.lblMejor.Location = new System.Drawing.Point(66, 356);
            this.lblMejor.Name = "lblMejor";
            this.lblMejor.Size = new System.Drawing.Size(38, 15);
            this.lblMejor.TabIndex = 13;
            this.lblMejor.Text = "Mejor";
            this.lblMejor.Visible = false;
            // 
            // FrmFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(284, 461);
            this.Controls.Add(this.lblMejor);
            this.Controls.Add(this.btnVendedorMejor);
            this.Controls.Add(this.btnClienteMejor);
            this.Controls.Add(this.rtbFacturacion);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_PetShop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmFacturacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pet Shop - Modulo facturacion";
            this.Load += new System.EventHandler(this.FrmFacturacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_PetShop;
        private System.Windows.Forms.RichTextBox rtbFacturacion;
        private System.Windows.Forms.Button btnClienteMejor;
        private System.Windows.Forms.Button btnVendedorMejor;
        private System.Windows.Forms.Label lblMejor;
    }
}