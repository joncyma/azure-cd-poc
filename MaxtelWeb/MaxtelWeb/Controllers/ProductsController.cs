using MaxtelWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MaxtelWeb.Controllers
{
    public class ProductsController : ApiController
    {
        Product[] products = new Product[]
        {
            new Product { Id = 1, Name = "Tomato Soup", Price = 2.50M },
            new Product { Id = 2, Name = "Chicken Soup", Price = 1.25M }
        };
        // GET: api/Products
        public IEnumerable<Product> Get()
        {
            return products;
        }

        // GET: api/Products/5
        public IHttpActionResult Get(int id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
                return NotFound();
                    
            return Ok(product);
        }
    }
}
