using Clothes.DataAccessLayer.Abstract;
using Clothes.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clothes.DataAccessLayer.Concrete.EntityFramework
{
    public class EFClotheDal : EFRepositoryBase<Clothe, ClothesContext>, IClotheDal
    {
    }
}
