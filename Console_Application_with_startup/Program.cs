using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;


/***
 * important notes
 * .net Core console application is a light weight application and it does not have
 * functionality such a dependency injection in built.
 * In console application configuration can be added using the configurationbuilder class.
 * Need below packages to install befor use it
 *  Install-Package Microsoft.Extensions.Configuration
    Install-Package Microsoft.Extensions.Configuration.Json
    Install-Package Microsoft.Extensions.Configuration.CommandLine
    Install-Package Microsoft.Extensions.Configuration.EnvironmentVariables
 * For Dependency Injection
    Microsoft.Extensions.DependencyInjection
    NetCore.AutoRegisterDi 
 * open appSettings.json properties and change copy to output directory to copy always
 * 
 * and then follow the code as follows
 */

namespace Console_Application_with_startup
{
    class Program
    {
        static void Main(string[] args)
        {

            var services = ConfigureServices();
            var serviceProvider = services.BuildServiceProvider();

            serviceProvider.GetService<MyClass1>();

            Console.Read();
        }

        private static IServiceCollection ConfigureServices()
        {

            IServiceCollection services = new ServiceCollection();

            //register singleton object
            services.AddSingleton(LoadConfiguration());

            //register service
            services.AddTransient<MyClass1>();

            // inject interfaces with concrete objects
            services.AddTransient<IUser, User>();
            services.AddTransient<IUser1, User1>();

            return services;
        }

        private static IConfiguration LoadConfiguration()
        {

            //register app settings 
            return new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .Build();
        }
    }

    public class MyClass1
    {

        public MyClass1(IConfiguration configuration, IUser user, IUser1 user1)
        {
            Configuration = configuration;
            User = user;
        }

        public IConfiguration Configuration { get; }
        public IUser User { get; }
    }

    public interface IUser
    {
        int Id { get; set; }
    }


    public class User : IUser
    {
        public int Id { get; set; }
        public User()
        {
            this.Id = 12;
            Console.WriteLine("Testing");
        }
    }

    public interface IUser1
    {
        int Id { get; set; }
    }


    public class User1 : IUser1
    {
        public int Id { get; set; }
        public User1()
        {
            this.Id = 12;
            Console.WriteLine("Testing");
        }
    }
}
