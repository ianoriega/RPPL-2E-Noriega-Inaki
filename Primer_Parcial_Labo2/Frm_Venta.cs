using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca_Parcial;

namespace Primer_Parcial_Labo2
{
    public partial class Frm_Venta : Form
    {
        Cliente cliente;
        Empleado empleado;
        Administrador admin;
        Producto[] productos;
        Compra compra;
        Producto auxProducto;
        bool flagAgregar;

        public Frm_Venta()
        {
            InitializeComponent();
        }

        public Frm_Venta(Empleado empleado) : this()
        {
            this.empleado = empleado;
        }

        private void Frm_Venta_Load(object sender, EventArgs e)
        {
            lbl_Vendedor.Text = $"Vendedor: {empleado.Nombre} {empleado.Apellido}";
            lbl_Legajo.Text = $"Legajo: {empleado.Legajo}";
            lbl_AgregarProducto.Hide();
            lblComprar.Hide();
            productos = PetShop.ObtenerArrayDeProductos();
            foreach (var item in productos)
            {
                cmb_Producto.Items.Add(item.Descripcion);
            }
            btn_AgregarProducto.Enabled = false;
            flagAgregar = false;
            lbl_ClienteNombre.Hide();
            txt_ClienteNombre.Hide();
            lbl_ClienteApellido.Hide();
            txt_ClienteApellido.Hide();
            lbl_ClienteSaldo.Hide();
            txt_ClienteSaldo.Hide();
            btn_CrearCliente.Hide();
            lbl_estadoCliente.Hide();
            if (empleado.GetType() == typeof(Administrador))
            {
                btnModificarCliente.Enabled = true;
                admin = (Administrador)empleado;
            }
        }

        private void MostrarTxtCliente()
        {
            lbl_ClienteNombre.Show();
            txt_ClienteNombre.Show();
            lbl_ClienteApellido.Show();
            txt_ClienteApellido.Show();
            lbl_ClienteSaldo.Show();
            txt_ClienteSaldo.Show();
            btn_CrearCliente.Show();
        }

        #region BtnNumCliente
        private void btn_NumCliente_Click(object sender, EventArgs e)
        {
            txt_NumCliente.Text.Trim();

            if(txt_NumCliente.Text.All(char.IsDigit) && !String.IsNullOrEmpty(txt_NumCliente.Text))
            {
                cliente = PetShop.ValidarCliente(int.Parse(txt_NumCliente.Text));
                if (cliente != null)
                {
                    MostrarTxtCliente();
                    lbl_estadoCliente.Text = "Cliente Cargado";
                    lbl_estadoCliente.ForeColor = Color.Green;
                    lbl_estadoCliente.Show();
                    txt_ClienteNombre.Text = cliente.Nombre;
                    txt_ClienteApellido.Text = cliente.Apellido;
                    txt_ClienteSaldo.Text = $"{cliente.Saldo}";
                    btn_CrearCliente.Hide();
                    txt_NumCliente.Enabled = false;
                    txt_ClienteNombre.Enabled = false;
                    txt_ClienteApellido.Enabled = false;
                    txt_ClienteSaldo.Enabled = false;
                    compra = new Compra(cliente.Dni, empleado.Legajo);
                    if (empleado.GetType()==typeof(Administrador))
                    {
                        btnModificarCliente.Show();
                    }
                    
                }
                else
                {
                    lbl_estadoCliente.Text = "Cliente No Encontrado";
                    lbl_estadoCliente.ForeColor = Color.Red;
                    lbl_estadoCliente.Show();
                    if (empleado.GetType() == typeof(Administrador))
                    {
                        MostrarTxtCliente();
                        txt_ClienteNombre.Text = "Cargar Nombre";
                        txt_ClienteApellido.Text = "Cargar Apellido";
                        txt_ClienteSaldo.Text = "Cargar Saldo";
                        btn_CrearCliente.Show();

                    }               
                }
            }
            else
            {
                lbl_estadoCliente.Text = "Datos Incorrectos";
                lbl_estadoCliente.ForeColor = Color.Red;
                lbl_estadoCliente.Show();
            }
               
        }
        #endregion


        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_DniPrueba_Click(object sender, EventArgs e)
        {
            txt_NumCliente.Text = "14352465";
        }

        #region btnCrearCliente
        private void btn_CrearCliente_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(txt_NumCliente.Text)      &&
               !String.IsNullOrEmpty(txt_ClienteNombre.Text)   &&
               !String.IsNullOrEmpty(txt_ClienteApellido.Text) &&
               !String.IsNullOrEmpty(txt_ClienteSaldo.Text)      )
            {
                txt_NumCliente.Text.Trim();
                txt_ClienteNombre.Text.Trim();
                txt_ClienteApellido.Text.Trim();
                txt_ClienteSaldo.Text.Trim();

                if (txt_NumCliente.Text.All(char.IsDigit) &&
                    txt_ClienteNombre.Text.All(char.IsLetter) &&
                    txt_ClienteApellido.Text.All(char.IsLetter) &&
                    txt_ClienteSaldo.Text.All(char.IsDigit))
                {
                    cliente = new Cliente(txt_ClienteNombre.Text, txt_ClienteApellido.Text, 
                                                             int.Parse(txt_NumCliente.Text),
                                                         float.Parse(txt_ClienteSaldo.Text));
                    if (cliente != null)
                    {
                        PetShop.AgregarCliente(cliente);
                        compra = new Compra(cliente.Dni, empleado.Legajo);

                        lbl_estadoCliente.Text = "Cliente Cargado";
                        lbl_estadoCliente.ForeColor = Color.Green;
                        txt_NumCliente.Enabled = false;
                        txt_ClienteNombre.Enabled = false;
                        txt_ClienteApellido.Enabled = false;
                        txt_ClienteSaldo.Enabled = false;
                        btn_CrearCliente.Enabled = false;
                        btn_CrearCliente.Hide();
                    }
                    else
                    {
                        lbl_estadoCliente.Text = "Error al agregar cliente";
                        lbl_estadoCliente.ForeColor = Color.Red;
                    }
                    

                }
                else
                {
                    MessageBox.Show("Error: Debe completar CORRECTAMENTE todos los datos del cliente.");
                    txt_NumCliente.Text = "Solo Numeros";
                    txt_ClienteNombre.Text = "Solo Letras";
                    txt_ClienteApellido.Text = "Solo Letras";
                    txt_ClienteSaldo.Text = "Solo Numeros";
                }
               
            }
            else
            {
                MessageBox.Show("Error: Debe completar todos los datos del cliente.");
            }
        }
        #endregion

        private void cmb_Producto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmb_Producto.SelectedIndex!= -1)
            {
                rtb_DatosProducto.Text = productos[cmb_Producto.SelectedIndex].ProductoToString();
                btn_AgregarProducto.Enabled = true;
            }
        }

        #region btnAgregarProducto
        private void btn_AgregarProducto_Click(object sender, EventArgs e)
        { 
            txt_CantidadProducto.Text.Trim();
            if(txt_CantidadProducto.Text.All(char.IsDigit) && !String.IsNullOrEmpty(txt_CantidadProducto.Text))
            {
                if (PetShop.ComprobarStock(productos[cmb_Producto.SelectedIndex].Codigo, int.Parse(txt_CantidadProducto.Text)))
                {
                    if (cliente != null)
                    {
                        auxProducto = compra.AgregarProducto(productos[cmb_Producto.SelectedIndex].Codigo, int.Parse(txt_CantidadProducto.Text));
                        if (auxProducto != null)
                        {
                            lbl_AgregarProducto.Text = "PRODUCTO AGREGADO";
                            lbl_AgregarProducto.ForeColor = Color.Green;
                            lbl_AgregarProducto.Show();

                            int renglon = dtgvCarrito.Rows.Add();
                            dtgvCarrito.Rows[renglon].Cells[0].Value = auxProducto.Descripcion;
                            dtgvCarrito.Rows[renglon].Cells[1].Value = auxProducto.Precio;
                            dtgvCarrito.Rows[renglon].Cells[2].Value = auxProducto.Cantidad;
                            dtgvCarrito.Rows[renglon].Cells[3].Value = auxProducto.Subtotal;


                            rtb_DatosProducto.Text = productos[cmb_Producto.SelectedIndex].ProductoToString();
                            txt_TotalCompra.Text = $"$ {compra.CalcularTotalCompra()}";
                            flagAgregar = true;
                        }
                    }
                    else
                    {
                        lbl_AgregarProducto.Text = "CLIENTE NO CARGADO\nDebe cargar Cliente";
                        lbl_AgregarProducto.ForeColor = Color.Red;
                        lbl_AgregarProducto.Show();
                    }
                }
                else 
                {
                    lbl_AgregarProducto.Text = "ERROR Stock insuficiente.";
                    lbl_AgregarProducto.ForeColor = Color.Red;
                    lbl_AgregarProducto.Show();
                }
            }
            else
            { 
                lbl_AgregarProducto.Text = "PRODUCTO NO CARGADO\nCantidad debe ser mayor a 0";
                lbl_AgregarProducto.ForeColor = Color.Red;
                lbl_AgregarProducto.Show();
            }
        }
        #endregion

        private void rtb_Carrito_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_RealizarCompra_Click(object sender, EventArgs e)
        {
            if(flagAgregar)
            {
                float auxTotalCompra = compra.CalcularTotalCompra();
                if (cliente.Saldo >= auxTotalCompra)
                {
                    cliente.Saldo -= auxTotalCompra;
                    cliente.AgregarCompra(compra);
                    Frm_Factura FrmFac = new Frm_Factura(cliente,compra);
                    FrmFac.ShowDialog(this);
                    lblComprar.ForeColor = Color.Green;
                    lblComprar.Text = "Compra realizada";
                    lblComprar.Show();
                }
                else
                {
                    lblComprar.ForeColor = Color.Red;
                    lblComprar.Text = "El cliente no tiene saldo suficiente para comprar";
                    lblComprar.Show();
                }
            }
            else
            {
                lblComprar.ForeColor = Color.Red;
                lblComprar.Text = "Error: Debe agregar productos a la compra";
                lblComprar.Show();
            }
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            txt_ClienteApellido.Enabled = true;
            txt_ClienteNombre.Enabled = true;
            txt_ClienteSaldo.Enabled = true;
            btnConfirmar.Show();

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txt_ClienteNombre.Text) &&
                !String.IsNullOrEmpty(txt_ClienteApellido.Text) &&
                !String.IsNullOrEmpty(txt_ClienteSaldo.Text))
            {
                txt_ClienteNombre.Text.Trim();
                txt_ClienteApellido.Text.Trim();
                txt_ClienteSaldo.Text.Trim();

                if (txt_ClienteNombre.Text.All(char.IsLetter) &&
                    txt_ClienteApellido.Text.All(char.IsLetter) &&
                    txt_ClienteSaldo.Text.All(char.IsDigit))
                {
                   if( admin.ModificarCliente(cliente, txt_ClienteNombre.Text, txt_ClienteApellido.Text, 
                                                                   float.Parse(txt_ClienteSaldo.Text))  )
                   {
                        lbl_estadoCliente.Text = "Cliente modificado";
                        lbl_estadoCliente.ForeColor = Color.Green;
                        lbl_estadoCliente.Show();
                        btnConfirmar.Enabled = false;
                        btnModificarCliente.Enabled = false;
                   }
                   else
                   {
                        lbl_estadoCliente.Text = "Error al modificar";
                        lbl_estadoCliente.ForeColor = Color.Red;
                        lbl_estadoCliente.Show();
                   }
                }
                else
                {
                    lbl_estadoCliente.Text = "Datos Erroneos";
                    lbl_estadoCliente.ForeColor = Color.Red;
                    lbl_estadoCliente.Show();
                }
            }
        }
    }
}
