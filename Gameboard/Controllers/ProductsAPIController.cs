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

        //[DefaultConstructor]
        public ProductsAPIController()
        {
        }

        IRepository<Product, int> _Repository;
        ProductsAPIController(IRepository<Product, int> repository)
        {
            _Repository = repository;
        }

        // retrieving all the products
        [ResponseType(typeof(Product))]
        public IHttpActionResult Get()
        {
            // test data JSON object
            Product test = new Product
            {
                Id = 1,
                Name = "Test JSON object",
                Description = "Test description",
                Company = "Mock Data",
                AgeRestriction = 15,
                Price = 10.5m
            };
            //var test = _Repository.Get();    
            return this.Ok(test);
        }
    }
}
