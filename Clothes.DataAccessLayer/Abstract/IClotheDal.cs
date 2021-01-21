using Clothes.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clothes.DataAccessLayer.Abstract
{
    public interface IClotheDal : IEntityRepository<Clothe>
    {
    }
}
