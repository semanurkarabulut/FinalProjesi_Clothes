using Clothes.BusinessLogicLayer.Abstract;
using Clothes.BusinessLogicLayer.Concrete;
using Clothes.DataAccessLayer.Abstract;
using Clothes.DataAccessLayer.Concrete.ADONET;
using Clothes.DataAccessLayer.Concrete.EntityFramework;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clothes.BusinessLogicLayer.CrossCuttingConcerns.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IClotheService>().To<ClotheManager>().InSingletonScope();
            Bind<IClotheDal>().To<AdoClotheDal>().InSingletonScope();
        }
    }
}
