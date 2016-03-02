using ALRApplicaiton.Registries;
using StructureMap;

namespace ALRApplicaiton.Bootstrap
{
    /// <summary>
    /// This would probably be done via a 3rd party component in most cases, but this
    /// at least shows how to setup the DI configuration for consumption in the app.
    /// 
    /// The Container constructor only allows a single registry so this approach collates
    /// them into one for consumption. See conventions example for another approach.
    /// </summary>
    public class StructuremapBootstrap
    {
        public Container Setup()
        {
            var registryCollation = new Registry();
            registryCollation.IncludeRegistry<SimpleRegistry>();
            registryCollation.IncludeRegistry<ComplexRegistry>();

            return new Container(registryCollation);
        }
    }
}