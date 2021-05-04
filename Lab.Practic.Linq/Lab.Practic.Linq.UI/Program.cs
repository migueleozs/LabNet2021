using Lab.Practic.Linq.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Practic.Linq.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            
            CustomersLogic customersLogic = new CustomersLogic();
  
            ProductsLogic productsLogic = new ProductsLogic();

            Console.Write("Tabla Customers:\n");
            Console.Write("Id - Nombre de la Compania\n");
            foreach (var item in customersLogic.GetAll())
            {
                Console.WriteLine($"{item.CustomerID} - {item.CompanyName}");
            }
            Console.WriteLine();
            Console.ReadLine();


            Console.Write("Tabla Products:\n");
            Console.Write("Id - Nombre del Producto\n");
            foreach (var item in productsLogic.NoStock())
            {
                Console.WriteLine($"{item.ProductID} - {item.ProductName}");
            }

            Console.WriteLine();
            Console.ReadLine();


            Console.Write("Tabla Products:\n");
            Console.Write("Id - Nombre del Producto\n");
            foreach (var item in productsLogic.Morethanthree())
            {
                Console.WriteLine($"{item.ProductID} - {item.ProductName}");
            }

            Console.WriteLine();
            Console.ReadLine();


            Console.Write("Tabla Customers:\n");
            Console.Write("Id - Nombre de la Compania\n");
            foreach (var item in customersLogic.WAcustomers())
            {
                Console.WriteLine($"{item.CustomerID} - {item.CompanyName}");
            }
            Console.WriteLine();
            Console.ReadLine();



            Console.Write("Tabla Products:\n");
            Console.Write("Id - Nombre del Producto\n");
            try
            {
                var productToPrint = productsLogic.FirstOrNull();
                Console.WriteLine($"{productToPrint.ProductID} - {productToPrint.ProductName}");
            }
            catch (Exception)
            {
                Console.WriteLine("Null  -  Null");

            }
            Console.WriteLine();
            Console.ReadLine();

            Console.Write("Tabla Customers:\n");
            Console.Write("Nombre del Customer\n");
            foreach (var item in customersLogic.CustomersNames())
            {
                Console.WriteLine($"{item.ToUpper()}");
                Console.WriteLine($"{item.ToLower()}");
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
