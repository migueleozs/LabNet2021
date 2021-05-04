using Lab.Practic.Linq.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Practic.Linq.Logic
{
    public class OrdersLogic : BasicLogic, IABMLogic<Orders>
    {
         public List<Orders> GetAll()
        {
            return context.Orders.ToList();
        }
        /*
        public List<Orders> JoinCustomer()
        {
            var innerJoin = from orders in Orders // outer sequence
                            join customer in Customers //inner sequence 
                            on orders.CustomerID equals customer.CustomerID // key selector 
                            select new
                            {};
        }*/

        public void Add(Orders newOrders)
        {
            context.Orders.Add(newOrders);

            context.SaveChanges();
        }
        public void Update(Orders employees)
        {
            throw new NotImplementedException();
        }
        public void Delete(int id)
        {
            var ordersToDelete = context.Orders.Find(id);

            context.Orders.Remove(ordersToDelete);

            context.SaveChanges();
        }

    }
}
