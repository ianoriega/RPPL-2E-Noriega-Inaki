using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Biblioteca_Parcial;

namespace Primer_Parcial_Labo2
{
    public partial class Frm_Factura : Form
    {
        Cliente cliente;
        Compra compra;
        public Frm_Factura()
        {
            InitializeComponent();
        }

        public Frm_Factura(Cliente cliente,Compra compra) : this()
        {
            this.cliente = cliente;
            this.compra = compra;
        }

        private void Frm_Factura_Load(object sender, EventArgs e)
        {
            lblDatos.Text = "Pet Shop S.A.\nCUIT Nro: 30-68731043-4\nInicio Actividad Comercial: 30/09/2021\n" +
                            "ORIENTACION AL CONSUMIDOR\nC.A.B.A.\n0.800-666-1518\nIVA RESPONSABLE INSCRIPTO\n" ;
            lblDatos2.Text = "     ORIGINAL\nFACTURA X (Cod.007)";
            lblFecha.Text = $"P.V. Nro.: 0001\nFecha { DateTime.Now.ToShortDateString()}\nCaja 0001";
            lblFactura.Text = $"Nro Factura: {compra.NumeroFactura}\nHora: {DateTime.Now.ToShortTimeString()}\nVendedor: {compra.LegajoVendedor}";
            foreach (var item in compra.ProductosComprados)
            {
                if (item != null)
                {
                    lblDetalleMarca.Text += $"\n{item.Marca}";
                    lblDetalleDescripcion.Text += $"\n{item.Descripcion}";
                    lblDetallePrecio.Text += $"\n{item.Precio}";
                    lblDetalleCant.Text += $"\n{item.Cantidad}";
                    lblDetalleTotal.Text += $"\n{item.Subtotal}";
                }
            }
            lblTotalCompra.Text += $"{compra.CalcularTotalCompra()}";
        
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(lblDatos.Text);
            sb.AppendLine(lblDatos2.Text);
            sb.AppendLine(lblFecha.Text);
            sb.AppendLine(lblFactura.Text);
            foreach (var item in compra.ProductosComprados)
            {
                if (item != null)
                {
                    sb.AppendLine(lblDetalleMarca.Text + lblDetalleDescripcion.Text + lblDetallePrecio.Text + 
                                                                   lblDetalleCant.Text + lblDetalleTotal.Text);
                }
            }

            StreamWriter texto = new StreamWriter($"C:\\Users\\Iñaki\\Desktop\\{compra.NumeroFactura}.txt");
            texto.Write(sb.ToString());
            texto.Close();
            MessageBox.Show("Archivo creado");
            this.Close();
        }
    }
}
