using System.Collections.Generic;
using System.Data;
using ComplexDependency;
using NSubstitute;

namespace ComplexImplementation
{
    public class DummyRepository<T,TK> : IRepository<T,TK> where T : class, new()
    {
        private readonly IDbConnection _dummyConnection;

        // Normally this would be satisfied with IoC, but its just being mocked here
        public DummyRepository()
        { _dummyConnection = Substitute.For<IDbConnection>(); }

        public bool Create(T entity)
        { return true; }

        public T Retrieve(TK id)
        { return new T(); }

        public bool Update(T entity)
        { return true; }

        public bool Delete(T entity)
        { return true; }

        public IEnumerable<T> FindAll(IFindQuery<T> query)
        { return query.Execute(_dummyConnection); }

        public bool Execute(IExecuteQuery query)
        { return query.Execute(_dummyConnection); }
    }
}
