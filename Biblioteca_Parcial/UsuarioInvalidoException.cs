using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Parcial
{
    public class UsuarioInvalidoException : Exception
    {
        public UsuarioInvalidoException(string cadena) : base(cadena)
        {

        }
    }
}
