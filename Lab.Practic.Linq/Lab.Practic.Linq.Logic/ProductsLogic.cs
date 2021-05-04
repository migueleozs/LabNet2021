using Lab.Practic.Linq.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Practic.Linq.Logic
{
    public class ProductsLogic : BasicLogic, IABMLogic<Products>
    {
        public List<Products> GetAll()
        {
            return context.Products.ToList();
        }
        public List<Products> NoStock()
        {
            return context.Products.Where(p => p.UnitsInStock == 0).ToList();
        }

        public List<Products> Morethanthree()
        {
            return context.Products.Where(p => p.UnitsInStock != 0 && p.UnitPrice > 3).ToList();
        }
        public Products FirstOrNull()
        {
            int id = 789;
            return context.Products.FirstOrDefault(p => p.ProductID == id);
        }
        public void Add(Products newProducts)
        {
            context.Products.Add(newProducts);

            context.SaveChanges();
        }

        public void Update(Products employees)
        {
            throw new NotImplementedException();
        }        
        public void Delete(int id)
        {
            var productsToDelete = context.Products.Find(id);

            context.Products.Remove(productsToDelete);

            context.SaveChanges();
        }
    }
}
