﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Budget.Repository.Interfaces
{

    public interface IRepository<TEntity> where TEntity : class
    {
        IList<TEntity> FindAll();
        TEntity Find(Expression<Func<TEntity, bool>> criteria);
        TEntity FindBy(int id);
        TEntity Add(TEntity entity);
        TEntity Add(IList<TEntity> items);
        bool Update(TEntity entity);
        bool Delete(TEntity entity);
        bool Delete(IList<TEntity> entities);
    }




}