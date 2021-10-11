using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Parcial
{
    public abstract class Persona
    {
        string nombre;
        string apellido;
        int dni;

        public Persona(string nombre, string apellido, int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
        }

        #region propiedades
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }

        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public int Dni
        {
            get { return dni; }
            set { dni = value; }
        }
        #endregion

        /// <summary>
        /// Metodo abstracto a ser implementado
        /// </summary>
        /// <returns>retorna un string</returns>
        public abstract string PersonaToString();

       
    }
}
