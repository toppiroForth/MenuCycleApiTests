﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace MenuCyclesDataAccessLayer.Domain.Interfaces
{
    public interface IRepository<T> where T : EntityBase, IAggregateRoot
    {
        void Add(T item);
        void Remove(T item);
        void Update(T item);
        T FindByID(Guid id);
        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);
        IEnumerable<T> FindAll();
    }
}
