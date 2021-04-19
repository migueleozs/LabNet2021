using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp3_Excepcions
{
    class Program
    {
        static void Main(string[] args)
        {
            int dividendo, divisor;

            do
            {
                Console.WriteLine("Ingrese un numero como Dividendo");
                dividendo = ExceptionIni.ThrowExceptionFormato(Console.ReadLine());
            } while (dividendo == -9999);

            do
            {
                Console.WriteLine("Ingrese un numero como Divisor");
            divisor = ExceptionIni.ThrowExceptionFormato(Console.ReadLine());
            } while (divisor == -9999);

            ExceptionIni.ThrowExceptionIni(dividendo);

            ExceptionIni.ThrowExceptionDivision(dividendo, divisor);


            try
            {
                Logic.ThrowException();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + ". Es una excepcion de tipo: " + ex.GetType() + "\n");
            }

            try
            {
                Logic.ThrowExceptionPersonalizada();
            }
            catch (ExceptionPersonalizada ex)
            {
                Console.WriteLine("Es una excepcion de tipo: " + ex.GetType());
            }

            new ExceptionIni("Texto de sobrecarga... ");

            Console.Read();

        }
    }
}
