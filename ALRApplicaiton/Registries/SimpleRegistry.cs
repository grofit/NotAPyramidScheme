using SimpleDependency;
using StructureMap;

namespace ALRApplicaiton.Registries
{
    /// <summary>
    /// Ultimately without conventional approaches this configuration will live somewhere, be it in the component or here.
    /// 
    /// The benefit of it being in the component is that you do not know as such as this level what ILogger is configured to,
    /// however if this was to be configured to a console logger at the component level and you wanted to write to a database
    /// at the application you will then have a redundant config, that you would need to override, also it will keep both
    /// configurations in memory so even if you did not use the "default" concrete class it would be known about.
    /// 
    /// Just to confirm in this scenario it is a moot point as the concrete class is in with the interface if you were to 
    /// separate the ILogger from the DefaultLogger then this would allow you to include only the implementations you needed
    /// although then you introduce a large amount of projects and dlls.
    /// 
    /// Ultimately this way will cause some amount of duplication when it comes to multiple applications which use the same
    /// component setups, but this is where conventional bindings can save a lot of time, and this sort of approach would only
    /// be applicable for those scenarios where its a simple ISomething -> DefaultSomething.
    /// </summary>
    public class SimpleRegistry : Registry
    {
        public SimpleRegistry()
        {
            For<ILogger>().Use<DefaultLogger>();
        }
    }
}
