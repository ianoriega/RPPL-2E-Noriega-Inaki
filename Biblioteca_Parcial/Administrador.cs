using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Parcial
{
    public class Administrador : Empleado
    {
        public Administrador(string nombre, string apellido, int dni, string usuario, string password) : base(nombre, apellido, dni, usuario, password)
        {

        }

        /// <summary>
        /// Permite crear un administrador
        /// </summary>
        /// <param name="nombre">recibe nombre</param>
        /// <param name="apellido">recibe apellido</param>
        /// <param name="dni">recibe dni</param>
        /// <param name="usuario">recibe usuario</param>
        /// <param name="password">recibe password</param>
        public void CrearAdministrador(string nombre, string apellido, int dni, string usuario, string password)
        {
            Administrador auxAdmin = new Administrador(nombre, apellido, dni, usuario, password);
            PetShop.AgregarEmpleado(auxAdmin);
        }

        /// <summary>
        /// Permite crear un objeto de clase vendedor y agregarlo a la lista de empleados
        /// </summary>
        /// <param name="nombre">recibe nombre</param>
        /// <param name="apellido">recibe el apellido </param>
        /// <param name="dni">recibe el dni</param>
        /// <param name="usuario">recibe el usuario</param>
        /// <param name="password">recibe la contraseña</param>
        public void CrearVendedor(string nombre, string apellido, int dni, string usuario, string password)
        {
            Vendedor auxVendedor = new Vendedor(nombre, apellido, dni, usuario, password);
            PetShop.AgregarEmpleado(auxVendedor);
        }

        /// <summary>
        /// permite modificar datos de un cliente
        /// </summary>
        /// <param name="cliente">recibe el objeto a modificar</param>
        /// <param name="nombre">recibe el nuevo nombre</param>
        /// <param name="apellido">recibe el nuevo apellido</param>
        /// <param name="saldo">recibe el nuevo saldo</param>
        /// <returns></returns>
        public bool ModificarCliente(Cliente cliente, string nombre, string apellido, float saldo)
        {
            return cliente.ModificarDatos(nombre, apellido, saldo);
        }

    }
}
