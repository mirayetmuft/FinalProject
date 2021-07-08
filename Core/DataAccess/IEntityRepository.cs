using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        //generic constraint -jenerik kısıtlaması
        //class: referans tip demek
        //IEntity: IEntity olabilir ya da IEntity implemente eden bir nesne olablir
        //new() : newlenebilir olmalı

        List<T> GetAll(Expression<Func<T,bool>>filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

       
    }
}
 