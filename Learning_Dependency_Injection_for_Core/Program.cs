using StructureMap;
using System;

/*
 * .NET core DI 
 * https://docs.microsoft.com/en-gb/aspnet/core/fundamentals/dependency-injection?view=aspnetcore-3.1#default-service-container-replacement
 * 
 * transient - create instance in each and every request
 * scoped - create instance for each web request. Therefore user can exchange values between to controllers or methods.
 * singleton - create instance only in application start. 
 * 
 * NetCore.AutoRegisterDi for auto map inteface with core DI
 * 
 * Sticking to the standard .NET Core container may eliminate some complexity and 
 * barriers for junior devs, but may require a bit of extra coding. It all can be justified on 
 * smaller projects. When on big projects having rich functionality 
 * of Autofac /Ninject brings much more benefits and Autofac may become irreplaceable.
 * 
 * Defualt .net core Di doent not contains scaning option. However with Scrutor we can add that option.
 * services.Scan(scan => 
    scan.FromCallingAssembly()                    
        .AddClasses()
        .AsMatchingInterface());

    or else

    s.LookForRegistries();
    //s.AssembliesAndExecutablesFromPath(Environment.CurrentDirectory);
    s.SingleImplementationsOfInterface();


 * Best Pratices
 * 
 * its not good practice to inject all the service through controller constructor
 * (because sometime all injected services are not used in individual action. therefore it will be a preformance issue.)
 * therefore we can use [FromServices] attributes to inject service to each action. 
 * 
 * "
 * Controller action injection is a useful feature that helps us keep services used by one action 
 * away from the class scope. This way we don't pile injected services to class level and our controller 
 * classes are smaller. If service is used by more than one or few actions it is a good idea to have reference 
 * to it at the class level. Otherwise, we can keep controller classes smaller by using controller action injection." 
 * 
 * 
 * 
 * IMPORTANT
 * When we compare structure map with autofac, its better to use structure map intead. 
 * 
 * 
 * So Structure Map tutorial is below
 * 
 * Install-Package StructureMap
 * <PackageReference Include="structuremap" Version="4.7.1" />* 
 * 
 * 
 * autofact example
 * // Scan an assembly for components
builder.RegisterAssemblyTypes(myAssembly)
       .Where(t => t.Name.EndsWith("Repository"))
       .AsImplementedInterfaces();
 */

namespace Learning_Dependency_Injection_for_Core
{
    class Program
    {
        static void Main(string[] args)
        {

            var application = Container.For<StructureMapResolver>();
            var manager = application.GetInstance<CX>();


            Console.WriteLine("Hello World!");
        }
    }

    public class CX
    {
        private readonly ILogger logger;
        public CX(ILogger logger)
        {
            this.logger = logger;
        }
    }

    public interface ILogger
    {

    }

    public class Logger : ILogger
    {
        public Logger()
        {
            Console.WriteLine("helloWorld");
        }
    }
}
