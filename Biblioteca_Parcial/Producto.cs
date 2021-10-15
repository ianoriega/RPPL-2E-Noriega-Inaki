using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Parcial
{
    public class Producto
    {
        string marca;
        float precio;
        string descripcion;
        int codigo;
        int cantidad;
        float subtotal;
        float peso;


        public Producto()
        {

        }

        public Producto(bool aux, string marca, float precio, string descripcion, float peso) : this()
        {
            this.marca = marca;
            this.precio = precio;
            this.descripcion = descripcion;
            this.peso = peso;
            if (aux)
            {
                this.codigo = PetShop.GenerarCodigoProducto();
            }
        }

        public Producto(bool aux, string marca, float precio, string descripcion, int cantidad, float peso) : this(aux, marca,  precio,  descripcion, peso)
        {
            this.cantidad = cantidad;
            this.subtotal = precio * cantidad;
        }

        //Solo para harcodear
        public Producto(int codigo, string marca, float precio, string descripcion, int cantidad, float peso)
        {
            this.codigo = codigo;
            this.marca = marca;
            this.descripcion = descripcion;
            this.precio = precio;
            this.cantidad = cantidad;
            this.subtotal = precio * cantidad;
            this.peso = peso;
        }


        #region propiedades
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public float Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        public float Subtotal
        {
            get { return subtotal; }
            set { subtotal = value; }
        }

        public float Peso
        {
            get { return peso; }
            set { peso = value; }
        }
        #endregion

        /// <summary>
        /// Retorna los campos del producto en formato string
        /// </summary>
        /// <returns>cadena con los campos</returns>
        public string ProductoToString()
        {
            return $"Codigo: {this.Codigo}\nMarca: {this.Marca}\nDescripcion:\n{this.Descripcion}\nPrecio: ${this.Precio}\nStock: {this.cantidad}   Peso:{this.Peso}.";
        }




    }
}
