using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Parcial
{
    public class Compra
    {
        int numeroFactura; 
        int nroCliente;
        int legajoVendedor; 
        List<Producto> productosComprados;
        


        public Compra(int nroCliente, int legajoVendedor)
        {
            this.numeroFactura = PetShop.GenerarNumeroFactura();
            if (PetShop.ValidarCliente(nroCliente) != null)
                this.nroCliente = nroCliente;
            if (PetShop.ValidarEmpleado(legajoVendedor))
                this.legajoVendedor = legajoVendedor;
            productosComprados = new List<Producto>();
        }

        public Compra(int nroCliente, int legajoVendedor, Producto producto) : this(nroCliente, legajoVendedor)
        {
            productosComprados.Add(producto);
            this.nroCliente = nroCliente;
        }

        #region propiedades
        public int NumeroFactura
        {
            get { return numeroFactura; }
        }

        public int NumeroCliente
        {
            get { return nroCliente; }
        }

        public int LegajoVendedor
        {
            get { return legajoVendedor; }
        }

        public List<Producto> ProductosComprados
        {
            get { return productosComprados; }
        }
        #endregion


        /// <summary>
        /// agrega un producto a la lista de productos comprados en compra con su stock, resta el stock en el
        /// objeto producto original
        /// </summary>
        /// <param name="codigo">recibe el codigo del producto a comprar</param>
        /// <param name="cantidad">recibe la cantidad a comprar</param>
        /// <returns> retorno devuelve null si no pudo validar y el nuevo producto si pudo procesar</returns>
        public Producto AgregarProducto(int codigo, int cantidad)
        {
            Producto retorno = null;
            Producto producto;
            Producto auxProducto;
            if (PetShop.ValidarProducto(codigo) && cantidad > 0)
            {
                if (PetShop.ComprobarStock(codigo,cantidad))
                {
                    auxProducto = PetShop.ObtenerProducto(codigo);
                    producto = new Producto(false, auxProducto.Marca, auxProducto.Precio, auxProducto.Descripcion, cantidad);
                    productosComprados.Add(producto);
                    auxProducto.Cantidad -= cantidad;
                    producto.Codigo = auxProducto.Codigo;
                    retorno = producto;
                }
            }
            return retorno;
        }

        /// <summary>
        /// Permite calcular el valor total de la compra
        /// </summary>
        /// <returns>el valor de dicha compra</returns>
        public float CalcularTotalCompra()
        {
            float acumulador = 0;

            foreach (var item in productosComprados)
            {
                acumulador += (item.Precio * item.Cantidad);
            }

            return  acumulador;
        }


        /// <summary>
        /// Comprueba si un producto no esta cargado en la lista de productos
        /// </summary>
        /// <param name="codigo">recibe el codigo del producto a verificar</param>
        /// <returns>false si el producto no fue cargado y true si el producto ya esta cargado</returns>
        public bool ProductoCargado(int codigo)
        {
            bool retorno = false;
            foreach (var item in productosComprados)
            {
                if (item.Codigo == codigo)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }

        /// <summary>
        /// Permite obtener los datos de la compra
        /// </summary>
        /// <returns>sb a string con todos los datos</returns>
        public string CompraToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Numero de factura: {this.NumeroFactura}");
            sb.AppendLine($"Dni cliente: {this.NumeroCliente}");
            sb.AppendLine($"Legajo del vendedor: {this.LegajoVendedor}");
            sb.AppendLine("Productos:");
            foreach (var item in productosComprados)
            {
                sb.AppendLine(item.ProductoToString());
            }
            sb.AppendLine($"Total compra: {this.CalcularTotalCompra()}");

            return sb.ToString();
        }

        //Crear metodo Calculo de envio

    }
}
