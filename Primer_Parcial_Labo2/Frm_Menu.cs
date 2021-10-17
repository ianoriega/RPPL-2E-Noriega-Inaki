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
                        btnAdministrarVentas.Show();
                        btn_Stock.Show();
                        btn_Venta.Show();
                        btn_Empleados.Show();
                    }
                    else if (empleado.GetType() == typeof(Vendedor))
                    {
                        lbl_Nivel.Text = "Nivel de acceso: Vendedor";
                        btn_Venta.Show();
                        btn_Empleados.Hide();
                        btnAdministrarVentas.Hide();
                        btn_Stock.Hide();
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


        bool flagDarkMode = false;

        private void btnDarkMode_Click(object sender, EventArgs e)
        {
            if (!flagDarkMode)
            {
                flagDarkMode = true;
                lbl_Bienvenida.ForeColor = Color.White;
                lbl_Nivel.ForeColor = Color.White;
                this.BackgroundImage = Properties.Resources.monooscuro;
                lbl_PetShop.ForeColor = Color.White;
                lblUsuarioContra.ForeColor = Color.White;
                btnLogear.ForeColor = Color.White;
                btnLogear.BackColor = Color.Black;
                btnAdmin.ForeColor = Color.White;
                btnAdmin.BackColor = Color.Black;
                btnLoguearVendedor.ForeColor = Color.White;
                btnLoguearVendedor.BackColor = Color.Black;
                btn_Venta.ForeColor = Color.White;
                btn_Venta.BackColor = Color.Black;
                btn_Stock.ForeColor = Color.White;
                btn_Stock.BackColor = Color.Black;
                btn_Empleados.ForeColor = Color.White;
                btn_Empleados.BackColor = Color.Black;
                btnAdministrarVentas.ForeColor = Color.White;
                btnAdministrarVentas.BackColor = Color.Black;
                btn_Salir.ForeColor = Color.White;
                btn_Salir.BackColor = Color.Black;
            }
            else if (flagDarkMode)
            {
                flagDarkMode = false;
                lbl_Bienvenida.ForeColor = Color.Black;
                lbl_Nivel.ForeColor = Color.Black;
                this.BackgroundImage = Properties.Resources.mascotas;
                lbl_PetShop.ForeColor = Color.Black;
                lblUsuarioContra.ForeColor = Color.Black;
                btnLogear.ForeColor = Color.Black;
                btnLogear.BackColor = Color.White;
                btnAdmin.ForeColor = Color.Black;
                btnAdmin.BackColor = Color.White;
                btnLoguearVendedor.ForeColor = Color.Black;
                btnLoguearVendedor.BackColor = Color.White;
                btn_Venta.ForeColor = Color.Black;
                btn_Venta.BackColor = Color.White;
                btn_Stock.ForeColor = Color.Black;
                btn_Stock.BackColor = Color.White;
                btn_Empleados.ForeColor = Color.Black;
                btn_Empleados.BackColor = Color.White;
                btnAdministrarVentas.ForeColor = Color.Black;
                btnAdministrarVentas.BackColor = Color.White;
                btn_Salir.ForeColor = Color.Black;
                btn_Salir.BackColor = Color.White;
            }
        }
    }
}
