using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using System.Threading;
using System.Threading.Tasks;
using System.Web.Http.Description;
using Gameboard.Models;
using Gameboard.Repositories;
using Newtonsoft.Json;

namespace Gameboard.Controllers
{
    public class ProductsAPIController : ApiController
    {
        IRepository<Product, int> _repo;
        public ProductsAPIController(IRepository<Product, int> repo)
        {
            _repo = repo;
        }

        // retrieving all the products
        [ResponseType(typeof(Product))]
        public IHttpActionResult Get()
        {
            var test = _repo.Get();    
            return this.Ok(test);
        }

        [ResponseType(typeof(Product))]
        public IHttpActionResult PostProduct(Product product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _repo.Add(product);
            return CreatedAtRoute("DefaultApi", new { id = product.Id }, product);
        }


        // DELETE: api/Products1/5
        [ResponseType(typeof(Product))]
        public IHttpActionResult DeleteProduct(int id)
        {
            Product product = _repo.Get().First(x => x.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            _repo.Remove(product);

            return Ok(product);
        }
    }
}
