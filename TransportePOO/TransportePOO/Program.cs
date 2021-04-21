using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportePOO
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidad;
            int op;

            List<Transporte> transportes = new List<Transporte>
            {
                new Avion(100),
                new Avion(200),
                new Avion(150),
                new Avion(180),
                new Avion(250),
                new Automovil(2),
                new Automovil(4),
                new Automovil(4),
                new Automovil(2),
                new Automovil(8)

            };

            do
            {
                Console.WriteLine("\t******MENÚ******");
                Console.WriteLine("1. Ingresar nuevas cantidades de pasajeros");
                Console.WriteLine("2. Ver listado de pasajeros actual");
                Console.WriteLine("3. Consultar estado de un vehiculo");
                Console.WriteLine("4. Avanzar un vehiculo");
                Console.WriteLine("5. Detener un vehiculo");
                Console.WriteLine("6. Salir");
                op = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (op)
                {
                    case 1:
                        Console.WriteLine("\n------------------------------");
                        Console.WriteLine("ENTRADA DE DATOS");
                        Console.WriteLine("------------------------------\n");
                        for (int i = 0; i < 10; i++)
                        {
                            Console.WriteLine("Ingrese cantidad de pasajeros para el vehiculo " + (i+1));
                            cantidad = int.Parse(Console.ReadLine());
                            transportes[i].SetPasajeros(cantidad);
                            
                        }
                        Console.Clear();
                        break;
                    case 2:
                        Console.WriteLine("\n------------------------------");
                        Console.WriteLine("\nLISTADO DE PASAJEROS POR VEHICULO");
                        Console.WriteLine("\n------------------------------\n");
                        string tipo="Avion";
                        foreach (Transporte item in transportes)
                        {
                            if (item.ToString().Contains("Avion"))
                            {
                                tipo = "Avion";
                            }
                            else if (item.ToString().Contains("Automovil"))
                            {
                                tipo = "Automovil";
                            }
                            
                            Console.WriteLine("El vehiculo es un " + tipo + ", lleva " + item.GetPasajeros() + " Pasajeros.\n");
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        Console.WriteLine("\n------------------------------");
                        Console.WriteLine("\nSTATUS DE VEHICULOS");
                        Console.WriteLine("\n------------------------------\n");

                        Console.WriteLine("Ingrese el numero del vehiculo a consultar: ");
                        int x = int.Parse(Console.ReadLine());

                        Console.WriteLine(transportes[x].Status());

                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        Console.WriteLine("\n------------------------------");
                        Console.WriteLine("\nAVANZANDO VEHICULOS");
                        Console.WriteLine("\n------------------------------\n");

                        Console.WriteLine("Ingrese el numero del vehiculo que avanzara: ");
                        x = int.Parse(Console.ReadLine());

                        Console.WriteLine(transportes[x].Avanzar());

                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 5:
                        Console.WriteLine("\n------------------------------");
                        Console.WriteLine("\nDETENIENDO VEHICULOS");
                        Console.WriteLine("\n------------------------------\n");

                        Console.WriteLine("Ingrese el numero del vehiculo que se detendra: ");
                        x = int.Parse(Console.ReadLine());
                        Console.WriteLine(transportes[x].Detenerse());

                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 6:
                        Console.WriteLine("\n------------------------------");
                        Console.WriteLine("GRACIAS POR PREFERIRNOS");
                        Console.WriteLine("------------------------------\n");
                        break;
                    default:
                        Console.WriteLine("\n Escriba opción válida");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }



            } while (op != 6);


            Console.ReadLine();

        }
    }
}