using ComplexDependency;
using StructureMap;
using StructureMap.Graph;

namespace CRApplication.Bootstrap
{
    /// <summary>
    /// This wraps up a simple set of conventional based bindings, it will scan all assemblies
    /// within the application and auto bind simple ISomething -> Something and then the 
    /// AddAllTypesOf will basically include any generic implementations which match the target.
    /// 
    /// You can write your own conventions over the top of this to automatically do things like  
    /// manage scopes and lifetimes, bind based on naming conventions ISomething -> DefaultSomething
    /// and many other things. This cuts down on a HUGE amount of boilerplate configuration AND
    /// also allows you to resolve new bindings without re-compiling, as long as the assemblies
    /// are included. 
    /// </summary>
    public class StructuremapBootstrap
    {
        public Container Setup()
        {
            return new Container(c => c.Scan(a =>
            {
                a.AssembliesFromApplicationBaseDirectory();
                a.RegisterConcreteTypesAgainstTheFirstInterface();
                a.AddAllTypesOf(typeof(IRepository<,>));
                a.WithDefaultConventions();
            }));
        }
    }
}
