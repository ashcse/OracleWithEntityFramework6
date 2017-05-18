//using Autofac;
//using Autofac.Integration.Mvc;
using Repository.DataService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace CDPOC.App_Start
{
    public class AutofacConfig
    {
        /// <summary>
        /// Commented this because Unity is being used
        /// </summary>
        public static void InitializeDependencies()
        {
            //var containerBuilder = new ContainerBuilder();
            //containerBuilder.RegisterControllers(Assembly.GetExecutingAssembly());

            //containerBuilder.Register(a => HttpContext.Current.User).As<System.Security.Principal.IPrincipal>();
            //containerBuilder.RegisterType<EmployeeDataService>().As<IEmployeeDataService>();
            //containerBuilder.RegisterType<ApplicationService.ApplicationService>().As<ApplicationService.IApplicationService>().SingleInstance();

            //var container = containerBuilder.Build();
            //DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }

    }
}