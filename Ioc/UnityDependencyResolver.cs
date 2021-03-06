using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;


namespace Ioc
{
    public class UnityDependencyResolver : IDependencyResolver
    {
        private readonly IUnityContainer _container;
        public UnityDependencyResolver(IUnityContainer container)
        {
            if (container == null)
                throw new ArgumentNullException("container", "The container cannot be null");
            _container = container;
        }

        public object GetService(Type serviceType)
        {
            object instance;
            try
            {
                instance = _container.Resolve(serviceType);
            }
            catch
            {
                instance = null;
            }
            return instance;
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            IEnumerable<object> instances;
            try
            {
                instances = _container.ResolveAll(serviceType);
            }
            catch
            {
                instances = new object[] { };
            }
            return instances;
        }
    }
}
