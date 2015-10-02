﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using UnitOfWork.Test;
using UnitOfWork.UnitOfWork;

namespace UnitOfWork
{
	public class BaseRepositoryTest<TDbSetType, TContextType> : IRepositoryTest<TDbSetType, TContextType>
		where TDbSetType : class
		where TContextType : class
	{
		private readonly DbSet<TDbSetType> _dbSet;

		public BaseRepositoryTest(IUnitOfWorkTest<TContextType> unitOfWork)
		{
			if (unitOfWork == null)
			{
				throw new ArgumentNullException("unitOfWork");
			}

			_dbSet = unitOfWork.Context.Set<TDbSetType>();
		}

		public TDbSetType Get(Expression<Func<TDbSetType, bool>> predicate)
		{
			return _dbSet.Find(predicate);
		}

		public TDbSetType FirstOrDefault(Expression<Func<TDbSetType, bool>> predicate)
		{
			return _dbSet.FirstOrDefault(predicate);
		}

		public IList<TDbSetType> GetAll(Expression<Func<TDbSetType, bool>> predicate)
		{
			return _dbSet.Where(predicate).ToList();
		}

		public IList<TDbSetType> GetAll()
		{
			return _dbSet.ToList();
		}

		public void Add(TDbSetType entity)
		{
			_dbSet.Add(entity);
		}

		public void Delete(TDbSetType entity)
		{
			_dbSet.Remove(entity);
		}

		public IQueryable<TDbSetType> GetQueryable(Expression<Func<TDbSetType, bool>> predicate)
		{
			return _dbSet.Where(predicate);
		}

		public IQueryable<TDbSetType> GetQueryable()
		{
			return _dbSet;
		}

		public int Count(Expression<Func<TDbSetType, bool>> predicate)
		{
			return _dbSet.Count(predicate);
		}

		public int Count()
		{
			return _dbSet.Count();
		}
	}
}