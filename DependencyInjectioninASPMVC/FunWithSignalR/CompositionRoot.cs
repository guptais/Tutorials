using System;
using System.Configuration;
using System.Web.Mvc;
using FunWithSignalR.Domain.Repository;

namespace FunWithSignalR
{
    public class CompositionRoot
    {
        private readonly IControllerFactory _controllerFactory;

        public CompositionRoot()
        {
            this._controllerFactory = CompositionRoot.CreateControllerFactory();
        }

        public IControllerFactory ControllerFactory
        {
            get
            {
                return _controllerFactory;
            }
        }

        private static IControllerFactory CreateControllerFactory()
        {
            string blogRepositoryTypeName = ConfigurationManager.AppSettings["BlogRepositoryType"];
            var blogRepositoryType = Type.GetType(blogRepositoryTypeName, true);
            var repository = (IBlogPostRepository)Activator.CreateInstance(blogRepositoryType);

            var controllerFactory = new BlogControllerFactory(repository);
            return controllerFactory;
        }
    }
}