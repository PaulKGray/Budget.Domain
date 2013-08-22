using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Budget.Repository.Interfaces
{

    public interface IReadOnlyRepository<TEntity> where TEntity:class
    {
        IList<TEntity> All();
        TEntity FindBy(Expression<Func<TEntity, bool>> expression);
        IList<TEntity> FilterBy(Expression<Func<TEntity, bool>> expression);
    }

    public interface IRepository<TEntity> : IIntKeyedRepository<TEntity> where TEntity : class
    {

        TEntity Add(TEntity entity);
        TEntity Add(IList<TEntity> items);
        bool Update(TEntity entity);
        bool Delete(TEntity entity);
        bool Delete(IList<TEntity> entities);
    }

    public interface IIntKeyedRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        TEntity FindBy(int id);
    }


}