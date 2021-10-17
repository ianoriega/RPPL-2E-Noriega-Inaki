using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Parcial
{
    public static class PetShop
    {
        static int legajo = 0;
        static int numeroFactura = 0;
        static int codigoProducto = 0;
        static List<Empleado> empleados = new List<Empleado>();
        static List<Cliente> clientes = new List<Cliente>();
        static List<Producto> productos = new List<Producto>();

        static PetShop() 
        {
            empleados = new List<Empleado>();
            clientes = new List<Cliente>();
            productos = new List<Producto>();

            empleados.Add(new Administrador("Administrador", "Default", 11111111, "admin","admin"));
            empleados.Add(new Vendedor("vendedor", "vendedor", 23123123, "vendedor", "vendedor"));
            empleados.Add(new Vendedor("Leonel", "Messi", 12312312, "leomessi", "luissuarezteamo"));

            productos.Add(new Producto(true, "PerritosYa", 1500, "Cama perrito grande", 50, 10));
            productos.Add(new Producto(true, "PerritosYa", 1200, "Cama perrito chico", 50, 7));
            productos.Add(new Producto(true, "Power", 700, "Pipeta anti pulgas", 50, (float)0.1));
            

            clientes.Add( (Cliente)(new Compra(14352465,1,new Producto(1, "PerritosYa", 1500, "Cama perrito grande", 5, 5))));

        }

        /// <summary>
        /// Metodo estatico que genera un legajo incremental
        /// </summary>
        /// <returns>retorna el legajo creado</returns>
        public static int GenerarLegajo()
        {
            legajo++;
            return legajo;
        }

        /// <summary>
        /// Metodo estatico que genera un numero de factura incremental
        /// </summary>
        /// <returns>retorna el numero de factura creado</returns>
        public static int GenerarNumeroFactura()
        {
            numeroFactura++;
            return numeroFactura;
        }

        /// <summary>
        /// Metodo que genera un codigo de producto incremental
        /// </summary>
        /// <returns>retorna el codigo de producto creado</returns>
        public static int GenerarCodigoProducto()
        {
            codigoProducto++;
            return codigoProducto;
        }

        /// <summary>
        /// Permite agregar un empleado a la lista de empleados
        /// </summary>
        /// <param name="empleado">el objeto empleado a agregar</param>
        public static void AgregarEmpleado(Empleado empleado)
        {
            empleados.Add(empleado);
        }

        /// <summary>
        /// Permite agregar un cliente a la lista de clientes
        /// </summary>
        /// <param name="cliente">el objeto cliente a agregar</param>
        public static void AgregarCliente(Cliente cliente)
        {
            clientes.Add(cliente);
        }

        /// <summary>
        /// Permite agregar un producto a la lista de productos
        /// </summary>
        /// <param name="producto">el objeto producto a agregar</param>
        public static void AgrearProducto(Producto producto)
        {
            productos.Add(producto);
        }

        /// <summary>
        /// Remueve un producto de la lista de productos
        /// </summary>
        /// <param name="producto">recibe el objeto a remover</param>
        /// <returns>true si pudo remover, false si no pudo</returns>
        public static bool EliminarProducto(Producto producto)
        {
            return productos.Remove(producto);
        }

        /// <summary>
        /// Recibe un numero de dni y confirma que el cliente exista en la lista cliente
        /// </summary>
        /// <param name="dni">recibe el dni a validar</param>
        /// <returns>retorno devuelve cliente si valido y null si no encontro al cliente</returns>
        public static Cliente ValidarCliente(int dni)
        {
            Cliente retorno = null;
            for (int i = 0; i < clientes.Count; i++)
            {
                if (clientes[i].Dni == dni)
                {
                    retorno = clientes[i];
                    break;
                }
            }
            return retorno;
        }

        /// <summary>
        /// Recibe el numero de legajo del empleado y confirma si existe en la lista de empleados
        /// </summary>
        /// <param name="legajo">recibe el legajo a validar</param>
        /// <returns>retorno devuelve true si encontro el legajo en la lista y false si no lo encontro</returns>
        public static bool ValidarEmpleado(int legajo)
        {
            bool retorno = false;
            for (int i = 0; i < empleados.Count; i++)
            {
                if (empleados[i].Legajo == legajo)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }

        /// <summary>
        /// recibe un dni y lo busca en la lista de empleados para retornar el legajo del empleado
        /// </summary>
        /// <param name="dni">recibe el dni del empleado</param>
        /// <returns>-1 si no encontro el empleado o bien su legajo</returns>
        public static int LegajoConDni(int dni)
        {
            int retorno = -1;

            foreach (var item in empleados)
            {
                if (item.Dni == dni)
                {
                    retorno = item.Legajo;
                }
            }

            return retorno;
        }

        /// <summary>
        /// Valida que un producto exista en la lista de productos
        /// </summary>
        /// <param name="codigo">recibe el codigo del producto a validar</param>
        /// <returns>retorno retorna true si encontro el producto y false si no valido</returns>
        public static bool ValidarProducto(int codigo)
        {
            bool retorno = false;
            for (int i = 0; i < productos.Count; i++)
            {
                if (productos[i].Codigo == codigo)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }

        /// <summary>
        /// recibe el codigo de un produto y retorna el producto
        /// </summary>
        /// <param name="codigo">recibe el codigo del producto</param>
        /// <returns>el producto obtenido o bien null si no pudo retornar</returns>
        public static Producto ObtenerProducto(int codigo)
        {
            Producto retorno=null;
            foreach (Producto item in productos)
            {
                if (item.Codigo == codigo)
                {
                    retorno = item;
                    break;
                }
            }
            return retorno;
        }

        /// <summary>
        /// Retorna una copia de la lista en forma de array
        /// </summary>
        /// <returns>array de productos</returns>
        public static Producto[] ObtenerArrayDeProductos()
        {
            return productos.ToArray();
        }


        /// <summary>
        /// recibe un usuario y contraseña y los compara con los datos de la lista de empleados
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="password"></param>
        /// <returns>retorno = objeto Empleado si logro validar / null si no pudo validar</returns>
        public static Empleado LoguearUsuario(string usuario, string password)
        {
            Empleado retorno = null;

            foreach (var item in empleados)
            {
                if (item.Usuario == usuario && item.Password == password)
                {
                    retorno = item;
                    break;
                }
            }
            return retorno;
        }

        /// <summary>
        /// Permite conocer si un producto tiene stock suficiente para realiar una  venta
        /// </summary>
        /// <param name="codigo">Recibe el codigo del producto</param>
        /// <param name="cantidad">Recibe la cantidad acomprobar</param>
        /// <returns>true si pudo validar, false si no pudo validar o no alcanza el stock</returns>
        public static bool ComprobarStock(int codigo, int cantidad)
        {
            bool retorno = false;

            foreach (var item in productos)
            {
                if (item.Codigo == codigo)
                {
                    if (item.Cantidad >= cantidad)
                    {
                        retorno = true;
                    }
                }
            }
            return retorno;
        }


        /// <summary>
        /// Permite obtener un array a partir de la lista de empleados
        /// </summary>
        /// <returns>retorna array de empleados</returns>
        public static Empleado[] ObtenerArrayEmpleados()
        {
            return empleados.ToArray();
        }


        /// <summary>
        /// Permite borrar un empleado de la lista
        /// </summary>
        /// <param name="empleado">empleado recibe el objeto a eliminar</param>
        /// <returns>true si pudo eliminar, false si no pudo</returns>
        public static bool EliminarEmpleado(Empleado empleado)
        {
           return empleados.Remove(empleado);
        }


        /// <summary>
        /// Permite obtener un array a partir de la lista de clientes
        /// </summary>
        /// <returns>array del tipo Cliente[]</returns>
        public static Cliente[] ObtenerArrayClientes()
        {
            return clientes.ToArray();
        }

    }
}
