using Library.DataLayer.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataLayer
{
    public class LibraryGenericRepository<TEntity> where TEntity : class
    {
        private Library_DB _db;
        private DbSet<TEntity> _dbset;

        public LibraryGenericRepository(Library_DB db)
        {
            _db = db;
            _dbset = db.Set<TEntity>();
        }

        public virtual TEntity GetById(object id)
        {
            return _dbset.Find(id);
        }

        public virtual IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> where = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderby = null, string includes = "")
        {
            try
            {
                IQueryable<TEntity> query = _dbset;
                if (where != null)
                {
                    query = query.Where(where);
                }
                if (orderby != null)
                {
                    query = orderby(query);
                }
                if (includes != "")
                {
                    foreach (string include in includes.Split(','))
                    {
                        query = query.Include(include);
                    }
                }
                return query.AsNoTracking().ToList();

            }
            catch (Exception ex)
            {
                var mm = ex.Message;
                return null;
            }
        }

        public virtual void Insert(TEntity entity)
        {
            _dbset.Add(entity);
        }

        public virtual void Update(TEntity entity)
        {
            _dbset.Attach(entity);
            _db.Entry(entity).State = EntityState.Modified;
        }

        public virtual void Delete(TEntity entity)
        {
            if (_db.Entry(entity).State == EntityState.Detached)
            {
                _dbset.Attach(entity);
            }
            _dbset.Remove(entity);
        }

        public virtual void Delete(object id)
        {
            var entity = GetById(id);
            Delete(entity);
        }

        public virtual void Save()
        {
            _db.SaveChanges();
        }
    }
}
