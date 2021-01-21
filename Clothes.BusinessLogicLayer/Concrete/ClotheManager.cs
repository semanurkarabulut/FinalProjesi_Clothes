using Clothes.BusinessLogicLayer.Abstract;
using Clothes.DataAccessLayer.Abstract;
using Clothes.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Clothes.BusinessLogicLayer.Concrete
{
    public class ClotheManager : IClotheService
    {
        IClotheDal _clotheDal;

        public ClotheManager(IClotheDal clotheDal)
        {
            _clotheDal = clotheDal;
        }

        public void Add(Clothe entity)
        {
            _clotheDal.Add(entity);
        }

        public void Delete(Clothe entity)
        {
            _clotheDal.Delete(entity);
        }

        public Clothe Get(Expression<Func<Clothe, bool>> filter)
        {
            return _clotheDal.Get(filter);
        }

        public List<Clothe> GetAll(Expression<Func<Clothe, bool>> filter = null)
        {
            return _clotheDal.GetAll(filter);
        }

        public void Update(Clothe entity)
        {
            _clotheDal.Update(entity);
        }
    }
}
