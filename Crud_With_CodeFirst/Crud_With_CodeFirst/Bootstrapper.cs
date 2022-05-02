using System.Web.Mvc;
using Crud_With_CodeFirst.Repository;
using Crud_With_CodeFirst.Repository.Implementation;
using Microsoft.Practices.Unity;
using Unity.Mvc4;

namespace Crud_With_CodeFirst
{
  public static class Bootstrapper
  {
    public static IUnityContainer Initialise()
    {
      var container = BuildUnityContainer();
            container.RegisterType<ITaxRepo, TaxRepositary>();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));

      return container;
    }

    private static IUnityContainer BuildUnityContainer()
    {
      var container = new UnityContainer();

      // register all your components with the container here
      // it is NOT necessary to register your controllers

      // e.g. container.RegisterType<ITestService, TestService>();    
      RegisterTypes(container);

      return container;
    }

    public static void RegisterTypes(IUnityContainer container)
    {
    
    }
  }
}