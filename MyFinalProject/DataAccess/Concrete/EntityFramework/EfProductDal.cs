using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : IProductDal
    {
        public void Add(Product entity)
        {
            //IDispossanable pattern implementation of c#
            using (NorthwindContext context=new NorthwindContext())//bellegi hizlica temizleme islemi yapar.
            {
                var addedEntitiy = context.Entry(entity);//contexte entitiy'i bagla
                addedEntitiy.State = EntityState.Added;//ekleme olarak durumu set et
                context.SaveChanges();
            }
        }

        public void Delete(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext())//bellegi hizlica temizleme islemi yapar.
            {
                var deletedEntitiy = context.Entry(entity);//contexte entitiy'i bagla
                deletedEntitiy.State = EntityState.Deleted;//silme olarak durumu set et
                context.SaveChanges();
            }
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            using (NorthwindContext context=new NorthwindContext())
            {
                return context.Set<Product>().SingleOrDefault(filter); 
            }
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            using (NorthwindContext context=new NorthwindContext())
            {
                return filter == null //veri tabanındaki tum tabloyu listeye cevir ve bunu ver
                    ? context.Set<Product>().ToList()//filtre null ise bu kisim calisir
                    : context.Set<Product>().Where(filter).ToList();//null degilse bu kisim calisir
            }
        }

        public void Update(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext())//bellegi hizlica temizleme islemi yapar.
            {
                var updatedEntitiy = context.Entry(entity);//contexte entitiy'i bagla
                updatedEntitiy.State = EntityState.Modified;//update olarak durumu set et
                context.SaveChanges();
            }
        }
    }
}
