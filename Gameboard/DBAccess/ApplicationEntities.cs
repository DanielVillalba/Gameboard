using Gameboard.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Web;

namespace Gameboard.DBAccess
{
    public class ApplicationEntities
    {
        // need to provide the code to return data and interact with JSON file

        public ApplicationEntities()
        {
            //mockData();
            retrieveData();
        }

        public IEnumerable<Product> CompleteProductsList()
        {
            return data;
        }

        public Product FindProduct(int id)
        {
            return data.FirstOrDefault(x => x.Id == id);
        }

        public void AddProduct(Product newProduct)
        {
            data.Add(newProduct);
            saveData(data);
        }

        public void RemoveProduct(int id)
        {
            Product toDelete = data.Find(x => x.Id == id);
            if ( toDelete != null)
            {
                data.Remove(toDelete);
                saveData(data);
            }
        }

        // mock data, this needs to be replaced by JSON file at some point
        private List<Product> data = new List<Product>();
        private void mockData()
        {
            data.Add(
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

            data.Add(
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
        
        private void saveData(List<Product> dataToStore)
        {
            string path = AppDomain.CurrentDomain.GetData("DataDirectory").ToString();
            using (StreamWriter file = File.CreateText(path + @"\products.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, dataToStore);
            }
        }

        private void retrieveData()
        {
            // implementing retry pattern
            int NumberOfRetries = 3;
            int DelayOnRetry = 1000;

            Thread.Sleep(200);  // allow the previous operation with the file to be completed

            for (int i = 1; i<=NumberOfRetries; i++)
            {
                try
                {
                    // deserialize JSON directly from a file
                    string path = AppDomain.CurrentDomain.GetData("DataDirectory").ToString();
                    using (StreamReader file = File.OpenText(path + @"\products.json"))
                    {
                        JsonSerializer serializer = new JsonSerializer();
                        data = (List<Product>)serializer.Deserialize(file, typeof(List<Product>));
                    }
                    break;
                }
                catch (Exception ex)
                {
                    if (i == NumberOfRetries) throw;
                    Thread.Sleep(DelayOnRetry);
                }
            }

        }
    }
}
