using System.Data.Entity;
using BLL.Interface.Services;
using BLL.Services;
using DAL.Concrete;
using DAL.Interface.Repository;
using Ninject;
using Ninject.Web.Common;
using ORM;
using BLL.Interfacies.Services;
using Moq;
using BLL.Interfacies.Entities;
using System.Collections.Generic;
using DAL.Interfacies.Repository;

namespace DependencyResolver
{
    public static class ResolverConfig
    {
        public static void ConfigurateResolverWeb(this IKernel kernel)
        {
            Configure(kernel, true);
        }

        public static void ConfigurateResolverConsole(this IKernel kernel)
        {
            Configure(kernel, false);
        }

        private static void Configure(IKernel kernel, bool isWeb)
        {
            //Mock<ITestRepository> mock = new Mock<ITestRepository>();
            //mock.Setup(m => m.Tests).Returns(new List<TestEntity> {
            //    new TestEntity { Name = "test1", Number = 1 },
            //    new TestEntity { Name = "test2", Number = 2 },
            //    new TestEntity { Name = "test3", Number = 3 },
            //});
            //kernel.Bind<ITestRepository>().ToConstant(mock.Object);
            //if (isWeb)
            //{
            //    kernel.Bind<IUnitOfWork>().To<UnitOfWork>().InRequestScope();
            //    kernel.Bind<DbContext>().To<EntityModel>().InRequestScope();
            //}
            //else
            //{
            //    kernel.Bind<IUnitOfWork>().To<UnitOfWork>().InSingletonScope();
            //    kernel.Bind<DbContext>().To<EntityModel>().InSingletonScope();
            //}
            kernel.Bind<DbContext>().To<EntityModel>().InSingletonScope();
            kernel.Bind<IUnitOfWork>().To<UnitOfWork>().InSingletonScope();
            kernel.Bind<IUserService>().To<UserService>();
            kernel.Bind<IUserRepository>().To<UserRepository>();
            kernel.Bind<ITestRepository>().To<TestRepository>();
            kernel.Bind<ITestService>().To<TestService>();
        }
    }
}