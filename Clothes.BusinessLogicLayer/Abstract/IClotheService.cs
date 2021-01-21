using Clothes.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Clothes.BusinessLogicLayer.Abstract
{
    public interface IClotheService
    {
        List<Clothe> GetAll(Expression<Func<Clothe, bool>> filter = null);
        void Add(Clothe entity);
        void Update(Clothe entity);
        void Delete(Clothe entity);
        Clothe Get(Expression<Func<Clothe, bool>> filter);
    }
}
