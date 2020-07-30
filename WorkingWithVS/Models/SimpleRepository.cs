using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkingWithVS.Models
{
    public class SimpleRepository
    {
        private static SimpleRepository sharedRepository = new SimpleRepository();
        private Dictionary<string, Product> products = new Dictionary<string, Product>();
        public static SimpleRepository SharedRepository => sharedRepository;//Where is area and methods
        public SimpleRepository()
        {
            var initalItem = new[]
            {
                new Product{Name="Kayak", Price=275M},
                new Product{Name="LifeJucet", Price=48.95M},
                new Product{Name="Soccer ball", Price=19.50M},
                new Product{Name="Corner flag", Price =34.95M}
            };
            foreach(var p in initalItem)
            {
                AddProduct(p);
            }
        }
        public IEnumerable<Product> Products => products.Values;
        public void AddProduct(Product p) => products.Add(p.Name, p);
    }
}
