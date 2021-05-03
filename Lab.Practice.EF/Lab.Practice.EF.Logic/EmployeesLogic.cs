using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab.Practice.EF.Data;
using Lab.Practice.EF.Entities;
    
namespace Lab.Practice.EF.Logic
{
    public class EmployeesLogic:BasicLogic, IABMLogic<Employees>
    {
       
        public List<Employees> GetAll()
        {
            return context.Employees.ToList();
        }
        public void Print()
        {
            Console.Write("Tabla Employee:\n");
            Console.Write("Id - Nombre - Apellido\n");
            foreach (var item in GetAll())
            {
                Console.WriteLine($"{item.EmployeeID} - {item.FirstName} - {item.LastName}");
            }
   
            Console.WriteLine();
            Console.ReadLine();
        }
        public void Add(Employees newEmployee)
        {
            context.Employees.Add(newEmployee);

            context.SaveChanges();
        }

        public void Update(Employees employees)
        {
            var employeeUpdate = context.Employees.Find(employees.EmployeeID);

            employeeUpdate.FirstName = employees.FirstName;
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var employeesAEliminar = context.Employees.Find(id);

            context.Employees.Remove(employeesAEliminar);

            context.SaveChanges();
        }

    }
}
