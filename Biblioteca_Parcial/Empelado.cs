using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Parcial
{
    public abstract class Empleado : Persona
    {
        int legajo;
        string usuario;
        string password;

        public Empleado(string nombre, string apellido, int dni, string usuario, string password) : base(nombre, apellido, dni)
        {
            this.legajo = PetShop.GenerarLegajo();
            this.usuario = usuario;
            this.password = password;
        }

        #region propiedades
        public int Legajo
        {
            get{return legajo;}
        }

        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        #endregion

        /// <summary>
        /// Implementacion del metodo abstracto de persona
        /// </summary>
        /// <returns>string con los datos del empleado</returns>
        public override string PersonaToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {this.Nombre}");
            sb.AppendLine($"Apellido: {this.Apellido}");
            sb.AppendLine($"Dni: {this.Dni}");
            sb.AppendLine($"Legajo: {this.Legajo}");
            sb.AppendLine($"Usuario: {this.Usuario}");

            return sb.ToString(); 
        }

        /// <summary>
        /// modifica los datos del empleado
        /// </summary>
        /// <param name="nombre">recibe el nombre</param>
        /// <param name="apellido">recibe el apellido</param>
        /// <param name="dni">recibe el dni</param>
        /// <param name="usuario">recibe el usuario</param>
        /// <param name="password">recibe la contraseña</param>
        /// <returns>retorna false si no pudo validar los parametros, true si logro modificar empleado</returns>
        public virtual bool ModificarDatos(string nombre, string apellido, int dni, string usuario, string password)
        {
            bool retorno = false;
            int auxDni = PetShop.LegajoConDni(dni);
            if (nombre != null && apellido != null && auxDni != -1 && usuario != null && password != null)
            {
                this.Nombre = nombre;
                this.Apellido = apellido;
                this.Dni = auxDni;
                this.Usuario = usuario;
                this.Password = password;

                retorno =  true;
            }

            return retorno;
        }
    }
}
