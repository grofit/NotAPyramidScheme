using System.Collections.Generic;
using System.Data;

namespace ComplexDependency
{
    public interface IFindQuery<T> where T: class, new()
    {
        IEnumerable<T> Execute(IDbConnection connection);
    }
}