using AmdarisInternship.Domain.Entities;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace AmdarisInternship.Infrastructure.Repositories
{
    public interface IRepository<T> where T : BaseEntity
    {
        T Find(int id);

        T Find(Expression<Func<T, bool>> predicate);

        IQueryable<T> FindAll(Expression<Func<T, bool>> predicate);

        void Delete(T entity);

        void Add(T entity);

        T Update(T entity);

        IQueryable<T> GetAll();

        void Save();
    }
}
