using Gameboard.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gameboard.DBAccess
{
    public class ApplicationEntities
    {
        // need to provide the code to return data and interact with JSON file

        public ApplicationEntities()
        {
            createMockData();
        }

        public IEnumerable<Product> CompleteProductsList()
        {
            return testData;
        }

        public Product FindProduct(int id)
        {
            return testData.FirstOrDefault(x => x.Id == id);
        }

        public void AddProduct(Product newProduct)
        {
            testData.Add(newProduct);
        }

        public void RemoveProduct(int id)
        {
            Product toDelete = testData.Find(x => x.Id == id);
            if ( toDelete != null)
            {
                testData.Remove(toDelete);
            }
        }

        // mock data, this needs to be replaced by JSON file at some point
        private List<Product> testData = new List<Product>();
        private void createMockData()
        {
            testData.Add(
                new Product
                {
                    Id = 1,
                    Name = "Toy # 1",
                    Description = "Sample toy # 1",
                    AgeRestriction = 12,
                    Company = "Tyco",
                    Price = 10.50m
                }
            );

            testData.Add(
                new Product
                {
                    Id = 2,
                    Name = "Toy # 2",
                    Description = "Sample toy # 2",
                    AgeRestriction = 22,
                    Company = "Tyco 2",
                    Price = 210.50m
                }
            );
        }
    }
}