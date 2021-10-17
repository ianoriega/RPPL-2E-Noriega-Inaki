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
    public partial class FrmFacturacion : Form
    {
        Cliente[] clientes;
        StringBuilder sb;
        Compra[] auxCompras;
        public FrmFacturacion()
        {
            InitializeComponent();
        }

        private void FrmFacturacion_Load(object sender, EventArgs e)
        {
            clientes = PetShop.ObtenerArrayClientes();
            sb = new StringBuilder();
            foreach (var item in clientes)
            {
                sb.AppendLine($"Cliente: {item.Nombre} {item.Apellido} ------------------");
                auxCompras = item.ObtenerCompras();
                foreach (var compra in auxCompras)
                {
                    sb.AppendLine(compra.CompraToString());
                }
            }
            rtbFacturacion.Text = sb.ToString();
        }

        private void btnClienteMejor_Click(object sender, EventArgs e)
        {
            Cliente aux = PetShop.ObtenerMejorCliente();
            lblMejor.Text = aux.PersonaToString();
            lblMejor.Show();
        }

        private void btnVendedorMejor_Click(object sender, EventArgs e)
        {
            Empleado aux = PetShop.ObtenerMejorEmpleado();
            lblMejor.Text = aux.PersonaToString();
            lblMejor.Show();
        }
    }
}
