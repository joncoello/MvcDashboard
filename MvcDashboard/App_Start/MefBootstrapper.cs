using System;
using System.Collections.Generic;
using System.Composition.Convention;
using System.Composition.Hosting;
using System.Linq;
using System.Reflection;
using System.Web;

namespace MvcDashboard
{
    public class MefBootstrapper
    {
        static bool isLoaded;
        static CompositionHost container;

        public static void Compose(IEnumerable<Assembly> assemblies)
        {
            if (isLoaded)
            {
                return;
            }

            container = GetContainer(assemblies);

            isLoaded = true;
        }

        static CompositionHost GetContainer(IEnumerable<Assembly> assemblies)
        {
            var conventions = new ConventionBuilder();
            conventions.ForTypesDerivedFrom<MvcDashboard.Contracts.IWidget>().Export<MvcDashboard.Contracts.IWidget>();
            return new ContainerConfiguration().WithAssemblies(assemblies, conventions).CreateContainer();
        }

        public static IEnumerable<T> GetInstances<T>()
        {
            if (container == null)
            {
                return new List<T>();
            }

            return container.GetExports<T>();

            //if (string.IsNullOrWhiteSpace(typeName))
            //{
            //    type = container.GetExport<T>();
            //}
            //else
            //{
            //    var exports = container.GetExports<T>();
            //    type = exports.FirstOrDefault(x => x.GetType().Name == typeName && (assemblyHint == null || (x.GetType().AssemblyQualifiedName != null && x.GetType().AssemblyQualifiedName.Contains(assemblyHint))));
            //}

            //return type;
        }
    }
}