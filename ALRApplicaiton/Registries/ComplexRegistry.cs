using ALRApplicaiton.DummyClasses;
using ComplexDependency;
using ComplexImplementation;
using StructureMap;

namespace ALRApplicaiton.Registries
{
    public class ComplexRegistry : Registry
    {
        public ComplexRegistry()
        {
            For<IRepository<SomeDummyClass, int>>().Use<DummyRepository<SomeDummyClass, int>>();
        }
    }
}