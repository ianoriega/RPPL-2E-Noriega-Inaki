using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Parcial
{
    public class Cliente : Persona
    {
        float saldo;
        Queue<Compra> compras;
        int distancia;

        public Cliente()
        {

        }

        public Cliente(string nombre, string apellido, int dni, float saldo) : base(nombre, apellido, dni)
        {
            this.saldo = saldo;
            compras = new Queue<Compra>();
            this.distancia = CargarDistancia();
        }

        public Cliente(string nombre, string apellido, int dni, float saldo, Compra compra) : this(nombre, apellido, dni, saldo)
        {
            compras.Enqueue(compra);
        }

        public Cliente(Compra compra)
        {
            compras = new Queue<Compra>();
            this.distancia = CargarDistancia();
            compras.Enqueue(compra);
        }

        public float Saldo
        {
            get { return saldo; }
            set { this.saldo = value; }
        }

        public int Distancia
        {
            get { return distancia; }
        }

        public Queue<Compra> Compras
        {
            get { return compras; }
        }

        /// <summary>
        /// Recibe el objeto Compra y lo agrega en la lista de compras del cliente
        /// </summary>
        /// <param name="compra">recibe un objeto de clase compra</param>
        public bool AgregarCompra(Compra compra)
        {
            return this + compra;
        }


        public static bool operator +(Cliente cliente, Compra compra)
        {
            cliente.compras.Enqueue(compra);
            return true;
        }

        public static explicit operator Cliente(Compra compra)
        {
            Cliente aux = new Cliente(compra);
            aux.Nombre = "Juan";
            aux.Apellido = "Poroto";
            aux.Dni = 14352465;
            aux.Saldo = 10000;
            return aux;
        }


        /// <summary>
        /// implemenacion del metodo abstracto persona to string
        /// </summary>
        /// <returns>retorna datos del cliente</returns>
        public override string PersonaToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {this.Nombre}");
            sb.AppendLine($"Apellido: {this.Apellido}");
            sb.AppendLine($"Dni: {this.Dni}");
            sb.AppendLine($"Saldo: {this.Saldo}");

            return sb.ToString();
        }

        /// <summary>
        /// permite modificar algunos datos del cliente
        /// </summary>
        /// <param name="nombre">recibe el nombre</param>
        /// <param name="apellido">recibe el apellido</param>
        /// <param name="saldo">recibe el saldo</param>
        /// <returns>retorna false si no pudo validar datos, true si pudo operar</returns>
        public bool ModificarDatos(string nombre, string apellido, float saldo)
        {
            bool retorno = false;

            if (nombre != null && apellido != null && saldo >= 0)
            {
                this.Apellido = apellido;
                this.Nombre = nombre;
                this.Saldo = saldo;
                retorno = true;
            }

            return retorno;
        }

        /// <summary>
        /// permite obtener un array de compras del cliente
        /// </summary>
        /// <returns>retorna array del tipo Compra[]</returns>
        public Compra[] ObtenerCompras()
        {
            return compras.ToArray();
        }


        /// <summary>
        /// Crea un numero aleatorio para la distancia a la vivienda del cliente
        /// </summary>
        /// <returns>int return el numero creado menor a 51</returns>
        int CargarDistancia()
        {
            Random kms = new Random();
            return kms.Next(51);
        }

        
    }
}
