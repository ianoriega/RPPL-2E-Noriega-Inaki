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
    public partial class FrmStock : Form
    {
        Empleado empleado;
        Producto[] productos;
        Producto producto;
        bool flagAlta = false;
        bool flagModi = false;
        bool flagBaja = false;

        public FrmStock()
        {
            InitializeComponent();
        }

        public FrmStock(Empleado empleado) : this()
        {
            this.empleado = empleado;
        }

        private void FrmStock_Load(object sender, EventArgs e)
        {
            lblBienvenida.Text = $"Bienvenido: {empleado.Nombre} {empleado.Apellido}";
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            lblAccion.Text = "Crear producto";
            txtProductoMarca.Show();
            txtProductoDescripcion.Show();
            txtProductoPrecio.Show();
            txtProductoCantidad.Show();
            lblAccion.Show();
            btnConfirmar.Show();
            flagAlta = true;
            btnBaja.Enabled = false;
            btnModificacion.Enabled = false;
        }

        private void btnModificacion_Click(object sender, EventArgs e)
        {
            lblProductoIngresarCod.Show();
            txtProductoCodigo.Show();      
            btnProductoBuscar.Show();
            lblProductoBuscar.Show();
            productos = PetShop.ObtenerArrayDeProductos();
            foreach (var item in productos)
            {
                cmbProductos.Items.Add(item.Descripcion);
            }
            cmbProductos.Show();
            lblAccion.Text = "Modificar producto";
            flagModi = true;
            btnBaja.Enabled = false;
            btnAlta.Enabled = false;
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            lblProductoIngresarCod.Show();
            txtProductoCodigo.Show();
            btnProductoBuscar.Show();
            lblProductoBuscar.Show();
            productos = PetShop.ObtenerArrayDeProductos();
            foreach (var item in productos)
            {
                cmbProductos.Items.Add(item.Descripcion);
            }
            cmbProductos.Show();
            lblAccion.Text = "Borrar producto";
            flagBaja = true;
            btnAlta.Enabled = false;
            btnModificacion.Enabled = false;
        }

        private void btnProductoBuscar_Click(object sender, EventArgs e)
        {
            txtProductoCodigo.Text.Trim();

            if (txtProductoCodigo.Text.All(char.IsDigit) && !String.IsNullOrEmpty(txtProductoCodigo.Text))
            {
                producto = PetShop.ObtenerProducto(int.Parse(txtProductoCodigo.Text));
                if (producto!=null)
                {
                    if (flagBaja)
                    {
                        lblProductoInfo.ForeColor = Color.Black;
                        lblProductoInfo.Text = producto.ProductoToString();
                        lblProductoInfo.Show();
                        lblAccion.Show();
                        btnConfirmar.Show();
                    }
                    else
                    {
                        lblProductoInfo.ForeColor = Color.Black;
                        lblProductoInfo.Text = producto.ProductoToString();
                        lblProductoInfo.Show();
                        txtProductoMarca.Show();
                        txtProductoDescripcion.Show();
                        txtProductoPrecio.Show();
                        txtProductoCantidad.Show();
                        lblAccion.Show();
                        btnConfirmar.Show();
                    }
                }
                else
                {
                    lblProductoInfo.Text = "Codigo invalido";
                    lblProductoInfo.ForeColor = Color.Red;
                    lblProductoInfo.Show();
                }
            }
            else
            {
                lblProductoInfo.Text = "Ingrese un codigo de producto valido";
                lblProductoInfo.ForeColor = Color.Red;
                lblProductoInfo.Show();
            }
        }

        private void cmbProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProductos.SelectedIndex != -1)
            {
                producto = PetShop.ObtenerProducto(productos[cmbProductos.SelectedIndex].Codigo);
                if(flagBaja)
                {
                    lblProductoInfo.ForeColor = Color.Black;
                    lblProductoInfo.Text = productos[cmbProductos.SelectedIndex].ProductoToString();
                    lblProductoInfo.Show();
                    lblAccion.Show();
                    btnConfirmar.Show();
                }
                else
                {
                    lblProductoInfo.Text = productos[cmbProductos.SelectedIndex].ProductoToString();
                    lblProductoInfo.ForeColor = Color.Black;
                    lblProductoInfo.Show();
                    txtProductoMarca.Show();
                    txtProductoDescripcion.Show();
                    txtProductoPrecio.Show();
                    txtProductoCantidad.Show();
                    lblAccion.Show();
                    btnConfirmar.Show();
                }
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            txtProductoMarca.Text.Trim();
            txtProductoDescripcion.Text.Trim();
            txtProductoCantidad.Text.Trim();
            txtProductoPrecio.Text.Trim();

            if (flagBaja)
            {
                if (PetShop.EliminarProducto(producto))
                {
                    lblAccion.ForeColor = Color.Green;
                    lblAccion.Text = "Producto Eliminado";
                    lblProductoInfo.Text = "Producto eliminado";
                }
                else
                {
                    lblAccion.ForeColor = Color.Red;
                    lblAccion.Text = "Error al eliminar";
                }

            }
            else if (!String.IsNullOrEmpty(txtProductoMarca.Text)       && txtProductoMarca.Text.All(char.IsLetter)       &&
                      !String.IsNullOrEmpty(txtProductoDescripcion.Text) && txtProductoDescripcion.Text.All(char.IsLetter) &&
                      !String.IsNullOrEmpty(txtProductoCantidad.Text)    && txtProductoCantidad.Text.All(char.IsDigit)     &&
                      !String.IsNullOrEmpty(txtProductoPrecio.Text)      && txtProductoPrecio.Text.All(char.IsDigit)         )
            {

                if(flagAlta)
                {
                    producto = new Producto(true, txtProductoMarca.Text,       float.Parse(txtProductoPrecio.Text),
                                            txtProductoDescripcion.Text, int.Parse(txtProductoCantidad.Text) );
                    PetShop.AgrearProducto(producto);
                    lblAccion.ForeColor = Color.Green;
                    lblAccion.Text = "Producto Creado";
                }
                else if(flagModi)
                {
                    producto.Marca = txtProductoMarca.Text;
                    producto.Descripcion = txtProductoDescripcion.Text;
                    producto.Precio = int.Parse(txtProductoPrecio.Text);
                    producto.Cantidad = int.Parse(txtProductoCantidad.Text);
                    lblAccion.ForeColor = Color.Green;
                    lblAccion.Text = "Producto Modificado";
                    lblProductoInfo.Text = producto.ProductoToString();
                }
            }
            else
            {
                lblAccion.ForeColor = Color.Red;
                lblAccion.Text = "Datos invalidos";
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
