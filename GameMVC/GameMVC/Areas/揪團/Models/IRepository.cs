using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameMVC.Areas.揪團.Models
{
    public interface IRepository<T>
    {
        T GetById(int id);
        IEnumerable<T> GetAll();
        void Create(T _entity);
        void Update(T _entity);
        void Delete(T _entity);
    }
}