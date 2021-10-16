
namespace Primer_Parcial_Labo2
{
    partial class Frm_Venta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Venta));
            this.lbl_PetShop = new System.Windows.Forms.Label();
            this.txt_NumCliente = new System.Windows.Forms.TextBox();
            this.lbl_NumCliente = new System.Windows.Forms.Label();
            this.btn_NumCliente = new System.Windows.Forms.Button();
            this.txt_ClienteNombre = new System.Windows.Forms.TextBox();
            this.lbl_estadoCliente = new System.Windows.Forms.Label();
            this.lbl_ClienteNombre = new System.Windows.Forms.Label();
            this.lbl_ClienteApellido = new System.Windows.Forms.Label();
            this.txt_ClienteApellido = new System.Windows.Forms.TextBox();
            this.txt_ClienteSaldo = new System.Windows.Forms.TextBox();
            this.lbl_ClienteSaldo = new System.Windows.Forms.Label();
            this.btn_CrearCliente = new System.Windows.Forms.Button();
            this.cmb_Producto = new System.Windows.Forms.ComboBox();
            this.lbl_Producto = new System.Windows.Forms.Label();
            this.rtb_DatosProducto = new System.Windows.Forms.RichTextBox();
            this.lbl_DescripcionProducto = new System.Windows.Forms.Label();
            this.txt_CantidadProducto = new System.Windows.Forms.TextBox();
            this.lbl_CantidadProducto = new System.Windows.Forms.Label();
            this.btn_AgregarProducto = new System.Windows.Forms.Button();
            this.lbl_Carrito = new System.Windows.Forms.Label();
            this.btn_RealizarCompra = new System.Windows.Forms.Button();
            this.lbl_Vendedor = new System.Windows.Forms.Label();
            this.lbl_Legajo = new System.Windows.Forms.Label();
            this.txt_TotalCompra = new System.Windows.Forms.TextBox();
            this.lbl_TotalCompra = new System.Windows.Forms.Label();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_DniPrueba = new System.Windows.Forms.Button();
            this.lbl_AgregarProducto = new System.Windows.Forms.Label();
            this.dtgvCarrito = new System.Windows.Forms.DataGridView();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblComprar = new System.Windows.Forms.Label();
            this.btnModificarCliente = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCarrito)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_PetShop
            // 
            this.lbl_PetShop.AutoSize = true;
            this.lbl_PetShop.BackColor = System.Drawing.Color.Transparent;
            this.lbl_PetShop.Font = new System.Drawing.Font("Segoe Script", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_PetShop.Location = new System.Drawing.Point(43, 10);
            this.lbl_PetShop.Name = "lbl_PetShop";
            this.lbl_PetShop.Size = new System.Drawing.Size(353, 106);
            this.lbl_PetShop.TabIndex = 3;
            this.lbl_PetShop.Text = "Pet Shop";
            // 
            // txt_NumCliente
            // 
            this.txt_NumCliente.Location = new System.Drawing.Point(44, 139);
            this.txt_NumCliente.Name = "txt_NumCliente";
            this.txt_NumCliente.Size = new System.Drawing.Size(175, 23);
            this.txt_NumCliente.TabIndex = 4;
            this.txt_NumCliente.Text = "Ingrese Dni";
            // 
            // lbl_NumCliente
            // 
            this.lbl_NumCliente.AutoSize = true;
            this.lbl_NumCliente.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_NumCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_NumCliente.Location = new System.Drawing.Point(44, 115);
            this.lbl_NumCliente.Name = "lbl_NumCliente";
            this.lbl_NumCliente.Size = new System.Drawing.Size(61, 21);
            this.lbl_NumCliente.TabIndex = 5;
            this.lbl_NumCliente.Text = "Cliente:";
            // 
            // btn_NumCliente
            // 
            this.btn_NumCliente.Location = new System.Drawing.Point(44, 174);
            this.btn_NumCliente.Name = "btn_NumCliente";
            this.btn_NumCliente.Size = new System.Drawing.Size(61, 23);
            this.btn_NumCliente.TabIndex = 7;
            this.btn_NumCliente.Text = "Buscar";
            this.btn_NumCliente.UseVisualStyleBackColor = true;
            this.btn_NumCliente.Click += new System.EventHandler(this.btn_NumCliente_Click);
            // 
            // txt_ClienteNombre
            // 
            this.txt_ClienteNombre.Location = new System.Drawing.Point(45, 231);
            this.txt_ClienteNombre.Name = "txt_ClienteNombre";
            this.txt_ClienteNombre.Size = new System.Drawing.Size(175, 23);
            this.txt_ClienteNombre.TabIndex = 8;
            // 
            // lbl_estadoCliente
            // 
            this.lbl_estadoCliente.AutoSize = true;
            this.lbl_estadoCliente.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_estadoCliente.Location = new System.Drawing.Point(111, 178);
            this.lbl_estadoCliente.Name = "lbl_estadoCliente";
            this.lbl_estadoCliente.Size = new System.Drawing.Size(82, 15);
            this.lbl_estadoCliente.TabIndex = 9;
            this.lbl_estadoCliente.Text = "Cliente estado";
            // 
            // lbl_ClienteNombre
            // 
            this.lbl_ClienteNombre.AutoSize = true;
            this.lbl_ClienteNombre.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_ClienteNombre.Location = new System.Drawing.Point(44, 212);
            this.lbl_ClienteNombre.Name = "lbl_ClienteNombre";
            this.lbl_ClienteNombre.Size = new System.Drawing.Size(54, 15);
            this.lbl_ClienteNombre.TabIndex = 10;
            this.lbl_ClienteNombre.Text = "Nombre:";
            // 
            // lbl_ClienteApellido
            // 
            this.lbl_ClienteApellido.AutoSize = true;
            this.lbl_ClienteApellido.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_ClienteApellido.Location = new System.Drawing.Point(45, 270);
            this.lbl_ClienteApellido.Name = "lbl_ClienteApellido";
            this.lbl_ClienteApellido.Size = new System.Drawing.Size(54, 15);
            this.lbl_ClienteApellido.TabIndex = 11;
            this.lbl_ClienteApellido.Text = "Apellido:";
            // 
            // txt_ClienteApellido
            // 
            this.txt_ClienteApellido.Location = new System.Drawing.Point(46, 295);
            this.txt_ClienteApellido.Name = "txt_ClienteApellido";
            this.txt_ClienteApellido.Size = new System.Drawing.Size(175, 23);
            this.txt_ClienteApellido.TabIndex = 12;
            // 
            // txt_ClienteSaldo
            // 
            this.txt_ClienteSaldo.Location = new System.Drawing.Point(45, 358);
            this.txt_ClienteSaldo.Name = "txt_ClienteSaldo";
            this.txt_ClienteSaldo.Size = new System.Drawing.Size(176, 23);
            this.txt_ClienteSaldo.TabIndex = 13;
            // 
            // lbl_ClienteSaldo
            // 
            this.lbl_ClienteSaldo.AutoSize = true;
            this.lbl_ClienteSaldo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_ClienteSaldo.Location = new System.Drawing.Point(44, 337);
            this.lbl_ClienteSaldo.Name = "lbl_ClienteSaldo";
            this.lbl_ClienteSaldo.Size = new System.Drawing.Size(39, 15);
            this.lbl_ClienteSaldo.TabIndex = 14;
            this.lbl_ClienteSaldo.Text = "Saldo:";
            // 
            // btn_CrearCliente
            // 
            this.btn_CrearCliente.Location = new System.Drawing.Point(43, 454);
            this.btn_CrearCliente.Name = "btn_CrearCliente";
            this.btn_CrearCliente.Size = new System.Drawing.Size(89, 23);
            this.btn_CrearCliente.TabIndex = 15;
            this.btn_CrearCliente.Text = "Crear";
            this.btn_CrearCliente.UseVisualStyleBackColor = true;
            this.btn_CrearCliente.Click += new System.EventHandler(this.btn_CrearCliente_Click);
            // 
            // cmb_Producto
            // 
            this.cmb_Producto.FormattingEnabled = true;
            this.cmb_Producto.Location = new System.Drawing.Point(250, 140);
            this.cmb_Producto.Name = "cmb_Producto";
            this.cmb_Producto.Size = new System.Drawing.Size(175, 23);
            this.cmb_Producto.TabIndex = 16;
            this.cmb_Producto.SelectedIndexChanged += new System.EventHandler(this.cmb_Producto_SelectedIndexChanged);
            // 
            // lbl_Producto
            // 
            this.lbl_Producto.AutoSize = true;
            this.lbl_Producto.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_Producto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Producto.Location = new System.Drawing.Point(250, 116);
            this.lbl_Producto.Name = "lbl_Producto";
            this.lbl_Producto.Size = new System.Drawing.Size(76, 21);
            this.lbl_Producto.TabIndex = 17;
            this.lbl_Producto.Text = "Producto:";
            // 
            // rtb_DatosProducto
            // 
            this.rtb_DatosProducto.Location = new System.Drawing.Point(250, 212);
            this.rtb_DatosProducto.Name = "rtb_DatosProducto";
            this.rtb_DatosProducto.ReadOnly = true;
            this.rtb_DatosProducto.Size = new System.Drawing.Size(174, 154);
            this.rtb_DatosProducto.TabIndex = 18;
            this.rtb_DatosProducto.Text = "";
            // 
            // lbl_DescripcionProducto
            // 
            this.lbl_DescripcionProducto.AutoSize = true;
            this.lbl_DescripcionProducto.BackColor = System.Drawing.Color.Transparent;
            this.lbl_DescripcionProducto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_DescripcionProducto.Location = new System.Drawing.Point(250, 178);
            this.lbl_DescripcionProducto.Name = "lbl_DescripcionProducto";
            this.lbl_DescripcionProducto.Size = new System.Drawing.Size(94, 21);
            this.lbl_DescripcionProducto.TabIndex = 19;
            this.lbl_DescripcionProducto.Text = "Descripcion:";
            // 
            // txt_CantidadProducto
            // 
            this.txt_CantidadProducto.Location = new System.Drawing.Point(250, 458);
            this.txt_CantidadProducto.Name = "txt_CantidadProducto";
            this.txt_CantidadProducto.Size = new System.Drawing.Size(76, 23);
            this.txt_CantidadProducto.TabIndex = 20;
            // 
            // lbl_CantidadProducto
            // 
            this.lbl_CantidadProducto.AutoSize = true;
            this.lbl_CantidadProducto.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_CantidadProducto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_CantidadProducto.Location = new System.Drawing.Point(250, 434);
            this.lbl_CantidadProducto.Name = "lbl_CantidadProducto";
            this.lbl_CantidadProducto.Size = new System.Drawing.Size(75, 21);
            this.lbl_CantidadProducto.TabIndex = 21;
            this.lbl_CantidadProducto.Text = "Cantidad:";
            // 
            // btn_AgregarProducto
            // 
            this.btn_AgregarProducto.Location = new System.Drawing.Point(350, 457);
            this.btn_AgregarProducto.Name = "btn_AgregarProducto";
            this.btn_AgregarProducto.Size = new System.Drawing.Size(75, 23);
            this.btn_AgregarProducto.TabIndex = 22;
            this.btn_AgregarProducto.Text = "Agregar";
            this.btn_AgregarProducto.UseVisualStyleBackColor = true;
            this.btn_AgregarProducto.Click += new System.EventHandler(this.btn_AgregarProducto_Click);
            // 
            // lbl_Carrito
            // 
            this.lbl_Carrito.AutoSize = true;
            this.lbl_Carrito.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_Carrito.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Carrito.Location = new System.Drawing.Point(463, 79);
            this.lbl_Carrito.Name = "lbl_Carrito";
            this.lbl_Carrito.Size = new System.Drawing.Size(146, 21);
            this.lbl_Carrito.TabIndex = 24;
            this.lbl_Carrito.Text = "Carrito de compras:";
            // 
            // btn_RealizarCompra
            // 
            this.btn_RealizarCompra.Location = new System.Drawing.Point(712, 457);
            this.btn_RealizarCompra.Name = "btn_RealizarCompra";
            this.btn_RealizarCompra.Size = new System.Drawing.Size(195, 23);
            this.btn_RealizarCompra.TabIndex = 25;
            this.btn_RealizarCompra.Text = "Comprar";
            this.btn_RealizarCompra.UseVisualStyleBackColor = true;
            this.btn_RealizarCompra.Click += new System.EventHandler(this.btn_RealizarCompra_Click);
            // 
            // lbl_Vendedor
            // 
            this.lbl_Vendedor.AutoSize = true;
            this.lbl_Vendedor.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_Vendedor.Location = new System.Drawing.Point(555, 9);
            this.lbl_Vendedor.Name = "lbl_Vendedor";
            this.lbl_Vendedor.Size = new System.Drawing.Size(116, 15);
            this.lbl_Vendedor.TabIndex = 26;
            this.lbl_Vendedor.Text = "Vendedor: vendedor ";
            // 
            // lbl_Legajo
            // 
            this.lbl_Legajo.AutoSize = true;
            this.lbl_Legajo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_Legajo.Location = new System.Drawing.Point(555, 30);
            this.lbl_Legajo.Name = "lbl_Legajo";
            this.lbl_Legajo.Size = new System.Drawing.Size(80, 15);
            this.lbl_Legajo.TabIndex = 27;
            this.lbl_Legajo.Text = "Legajo: legajo";
            // 
            // txt_TotalCompra
            // 
            this.txt_TotalCompra.Location = new System.Drawing.Point(583, 458);
            this.txt_TotalCompra.Name = "txt_TotalCompra";
            this.txt_TotalCompra.Size = new System.Drawing.Size(100, 23);
            this.txt_TotalCompra.TabIndex = 28;
            // 
            // lbl_TotalCompra
            // 
            this.lbl_TotalCompra.AutoSize = true;
            this.lbl_TotalCompra.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_TotalCompra.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_TotalCompra.Location = new System.Drawing.Point(463, 456);
            this.lbl_TotalCompra.Name = "lbl_TotalCompra";
            this.lbl_TotalCompra.Size = new System.Drawing.Size(105, 21);
            this.lbl_TotalCompra.TabIndex = 29;
            this.lbl_TotalCompra.Text = "Total Compra:";
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(832, 526);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(75, 23);
            this.btn_Salir.TabIndex = 30;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // btn_DniPrueba
            // 
            this.btn_DniPrueba.Location = new System.Drawing.Point(152, 115);
            this.btn_DniPrueba.Name = "btn_DniPrueba";
            this.btn_DniPrueba.Size = new System.Drawing.Size(68, 23);
            this.btn_DniPrueba.TabIndex = 31;
            this.btn_DniPrueba.Text = "Auto";
            this.btn_DniPrueba.UseVisualStyleBackColor = true;
            this.btn_DniPrueba.Click += new System.EventHandler(this.btn_DniPrueba_Click);
            // 
            // lbl_AgregarProducto
            // 
            this.lbl_AgregarProducto.AutoSize = true;
            this.lbl_AgregarProducto.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_AgregarProducto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_AgregarProducto.Location = new System.Drawing.Point(250, 392);
            this.lbl_AgregarProducto.Name = "lbl_AgregarProducto";
            this.lbl_AgregarProducto.Size = new System.Drawing.Size(152, 21);
            this.lbl_AgregarProducto.TabIndex = 33;
            this.lbl_AgregarProducto.Text = "Informacion roducto";
            // 
            // dtgvCarrito
            // 
            this.dtgvCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCarrito.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Descripcion,
            this.Precio,
            this.Cant,
            this.Total});
            this.dtgvCarrito.Location = new System.Drawing.Point(463, 116);
            this.dtgvCarrito.Name = "dtgvCarrito";
            this.dtgvCarrito.ReadOnly = true;
            this.dtgvCarrito.RowTemplate.Height = 25;
            this.dtgvCarrito.Size = new System.Drawing.Size(445, 323);
            this.dtgvCarrito.TabIndex = 34;
           
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 94;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Cant
            // 
            this.Cant.HeaderText = "Cant";
            this.Cant.Name = "Cant";
            this.Cant.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // lblComprar
            // 
            this.lblComprar.AutoSize = true;
            this.lblComprar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblComprar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblComprar.Location = new System.Drawing.Point(500, 503);
            this.lblComprar.Name = "lblComprar";
            this.lblComprar.Size = new System.Drawing.Size(151, 21);
            this.lblComprar.TabIndex = 35;
            this.lblComprar.Text = "informacion compra";
            // 
            // btnModificarCliente
            // 
            this.btnModificarCliente.Location = new System.Drawing.Point(138, 454);
            this.btnModificarCliente.Name = "btnModificarCliente";
            this.btnModificarCliente.Size = new System.Drawing.Size(83, 23);
            this.btnModificarCliente.TabIndex = 36;
            this.btnModificarCliente.Text = "Modificar";
            this.btnModificarCliente.UseVisualStyleBackColor = true;
            this.btnModificarCliente.Visible = false;
            this.btnModificarCliente.Click += new System.EventHandler(this.btnModificarCliente_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(91, 491);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 37;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Visible = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // Frm_Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(953, 561);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnModificarCliente);
            this.Controls.Add(this.lblComprar);
            this.Controls.Add(this.dtgvCarrito);
            this.Controls.Add(this.lbl_AgregarProducto);
            this.Controls.Add(this.btn_DniPrueba);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.lbl_TotalCompra);
            this.Controls.Add(this.txt_TotalCompra);
            this.Controls.Add(this.lbl_Legajo);
            this.Controls.Add(this.lbl_Vendedor);
            this.Controls.Add(this.btn_RealizarCompra);
            this.Controls.Add(this.lbl_Carrito);
            this.Controls.Add(this.btn_AgregarProducto);
            this.Controls.Add(this.lbl_CantidadProducto);
            this.Controls.Add(this.txt_CantidadProducto);
            this.Controls.Add(this.lbl_DescripcionProducto);
            this.Controls.Add(this.rtb_DatosProducto);
            this.Controls.Add(this.lbl_Producto);
            this.Controls.Add(this.cmb_Producto);
            this.Controls.Add(this.btn_CrearCliente);
            this.Controls.Add(this.lbl_ClienteSaldo);
            this.Controls.Add(this.txt_ClienteSaldo);
            this.Controls.Add(this.txt_ClienteApellido);
            this.Controls.Add(this.lbl_ClienteApellido);
            this.Controls.Add(this.lbl_ClienteNombre);
            this.Controls.Add(this.lbl_estadoCliente);
            this.Controls.Add(this.txt_ClienteNombre);
            this.Controls.Add(this.btn_NumCliente);
            this.Controls.Add(this.lbl_NumCliente);
            this.Controls.Add(this.txt_NumCliente);
            this.Controls.Add(this.lbl_PetShop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Venta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pet Shop - Modulo de ventas";
            this.Load += new System.EventHandler(this.Frm_Venta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCarrito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_PetShop;
        private System.Windows.Forms.TextBox txt_NumCliente;
        private System.Windows.Forms.Label lbl_NumCliente;
        private System.Windows.Forms.Button btn_NumCliente;
        private System.Windows.Forms.TextBox txt_ClienteNombre;
        private System.Windows.Forms.Label lbl_estadoCliente;
        private System.Windows.Forms.Label lbl_ClienteNombre;
        private System.Windows.Forms.Label lbl_ClienteApellido;
        private System.Windows.Forms.TextBox txt_ClienteApellido;
        private System.Windows.Forms.TextBox txt_ClienteSaldo;
        private System.Windows.Forms.Label lbl_ClienteSaldo;
        private System.Windows.Forms.Button btn_CrearCliente;
        private System.Windows.Forms.ComboBox cmb_Producto;
        private System.Windows.Forms.Label lbl_Producto;
        private System.Windows.Forms.RichTextBox rtb_DatosProducto;
        private System.Windows.Forms.Label lbl_DescripcionProducto;
        private System.Windows.Forms.TextBox txt_CantidadProducto;
        private System.Windows.Forms.Label lbl_CantidadProducto;
        private System.Windows.Forms.Button btn_AgregarProducto;
        private System.Windows.Forms.Label lbl_Carrito;
        private System.Windows.Forms.Button btn_RealizarCompra;
        private System.Windows.Forms.Label lbl_Vendedor;
        private System.Windows.Forms.Label lbl_Legajo;
        private System.Windows.Forms.TextBox txt_TotalCompra;
        private System.Windows.Forms.Label lbl_TotalCompra;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_DniPrueba;
        private System.Windows.Forms.Label lbl_AgregarProducto;
        private System.Windows.Forms.DataGridView dtgvCarrito;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cant;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Label lblComprar;
        private System.Windows.Forms.Button btnModificarCliente;
        private System.Windows.Forms.Button btnConfirmar;
    }
}