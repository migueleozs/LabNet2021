using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp3_Excepcions
{
    class Logic
    {
        public static void ThrowException()
        {
            int numero = 0;
            if (numero == 0)
            {
                throw new Exception("Excepcion de prueba: se activa porque si");
            }
        }

        public static void ThrowExceptionPersonalizada()
        {
            int aux = 0;
            if (aux == 0)
            {  
                throw new ExceptionPersonalizada("Excepcion: Auxiliar vale cero \n");
            }
        }
    }
}
