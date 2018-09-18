using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Routing;
using FlowerStore.Domain.Abstract;
using FlowerStore.Domain.Entities;
using Moq;
using Ninject;

namespace FlowerStore.WebUI.Infrastructure
{
    public class NinjectControllerFactory : DefaultControllerFactory
    {
        private IKernel ninjectKernel;

        public NinjectControllerFactory()
        {
            ninjectKernel = new StandardKernel();
            AddBindings();
        }


        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return controllerType == null ? null : (IController)ninjectKernel.Get(controllerType);
        }

        private void AddBindings()
        {
            Mock<IProductRepository> mock = new Mock<IProductRepository>();
            mock.Setup(m => m.Products).Returns(new List<Product>
            {
                new Product {Name = "Goździk", Price = 2},
                new Product {Name = "Tulipan", Price = 3},
                new Product {Name = "Róża", Price = 5}
            }.AsQueryable());

            ninjectKernel.Bind<IProductRepository>().ToConstant(mock.Object);
        }


    }
}