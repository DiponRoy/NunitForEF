﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using FRGS.Model.Contracts.Shared;

namespace FRGS.Test.Unit.DbContext
{
    class InMemoryDbSet<T> : IDbSet<T> where T : class
    {

        readonly HashSet<T> _set;
        readonly IQueryable<T> _queryableSet;


        public InMemoryDbSet() : this(Enumerable.Empty<T>()) { }

        public InMemoryDbSet(IEnumerable<T> entities)
        {
            _set = new HashSet<T>();

            foreach (var entity in entities)
            {
                _set.Add(entity);
            }

            _queryableSet = _set.AsQueryable();
        }

        public T Add(T entity)
        {
            _set.Add(entity);
            return entity;

        }

        public T Attach(T entity)
        {
            _set.Add(entity);
            return entity;
        }

        public TDerivedEntity Create<TDerivedEntity>() where TDerivedEntity : class, T
        {
            throw new NotImplementedException();
        }

        public T Create()
        {
            throw new NotImplementedException();
        }

        public T Find(params object[] keyValues)
        {
            throw new NotImplementedException();
        }

        public System.Collections.ObjectModel.ObservableCollection<T> Local
        {
            get { throw new NotImplementedException(); }
        }

        public T Remove(T entity)
        {
            _set.Remove(entity);
            return entity;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _set.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public Type ElementType
        {
            get { return _queryableSet.ElementType; }
        }

        public System.Linq.Expressions.Expression Expression
        {
            get { return _queryableSet.Expression; }
        }

        public IQueryProvider Provider
        {
            get { return _queryableSet.Provider; }
        }
    }
}
