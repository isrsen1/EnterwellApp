using EnterwellApp.Business;
using EnterwellApp.Business.Interface;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace EnterwellApp
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            container.RegisterType<IProizvod, ProizvodBusinessLayer>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}