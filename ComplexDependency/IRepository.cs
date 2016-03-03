using System.Collections.Generic;

namespace ComplexDependency
{
    public interface IRepository<T, in TK> where T : class, new()
    {
        bool Create(T entity);
        T Retrieve(TK id);
        bool Update(T entity);
        bool Delete(T entity);

        IEnumerable<T> FindAll(IFindQuery<T> query);
        bool Execute(IExecuteQuery query);
    }
}
