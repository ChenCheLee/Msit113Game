
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using GameMVC.Models;

namespace GameMVC.Areas.揪團.Models
{
    public class PairRepository<T> : IRepository<T> where T : class
    {
        public GameAllEntities db = null;
        private DbSet<T> Dbset = null;

        public PairRepository()
        {
            db = new GameAllEntities();
            Dbset = db.Set<T>();
        }

        public void Create(T _entity)
        {
            Dbset.Add(_entity);
            Dbset.Add(_entity);
            db.SaveChanges();
        }

        public void Delete(T _entity)
        {
            Dbset.Remove(_entity);
            db.SaveChanges();
        }

        public IEnumerable<T> GetAll()
        {
            return Dbset.ToList();
        }

        public T GetById(int id)
        {
            return Dbset.Find(id);
        }

        public void Update(T _entity)
        {
            db.Entry(_entity).State = EntityState.Modified;
            db.SaveChanges();
        }
        public IEnumerable<T> GetMypair()
        {
            return Dbset.ToList();
        }
    }
}