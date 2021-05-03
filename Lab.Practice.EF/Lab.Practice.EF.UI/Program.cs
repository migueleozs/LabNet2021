using Lab.Practice.EF.Entities;
using Lab.Practice.EF.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Practice.EF.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidad;
            int op;

            EmployeesLogic employeesLogic = new EmployeesLogic();
            ShippersLogic shippersLogic = new ShippersLogic();

            do
            {
                Console.WriteLine("\t******MENÚ******");
                Console.WriteLine("1. Consulta simple de las entidades Employees y Shippers");
                Console.WriteLine("2. Alta en la tabla Employees:");
                Console.WriteLine("3. Modificacion en la tabla Employees: (Id=4)");
                Console.WriteLine("4. Baja en la tabla Employees: (Id=4)");
                Console.WriteLine("5. Salir");
                op = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (op)
                {
                    case 1:
                        Console.WriteLine("\n------------------------------");
                        Console.WriteLine("Employees y Shippers");
                        Console.WriteLine("------------------------------\n");
                        employeesLogic.Print();
                        shippersLogic.Print();
                        Console.Clear();
                        break;
                    case 2:
                        Console.WriteLine("\n------------------------------");
                        Console.WriteLine("\nAlta en la tabla Employees");
                        Console.WriteLine("\n------------------------------\n");
                        employeesLogic.Add(new Employees
                        {
                            EmployeeID = 4,
                            LastName = "Sarasa",
                            FirstName = "Company"
                        });

                        employeesLogic.Print();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        Console.WriteLine("\n------------------------------");
                        Console.WriteLine("\nModificacion en la tabla Employees: (Id=4)");
                        Console.WriteLine("\n------------------------------\n");

                        employeesLogic.Update(new Employees
                        {
                            EmployeeID = 4,
                            LastName = "Zamudio",
                            FirstName = "Miguel"
                        });

                        employeesLogic.Print();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        Console.WriteLine("\n------------------------------");
                        Console.WriteLine("\nBaja en la tabla Employees: (Id=4)");
                        Console.WriteLine("\n------------------------------\n");
                        employeesLogic.Delete(30);
                        employeesLogic.Print();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 5:
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
            } while (op != 5);

            Console.ReadLine();

            // La tabla shipper tiene autoincrementar. Despues de crear el primer registro 4 no se repite.
        }
    }
}
