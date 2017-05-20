using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web;

namespace MvcDashboard
{
    public class MefConfig
    {
        public static void Register()
        {
            var assemblies = Fetch().ToList();
            MefBootstrapper.Compose(assemblies);
        }

        private static IEnumerable<Assembly> Fetch()
        {
            var assemblyPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "bin");
            var assemblies = new DirectoryInfo(assemblyPath).GetFiles("Widget*.dll").Select(x => Assembly.LoadFile(x.FullName)).ToList();
            return assemblies;
        }
    }
}