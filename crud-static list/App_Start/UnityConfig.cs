using System.Web.Mvc;
using Unity;
using Unity.Mvc5;
using vermadimple.Repository;

namespace vermadimple
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            container.RegisterType<EmployeeRepository, EmployeeImpl>();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}