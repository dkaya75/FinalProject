using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.DependencyResolvers.Autofac
{//burayı oluşturmamın sebebi webApi nin kendi IoC altyapısı var ama ben aotufaci kullanmak istiyorsam bunu oluşturuyorum. 
    public class AutofacBusinessModule:Module //aotofac modülü old.yaptım
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ProductManager>().As<IProductService>().SingleInstance();
            //biri Iproductservice isterse Product manageri register(kayıt) et.Yani biri servici isterse sen ona manager instance (örneği) ver
            builder.RegisterType<EfProductDal>().As<IProductDal>().SingleInstance();

        }
    }
}
