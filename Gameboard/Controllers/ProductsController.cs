using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Gameboard.Models;
using Gameboard.Repositories;

namespace Gameboard.Controllers
{
    public class ProductsController : Controller
    {
        IRepository<Product, int> _repo;

        public ProductsController(IRepository<Product, int> repo)
        {
            _repo = repo;
        }

        // GET: Products
        public ActionResult Index()
        {
            Product test = _repo.Get(2);
            return Content(test.Name);
        }

    }
}