using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Parcial
{
    public class ClienteSinDineroExcepcion : Exception
    {
        public ClienteSinDineroExcepcion(string mensaje) : base(mensaje)
        {

        }
    }
}
