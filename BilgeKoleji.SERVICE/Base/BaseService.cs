using BilgeKoleji.CORE.Entity.Enum;
using BilgeKoleji.CORE.Service;
using BilgeKoleji.DAL.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Infrastructure;
using System.Linq.Expressions;

namespace BilgeKoleji.SERVICE.Base
{
    public class BaseService<T> : ICoreService<T> where T : CoreEntity
    {
        private static KolejContext _db;


        #region College Pattern
        public static KolejContext db
        {
            get
            {
                if (_db == null)
                {
                    _db = new KolejContext();
                }
                return _db;
            }
        }

        #endregion

        public void Add(T item)
        {
            db.Set<T>().Add(item);
            db.SaveChanges();
        }

        public void Add(List<T> item)
        {
            db.Set<T>().AddRange(item);
            db.SaveChanges();
        }

        public void Remove(T item)
        {
            item.Status = BilgeKoleji.CORE.Entity.Enum.Status.Deleted;
            Update(item);
        }

        public T GetByID(Guid id)
        {
            return db.Set<T>().Find(id);
        }

        public void Update(T item)
        {
            T update = db.Set<T>().Find(item.ID);
            DbEntityEntry entry = db.Entry(update);
            entry.CurrentValues.SetValues(item);
            db.SaveChanges();

        }

        public List<T> GetAll()
        {
            return db.Set<T>().ToList();
        }

        public bool Any(Expression<Func<T, bool>> exp)
        {
            return db.Set<T>().Any(exp);
        }

        public T GetByDefault(Expression<Func<T, bool>> exp)
        {
            return db.Set<T>().Where(exp).FirstOrDefault();
        }

        public List<T> GetActive()
        {
            return db.Set<T>().Where(x => x.Status == CORE.Entity.Enum.Status.Created).ToList();
        }


    }





}
