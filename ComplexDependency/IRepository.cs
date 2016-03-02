using System.Collections.Generic;

namespace ComplexDependency
{
    public interface IRepository<T, K> where T : class, new()
    {
        bool Create(T entity);
        T Retrieve(K id);
        bool Update(T entity);
        bool Delete(T entity);

        IEnumerable<T> FindAll(IFindQuery<T> query);
        bool Execute(IExecuteQuery query);
    }
}
