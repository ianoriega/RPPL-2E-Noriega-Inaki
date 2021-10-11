using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Parcial
{
    public class Vendedor : Empleado
    {
        public Vendedor(string nombre, string apellido, int dni, string usuario, string password) : base(nombre, apellido, dni, usuario, password)
        {

        }
    }
}
