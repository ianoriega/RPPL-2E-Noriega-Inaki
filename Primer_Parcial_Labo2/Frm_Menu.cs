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

    public partial class Frm_Menu : Form
    {
        Empleado empleado;
        public Frm_Menu()
        {
            InitializeComponent();
        }

        public Frm_Menu(Empleado empleado) :this()
        {
            this.empleado = empleado;

        }
        private void Frm_Menu_Load(object sender, EventArgs e)
        {
           
        }


        private void btn_Venta_Click(object sender, EventArgs e)
        {
            Frm_Venta menuVenta = new Frm_Venta(empleado);
            menuVenta.ShowDialog(this);
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btn_Stock_Click(object sender, EventArgs e)
        {
            FrmStock menuStock = new FrmStock(empleado);
            menuStock.ShowDialog(this);
        }

        private void btn_Empleados_Click(object sender, EventArgs e)
        {
           
            FrmEmpleados menuEmpleados = new FrmEmpleados(empleado);
            menuEmpleados.ShowDialog(this);
        }

        private void btnLogear_Click(object sender, EventArgs e)
        {
            try
            {
                empleado = PetShop.LoguearUsuario(txtUsuario.Text, txtPassword.Text);
                if (empleado != null)
                {
                    lbl_Bienvenida.Text = "Bienvenido:\n" + empleado.Nombre + " " + empleado.Apellido;
                    lblUsuarioContra.Text = "Logueado Correctamente";
                    lblUsuarioContra.ForeColor = Color.Green;
                    lblUsuarioContra.Show();
                    if (empleado.GetType() == typeof(Administrador))
                    {
                        lbl_Nivel.Text = "Nivel de acceso: Administrador";
                        btnAdministrarVentas.Enabled = true;
                        btn_Stock.Enabled = true;
                        btn_Venta.Enabled = true;
                        btn_Empleados.Enabled = true;
                    }
                    else if (empleado.GetType() == typeof(Vendedor))
                    {
                        lbl_Nivel.Text = "Nivel de acceso: Vendedor";
                        btn_Venta.Enabled = true;
                        btn_Empleados.Enabled = false;
                        btnAdministrarVentas.Enabled = false;
                        btn_Stock.Enabled = false;
                    }


                }
                else
                {
                    lblUsuarioContra.Text = "Usuario o contraseña invalidos";
                    lblUsuarioContra.ForeColor = Color.Red;
                    lblUsuarioContra.Show();
                    UsuarioInvalidoException ex = new UsuarioInvalidoException("Usuario o contraseña invalidos");
                    throw ex;
                    
                }
            }
            catch (UsuarioInvalidoException ex)
            {
                MessageBox.Show($"{ex}");
            }
           

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "admin";
            txtPassword.Text = "admin";
        }

        private void btnLoguearVendedor_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "vendedor";
            txtPassword.Text = "vendedor";
        }

        private void btnAdministrarVentas_Click(object sender, EventArgs e)
        {
            FrmFacturacion moduloFacturacion = new FrmFacturacion();
            moduloFacturacion.ShowDialog(this);
        }
    }
}
