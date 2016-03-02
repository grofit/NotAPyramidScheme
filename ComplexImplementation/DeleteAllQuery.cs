using System.Data;
using ComplexDependency;

namespace ComplexImplementation
{
    public class DeleteAllQuery : IExecuteQuery
    {
        public bool Execute(IDbConnection connection)
        { return true; }
    }
}