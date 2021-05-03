using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab.Practice.EF.Data;
using Lab.Practice.EF.Entities;

namespace Lab.Practice.EF.Logic
{
    public class ShippersLogic:BasicLogic,IABMLogic<Shippers>
    {
 
        public List<Shippers> GetAll()
        {
                return context.Shippers.ToList();
        }

        public void Print()
        {
            Console.Write("Tabla Shipper:\n");
            Console.Write("ID - Nombre de Compania - Telefono\n");
            foreach (var item in GetAll())
            {
                Console.WriteLine($"{item.ShipperID} - {item.CompanyName} - {item.Phone}");
            }

            Console.WriteLine();
            Console.ReadLine();
        }

        public void Add(Shippers newShipper)
        {
            context.Shippers.Add(newShipper);

            context.SaveChanges();
        }

        public void Update(Shippers shippers)
        {
            var shippersUpdate = context.Shippers.Find(shippers.ShipperID);

            shippersUpdate.CompanyName = shippers.CompanyName;
            context.SaveChanges();
        }  
        
        public void Delete(int id)
        {
            var shipperAEliminar = context.Shippers.Find(id);

            context.Shippers.Remove(shipperAEliminar);

            context.SaveChanges();
        }

    }
}
