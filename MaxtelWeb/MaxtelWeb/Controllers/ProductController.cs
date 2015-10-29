using MaxtelWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MaxtelWeb.Controllers
{
    public class ProductController : ApiController
    {
        Product[] products = new Product[] {
            new Product { Id = 1, Name = "Soup", Price = 2.50M },
            new Product { Id = 2, Name = "Chocolate", Price = 1.25M }
        };

        public IEnumerable<Product> GetAllProducts() {
            return products;
        }

        public IHttpActionResult GetProduct(int id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);
            if (product == null) return NotFound();
            return Ok(product);
        }
    }
}
