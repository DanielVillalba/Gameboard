using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Gameboard;
using Gameboard.Controllers;
using Gameboard.Repositories;
using Gameboard.Models;

namespace Gameboard.Tests.Controllers
{
    [TestClass]
    public class ProductsControllerTest
    {
        IRepository<Product, int> repo = new ProductRepository();

        [TestMethod]
        public void Index()
        {
            // Arrange
            ProductsController controller = new ProductsController(repo);

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

    }
}
