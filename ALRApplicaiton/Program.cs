using System;
using System.Collections.Generic;
using System.Linq;
using ALRApplicaiton.Bootstrap;
using ALRApplicaiton.DummyClasses;
using ComplexDependency;
using ComplexImplementation;
using SimpleDependency;
using StructureMap;

namespace ALRApplicaiton
{
    public class Program
    {
        /// <summary>
        /// Pretend this is some sort of action or logic that depends on stuff
        /// </summary>
        private static void SimpleScenario(ILogger logger)
        {
            logger.DoSomeLogging("Hello This Is Being Logged");
        }

        /// <summary>
        /// This shows a more complex scenario where you require DI to instantiate some objects but 
        /// also directly consume others, in most cases this would be when a component is dependent
        /// upon another component, which is then consumed via an application layer (console, webapi, mvc, service etc)
        /// </summary>
        private static void ComplexScenario(ILogger logger, IRepository<SomeDummyClass, int> repository)
        {
            GetAllQuery<SomeDummyClass> query = new GetAllQuery<SomeDummyClass>();
            IEnumerable<SomeDummyClass> results = repository.FindAll(query);
            logger.DoSomeLogging($"Got {results.Count()} Records From Db");
        }

        /// <summary>
        /// This is just mimicing what would happen in a WebAPI project or some other application.
        /// 
        /// The DI framework is bootstrapped to set it up, then the DI container is used for resolving
        /// of some root level object or put into the underlying framework to replace the current
        /// resolving object (i.e MVC ControllerFactory, DependencyResolver etc). This is normally done
        /// within the bootstrapper for you, however in this instance to keep it simple I have just
        /// explicitly used the container here to resolve instances. I say this so this approach is 
        /// not to be confused with ServiceLocation which is a bad pattern.
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            if (args == null) throw new ArgumentNullException(nameof(args));
            Container container = new StructuremapBootstrap().Setup();
            ILogger logger = container.GetInstance<ILogger>();
            IRepository<SomeDummyClass, int> repository = container.GetInstance<IRepository<SomeDummyClass, int>>();

            SimpleScenario(logger);
            ComplexScenario(logger, repository);

            // This is just to stop the app closing
            Console.WriteLine("Press Any Key To Exit");
            Console.ReadKey();
        }
    }
}
