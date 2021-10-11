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
    public partial class FrmEmpleados : Form
    {
        Administrador usuario;
        bool flagAlta = false;
        bool flagBaja = false;
        bool flagModi = false;
        Empleado[] empleados;
        Empleado empleado;
        bool flagVendedor = false;
        bool flagAdmin = false;
        enum roles {Administrador, Vendedor}; 
    

        public FrmEmpleados()
        {
            InitializeComponent();
        }

        public FrmEmpleados(Empleado empleado) : this()
        {
            this.usuario = (Administrador)empleado;
        }

        private void FrmEmpleados_Load(object sender, EventArgs e)
        {
            lblBienvenida.Text = $"Bienvenido: {usuario.Nombre} {usuario.Apellido}";
            empleados = PetShop.ObtenerArrayEmpleados();
            foreach (var item in empleados)
            {
                cmbEmpleados.Items.Add($"{item.Nombre} {item.Apellido}");
            }

        }

        public void MostrarCamposEmpleado()
        {
            btnCrearAdmin.Show();
            btnCrearVendedor.Show();
            txtEmpleadoNombre.Show();
            txtEmpleadoApellido.Show();
            txtEmpleadoDni.Show();
            txtEmpleadoUsuario.Show();
            txtEmpleadoPassword.Show();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            flagAlta = true;
            btnBaja.Enabled = false;
            btnModificacion.Enabled = false;
            this.MostrarCamposEmpleado();
            lblAccion.Text = "Crear empleado";
            lblAccion.Show();
            btnConfirmar.Show();
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            flagBaja = true;
            btnAlta.Enabled = false;
            btnModificacion.Enabled = false;
            lblSeleccionarEmpleado.Show();
            cmbEmpleados.Show();
        }

        private void btnModificacion_Click(object sender, EventArgs e)
        {
            flagModi = true;
            btnAlta.Enabled = false;
            btnBaja.Enabled = false;
            lblSeleccionarEmpleado.Show();
            cmbEmpleados.Show();
        }

        private void btnCrearAdmin_Click(object sender, EventArgs e)
        {
            btnCrearVendedor.Enabled = false;
            flagAdmin = true;
        }

        private void btnCrearVendedor_Click(object sender, EventArgs e)
        {
            btnCrearAdmin.Enabled = false;
            flagVendedor = true;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            txtEmpleadoNombre.Text.Trim();
            txtEmpleadoApellido.Text.Trim();
            txtEmpleadoDni.Text.Trim();
            txtEmpleadoUsuario.Text.Trim();
            txtEmpleadoPassword.Text.Trim();

            if (flagBaja)
            {
                if (empleado.Legajo != usuario.Legajo)
                {
                    if (PetShop.EliminarEmpleado(empleado))
                    {
                        lblInfoEmpleado.Text = "Empleado eliminado";
                        lblInfoEmpleado.ForeColor = Color.Green;
                    }
                    else
                    {
                        lblInfoEmpleado.Text = "Error al eliminar el empleado";
                        lblInfoEmpleado.ForeColor = Color.Red;
                    }
                }
                else
                {
                    lblInfoEmpleado.Text = "Error, no puede eliminarse a si mismo";
                    lblInfoEmpleado.ForeColor = Color.Red;
                }

            }
            else if (!String.IsNullOrEmpty(txtEmpleadoNombre.Text)   && txtEmpleadoNombre.Text.All(char.IsLetter)      &&
                     !String.IsNullOrEmpty(txtEmpleadoApellido.Text) && txtEmpleadoApellido.Text.All(char.IsLetter)    &&
                     !String.IsNullOrEmpty(txtEmpleadoDni.Text)      && txtEmpleadoDni.Text.All(char.IsDigit)          &&
                     !String.IsNullOrEmpty(txtEmpleadoUsuario.Text)  && !String.IsNullOrEmpty(txtEmpleadoPassword.Text)   )
            {
                if (flagAlta)
                {
                    if (flagAdmin)
                    {
                        usuario.CrearAdministrador(txtEmpleadoNombre.Text, txtEmpleadoApellido.Text, int.Parse(txtEmpleadoDni.Text),
                                                                                txtEmpleadoUsuario.Text, txtEmpleadoPassword.Text);
                        lblInfoEmpleado.Text = "Empleado Creado";
                        lblInfoEmpleado.ForeColor = Color.Green;
                        lblInfoEmpleado.Show();
                    }
                    else if (flagVendedor)
                    {
                        usuario.CrearVendedor(txtEmpleadoNombre.Text, txtEmpleadoApellido.Text, int.Parse(txtEmpleadoDni.Text),
                                                                            txtEmpleadoUsuario.Text, txtEmpleadoPassword.Text);
                        lblInfoEmpleado.Text = "Empleado Creado";
                        lblInfoEmpleado.ForeColor = Color.Green;
                        lblInfoEmpleado.Show();
                    }
                }
                else if (flagModi)
                {
                    empleado.ModificarDatos(txtEmpleadoNombre.Text, txtEmpleadoApellido.Text, int.Parse(txtEmpleadoDni.Text),
                                                                          txtEmpleadoUsuario.Text, txtEmpleadoPassword.Text);
                    lblInfoEmpleado.Text = "Empleado Modificado";
                    lblInfoEmpleado.ForeColor = Color.Green;
                    lblInfoEmpleado.Show();
                }

            }
            else
            {
                lblInfoEmpleado.Text = "Error. Datos incorrectos";
                lblInfoEmpleado.ForeColor = Color.Red;
                lblInfoEmpleado.Show();
            }
        }

        private void cmbEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbEmpleados.SelectedIndex != -1)
            {
                empleado = empleados[cmbEmpleados.SelectedIndex];
                lblInfoEmpleado.Text = empleado.PersonaToString();
                lblInfoEmpleado.Show();
                btnConfirmar.Show();
                if (flagBaja)
                {
                    lblAccion.Text = "Eliminar empleado";
                    lblAccion.Show();
                }
                else if (flagModi)
                {
                    lblAccion.Text = "Modificar empleado";
                    lblAccion.Show();
                    MostrarCamposEmpleado();
                    btnCrearAdmin.Hide();
                    btnCrearVendedor.Hide();
                }

                
            }
        }

        private void lblAccion_Click(object sender, EventArgs e)
        {

        }
    }
}
