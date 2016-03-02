using System.Data;

namespace ComplexDependency
{
    public interface IExecuteQuery
    {
        bool Execute(IDbConnection connection);
    }
}