using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp3_Excepcions
{
    class ExceptionIni : Exception
    {
        public ExceptionIni(string texto) : base("Mensaje de error inicial")
        {
            Console.WriteLine("\n" + texto + base.Message);
        }

        public static void ThrowExceptionIni(int dividendo)
        {
            try
            {
                Console.WriteLine(dividendo.Division(0));
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("\nMensaje de la excepcion: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Operacion finalizada.\n");
            }
        }

        public static void ThrowExceptionDivision(int dividendo, int divisor)
        {
            try
            {
                Console.WriteLine("El resultado de la division es: " + dividendo.Division(divisor) +"\n");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Solo Chuck Norris divide por cero! " + ex.Message);
            }
        }

        public static int ThrowExceptionFormato(string entrada)
        {
            
            try
            {
                int numero = int.Parse(entrada);
                return numero;
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Seguro Ingreso una letra o no ingreso nada! ");
                return -9999;
            }
        }

    }
}
