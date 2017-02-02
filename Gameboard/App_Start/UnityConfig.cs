using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc5;
using Gameboard.Models;
using Gameboard.Repositories;

namespace Gameboard
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            //Register the Repository in the Unity Container
            container.RegisterType<IRepository<Product, int>, ProductRepository>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}