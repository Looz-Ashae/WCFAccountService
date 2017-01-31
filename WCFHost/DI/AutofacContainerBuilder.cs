using Autofac;

namespace WCFHost
{
    /// <summary>
    /// Class to build Autofac IOC container.
    /// </summary>
    public static class AutofacContainerBuilder
    {
        /// <summary>
        /// Configures and builds Autofac IOC container.
        /// </summary>
        /// <returns></returns>
        public static IContainer BuildContainer()
        {
            var builder = new ContainerBuilder();

            // register types
            builder.RegisterType<AccountDomain.AccountRepository>().As<AccountDomain.IAccountRepository>();
            builder.RegisterType<WCFAccountService.AccountService>().As<WCFAccountService.IAccountService>();
            // build container
            return builder.Build();
        }
    }
}
