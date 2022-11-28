using Domain;
using Infraestructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class ProductService
    {
        public List<Product> Get()
        {
            using (var context = new ExampleContext())
            {
                return context.Product.Where(x => x.IsEnable == true).ToList();
            }
        }
        public Product GetById(int id)
        {
            using (var context = new ExampleContext())
            {
                return context.Product.Find(id);
            }
        }


        public void Insert(Product product)
        {
            using (var context = new ExampleContext())
            {

                product.IsEnable = true;
                product.CreatedON = DateTime.Today;
                context.Product.Add(product);
                context.SaveChanges();
            }
        }

    }
}
