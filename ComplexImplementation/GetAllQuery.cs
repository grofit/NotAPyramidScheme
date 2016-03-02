using System.Collections.Generic;
using System.Data;
using ComplexDependency;

namespace ComplexImplementation
{
    public class GetAllQuery<T> : IFindQuery<T> where T : class, new()
    {
        public IEnumerable<T> Execute(IDbConnection connection)
        {
            return new List<T> { new T(), new T(), new T() };
        }
    }
}