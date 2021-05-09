using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //generic constraint =generic sınırlama yani T nin hangi tipleri icerebilecegini belirtiyoruz
    public interface IEntityRepository<T> where T:class,IEntity,new()
        //IEntity iceren classlardan biri olabilir baska classlari kabul etmez. Eger new olmazsa. new olursa soyut nesneler kullanılamaz yani artık IEntitiy'nin implemente ettigi classlari alabilir.
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);//filtreleme ozelligi saglar. İstenilen verileri getirmeyi saglar.
        T Get(Expression<Func<T, bool>> filter);//null'a esitlenmediginde filtre vermek zorunda degilsin. Filtre verilmezse butun verileri getirir.
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
