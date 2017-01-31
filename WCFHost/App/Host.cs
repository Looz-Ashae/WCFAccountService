using Autofac;
using Autofac.Integration.Wcf;
using System;
using System.ServiceModel;

namespace WCFHost
{
    class Host
    {
        static void Main()
        {
            IContainer container = AutofacContainerBuilder.BuildContainer();
            AutofacHostFactory.Container = container;

            using (var host = new ServiceHost(typeof(WCFAccountService.AccountService)))
            {
                host.AddDependencyInjectionBehavior<WCFAccountService.IAccountService>(container);
                host.Open();
                Console.WriteLine("Server has been started");
                Console.ReadKey();
            }
            Environment.Exit(0);
        }
    }
}
