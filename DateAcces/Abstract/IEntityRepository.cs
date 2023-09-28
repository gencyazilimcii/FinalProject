using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Abstract
{
    //Generic constraint -- Generic Kısıt

    //T: Class da ki class referance tip olabilir demek

    //Ientity : Ientity olabilir veya ıentity implemente eden bir nesne olabilir

    //new() : IEntity implementasyonu olan nesneleri istiyoruz ama IEntity yı
    //soyut olduğu için istemiyoruz. İnterfaceler new lenemiyeceği için
    //new() i kullanarak IEntity i devre dışı bırakıyoruz.

    public interface IEntityRepository<T> where T : class, IEntity,new()
    {

        List<T> GetAll(Expression<Func<T,bool>> filter=null);

        T Get(Expression<Func<T, bool>> filter);

        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        
      // List<T> GetAllByCategory(int categoryId);
    }
}
