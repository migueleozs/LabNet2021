using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp3_Excepcions
{
    class ExceptionPersonalizada : Exception
    {
        public ExceptionPersonalizada(string texto) : base("Esta es una excepcion personalizada")
        {
            Console.WriteLine(texto);
        }
    }
}
