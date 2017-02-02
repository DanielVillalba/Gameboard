using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Gameboard.Models;

namespace Gameboard.Repositories
{
    //Isolate the EntityFramework based Data Access Layer from
    //the MVC Controller class
    public class ProductRepository : IRepository<Models.Product, int>
    {
        [Dependency]
        public DBAccess.ApplicationEntities context { get; set; }

        IEnumerable<Product> IRepository<Product, int>.Get()
        {
            return context.CompleteProductsList();
        }

        Product IRepository<Product, int>.Get(int id)
        {
            return context.FindProduct(id);
        }

        void IRepository<Product, int>.Add(Product entity)
        {
            context.AddProduct(entity);
        }

        void IRepository<Product, int>.Remove(Product entity)
        {
            context.RemoveProduct(entity.Id);
        }
    }
}