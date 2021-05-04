using Lab.Practic.Linq.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Practic.Linq.Logic
{
    public class CustomersLogic : BasicLogic, IABMLogic<Customers>
    {
        Customers customer = new Customers();

        public List<Customers> GetAll()
        {
            return context.Customers.ToList();
        }
        public List<Customers> WAcustomers()
        {
            return context.Customers.Where(c => c.Region == "WA").ToList();
        }
        public List<string> CustomersNames()
        {
            var nombresMayuscula = (from customer in context.Customers
                                    select customer.ContactName).ToList();
            return nombresMayuscula;
        }

        public void Add(Customers newCustomer)
        {
            context.Customers.Add(newCustomer);

            context.SaveChanges();
        }

        public void Update(Customers employees)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            var customersToDelete = context.Customers.Find(id);

            context.Customers.Remove(customersToDelete);

            context.SaveChanges();
        }
    }
}
