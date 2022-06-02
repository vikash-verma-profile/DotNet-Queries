using ProductService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductService.Services
{
    public class ProductServiceImpl : IProductService
    {
        public List<Product> FindAll()
        {
            return new List<Product> {
                new Product{Id=1,Name="Product 1",Price=11.2},
                 new Product{Id=2,Name="Product 2",Price=67},
                  new Product{Id=3,Name="Product 3",Price=3},
                   new Product{Id=4,Name="Product 4",Price=9}

            };
        }
    }
}
